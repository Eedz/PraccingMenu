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
    public partial class frmFixNames : Form
    {
        List<StringPair> Names;
        public frmFixNames(List<StringPair> toFix)
        {
            InitializeComponent();

            Names = toFix;
            chValid.ValueMember = "Name";
            chValid.DisplayMember = "Name";
            chValid.DataSource = DBAction.GetPeople();
            chValid.DataPropertyName = "String2";
           
            chInvalid.DataPropertyName = "String1";
            dgvNames.AutoGenerateColumns = false;
            dgvNames.DataSource = Names;
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            //foreach (StringPair sp in Names)
            //{
            //    if (string.IsNullOrEmpty(sp.Valid))
            //    {
            //        MessageBox.Show("Some names are not blank.");
            //        return;
            //    }
            //}
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
