using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ITCLib;


namespace PraccingMenu
{
    
    // TODO detect when user changes response to/from (use click event with DirtyResponse flag?)
    public partial class PraccingEntry : Form
    {

        public PraccingMenu frmParent;
        public string key;

        PraccingIssue CurrentIssue;
        PraccingResponse CurrentResponse;
        List<PraccingIssue> IssuesList;
        List<Person> PeopleList;
        List<PraccingCategory> CategoryList;
        List<Survey> SurveyList;

        BindingSource bsMainIssues;
        BindingSource bsResponses;
        BindingSource bsImages;
        BindingSource bsResponseImages;

        string DBImageRepo = @"\\psychfile\psych$\psych-lab-gfong\SMG\Praccing Images";

        private bool Dirty { get; set; }
        

        private bool NewRecord { get; set; }

        public PraccingEntry(int SurvID)
        {
            InitializeComponent();

            IssuesList = new List<PraccingIssue>();
            PeopleList = DBAction.GetPeople();
            CategoryList = DBAction.GetPraccingCategories();
            SurveyList = DBAction.GetAllSurveysInfo();

            bsMainIssues = new BindingSource();
            bsMainIssues.DataSource = IssuesList;

            bsResponses = new BindingSource();
            bsImages = new BindingSource();
            bsResponseImages = new BindingSource();

            navMainIssues.BindingSource = bsMainIssues;
            navMainImages.BindingSource = bsImages;
            navResponseImages.BindingSource = bsResponseImages;

            bsMainIssues.PositionChanged += BsMainIssues_PositionChanged;
            bsResponses.PositionChanged += BsResponses_PositionChanged;

            FillBoxes();

            cboGoToSurvey.SelectedValue = SurvID;

            BindProperties();

            this.MouseWheel += PraccingEntry_OnMouseWheel;
        }

        


        #region Bindingsource Events

        private void BsMainIssues_PositionChanged(object sender, EventArgs e)
        {
            
            RefreshCurrentIssue();
        }

        private void BsResponses_PositionChanged(object sender, EventArgs e)
        {
            RefreshCurrentResponse();
        }

        #endregion

        #region Menu Events

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            UpdateSummary();
            Survey selected = (Survey)cboGoToSurvey.SelectedItem;

            GoToSurvey(selected.SID);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage page = frmParent.GetTab("PraccingReport");

            if (page == null)
            {
                PraccingReportForm frm = new PraccingReportForm();
                frm.frmParent = frmParent;
                frm.key = "PraccingReport";
                frmParent.AddTab(frm, "PraccingReport", "Praccing Issues - Report");
                page = frmParent.GetTab("PraccingReport");
            }

            frmParent.SetTab(page);
         
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage page = frmParent.GetTab("PraccingImport");

            if (page == null)
            {
                frmPraccingIssuesImport frm = new frmPraccingIssuesImport();
                frm.frmParent = frmParent;
                frm.key = "PraccingImport";
                frmParent.AddTab(frm, "PraccingImport", "Praccing Issues - Import");
                page = frmParent.GetTab("PraccingImport");
            }

            frmParent.SetTab(page);
        }

        private void toolstripDisplay_Click(object sender, EventArgs e)
        {
            List<SurveyQuestion> questions = new List<SurveyQuestion>();
            string[] varnames = CurrentIssue.VarNames.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Survey survey = (Survey)cboGoToSurvey.SelectedItem;

            foreach (string v in varnames)
            {
                int id = DBAction.GetQuestionID(survey.SurveyCode, Utilities.ChangeCC(v, survey.CountryCode));
                if (id > 0)
                {

                    SurveyQuestion toAdd = DBAction.GetSurveyQuestion(id);
                    toAdd = DBAction.GetSurveyQuestion(id);

                    toAdd.Filters = string.Join("\r\n", toAdd.GetFilterVars());

                    toAdd.Translations = DBAction.GetQuestionTranslations(id);

                    toAdd.Comments = DBAction.GetQuesCommentsByQID(id);
                    questions.Add(toAdd);
                }
            }

            if (questions.Count() == 0)
            {
                MessageBox.Show("No VarNames to display!");
                return;
            }

            QuestionViewer viewer = new QuestionViewer(questions);
            viewer.Show();

        }

