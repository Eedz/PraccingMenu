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
    public partial class SurveySelector : Form
    {

        public Survey Selected;

        public SurveySelector()
        {
            InitializeComponent();

            cboSurvey.DisplayMember = "SurveyCode";
            cboSurvey.ValueMember = "SID";
            cboSurvey.DataSource = DBAction.GetAllSurveys();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (cboSurvey.SelectedItem == null)
                Selected = null;
            else
                Selected = (Survey)cboSurvey.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Selected = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
