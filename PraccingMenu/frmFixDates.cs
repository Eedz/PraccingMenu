using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PraccingMenu
{
    public partial class frmFixDates : Form
    {
        List<StringPair> Dates;
        public frmFixDates(List<StringPair> toFix)
        {
            InitializeComponent();

            Dates = toFix;

            dgvDates.DataSource = Dates;
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            foreach(StringPair sp in Dates)
            {
                if (!Regex.IsMatch(sp.String2, "[0-9]{2}[-][A-Z][a-z]{2}[-][0-9]{4}"))
                {
                    MessageBox.Show("Some dates are not valid.");
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
