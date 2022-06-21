using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using ITCLib;
using OpenXMLHelper;
using System.Text.RegularExpressions;
using System.IO;

namespace PraccingMenu
{

    public partial class frmPraccingIssuesImport : Form
    {
        public PraccingMenu frmParent;
        public string key;

        UserPrefs CurrentUser;
        BindingSource bsIssues;
        BindingSource bsExistingResponses;
        BindingSource bsNewResponses;

        List<PraccingIssue> ReferenceList; // list of existing issues to compare against
        // list of praccing records from file
        List<PraccingIssue> importIssues;
        List<PraccingResponse> importResponses;
        List<PraccingIssue> mainIssues;
        List<Person> personList;
        List<PraccingCategory> categoryList;
        List<Survey> surveyList;
        PraccingIssue CurrentIssue;
        PraccingResponse CurrentResponse;

        List<StringPair> datesToFix;
        List<StringPair> namesToFix;
        List<StringPair> images;

        string SurveyCode;
        double minuteOffset;
        // these 2 keep new issues and responses unique by assigning incremental IDs
        int issueIDOffset;
        int responseIDOffset;
        string lastIssueNo;

        int IssueNoColumn;
        int VarNamesColumn;
        int DescriptionColumn;
        int DateColumn;
        int FromColumn;
        int ToColumn;
        int CategoryColumn;

        // form layout values
        int doubleResponseHeight;
        int singleResponseHeight;

        //image paths
        string AppImageRepo;
        string DBImageRepo = @"\\psychfile\psych$\psych-lab-gfong\SMG\Praccing Images";

        public frmPraccingIssuesImport()
        {
            InitializeComponent();

            CurrentUser = DBAction.GetUser(Environment.UserName);

            doubleResponseHeight = 488;
            singleResponseHeight = 244;

            importIssues = new List<PraccingIssue>();
            importResponses = new List<PraccingResponse>();
            mainIssues = new List<PraccingIssue>();

            datesToFix = new List<StringPair>();
            namesToFix = new List<StringPair>();
            images = new List<StringPair>();

            // get list of people
            personList = new List<Person>(DBAction.GetPeople());
            // get list of categories
            categoryList = DBAction.GetPraccingCategories();
            // get list of surveys
            surveyList = new List<Survey>(DBAction.GetAllSurveysInfo());

            AppImageRepo = System.IO.Path.GetDirectoryName(Application.StartupPath);

            bsIssues = new BindingSource();
            bsIssues.PositionChanged += BsIssues_PositionChanged;

            bsExistingResponses = new BindingSource();

            bsNewResponses = new BindingSource();
           

            FillBoxes();
            
        }

        #region Form Setup

        private void FillBoxes()
        {
            // get list of surveys
            cboSurvey.ValueMember = "SID";
            cboSurvey.DisplayMember = "SurveyCode";
            cboSurvey.DataSource = surveyList;

            cboCategory.ValueMember = "ID";
            cboCategory.DisplayMember = "Category";
            cboCategory.DataSource = categoryList;

            cboFrom.ValueMember = "ID";
            cboFrom.DisplayMember = "Name";
            cboFrom.DataSource = new List<Person>(personList);

            cboTo.ValueMember = "ID";
            cboTo.DisplayMember = "Name";
            cboTo.DataSource = new List<Person>(personList);

            cboResName.ValueMember = "ID";
            cboResName.DisplayMember = "Name";
            cboResName.DataSource = new List<Person>(personList);

            cboNewFrom.ValueMember = "ID";
            cboNewFrom.DisplayMember = "Name";
            cboNewFrom.DataSource = new List<Person>(personList);

            cboNewTo.ValueMember = "ID";
            cboNewTo.DisplayMember = "Name";
            cboNewTo.DataSource = new List<Person>(personList);
        }

        #endregion


        #region BindingSource events

        private void BsIssues_PositionChanged(object sender, EventArgs e)
        {

            CurrentIssue = (PraccingIssue)bsIssues.Current;

            if (CurrentIssue == null)
                return;

            bool isNewIssue = CurrentIssue.ID == 0;
            bool hasImages = CurrentIssue.Images.Count > 0;

            chkKeepIssue.Visible = isNewIssue;
            cmdMoveIssue.Visible = isNewIssue;

            if (CurrentIssue.ID == 0)
                txtStatus.Text = "New";
            else
                txtStatus.Text = "Existing";

            rtbDescription.Rtf = "";
            rtbDescription.Rtf = CurrentIssue.DescriptionRTF;

            if (CurrentIssue.Images.Count ==1)
                lblIssueImages.Text = CurrentIssue.Images.Count + " image found for this issue.";
            else if (CurrentIssue.Images.Count > 1)
                lblIssueImages.Text = CurrentIssue.Images.Count + " images found for this issue.";

            lblIssueImages.Visible = hasImages;

            RefreshResponses();

            UpdateKeepToggles();


        }

        #endregion

