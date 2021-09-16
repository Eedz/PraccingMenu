using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraccingMenu
{
    public partial class RichTextEditor : Form
    {
        public string OriginalText { get; set; }
        public string EditedText { get; set; }

        public RichTextEditor(string text)
        {
            InitializeComponent();
            OriginalText = text;
            rtbEditor.Rtf = text;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            EditedText = OriginalText;
            Close();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            EditedText = rtbEditor.Rtf;
            Close();
        }

        private void cmdBold_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont.Bold)
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Regular);
            }
            else
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Bold);
            }
        }

        private void cmdItalic_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont.Italic)
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Regular);
            }
            else
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Italic);
            }
        }

        private void cmdUnderline_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont.Underline)
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Regular);
            }
            else
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Underline);
            }
        }

        private void cmdStrikethrough_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont.Strikeout)
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Regular);
            }
            else
            {
                rtbEditor.SelectionFont = new Font(rtbEditor.Font, FontStyle.Strikeout);
            }
        }

        private void cmdHighlight_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionBackColor == Color.Yellow)
            {
                rtbEditor.SelectionBackColor = Color.White;
            }
            else
            {
                rtbEditor.SelectionBackColor = Color.Yellow;
            }
        }
    }
}
