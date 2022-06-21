using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITCLib;

namespace PraccingMenu
{
    public partial class PraccingReportForm : Form
    {
        public PraccingMenu frmParent;
        public string key;
        List<Survey> SurveyList;
        List<PraccingIssue> IssuesList;
        List<PraccingIssue> FilteredIssuesList;

        Survey SelectedSurvey;

        public PraccingReportForm()
        {
            InitializeComponent();

            SurveyList =new List<Survey>(DBAction.GetAllSurveysInfo());


            cboSurvey.DisplayMember = "SurveyCode";
            cboSurvey.ValueMember = "SID";
            cboSurvey.DataSource = SurveyList;

            cboSurvey.SelectedIndexChanged += cboSurvey_SelectedIndexChanged;

            IssuesList = new List<PraccingIssue>();
            FilteredIssuesList = new List<PraccingIssue>();

            
        }

        #region Menu Events

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cboSurvey.SelectedItem = null;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage page = frmParent.GetTab("PraccingEntry");

            if (page == null)
            {
                var state = frmParent.CurrentUser.FormStates.Where(x => x.FormName.Equals("frmIssuesTracking") && x.FormNum == 1).First();
                int survID = 899;
                if (state != null)
                    survID = state.FilterID;

                PraccingEntry frm = new PraccingEntry(survID);
                frm.frmParent = frmParent;
                frm.key = "PraccingEntry";
                frmParent.AddTab(frm, "PraccingEntry", "Praccing Issues - Entry");
                page = frmParent.GetTab("PraccingEntry");
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
        #endregion


        #region Control Events

        private void cboSurvey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSurvey.SelectedItem == null)
                return;

            SelectedSurvey = (Survey)cboSurvey.SelectedItem;
            FillBoxes();
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;

            // only the <All> option is in the box
            if (lst.Items.Count == 1)
                return;

            lst.SelectedIndexChanged -= ListBox_SelectedIndexChanged;

            int count = lst.SelectedItems.Count;

            if (count > 1 && (bool)lst.Tag)
            {
                lst.SelectedItems.Remove(lst.Items[0]);
                lst.Tag = false;
            }
            else if (count > 1 && lst.SelectedIndices.Contains(0))
            {
                lst.SelectedItems.Clear();
                lst.SelectedItems.Add(lst.Items[0]);
                lst.Tag = true;
            }

            lst.SelectedIndexChanged += ListBox_SelectedIndexChanged;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            IssuesList = DBAction.GetPraccingIssues(SelectedSurvey.SID); // get all the issues again in case any were added since opening the form

            // get the filtered list
            FilteredIssuesList = GetIssueList();

            if (FilteredIssuesList.Count == 0)
            {
                MessageBox.Show("No praccing issues found!");
                return;
            }

            PraccingReport report = new PraccingReport();

            if (chkIncludeQnums.Checked)
            {
                report.VarQnums = GetQnumDictionary();
            }

            if (chkIncludePrevNames.Checked)
            {
                report.PrevNames = GetPrevNamesDictionary();
            }

            
            report.SelectedSurvey = SelectedSurvey;
            report.AddBlankLine = chkEmptyRow.Checked;
            report.IncludeToPracc = chkPraccInstructions.Checked;
            report.IncludePraccInstructions = chkPraccInstructions.Checked;
            report.IncludeQnums = chkIncludeQnums.Checked;
            report.IncludePrevNames = chkIncludePrevNames.Checked;
            report.Recipients = GetRecipients();
            report.Issues = FilteredIssuesList;

            report.CreateReport();
         
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PraccingReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParent.CloseTab(key);
        }

        private void PraccingReportForm_Resize(object sender, EventArgs e)
        {
            cmdClose.Left = this.Width - cmdClose.Width;
        }

        
        #endregion

        private Dictionary<string, string> GetQnumDictionary()
        {
            Dictionary<string, string> VarQnums = new Dictionary<string, string>();

            List<SurveyQuestion> qs = DBAction.GetSurveyQuestions(SelectedSurvey).ToList();

            foreach (PraccingIssue pi in FilteredIssuesList)
            {
                string[] varnames = pi.VarNames.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in varnames)
                {
                    SurveyQuestion q = qs.Where(x => x.VarName.RefVarName.Equals(s)).FirstOrDefault();
                    if (q == null)
                        continue;

                    if (!VarQnums.ContainsKey(s))
                        VarQnums.Add(s, q.Qnum);

                }
            }