        private void toolstripExport_Click(object sender, EventArgs e)
        {
            bool q, t, c, f;

            q = toolstripQ.Checked;
            t = toolstripT.Checked;
            c = toolstripC.Checked;
            f = toolstripF.Checked;

            List<SurveyQuestion> questions = new List<SurveyQuestion>();

            string[] varnames = CurrentIssue.VarNames.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Survey survey = (Survey)cboGoToSurvey.SelectedItem;

            foreach (string v in varnames)
            {
                int id = DBAction.GetQuestionID(survey.SurveyCode, Utilities.ChangeCC(v, survey.CountryCode));
                if (id > 0)
                {

                    SurveyQuestion toAdd = new SurveyQuestion();


                    toAdd = DBAction.GetSurveyQuestion(id);

                    if (f)
                        toAdd.Filters = string.Join("\r\n", toAdd.GetFilterVars());

                    if (t)
                        toAdd.Translations = DBAction.GetQuestionTranslations(id);

                    if (c)
                        toAdd.Comments = DBAction.GetQuesCommentsByQID(id);

                    questions.Add(toAdd);
                }
            }

            if (questions.Count() == 0)
            {
                MessageBox.Show("No VarNames to export!");
                return;
            }

            QuestionReport report = new QuestionReport();
            report.SelectedSurvey = (Survey)cboGoToSurvey.SelectedItem;
            report.Questions = questions;
            report.IncludeQuestion = q;
            report.IncludeComments = c;
            report.IncludeTranslation = t;
            report.IncludeFilters = f;

            report.CreateReport();

        }

        #endregion

        #region Control Events

