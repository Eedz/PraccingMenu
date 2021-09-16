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
    public partial class frmMoveIssue : Form
    {
        List<int> IssueNums;
        public int TargetIssueNum;

        public frmMoveIssue(List<int> issueNums)
        {
            InitializeComponent();

            IssueNums = issueNums;

            cboIssueNo.DataSource = IssueNums;
        }

        private void frmMoveIssue_Load(object sender, EventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            TargetIssueNum = (int)cboIssueNo.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
