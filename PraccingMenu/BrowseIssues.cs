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
    public partial class BrowseIssues : Form
    {
        public PraccingEntry frmParent;
        List<PraccingIssue> IssueList;
        BindingSource bs;
        public int SelectedIssueNo;

        public BrowseIssues(List<PraccingIssue> list)
        {
            InitializeComponent();

            IssueList = list;
            bs = new BindingSource();
            bs.DataSource = IssueList;

            dataRepeater1.DataSource = bs;

            txtSurvey.DataBindings.Add(new Binding("Text", bs, "Survey.SurveyCode"));
            cboToCriteria.DisplayMember = "Name";
            cboToCriteria.ValueMember = "ID";
            cboToCriteria.DataSource = DBAction.GetPeople();
            cboToCriteria.SelectedItem = null;

            txtIssueNo.DataBindings.Add(new Binding("Text", bs, "IssueNo"));
            txtVarNames.DataBindings.Add(new Binding("Text", bs, "VarNames"));
            txtFrom.DataBindings.Add(new Binding("Text", bs, "IssueFrom.Name"));
            txtTo.DataBindings.Add(new Binding("Text", bs, "IssueTo.Name"));
            dtpIssueDate.DataBindings.Add(new Binding("Value", bs, "IssueDate", true));

            rtbDescription.DataBindings.Add(new Binding("Rtf", bs, "DescriptionRTF"));
        }

        private void cmdCheckForIssues_Click(object sender, EventArgs e)
        {
           
            IEnumerable<PraccingIssue> query = IssueList;

            string varnames = txtVarNameCriteria.Text.ToLower();
            Person to = (Person)cboToCriteria.SelectedItem;
            if (!string.IsNullOrEmpty(varnames))
                query = query.Where(x => x.VarNames.ToLower().Contains(varnames));
            if (cboToCriteria.SelectedItem !=null)
                query = query.Where(x => x.IssueTo.ID == to.ID);

            if (query.Count() ==0)
            {
                MessageBox.Show("No matches found!");
                return;
            }


            bs.DataSource = query.ToList();
        }

        private void cmdCreateNew_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void cmdSelectIssue_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var dataRepeaterItem = (Microsoft.VisualBasic.PowerPacks.DataRepeaterItem)btn.Parent;
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)btn.Parent.Parent;
            var source = (List<PraccingIssue>)((BindingSource)dataRepeater.DataSource).DataSource;

            

            SelectedIssueNo = source[dataRepeaterItem.ItemIndex].IssueNo;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// After Item is cloned, draw item. The index is now available to select the proper data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataRepeater1_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)sender;
            var datasource = (List<PraccingIssue>)((BindingSource)dataRepeater.DataSource).DataSource;

            var fromBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtFrom", false)[0];
            fromBox.Text = datasource[e.DataRepeaterItem.ItemIndex].IssueFrom.Name;

            var toBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtTo", false)[0];
            toBox.Text = datasource[e.DataRepeaterItem.ItemIndex].IssueTo.Name;


        }
    }
}