        private void PraccingEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSurveyFilter();
            frmParent.CloseTab(key);
        }

        private void cboGoToSurvey_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboGoToSurvey.SelectedItem == null)
                return;

            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            Survey selected = (Survey)cboGoToSurvey.SelectedItem;

            GoToSurvey(selected.SID);
             
        }

        private void cboGoToIssueNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboGoToIssueNo.SelectedItem == null)
                return;

            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            PraccingIssue selectedIssue = (PraccingIssue)cboGoToIssueNo.SelectedItem;
            GoToIssue(selectedIssue.IssueNo);
        }

        protected void PraccingEntry_OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving record.");
                return;
            }

            if (e.Delta == -120)
                MoveRecord(1);
            else if (e.Delta == 120)
            {
                MoveRecord(-1);
            }

        }

        private void cboGoToIssueNo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                foreach(PraccingIssue pi in cboGoToIssueNo.Items)
                {
                    if (pi.IssueNo == Int32.Parse(cboGoToIssueNo.Text))
                        cboGoToIssueNo.SelectedItem = pi;
                }
                
            }
        }

        private void cmdAddResponse_Click(object sender, EventArgs e)
        {
            AddResponse();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }
        }

        private void cmdDeleteIssue_Click(object sender, EventArgs e)
        {
            if (NewRecord)
            {
                CancelNew();
            }
            else
            {
                DeleteIssue();
            }
        }

        private void cmdDeleteResponse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this praccing response?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteResponse();          
            }
        }

        private void rtbResponse_DoubleClick(object sender, EventArgs e)
        {


            var rtb = (RichTextBox)sender;
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)rtb.Parent;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)rtb.Parent.Parent;
            var source = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;

            RichTextEditor frmEditor = new RichTextEditor(source[dataRepeaterItem.ItemIndex].ResponseRTF);

            frmEditor.ShowDialog();
            if (frmEditor.DialogResult == DialogResult.OK)
            {
                rtb.Rtf = Utilities.FormatRTF(frmEditor.EditedText);
                source[dataRepeaterItem.ItemIndex].Response = Utilities.TrimString(rtb.Text, "<br>");
                rtb.Rtf = source[dataRepeaterItem.ItemIndex].ResponseRTF;

                Dirty = true;
            }
        }

        private void cmdAddIssue_Click(object sender, EventArgs e)
        {
            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            if (bsMainIssues.Current == null)
                CreateFirst();
            else
                CreateNew();
        }

        private void cmdBrowseIssue_Click(object sender, EventArgs e)
        {
            BrowseIssues frm = new BrowseIssues(IssuesList);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                GoToIssue(frm.SelectedIssueNo);

            }
            else if (frm.DialogResult == DialogResult.No)
            {
                CreateNew();
            }
            else
            {
                // cancelled
            }
        }

        private void dtp_Format(object sender, ConvertEventArgs e)
        {
            // e.Value is the object value, we format it to be what we want to show up in the control 
            Binding b = sender as Binding;

            if (b == null)
                return;
            
            DateTimePicker dtp = (b.Control as DateTimePicker);
            if (dtp == null)
                return;
            
            if (e.Value == null)
            {
                dtp.ShowCheckBox = true;
                dtp.Checked = false;
                // have to set e.Value to SOMETHING, since it’s coming in as NULL 
                // if i set to DateTime.Today, and that’s DIFFERENT than the control’s current  
                // value, then it triggers a CHANGE to the value, which CHECKS the box (not ok) 
                // the trick – set e.Value to whatever value the control currently has.   
                // This does NOT cause a CHANGE, and the checkbox stays OFF. 
                e.Value = dtp.Value;
            }
            else
            {
                dtp.ShowCheckBox = true;
                dtp.Checked = true;
                // leave e.Value unchanged – it’s not null, so the DTP is fine with it. 
            }
        }

        private void dtp_Parse(object sender, ConvertEventArgs e)
        {
            // e.value is the formatted value coming from the control.   
            // we change it to be the value we want to stuff in the object. 
            Binding b = sender as Binding;

            if (b == null)
                return;
            
            DateTimePicker dtp = (b.Control as DateTimePicker);

            if (dtp == null)
                return;
            
            if (dtp.Checked == false)
            {
                dtp.ShowCheckBox = true;
                dtp.Checked = false;
                e.Value = new Nullable<DateTime>();
            }
            else
            {
                DateTime val = Convert.ToDateTime(e.Value);
                e.Value = new Nullable<DateTime>(val);
            }
        }

        private void rtbDescription_DoubleClick(object sender, EventArgs e)
        {
            RichTextEditor frmEditor = new RichTextEditor(CurrentIssue.DescriptionRTF);

            frmEditor.ShowDialog();
            if (frmEditor.DialogResult == DialogResult.OK)
            {
                rtbDescription.Rtf = Utilities.FormatRTF(frmEditor.EditedText);
                CurrentIssue.Description = Utilities.TrimString(rtbDescription.Text, "<br>"); ;
                rtbDescription.Rtf = CurrentIssue.DescriptionRTF;

                Dirty = true;
            }
        }

        private void chkResolved_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkResolved.Checked)
            //{
            //    dtpResolvedDate.Checked = true;
            //    //CurrentIssue.ResolvedDate = DateTime.Today;
            //    //CurrentIssue.ResolvedBy.ID = 0;
            //}
            //else
            //{
            //    dtpResolvedDate.Checked = false;
            //    CurrentIssue.ResolvedDate = null;
            //    CurrentIssue.ResolvedBy.ID = 0;
            //}
        }

        private void chkFilterUnresolved_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterUnresolved.Checked)
            {
                bsMainIssues.DataSource = IssuesList.Where(x => !x.Resolved).ToList();
            }
            else
            {
                bsMainIssues.DataSource = IssuesList;
            }
        }

        private void cmdFilterText_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox("Description");

            input.ShowDialog();

            string crit = input.userInput;

            if (input.DialogResult == DialogResult.OK)
            {
                bsMainIssues.DataSource = IssuesList.Where(x => x.Description.Contains(crit)).ToList();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files|*.png";
            dialog.ShowDialog();

            if (string.IsNullOrEmpty(dialog.FileName))
                return;

            string newFileName = "Praccing Image - " + DateTime.Now.Month.ToString().Trim() +
                        DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() +
                        DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".png";

            // copy the image to the praccing images folder
            System.IO.File.Copy(dialog.FileName, DBImageRepo + @"\" + newFileName);

            PraccingImage newImage = new PraccingImage();
            newImage.PraccID = CurrentIssue.ID;
            newImage.Path = DBImageRepo + @"\" + newFileName;
            CurrentIssue.Images.Add(newImage);
            bsImages.ResetBindings(false);
            Dirty = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            PraccingImage current = (PraccingImage)bsImages.Current;

            if (MessageBox.Show("Are you sure you want to delete this image?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (current.ID > 0)                   
                    DBAction.DeletePraccingImage(current.ID);

                try
                {
                    File.Delete(current.Path);
                }
                catch (Exception)
                {

                }
                bsImages.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            if (CurrentResponse == null)
                return;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files|*.png";
            dialog.ShowDialog();

            if (string.IsNullOrEmpty(dialog.FileName))
                return;

            string newFileName = "Praccing Response Image - " + DateTime.Now.Month.ToString().Trim() +
                        DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() +
                        DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".png";

            // copy the image to the praccing images folder
            System.IO.File.Copy(dialog.FileName, DBImageRepo + @"\" + newFileName);

            PraccingImage newImage = new PraccingImage();
            newImage.PraccID = CurrentResponse.ID;
            newImage.Path = DBImageRepo + @"\" + newFileName;
            CurrentResponse.Images.Add(newImage);
            bsResponseImages.ResetBindings(false);
            Dirty = true;
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (CurrentResponse == null)
                return;

            PraccingImage current = (PraccingImage)bsResponseImages.Current;

            if (MessageBox.Show("Are you sure you want to delete this image?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (current.ID > 0)
                    DBAction.DeletePraccingResponseImage(current.ID);

                try
                {
                    File.Delete(current.Path);
                }
                catch (Exception)
                {

                }
                bsResponseImages.RemoveCurrent();
            }
        }

        private void picMain_DoubleClick(object sender, EventArgs e)
        {

        }

        #endregion


        #region DataRepeater Bullshit

        private void dataRepeater1_ItemCloned(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var combo = (ComboBox)e.DataRepeaterItem.Controls.Find("cboResponseFrom", false)[0];
            //Set the data source
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
            combo.DataSource = new List<Person>(PeopleList);

            var combo2 = (ComboBox)e.DataRepeaterItem.Controls.Find("cboResponseTo", false)[0];
            //Set the data source
            combo2.DisplayMember = "Name";
            combo2.ValueMember = "ID";
            combo2.DataSource = new List<Person>(PeopleList);
        }

        /// <summary>
        /// After Item is cloned, draw item. The index is now available to select the proper data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataRepeater1_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)sender;
            var datasource = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;

            var combo = (ComboBox)e.DataRepeaterItem.Controls.Find("cboResponseFrom", false)[0];
            PraccingResponse item = datasource[e.DataRepeaterItem.ItemIndex];

            //Set the selected item based of the list item index
            combo.SelectedItem = item.ResponseFrom;

            var combo2 = (ComboBox)e.DataRepeaterItem.Controls.Find("cboResponseTo", false)[0];
            //Set the selected item based of the list item index
            combo2.SelectedItem = item.ResponseTo;

            var rtb = (RichTextBox)e.DataRepeaterItem.Controls.Find("rtbResponse", false)[0];
            rtb.Rtf = item.ResponseRTF;

        }

        private void cboResponseFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)combo.Parent;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)combo.Parent.Parent;

            var source = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;
            source[dataRepeaterItem.ItemIndex].ResponseFrom = (Person)combo.SelectedItem;

        }

        private void cboResponseTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)combo.Parent;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)combo.Parent.Parent;

            var source = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;
            source[dataRepeaterItem.ItemIndex].ResponseTo = (Person)combo.SelectedItem;

        }

        private void dataRepeater1_ItemTemplate_Enter(object sender, EventArgs e)
        {
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)sender;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)dataRepeaterItem.Parent;

            var source = (List<PraccingResponse>)((BindingSource)dataRepeater.DataSource).DataSource;

            CurrentResponse = source[dataRepeaterItem.ItemIndex];
        }

        #endregion

        #region Navigation Bar events
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            bsMainIssues.EndEdit();
            
            bsResponses.EndEdit();
           

            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            MoveRecord(1);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            bsMainIssues.EndEdit();
            bsResponses.EndEdit();

            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            MoveRecord(-1);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            bsMainIssues.EndEdit();
            bsResponses.EndEdit();

            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            bsMainIssues.MoveLast();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            bsMainIssues.EndEdit();
            bsResponses.EndEdit();

            if (SaveRecord() == 1)
            {
                MessageBox.Show("Error saving this issue.");
                return;
            }

            bsMainIssues.MoveFirst();
        }
        #endregion

        /// <summary>
        /// Update the user's profile with the currently selected survey.
        /// </summary>
        private void SaveSurveyFilter()
        {
            DBAction.UpdateFormSurvey("frmIssuesTracking", 1, ((Survey)cboGoToSurvey.SelectedItem).SID, 0, frmParent.CurrentUser);
            frmParent.CurrentUser.PraccingEntrySurvey = ((Survey)cboGoToSurvey.SelectedItem).SID;
        }

        /// <summary>
        /// Load the praccing records for the selected survey.
        /// </summary>
        /// <param name="survID"></param>
        private void GoToSurvey(int survID)
        {

            IssuesList = DBAction.GetPraccingIssues(survID);
            cboGoToIssueNo.DataSource = IssuesList;

            var langList = DBAction.GetLanguages(new Survey() { SID = survID });
            langList.Add("English");

            lstLanguage.DataSource = langList;
            lstLanguage.SelectedItem = null;

            if (IssuesList.Count == 0)
            {
                CreateFirst();
                return;
            }
            

            foreach (PraccingIssue pi in IssuesList)
            {
                pi.Images = DBAction.GetPraccingImages(pi.ID);
            }

            bsMainIssues.DataSource = IssuesList;
            
            RefreshCurrentIssue();
            UpdateSummary();

        }

        /// <summary>
        /// Navigate to the specified issue number.
        /// </summary>
        /// <param name="issueNum"></param>
        private void GoToIssue(int issueNum)
        {
            int issuePosition = 0;
            for (int i = 0; i < IssuesList.Count; i++)
            {
                if (IssuesList[i].IssueNo == issueNum)
                {
                    issuePosition = i;
                    break;
                }
            }

            bsMainIssues.Position = issuePosition;
        }

        /// <summary>
        /// Set the CurrentIssue, update the description and load the responses.
        /// </summary>
        private void RefreshCurrentIssue()
        {
            CurrentIssue = (PraccingIssue)bsMainIssues.Current;

            rtbDescription.Rtf = "";

            if (CurrentIssue == null)
                return;
    

            CurrentIssue.Responses.Sort((x, y) => x.ResponseDate.Value.CompareTo(y.ResponseDate));

            rtbDescription.Rtf = CurrentIssue.DescriptionRTF;

          
            bsImages.DataSource = CurrentIssue.Images;

            bsResponses.DataSource = CurrentIssue.Responses;
            
            dataRepeater1.DataSource = bsResponses;

            RefreshCurrentResponse();

        }

        private void RefreshCurrentResponse()
        {
            CurrentResponse = (PraccingResponse)bsResponses.Current;

            if (CurrentResponse == null)
            {
                picResponse.ImageLocation = "";
                picResponse.DataBindings.Clear();
                bsResponseImages.DataSource = null;
                return;
            }
            
            bsResponseImages.DataSource = CurrentResponse.Images;
            BindControl(picResponse, "ImageLocation", bsResponseImages, "Path");

        }

        /// <summary>
        /// Refresh the summary section by counting the different types of issues and how many are resolved/unresolved.
        /// </summary>
        private void UpdateSummary()
        {
            int total = IssuesList.Count();
            int total_skips = IssuesList.Where(x => x.Category.ID == 1).Count();
            int total_typos = IssuesList.Where(x => x.Category.ID == 2).Count();
            int total_wordings = IssuesList.Where(x => x.Category.ID == 3).Count();
            int total_interface = IssuesList.Where(x => x.Category.ID == 4).Count();
            int total_coding = IssuesList.Where(x => x.Category.ID == 5).Count();
            int total_quota = IssuesList.Where(x => x.Category.ID == 6).Count();
            int total_smartdata = IssuesList.Where(x => x.Category.ID == 7).Count();

            int unres_total = IssuesList.Where(x => !x.Resolved).Count();
            int unres_skips = IssuesList.Where(x => x.Category.ID == 1 && !x.Resolved).Count();
            int unres_typos = IssuesList.Where(x => x.Category.ID == 2 && !x.Resolved).Count();
            int unres_wordings = IssuesList.Where(x => x.Category.ID == 3 && !x.Resolved).Count();
            int unres_interface = IssuesList.Where(x => x.Category.ID == 4 && !x.Resolved).Count();
            int unres_coding = IssuesList.Where(x => x.Category.ID == 5 && !x.Resolved).Count();
            int unres_quota = IssuesList.Where(x => x.Category.ID == 6 && !x.Resolved).Count();
            int unres_smartdata = IssuesList.Where(x => x.Category.ID == 7 && !x.Resolved).Count();

            lblTotalIssues.Text = total + " Total issue(s). " + unres_total + " unresolved." ;
            lblSkipIssues.Text = total_skips + " Skip/Filter issues. " + unres_skips + " unresolved." ;
            lblTypoIssues.Text = total_typos + " Typos/Aesthetic issues. " + unres_typos + " unresolved."; ;
            lblWordingIssues.Text = total_wordings + " Wording issues. " + unres_wordings + " unresolved."; ;
            lblInterfaceIssues.Text = total_interface + " User Interface issues. " + unres_interface + " unresolved."; ;
            lblCodingIssues.Text = total_coding + " Coding/Response issues. " + unres_coding + " unresolved."; ;
            lblQuotaIssues.Text = total_quota + " Quota issues. " + unres_quota + " unresolved."; ;
            lblSmartDataIssues.Text = total_smartdata + " Smart Data issues. " + unres_smartdata + " unresolved."; ;

        }

        /// <summary>
        /// Fill the combo boxes in the main issue area.
        /// </summary>
        private void FillBoxes()
        {
            cboGoToSurvey.ValueMember = "SID";
            cboGoToSurvey.DisplayMember = "SurveyCode";
            cboGoToSurvey.DataSource = SurveyList;

            cboGoToIssueNo.DisplayMember = "IssueNo";
            cboGoToIssueNo.ValueMember = "ID";
            cboGoToIssueNo.DataSource = IssuesList;

            cboIssueFrom.DisplayMember = "Name";
            cboIssueFrom.ValueMember = "ID";
            cboIssueFrom.DataSource = new List<Person>(PeopleList);

            cboIssueTo.DisplayMember = "Name";
            cboIssueTo.ValueMember = "ID";
            cboIssueTo.DataSource = new List<Person>(PeopleList);

            cboIssueCategory.DisplayMember = "Category";
            cboIssueCategory.ValueMember = "ID";
            cboIssueCategory.DataSource = new List<PraccingCategory>(CategoryList);

            cboResolvedBy.DisplayMember = "Name";
            cboResolvedBy.ValueMember = "ID";
            cboResolvedBy.DataSource = new List<Person>(PeopleList);
            

        }

        private void BindControl(System.Windows.Forms.Control ctl, string prop, object datasource, string dataMember, bool formatting = false)
        {
            ctl.DataBindings.Clear();
            ctl.DataBindings.Add(prop, datasource, dataMember, formatting,DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Bind controls to data. Not data repeater controls.
        /// </summary>
        private void BindProperties()
        {
            BindControl(txtSurveyCode, "Text", bsMainIssues, "Survey.SurveyCode");
            BindControl(txtIssueNo, "Text", bsMainIssues, "IssueNo");
            BindControl(txtVarNames, "Text", bsMainIssues, "VarNames");
            BindControl(dtpIssueDate, "Value", bsMainIssues, "IssueDate", true);
            BindControl(cboIssueFrom, "SelectedValue", bsMainIssues, "IssueFrom.ID");
            BindControl(cboIssueTo, "SelectedValue", bsMainIssues, "IssueTo.ID");
            BindControl(cboIssueCategory, "SelectedValue", bsMainIssues, "Category.ID");

            Binding languageBinding = new Binding("SelectedItem", bsMainIssues, "Language", true);
            languageBinding.NullValue = "English";
            lstLanguage.DataBindings.Add(languageBinding);
            BindControl(chkResolved, "Checked", bsMainIssues, "Resolved");
            BindControl(cboResolvedBy, "SelectedValue", bsMainIssues, "ResolvedBy.ID");

            Binding b = new Binding("Value", bsMainIssues, "ResolvedDate", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpResolvedDate.DataBindings.Add(b);
            b.Format += new ConvertEventHandler(dtp_Format);
            b.Parse += new ConvertEventHandler(dtp_Parse);

            BindControl(picMain, "ImageLocation", bsImages, "Path");
            

            // responses
            BindControl(dtpResponseDate, "Value", bsResponses, "ResponseDate");
            BindControl(dtpResponseTime, "Value", bsResponses, "ResponseDate");

        }

        /// <summary>
        /// Remove the current item, set the NewRecord flag to false and set the delete button to delete.
        /// </summary>
        private void CancelNew()
        {
            bsMainIssues.RemoveCurrent();
            NewRecord = false;
            cmdDeleteIssue.Text = "Delete";
        }

        /// <summary>
        /// Delete the current issue from the database and remove the item from the underlying list.
        /// </summary>
        private void DeleteIssue()
        {
            if (MessageBox.Show("Are you sure you want to delete this praccing issue?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBAction.DeletePraccingIssue(CurrentIssue.ID);
                bsMainIssues.RemoveCurrent();
            }
        }

        /// <summary>
        /// Delete the current response from the database and remove the item from the underlying list.
        /// </summary>
        private void DeleteResponse()
        {
            int index = dataRepeater1.CurrentItem.ItemIndex;
            PraccingResponse currentReponse = CurrentIssue.Responses[index];

            DBAction.DeletePraccingResponse(currentReponse.ID);
            dataRepeater1.RemoveAt(index);
        }
       

        private int SaveRecord()
        {

            if (NewRecord)
            {

                if (CurrentIssue.ID ==0 && DBAction.InsertPraccingIssue(CurrentIssue) == 1)
                    return 1;

                foreach (PraccingResponse pr in CurrentIssue.Responses)
                {
                    pr.IssueID = CurrentIssue.ID;
                    if (pr.ID == 0 && DBAction.InsertPraccingResponse(pr) == 1)
                        return 1;

                    foreach (PraccingImage img in pr.Images)
                    {
                        img.PraccID = pr.ID;
                        if (DBAction.InsertPraccingResponseImage(img) == 1)
                            return 1;
                    }
                }

                foreach (PraccingImage img in CurrentIssue.Images)
                {
                    img.PraccID = CurrentIssue.ID;
                    if (DBAction.InsertPraccingImage(img) == 1)
                        return 1;
                }


                NewRecord = false;
                Dirty = false;
                cmdDeleteIssue.Text = "Delete";
            }
            else if (Dirty)
            {

                if (DBAction.UpdatePraccingIssue(CurrentIssue) == 1)
                    return 1;

                foreach (PraccingResponse pr in CurrentIssue.Responses)
                {
                    if (pr.ID == 0)
                    {
                        pr.IssueID = CurrentIssue.ID;
                        if (DBAction.InsertPraccingResponse(pr) == 1)
                            return 1;
                    }
                    else
                    {
                        if (DBAction.UpdatePraccingResponse(pr) == 1)
                            return 1;
                    }

                    foreach (PraccingImage img in pr.Images)
                    {
                        if (img.ID == 0)
                        {
                            if (DBAction.InsertPraccingResponseImage(img) == 1)
                                return 1;
                        }
                    }
                }

                foreach (PraccingImage img in CurrentIssue.Images)
                {
                    if (img.ID == 0)
                    {
                        if (DBAction.InsertPraccingImage(img) == 1)
                            return 1;
                    }
                }

                Dirty = false;
            }

            return 0;
        }

        private void MoveRecord(int count)
        {
            
            if (count > 0)
                for (int i = 0; i < count; i++)
                {
                    bsMainIssues.MoveNext();
                }
            else
                for (int i = 0; i < Math.Abs(count); i++)
                {
                    bsMainIssues.MovePrevious();
                }

            
        }


        

        private void CreateNew()
        {
            NewRecord = true;
            Survey current = new Survey(CurrentIssue.Survey.SurveyCode);
            current.SID = CurrentIssue.Survey.SID;
            CurrentIssue = (PraccingIssue)bsMainIssues.AddNew();
            CurrentIssue.Survey = current;
            CurrentIssue.IssueNo = IssuesList.Max(x => x.IssueNo) + 1;
            CurrentIssue.IssueDate = DateTime.Today;
            CurrentIssue.ResolvedDate = null;
            bsMainIssues.ResetBindings(false);
            cmdDeleteIssue.Text = "Cancel";
        }

        private void AddResponse()
        {
            dataRepeater1.AddNew();
            ((DateTimePicker)dataRepeater1.CurrentItem.Controls["dtpResponseDate"]).Value = DateTime.Today;
            ((DateTimePicker)dataRepeater1.CurrentItem.Controls["dtpResponseTime"]).Value = DateTime.Now;

            Dirty = true;
        }

        private void CreateFirst()
        {
            NewRecord = true;

            Survey filter = (Survey)cboGoToSurvey.SelectedItem;

            Survey current = new Survey(filter.SurveyCode);
            current.SID = filter.SID;
            IssuesList.Clear();
            bsMainIssues.DataSource = IssuesList;
            CurrentIssue = (PraccingIssue)bsMainIssues.AddNew();
            CurrentIssue.Survey = current;
            CurrentIssue.IssueNo =  1;
            CurrentIssue.IssueDate = DateTime.Today;
            CurrentIssue.ResolvedDate = null;
            bsMainIssues.ResetBindings(false);
            cmdDeleteIssue.Text = "Cancel";
        }

        private void Control_Validated(object sender, EventArgs e)
        {
            Dirty = true;
        }

        
    }
}