        #region Control Events

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void cboSurvey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSurvey.SelectedItem == null)
                return;

            SurveyCode = ((Survey)cboSurvey.SelectedItem).SurveyCode;

        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.doc|*.docx";
            dialog.ShowDialog();

            txtPath.Text = dialog.FileName;
            cmdLoad.Visible = true;
            cmdLoad.Enabled = true;
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            if (cboSurvey.SelectedItem == null)
            {
                MessageBox.Show("Choose a survey before continuing.");
                return;
            }

            if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("Choose a file before continuing.");
                return;
            }


            try
            {
                ReferenceList = DBAction.GetPraccingIssues(surveyList.First(x => x.SurveyCode.Equals(SurveyCode)).SID);
                LoadRecords(txtPath.Text);

                ShowResults();
                cmdLoad.Enabled = false;
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to access the file. Make sure it is not open in the background and try again.");
            }

        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            ImportRecords();
        }

        private void cmdMoveIssue_Click(object sender, EventArgs e)
        {
            int targetIssueNo = SelectIssue();

            if (targetIssueNo == 0)
                return;

            // move issue to target issue as a response
            MoveIssue(CurrentIssue, targetIssueNo);
            
        }

        

        private void cmdMoveResponse_Click(object sender, EventArgs e)
        {
            int targetIssueNo = SelectIssue();

            if (targetIssueNo == 0)
                return;

            // move issue to target issue as a response
            MoveResponse(CurrentResponse, targetIssueNo);
            
        }

        private void chkKeepIssue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKeepIssue.Checked)
            {
                importIssues.Add((PraccingIssue)bsIssues.Current);
                chkKeepIssue.Text = "Saved";
            }
            else
            {
                importIssues.Remove((PraccingIssue)bsIssues.Current);
                chkKeepIssue.Text = "Keep?";
            }

        }

        private void chkResolved_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResolved.Checked)
            {
                CurrentIssue.ResolvedDate = DateTime.Today;
                CurrentIssue.ResolvedBy.ID = CurrentUser.userid;
            }
            else
            {
                CurrentIssue.ResolvedDate = null;
                CurrentIssue.ResolvedBy.ID = 0;
            }
        }

        private void chkKeepResponse_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkKeepResponse.Checked)
            //{
            //    importResponses.Add((PraccingResponse)bsNewResponses.Current);
            //    chkKeepResponse.Text = "Saved";
            //    if (!importIssues.Contains(CurrentIssue))
            //    {
            //        importIssues.Add(CurrentIssue);
            //        chkKeepIssue.CheckedChanged -= chkKeepIssue_CheckedChanged;
            //        chkKeepIssue.Checked = true;
            //        chkKeepIssue.CheckedChanged += chkKeepIssue_CheckedChanged;
            //    }
            //}
            //else
            //{
            //    importResponses.Remove((PraccingResponse)bsNewResponses.Current);
            //    chkKeepResponse.Text = "Keep?";
            //}
        }

        private void chkKeepResponse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)checkBox.Parent;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)checkBox.Parent.Parent;
            var datasource = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;
            PraccingResponse response = datasource[dataRepeaterItem.ItemIndex];
            if (checkBox.Checked)
            {
                importResponses.Add(response);
                checkBox.Text = "Saved";
                if (!importIssues.Contains(CurrentIssue))
                {
                    importIssues.Add(CurrentIssue);
                    chkKeepIssue.CheckedChanged -= chkKeepIssue_CheckedChanged;
                    chkKeepIssue.Checked = true;
                    chkKeepIssue.CheckedChanged += chkKeepIssue_CheckedChanged;
                }
            }
            else
            {
                importResponses.Remove(response);
                checkBox.Text = "Keep?";
            }
        }

        #endregion

        #region Loading Methods

        /// <summary>
        /// Scan the document for a table. Each unqie issue number found in the table corresponds to 1 Praccing Issue and its related responses.
        /// </summary>
        /// <param name="filePath"></param>
        private void LoadRecords(string filePath)
        {
            issueIDOffset = 0;
            responseIDOffset = 0;

            datesToFix.Clear();
            namesToFix.Clear();

            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, false))
            {
                Body body = doc.MainDocumentPart.Document.Body;
                Table issuesTable = doc.MainDocumentPart.Document.Body.Elements<Table>().FirstOrDefault();

                if (issuesTable == null)
                    throw new Exception("Missing table.");

                GetHeadings(doc.MainDocumentPart.Document.Body);
                // check each date and from/to for valid entries, add invalid ones to a list
                int rowCount = 0;
                foreach (TableRow row in issuesTable.Elements<TableRow>())
                {
                    rowCount++;
                    if (rowCount == 1)
                        continue;

                    if (MissingDates(row))
                    {
                        throw new Exception("One or more issues / responses is missing a dates. Please enter the date and try again.");
                     }

                    CheckValidDates(row);
                    CheckValidNames(row);
                }

                // show list of things to fix
                if (datesToFix.Count > 0)
                {

                    frmFixDates frm = new frmFixDates(datesToFix);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.Cancel)
                        return;
                }

                if (namesToFix.Count > 0)
                {
                    frmFixNames frm = new frmFixNames(namesToFix);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("Some names may appear blank.");
                    }

                }

                XMLUtilities.TagBold(body);
                XMLUtilities.TagItalics(body);
                XMLUtilities.TagHighlighting(body);
                images = ExtractImages(body, doc.MainDocumentPart);

                string issueNumber;
                string varname;

                rowCount = 0;
                foreach (TableRow row in issuesTable.Elements<TableRow>())
                {
                    rowCount++;
                    if (rowCount == 1)
                        continue;

                    var cells = row.Elements<TableCell>();

                    issueNumber = GetContentFromCell(cells, IssueNoColumn, false);
                    varname = GetContentFromCell(cells, VarNamesColumn, false);

                    if (issueNumber.EndsWith("-1"))
                    {
                        AddMainIssue(row);
                        minuteOffset = 0;
                    }
                    else if (issueNumber.Contains("-"))
                    {
                        minuteOffset++;
                        AddResponse(row);
                        
                    }
                    else if (!string.IsNullOrEmpty(varname) || issueNumber.ToLower().Contains("new"))
                    {
                        AddMainIssue(row);
                        minuteOffset = 0;
                    }
                    else if (string.IsNullOrEmpty(issueNumber))
                    {
                        minuteOffset++;
                        AddResponse(row, lastIssueNo);
                        
                    }
                    else
                    {

                    }

                    

                }
            }
        }

        /// <summary>
        /// Saves all images in the document to the application's folder and returns a StringPair list of their Ids and names.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="wDoc"></param>
        /// <returns></returns>
        private List<StringPair> ExtractImages(Body content, MainDocumentPart wDoc)
        {

            List<StringPair> imageList = new List<StringPair>();

            foreach (Run run in content.Descendants<Run>())
            {
                //detect if the run contains an image and upload it to wordpress
                Drawing image =  run.Descendants<Drawing>().FirstOrDefault();

                if (image != null)

                {

                    var imageFirst = image.Inline.Graphic.GraphicData.Descendants<DocumentFormat.OpenXml.Drawing.Pictures.Picture>().FirstOrDefault();
                    var blip = imageFirst.BlipFill.Blip.Embed.Value;

                    if (imageList.Any(x => x.String1.Equals(blip)))
                        continue;

                    ImagePart img = (ImagePart)wDoc.Document.MainDocumentPart.GetPartById(blip);
                    string imageFileName = string.Empty;

                    //the image is stored in a zip file code behind, so it must be extracted

                    using (System.Drawing.Image toSaveImage = Bitmap.FromStream(img.GetStream()))
                    {
                        imageFileName = "Praccing Image - " + SurveyCode + " - " + DateTime.Now.Month.ToString().Trim() +
                        DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() +
                        DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".png";

                        try
                        {
                            toSaveImage.Save(AppImageRepo + @"\" + imageFileName);
                        }
                        catch (Exception)
                        {
                            
                        }
                    }

                    StringPair sp = new StringPair(blip, imageFileName);

                    imageList.Add(sp);
                }
            }

            return imageList;
        }

        private bool MissingDates(TableRow row)
        {
            var cells = row.Elements<TableCell>();

            string date = GetContentFromCell(cells, DateColumn, false);
            string desc = GetContentFromCell(cells, DescriptionColumn, false);
            if (string.IsNullOrEmpty(date) && !string.IsNullOrEmpty(desc))
                return true;

            return false;
            
        }


        private void CheckValidDates(TableRow row)
        {
            var cells = row.Elements<TableCell>();

            string date = GetContentFromCell(cells, DateColumn, false);
            if (string.IsNullOrEmpty(date))
                return;

            if (!DateTime.TryParse(date, out DateTime d))
            {
                if (!datesToFix.Any(x=>x.String1.Equals(date))) datesToFix.Add(new StringPair(date));
            }

            if (d < dtpIssueDate.MinDate)
                datesToFix.Add(new StringPair(date));
        }

        private void CheckValidNames(TableRow row)
        {
            var cells = row.Elements<TableCell>();
            string from = Utilities.TrimString(GetContentFromCell(cells, FromColumn, false), " ");
            if (!string.IsNullOrEmpty(from) && personList.Where(x => x.Name.Equals(from)).FirstOrDefault() == null)
                namesToFix.Add(new StringPair(from));

            string to = Utilities.TrimString(GetContentFromCell(cells, ToColumn, false), " ");
            if (!string.IsNullOrEmpty(to) && personList.Where(x => x.Name.Equals(to)).FirstOrDefault() == null)
                namesToFix.Add(new StringPair(to));
        }

        private void AddMainIssue(TableRow row)
        {
            var cells = row.Elements<TableCell>();

            string varNames;
            string description;
            string descriptionRTF;
            string date;
            string from;
            string to;
            string category;
            string issueNumber = GetContentFromCell(cells, IssueNoColumn, false);
            int issueNo = 0;

            if (string.IsNullOrEmpty(issueNumber) || issueNumber.ToLower().Contains("new"))
            {
                issueNo = -1 - issueIDOffset;
                issueIDOffset++;
                lastIssueNo = issueNo + "-1";
            }
            else
            {
                issueNo = Int32.Parse(issueNumber.Substring(0, issueNumber.IndexOf("-")));
                lastIssueNo = issueNumber;
            }

            varNames = GetContentFromCell(cells, VarNamesColumn, false);
            description = GetContentFromCell(cells, DescriptionColumn, true);
            description = Utilities.TrimString(description, " ");
            description = Utilities.TrimString(description, "<br>");
            descriptionRTF = description.Replace(" ", "&nbsp;");

            // check date and names for valid entries
            date = GetContentFromCell(cells, DateColumn, false);
            date = Utilities.TrimString(date, "\r\n");
            DateTime issueDate = GetIssueDate(date);

            from = GetContentFromCell(cells, FromColumn, false);
            from = Utilities.TrimString(from, "\r\n");
            Person issueFrom = GetName(from);
            
            to = GetContentFromCell(cells, ToColumn, false);
            to = Utilities.TrimString(to, "\r\n");
            Person issueTo = GetName(to);

            category = GetContentFromCell(cells, CategoryColumn, false);
            category = Utilities.TrimString(category, "\r\n");
            PraccingCategory issueCategory = categoryList.FirstOrDefault(x => x.Category.Equals(category));
            if (issueCategory == null)
                issueCategory = new PraccingCategory();

            // images
            List<PraccingImage> issueImages = new List<PraccingImage>();
            var imageRuns = cells.ElementAt(DescriptionColumn).Descendants<Run>();
            if (imageRuns.Any(x=>x.Descendants<Drawing>().Count() > 0))
            {
                foreach (Run r in imageRuns)
                {
                    Drawing image = r.Descendants<Drawing>().FirstOrDefault();

                    if (image != null)
                    {
                        var imageFirst = image.Inline.Graphic.GraphicData.Descendants<DocumentFormat.OpenXml.Drawing.Pictures.Picture>().FirstOrDefault();

                        var blip = imageFirst.BlipFill.Blip.Embed.Value;
                        foreach (StringPair sp in images)
                        {
                            if (sp.String1 == blip)
                                issueImages.Add(new PraccingImage(0, sp.String2));
                        }

                    }
                }
            }



            PraccingIssue mainIssue = new PraccingIssue();
            mainIssue.Survey.SID = surveyList.First(x => x.SurveyCode.Equals(SurveyCode)).SID;
            mainIssue.Survey.SurveyCode = SurveyCode;
            mainIssue.IssueNo = issueNo;
            
            var matchingIssue = ReferenceList.FirstOrDefault(x => x.Survey.SurveyCode.Equals(SurveyCode) && x.IssueNo == issueNo);
            if (matchingIssue != null)
            {
                mainIssues.Add(matchingIssue);


            }
            else
            {
                mainIssue.VarNames = varNames;
                mainIssue.Description = description;
                mainIssue.IssueDate = issueDate;
                mainIssue.IssueFrom = issueFrom;
                mainIssue.IssueTo = issueTo;
                mainIssue.Category = issueCategory;
                mainIssue.Images = issueImages;

                mainIssues.Add(mainIssue);
            }

            
        }

        

        private void AddResponse(TableRow row, string lastIssueNo= "")
        {
            var cells = row.Elements<TableCell>();

            string description;
            string date;
            string from;
            string to;
            string issueNumber;

            if (string.IsNullOrEmpty(lastIssueNo))
                issueNumber = GetContentFromCell(cells, IssueNoColumn, false);
            else
                issueNumber = lastIssueNo;
             
            int issueNo;
            issueNo = Int32.Parse(issueNumber.Substring(0, issueNumber.IndexOf("-",1)));

            description = GetContentFromCell(cells, DescriptionColumn, true);
            description = Utilities.TrimString(description, " ");
            description = Utilities.TrimString(description, "<br>");

            string forcompare = Utilities.PrepareTextCompare(description);

            if (string.IsNullOrEmpty(description))
                return;

            int responseID;
            PraccingIssue matchingIssue = (PraccingIssue)ReferenceList.FirstOrDefault(x => x.Survey.SurveyCode.Equals(SurveyCode) && x.IssueNo == issueNo);
            if (matchingIssue != null)
            {
                PraccingResponse matchingResponse = (PraccingResponse)matchingIssue.Responses.FirstOrDefault(x => Utilities.PrepareTextCompare(x.Response).Equals(forcompare));
                
                if (matchingResponse != null)
                    responseID = matchingResponse.ID;
                else
                    responseID = 0;
            }
            else
            {
                responseID = 0;
            }
            
            // if the ID is not 0, this response already exists and should be already part of the main issue
            // only continue if this is a new response
            if (responseID != 0) 
                return;
            else
            {
                responseID = -1 - responseIDOffset;
                responseIDOffset++;
            }
            
            date = GetContentFromCell(cells, DateColumn, false);
            date = Utilities.TrimString(date, "\r\n");
            DateTime issueDate = GetResponseDate(date);
            

            from = GetContentFromCell(cells, FromColumn, false);
            from = Utilities.TrimString(from, "\r\n");
            Person issueFrom = GetName(from);
           
            to = GetContentFromCell(cells, ToColumn, false);
            to = Utilities.TrimString(to, "\r\n");
            Person issueTo = GetName(to);
            

            // images
            List<PraccingImage> issueImages = new List<PraccingImage>();
            var imageRuns = cells.ElementAt(DescriptionColumn).Descendants<Run>();
            if (imageRuns.Any(x => x.Descendants<Drawing>().Count() > 0))
            {
                foreach (Run r in imageRuns)
                {
                    Drawing image = r.Descendants<Drawing>().FirstOrDefault();

                    if (image != null)

                    {

                        var imageFirst = image.Inline.Graphic.GraphicData.Descendants<DocumentFormat.OpenXml.Drawing.Pictures.Picture>().FirstOrDefault();

                        var blip = imageFirst.BlipFill.Blip.Embed.Value;
                        foreach (StringPair sp in images)
                        {
                            if (sp.String1 == blip)
                                issueImages.Add(new PraccingImage(0, sp.String2));
                        }

                    }
                }
            }

            PraccingResponse response = new PraccingResponse();
            response.ID = responseID;
            response.IssueID = (mainIssues.Where(x => x.IssueNo == issueNo)).FirstOrDefault().ID;
            
            response.Response = description;
            response.ResponseDate = issueDate;
            response.ResponseFrom = issueFrom;
            response.ResponseTo = issueTo;
            response.Images = issueImages;

            // find which main issue this response belongs to
            var mainIssue = mainIssues.Where(x => x.IssueNo == issueNo).FirstOrDefault();


            mainIssue.Responses.Add(response);
            
        }

        private DateTime GetIssueDate(string date)
        {
 
            if (!DateTime.TryParse(date, out DateTime issueDate))
            {
                var found = datesToFix.Where(x => x.String1.Equals(date)).FirstOrDefault();
                if (found != null)
                    issueDate = DateTime.Parse(found.String2);
            }
 
            return issueDate;
        }

        private DateTime GetResponseDate(string date)
        {

            if (!DateTime.TryParse(date, out DateTime responseDate))
                {
                var found = datesToFix.Where(x => x.String1.Equals(date)).FirstOrDefault();
                if (found != null)
                {
                    responseDate = DateTime.Parse(found.String2);

                    responseDate += DateTime.Now.TimeOfDay;
                    responseDate.AddMinutes(minuteOffset);
                }
            }
            else
            {
                responseDate = DateTime.Parse(date);
                responseDate += DateTime.Now.TimeOfDay;
                responseDate.AddMinutes(minuteOffset);
            }

            return responseDate;
        }

        private Person GetName(string from)
        {
            Person name = new Person();
            var person = personList.Where(x => x.Name.Equals(from)).FirstOrDefault();
            if (person == null)
            {
                var found = namesToFix.Where(x => x.String1.Equals(from)).FirstOrDefault();
                if (found != null)
                {

                    name.ID = (personList.Where(x => x.Name.Equals(found.String2)).First()).ID;
                    name.Name = found.String2;
                }
            }
            else
            {
                name.ID = person.ID;
                name.Name = person.Name;
            }
            return name;
        }

        

        private void ShowResults()
        {
            
            UnBindProperties();
            RefreshMainIssues();

            if (this.mainIssues.Count() == 0)
            {
                MessageBox.Show("No new issues or responses found.");
                return;
            }

            BindProperties();
            navIssues.BindingSource = bsIssues;
            panelResults.Visible = true;
            cmdImport.Visible = true;
        }

        private void GetHeadings(Body body)
        {
            var rows = body.Descendants<TableRow>();

            List<TableCell> headerCells = rows.ElementAt(0).Elements<TableCell>().ToList<TableCell>();

            for (int i = 0; i < headerCells.Count(); i++)
            {
                string cellText = headerCells.ElementAt(i).GetCellText();
                int newLine = cellText.IndexOf("\r");
                if (newLine > -1)
                    cellText = cellText.Substring(0, cellText.IndexOf("\r"));


                switch (cellText)
                {
                    case "#":
                        IssueNoColumn = i;
                        break;
                    case "Var Name":
                        VarNamesColumn = i;

                        break;
                    case "Description/Response":
                        DescriptionColumn = i;
                        break;
                    case "Date":
                        DateColumn = i;
                        break;
                    case "From":
                        FromColumn = i;
                        break;
                    case "To":
                        ToColumn = i;
                        break;
                    case "Category":
                        CategoryColumn = i;
                        break;
                }
            }
        }
        #endregion

        #region DataRepeater Bullshit

        

        /// <summary>
        /// After Item is cloned, draw item. The index is now available to select the proper data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drExisting_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)sender;
            var datasource = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;

            var oldFrom = (TextBox)e.DataRepeaterItem.Controls.Find("txtOldFrom", false)[0];
            oldFrom.Text = datasource[e.DataRepeaterItem.ItemIndex].ResponseFrom.Name;

            var oldTo = (TextBox)e.DataRepeaterItem.Controls.Find("txtOldTo", false)[0];
            oldTo.Text = datasource[e.DataRepeaterItem.ItemIndex].ResponseTo.Name;

            var rtb = (RichTextBox)e.DataRepeaterItem.Controls.Find("rtbOldResponse", false)[0];
            rtb.Rtf = datasource[e.DataRepeaterItem.ItemIndex].ResponseRTF;
        }

        private void drNewResponses_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)sender;
            var datasource = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;
            var item = datasource[e.DataRepeaterItem.ItemIndex];

            var newFrom = (ComboBox)e.DataRepeaterItem.Controls.Find("cboNewFrom", false)[0];
            newFrom.SelectedItem = item.ResponseFrom;

            var newTo = (ComboBox)e.DataRepeaterItem.Controls.Find("cboNewTo", false)[0];
            newTo.SelectedItem = item.ResponseTo;

            var rtb = (RichTextBox)e.DataRepeaterItem.Controls.Find("rtbNewResponse", false)[0];
            rtb.Rtf = item.ResponseRTF;

            var checkbox = (System.Windows.Forms.CheckBox)e.DataRepeaterItem.Controls.Find("chkKeepResponse", false)[0];

            // update toggle
            if (importResponses.Contains(item))
            {
                checkbox.Text = "Saved";
                checkbox.Checked = true;
            }
            else
            {
                checkbox.Text = "Keep?";
                checkbox.Checked = false;
            }

            // update image message
            var lbl = (Label)e.DataRepeaterItem.Controls.Find("lblResponseImages", false)[0];
            if (item != null)
            {
                if (item.Images.Count == 1)
                {
                    lbl.Text = item.Images.Count + " image found for this response.";
                    lbl.Visible = true;
                }
                else if (item.Images.Count > 1)
                {
                    lbl.Text = item.Images.Count + " images found for this response.";
                    lbl.Visible = true;
                }
                else
                {
                    lbl.Visible = false;
                }
            }
            else
            {
                lbl.Visible = false;
            }
        }

        private void drNewResponses_ItemCloned(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var combo = (ComboBox)e.DataRepeaterItem.Controls.Find("cboNewFrom", false)[0];
            //Set the data source
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
            combo.DataSource = new List<Person>(personList);

            var combo2 = (ComboBox)e.DataRepeaterItem.Controls.Find("cboNewTo", false)[0];
            //Set the data source
            combo2.DisplayMember = "Name";
            combo2.ValueMember = "ID";
            combo2.DataSource = new List<Person>(personList);
        }

        private void cboNewFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)combo.Parent;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)combo.Parent.Parent;

            var source = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;
            source[dataRepeaterItem.ItemIndex].ResponseFrom = (Person)combo.SelectedItem;

            
        }

        private void cboNewTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)combo.Parent;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)combo.Parent.Parent;

            var source = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;
            source[dataRepeaterItem.ItemIndex].ResponseTo = (Person)combo.SelectedItem;

            
        }

        #endregion

        private void RefreshMainIssues()
        {

            mainIssues = mainIssues.Where(x => x.Responses.Where(y => y.ID < 0).Count() > 0 || x.ID==0).ToList();

            bsIssues.DataSource = null;
            bsIssues.DataSource = mainIssues;
        }

        private void RefreshResponses()
        {
            
            bsNewResponses.DataSource = CurrentIssue.Responses.Where(x => x.ID < 0).ToList();

            CurrentResponse = (PraccingResponse)bsNewResponses.Current;
            
            bsExistingResponses.DataSource = CurrentIssue.Responses.Where(x => x.ID > 0).ToList();

            drExisting.DataSource = bsExistingResponses;
            drNewResponses.DataSource = bsNewResponses;

            panelExisting.Visible = bsExistingResponses.Count != 0;
            panelNew.Visible = bsNewResponses.Count != 0;
            if (bsExistingResponses.Count == 0)
            {
                panelNew.Top = panelExisting.Top;
                panelNew.Height = doubleResponseHeight;
            }
            else
            {
                panelNew.Top = panelExisting.Top + panelExisting.Height + 5;
                panelNew.Height = singleResponseHeight;
            }
        }

        /// <summary>
        /// Turn an issue into a response for another issue.
        /// </summary>
        /// <param name="issue">The original main issue to be moved.</param>
        /// <param name="newIssueNo">The Issue Number of the destination issue.</param>
        private void MoveIssue(PraccingIssue issue, int newIssueNo)
        {
            PraccingResponse newResponse = new PraccingResponse();

            PraccingIssue mainIssue = mainIssues.Where(x => x.IssueNo == newIssueNo).FirstOrDefault();

            if (mainIssue == null)
            {
                // get mainIssue from DB
                mainIssue = DBAction.GetPraccingIssue(newIssueNo);
                mainIssues.Add(mainIssue);
            }

            newResponse.IssueID = mainIssue.ID;
            newResponse.Response = issue.Description;
            newResponse.ResponseFrom = issue.IssueFrom;
            newResponse.ResponseTo = issue.IssueTo;
            newResponse.ResponseDate = issue.IssueDate;
            newResponse.Images = issue.Images;

            mainIssue.Responses.Add(newResponse);

            mainIssues.Remove(issue);

            RefreshMainIssues();
        }

        /// <summary>
        /// Reassign a response to a new main issue.
        /// </summary>
        /// <param name="response">Response to be reassigned.</param>
        /// <param name="newIssueNo">Issue Number of the new main issue.</param>
        private void MoveResponse(PraccingResponse response, int newIssueNo)
        {
            PraccingIssue parentIssue = mainIssues.Where(x => x.Responses.Contains(response)).FirstOrDefault();
            PraccingIssue mainIssue = mainIssues.Where(x => x.IssueNo == newIssueNo).FirstOrDefault();

            if (mainIssue == null)
            {
                // get mainIssue from DB
                mainIssue = DBAction.GetPraccingIssue(newIssueNo);
                mainIssues.Add(mainIssue);
            }

            mainIssue.Responses.Add(response);
            parentIssue.Responses.Remove(response);
            response.IssueID = mainIssue.ID;

            RefreshResponses();
        }

        private void ImportRecords()
        {
            int issueCount = SaveIssues();
            int responseCount = SaveResponses();

            UpdateKeepToggles();

            MessageBox.Show(issueCount + " issue(s) imported and " + responseCount + " response(s) imported.");

        }

        private int SaveIssues()
        {
            int issueCount = 0;

            // for each "saved" issue, add it to the database
            foreach (PraccingIssue pi in importIssues)
            {
                // skip those that are already in the database
                if (pi.ID > 0)
                {
                    DBAction.UpdatePraccingIssue(pi);
                    continue;
                }
                    

                int tempIssueNo = pi.IssueNo;
                pi.IssueNo = DBAction.GetNextPraccingIssueNo(pi.Survey.SID);
                if (DBAction.InsertPraccingIssue(pi) == 1)
                    pi.IssueNo = tempIssueNo;
                else
                {
                    foreach (PraccingResponse pr in pi.Responses)
                        pr.IssueID = pi.ID;

                    // save images
                    // copy images to network path
                    foreach (PraccingImage img in pi.Images)
                    {
                        if (!File.Exists(DBImageRepo + @"\" + img.Path))
                            File.Copy(AppImageRepo + @"\" + img.Path, DBImageRepo + @"\" + img.Path);
                    }


                    DBAction.InsertPraccingImage(pi.ID, pi.Images);

                    issueCount++;
                }

            }
            // if the issue was inserted successfully, remove it from the list
            for (int i = 0; i < importIssues.Count; i++)
            {
                if (importIssues[i].ID > 0)
                    importIssues.Remove(importIssues[i]);
            }

            return issueCount;
        }

        private int SaveResponses()
        {
            int responseCount = 0;

            // for each "saved" response, add it to the database
            foreach (PraccingResponse pr in importResponses)
            {
                // skip those that are already in the database
                if (pr.ID > 0)
                    continue;

                if (DBAction.InsertPraccingResponse(pr) != 1)
                    responseCount++;

                // save images
                // copy images to network path
                foreach (PraccingImage img in pr.Images)
                {
                    if (!File.Exists(DBImageRepo + @"\" + img.Path))
                        File.Copy(AppImageRepo + @"\" + img.Path, DBImageRepo + @"\" + img.Path);
                }


                DBAction.InsertPraccingResponseImage(pr.ID, pr.Images);

            }
            // if the response was inserted successfully, remove it from the list
            for (int i = 0; i < importResponses.Count; i++)
            {
                if (importResponses[i].ID > 0)
                    importResponses.Remove(importResponses[i]);
            }

            return responseCount;
        }

        private void BindProperties()
        {
            BindControl(txtIssueNo, "Text", bsIssues, "IssueNo");
            BindControl(txtVarNames, "Text", bsIssues, "VarNames");
            
           
            BindControl(cboFrom, "SelectedValue", bsIssues, "IssueFrom.ID");
            BindControl(cboTo, "SelectedValue", bsIssues, "IssueTo.ID");
            BindControl(cboCategory, "SelectedValue", bsIssues, "Category.ID");
            BindControl(dtpIssueDate, "Value", bsIssues, "IssueDate", true);
            BindControl(chkResolved, "Checked", bsIssues, "Resolved");
            BindControl(dtpResDate, "Value", bsIssues, "ResolvedDate", true);
            BindControl(cboResName, "SelectedValue", bsIssues, "ResolvedBy.ID", true);

            BindControl(dtpOldTime, "Value", bsExistingResponses, "ResponseDate",true);
            BindControl(dtpOldDate, "Value", bsExistingResponses, "ResponseDate", true);
            

            BindControl(dtpNewTime, "Value", bsNewResponses, "ResponseDate", true);
            BindControl(dtpNewDate, "Value", bsNewResponses, "ResponseDate", true);
           
        }

        private void UnBindProperties()
        {
            txtIssueNo.DataBindings.Clear();
            txtVarNames.DataBindings.Clear();
            rtbDescription.DataBindings.Clear();
            cboFrom.DataBindings.Clear();
            cboTo.DataBindings.Clear();
            cboCategory.DataBindings.Clear();
            dtpIssueDate.DataBindings.Clear();
            chkResolved.DataBindings.Clear();
            cboResName.DataBindings.Clear();
            dtpResDate.DataBindings.Clear();

            dtpOldTime.DataBindings.Clear();
            dtpOldDate.DataBindings.Clear();
            

            dtpNewTime.DataBindings.Clear();
            dtpNewDate.DataBindings.Clear();
            //cboNewFrom.DataBindings.Clear();
            //cboNewTo.DataBindings.Clear();
           // rtbNewResponse.DataBindings.Clear();
            
        }

        private void BindControl(System.Windows.Forms.Control ctl, string prop, object datasource, string dataMember, bool formatting = false)
        {
            ctl.DataBindings.Clear();
            ctl.DataBindings.Add(prop, datasource, dataMember, formatting);
        }

        


        

        

        /// <summary>
        /// Returns the text contents from the specified cell in a group of cells. If a cell doesn't exist at that index, an empty string is returned.
        /// </summary>
        /// <param name="cells"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private string GetContentFromCell(IEnumerable<TableCell> cells, int index, bool richText)
        {
            string text;
            try
            {
                text = cells.ElementAt(index).GetCellText();
                if (richText)
                    text = text.Replace("\r\n", "<br>");
            }
            catch (Exception)
            {
                text = "";
            }

            if (!richText)
                text = RemoveTags(text);

            return text;
        }

        private void UpdateKeepToggles()
        {
            if (importIssues.Contains(CurrentIssue))
            {
                chkKeepIssue.Text = "Saved";
                chkKeepIssue.CheckedChanged -= chkKeepIssue_CheckedChanged;
                chkKeepIssue.Checked = true;
                chkKeepIssue.CheckedChanged += chkKeepIssue_CheckedChanged;
            }
            else
            {
                chkKeepIssue.Text = "Keep?";
                chkKeepIssue.CheckedChanged -= chkKeepIssue_CheckedChanged;
                chkKeepIssue.Checked = false;
                chkKeepIssue.CheckedChanged += chkKeepIssue_CheckedChanged;
            }

            
        }


        public static string RemoveTags(string input)
        {
            string text = input;
            text = text.Replace("<Font Color=Red>", "");
            text = text.Replace("<Font Color=Blue>", "");
            text = Regex.Replace(text, "<font style=\"BACKGROUND-COLOR:#[A-Z0-9]{6}\">", "");
            text = text.Replace("</font>", "");
            text = text.Replace("</Font>", "");
            text = text.Replace("<strong>", "").Replace("</strong>", "");
            text = text.Replace("<em>", "").Replace("</em>", "");
            text = text.Replace("<u>", "").Replace("</u>", "");
            return text;

        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (StringPair sp in images)
            {
                // delete images from app path
                File.Delete(AppImageRepo + @"\" + sp.String2);
            }
            frmParent.CloseTab(key);
        }


        private int SelectIssue()
        {
            List<PraccingIssue> issueNumbers = DBAction.GetPraccingIssues(((Survey)cboSurvey.SelectedItem).SID);

            issueNumbers.AddRange(mainIssues);
            BrowseIssues frm = new BrowseIssues(issueNumbers);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                return frm.SelectedIssueNo;
            }
            else
            {
                // user cancelled
                return 0;
            }
        }



        /// <summary>
        /// Start a new import procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearForm()
        {
            panelResults.Visible = false;
            cmdLoad.Visible = false;
            cmdImport.Visible = false;
            mainIssues.Clear();
            namesToFix.Clear();
            datesToFix.Clear();

            foreach (StringPair sp in images)
            {
                // delete images from app path
                File.Delete(AppImageRepo + @"\" + sp.String2);
            }

            images.Clear();
            CurrentIssue = null;
            CurrentResponse = null;
            txtPath.Text = string.Empty;


        }

        
    }
}