            return VarQnums;
        }

        private Dictionary<string, string> GetPrevNamesDictionary()
        {
            Dictionary<string, string> prevNames = new Dictionary<string, string>();

            List<SurveyQuestion> qs = DBAction.GetSurveyQuestions(SelectedSurvey).ToList();

            foreach (PraccingIssue pi in FilteredIssuesList)
            {
                string[] varnames = pi.VarNames.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in varnames)
                {
                    SurveyQuestion q = qs.Where(x => x.VarName.RefVarName.Equals(s)).FirstOrDefault();
                    
                    if (q == null)
                        continue;

                    var prev = DBAction.GetPreviousNames(SelectedSurvey.SurveyCode, q.VarName.VarName, false);

                    if (prev.Count <= 1)
                        continue;

                    if (!prevNames.ContainsKey(s))
                        prevNames.Add(s, prev[1]);

                }
            }

            return prevNames;
        }

        private List<PraccingIssue> GetIssueList()
        {
            SelectedSurvey = (Survey)cboSurvey.SelectedItem;


            // now filter it based on the form selections
            List<string> dates = new List<string>();
            List<Person> from = new List<Person>();
            List<Person> to = new List<Person>();
            string status = "";
            string language = "";
            List<string> lastUpdateDates = new List<string>();
            List<Person> lastUpdateFroms = new List<Person>();
            List<Person> lastUpdateTos = new List<Person>();


            if (!lstDate.SelectedItems[0].Equals("<All>"))
            {
                foreach (string s in lstDate.SelectedItems)
                    dates.Add(s);
            }

            if (((Person)lstFrom.SelectedItems[0]).ID != -1)
            {
                foreach (Person s in lstFrom.SelectedItems)
                    from.Add(s);
            }

            if (((Person)lstTo.SelectedItems[0]).ID != -1)
            {
                foreach (Person s in lstTo.SelectedItems)
                    to.Add(s);
            }

            if (!lstLastUpdateDate.SelectedItems[0].Equals("<All>"))
            {
                foreach (string s in lstLastUpdateDate.SelectedItems)
                    lastUpdateDates.Add(s);
            }

            if (((Person)lstLastUpdateFrom.SelectedItems[0]).ID != -1)
            {
                foreach (Person s in lstLastUpdateFrom.SelectedItems)
                    lastUpdateFroms.Add(s);
            }

            if (((Person)lstLastUpdateTo.SelectedItems[0]).ID != -1)
            {
                foreach (Person s in lstLastUpdateTo.SelectedItems)
                    lastUpdateTos.Add(s);
            }

            status = (string)cboStatus.SelectedItem;
            language = (string)cboLanguage.SelectedItem;

            IEnumerable<PraccingIssue> query = IssuesList;

            if (dates.Count() != 0)
                query = query.Where(x => dates.Contains(x.IssueDate.ToString("d")));
            if (from.Count() != 0)
                query = query.Where(x => from.Contains(x.IssueFrom));
            if (to.Count() != 0)
                query = query.Where(x => to.Contains(x.IssueTo));
            if (status.Equals("Resolved"))
                query = query.Where(x => x.Resolved);
            else if (status.Equals("Unresolved"))
                query = query.Where(x => !x.Resolved);

            if (!language.Equals("<All>"))
                query = query.Where(x => x.Language.Equals(language));

            if (lastUpdateDates.Count() != 0)
            {
                query = query.Where(x => (x.Responses.Count() == 0 && lastUpdateDates.Contains(x.IssueDate.ToString("d"))) ||
                    (x.Responses.Count() > 0 && lastUpdateDates.Contains(x.Responses.Last().ResponseDate.Value.ToString("d"))));
            }

            if (lastUpdateFroms.Count() != 0)
            {
                query = query.Where(x => (x.Responses.Count() == 0 && lastUpdateFroms.Contains(x.IssueFrom)) ||
                    (x.Responses.Count() > 0 && lastUpdateFroms.Contains(x.Responses.Last().ResponseFrom)));
            }

            if (lastUpdateTos.Count() != 0)
            {
                query = query.Where(x => (x.Responses.Count() == 0 && lastUpdateTos.Contains(x.IssueTo)) ||
                    (x.Responses.Count() > 0 && lastUpdateTos.Contains(x.Responses.Last().ResponseTo)));
            }

            List<PraccingIssue> filtered = query.ToList();
            return filtered;
        }

        private void FillBoxes()
        {
            IssuesList = DBAction.GetPraccingIssues(SelectedSurvey.SID);

            lstDate.DataSource = GetDates();
            lstDate.Tag = true;

            lstFrom.DisplayMember = "Name";
            lstFrom.ValueMember = "ID";
            lstFrom.DataSource = GetFroms();
            lstFrom.Tag = true;

            lstTo.DisplayMember = "Name";
            lstTo.ValueMember = "ID";
            lstTo.DataSource = GetTos();
            lstTo.Tag = true;

            lstLastUpdateDate.DataSource = GetLastUpdateDates();
            lstLastUpdateDate.Tag = true;

            lstLastUpdateFrom.DisplayMember = "Name";
            lstLastUpdateFrom.ValueMember = "ID";
            lstLastUpdateFrom.DataSource = GetLastUpdateFroms();
            lstLastUpdateFrom.Tag = true;

            lstLastUpdateTo.DisplayMember = "Name";
            lstLastUpdateTo.ValueMember = "ID";
            lstLastUpdateTo.DataSource = GetLastUpdateTos();
            lstLastUpdateTo.Tag = true;

            cboLanguage.DataSource = GetLanguages();
            cboStatus.DataSource = new string[] { "<All>", "Unresolved", "Resolved" };
            cboStatus.SelectedItem = "Unresolved";
            
        }

        List<string> GetDates()
        {
            var dates = IssuesList.GroupBy(x => x.IssueDate).Select(group => new { PraccingIssue = group.Key, Items = group.ToList() }).OrderByDescending(group => group.PraccingIssue).ToList();

            List<string> dateList = new List<string>();

            dateList.Add("<All>");
            foreach (var d in dates)
            {
                dateList.Add(d.PraccingIssue.ToString("d"));
            }
            
            return dateList;
        }

        List<Person> GetFroms()
        {
            var froms = IssuesList.GroupBy(x => x.IssueFrom).Select(s => new { Name = s.Key, Items = s.ToList() }).ToList();
            List<Person> fromList = new List<Person>();
            fromList.Add(new Person("<All>", -1));
            foreach (var f in froms)
            {
                if (f.Name.ID!=0)
                    fromList.Add(f.Name);
            }

            var sortedFrom = fromList.OrderBy(x => x.Name).ToList();
            return sortedFrom;
        }

        List<Person> GetTos()
        {
            var tos = IssuesList.GroupBy(x => x.IssueTo).Select(s => new { Name = s.Key, Items = s.ToList() }).ToList();
            List<Person> toList = new List<Person>();
            toList.Add(new Person("<All>", -1));
            foreach (var t in tos)
            {
                if (t.Name.ID != 0)
                    toList.Add(t.Name);
            }

            var sortedTo = toList.OrderBy(x => x.Name).ToList();
            return sortedTo;
        }

        List<string> GetLastUpdateDates()
        {
            List<DateTime> rawDates = new List<DateTime>();
            List<string> finalDates = new List<string>();
            foreach (PraccingIssue pi in IssuesList)
            {
                if (pi.Responses.Count() == 0)
                {
                    rawDates.Add(pi.IssueDate);
                    continue;
                }

                DateTime? last = pi.Responses.Last().ResponseDate;
                if (last.HasValue)
                    rawDates.Add(last.Value.Date);
            }

            var sortedDates = rawDates.GroupBy(x => x).Select(group => new { Dates = group.Key, Items = group.ToList() }).OrderByDescending(group => group.Dates).ToList();

            finalDates.Add("<All>");
            foreach(var d in sortedDates)
            {
                finalDates.Add(d.Dates.ToString("d"));
            }

            return finalDates;
        }

        List<Person> GetLastUpdateFroms()
        {
            List<Person> rawNames = new List<Person>();
            List<Person> finalNames = new List<Person>();
            foreach (PraccingIssue pi in IssuesList)
            {
                if (pi.Responses.Count() == 0)
                {
                    rawNames.Add(pi.IssueFrom);
                    continue;
                }

                rawNames.Add(pi.Responses.Last().ResponseFrom);
            }

            var sortedNames = rawNames.GroupBy(x => x).Select(group => new { Names = group.Key, Items = group.ToList() }).ToList();

            finalNames.Add(new Person("<All>", -1));
            foreach(var d in sortedNames)
            {
                if (d.Names.ID!=0)
                    finalNames.Add(d.Names);
            }

            return finalNames.OrderBy(x=>x.Name).ToList();

     
        }

        List<Person> GetLastUpdateTos()
        {
            List<Person> rawNames = new List<Person>();
            List<Person> finalNames = new List<Person>();
            foreach (PraccingIssue pi in IssuesList)
            {
                if (pi.Responses.Count() == 0)
                {
                    rawNames.Add(pi.IssueTo);
                    continue;
                }

                rawNames.Add(pi.Responses.Last().ResponseTo);
            }

            var sortedNames = rawNames.GroupBy(x => x).Select(group => new { Names = group.Key, Items = group.ToList() }).ToList();

            finalNames.Add(new Person("<All>", -1));
            foreach (var d in sortedNames)
            {
                if (d.Names.ID!=0)
                    finalNames.Add(d.Names);
            }

            return finalNames.OrderBy(x => x.Name).ToList();
        }

        List<string> GetLanguages()
        {
            var languages = IssuesList.GroupBy(x => x.Language).Select(group => new { PraccingIssue = group.Key, Items = group.ToList() }).OrderByDescending(group => group.PraccingIssue).ToList();

            List<string> languageList = new List<string>();

            languageList.Add("<All>");
            foreach (var d in languages)
            {
                languageList.Add(d.PraccingIssue);
            }

            return languageList;
        }

        List<string> GetRecipients()
        {
            List<string> finalList = new List<string>();
            if (lstTo.SelectedItems.Count>0 && ((Person)lstTo.SelectedItems[0]).ID != -1)
            {
                foreach (Person s in lstTo.SelectedItems)
                    finalList.Add(s.Name);
            }
            if (lstLastUpdateTo.SelectedItems.Count > 0 && ((Person)lstLastUpdateTo.SelectedItems[0]).ID != -1)
            {
                foreach (Person s in lstLastUpdateTo.SelectedItems)
                    if (!finalList.Contains(s.Name))
                        finalList.Add(s.Name);
            }

            return finalList;
        }

        
    }
}
