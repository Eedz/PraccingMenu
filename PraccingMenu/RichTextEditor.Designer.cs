namespace PraccingMenu
{
    partial class RichTextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.cmdBold = new System.Windows.Forms.Button();
            this.cmdItalic = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdUnderline = new System.Windows.Forms.Button();
            this.cmdStrikethrough = new System.Windows.Forms.Button();
            this.cmdHighlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEditor.Location = new System.Drawing.Point(12, 41);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(509, 285);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            // 
            // cmdBold
            // 
            this.cmdBold.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBold.Location = new System.Drawing.Point(12, 12);
            this.cmdBold.Name = "cmdBold";
            this.cmdBold.Size = new System.Drawing.Size(75, 23);
            this.cmdBold.TabIndex = 1;
            this.cmdBold.Text = "B";
            this.cmdBold.UseVisualStyleBackColor = true;
            this.cmdBold.Click += new System.EventHandler(this.cmdBold_Click);
            // 
            // cmdItalic
            // 
            this.cmdItalic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdItalic.Location = new System.Drawing.Point(93, 12);
            this.cmdItalic.Name = "cmdItalic";
            this.cmdItalic.Size = new System.Drawing.Size(75, 23);
            this.cmdItalic.TabIndex = 2;
            this.cmdItalic.Text = "I";
            this.cmdItalic.UseVisualStyleBackColor = true;
            this.cmdItalic.Click += new System.EventHandler(this.cmdItalic_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(365, 332);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(446, 332);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdUnderline
            // 
            this.cmdUnderline.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnderline.Location = new System.Drawing.Point(174, 12);
            this.cmdUnderline.Name = "cmdUnderline";
            this.cmdUnderline.Size = new System.Drawing.Size(75, 23);
            this.cmdUnderline.TabIndex = 5;
            this.cmdUnderline.Text = "U";
            this.cmdUnderline.UseVisualStyleBackColor = true;
            this.cmdUnderline.Click += new System.EventHandler(this.cmdUnderline_Click);
            // 
            // cmdStrikethrough
            // 
            this.cmdStrikethrough.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStrikethrough.Location = new System.Drawing.Point(255, 12);
            this.cmdStrikethrough.Name = "cmdStrikethrough";
            this.cmdStrikethrough.Size = new System.Drawing.Size(75, 23);
            this.cmdStrikethrough.TabIndex = 6;
            this.cmdStrikethrough.Text = "S";
            this.cmdStrikethrough.UseVisualStyleBackColor = true;
            this.cmdStrikethrough.Click += new System.EventHandler(this.cmdStrikethrough_Click);
            // 
            // cmdHighlight
            // 
            this.cmdHighlight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cmdHighlight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHighlight.ForeColor = System.Drawing.Color.Yellow;
            this.cmdHighlight.Location = new System.Drawing.Point(336, 12);
            this.cmdHighlight.Name = "cmdHighlight";
            this.cmdHighlight.Size = new System.Drawing.Size(75, 23);
            this.cmdHighlight.TabIndex = 7;
            this.cmdHighlight.Text = "Highlight";
            this.cmdHighlight.UseVisualStyleBackColor = false;
            this.cmdHighlight.Click += new System.EventHandler(this.cmdHighlight_Click);
            // 
            // RichTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 368);
            this.ControlBox = false;
            this.Controls.Add(this.cmdHighlight);
            this.Controls.Add(this.cmdStrikethrough);
            this.Controls.Add(this.cmdUnderline);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdItalic);
            this.Controls.Add(this.cmdBold);
            this.Controls.Add(this.rtbEditor);
            this.Name = "RichTextEditor";
            this.Text = "Rich Text Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.Button cmdBold;
        private System.Windows.Forms.Button cmdItalic;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdUnderline;
        private System.Windows.Forms.Button cmdStrikethrough;
        private System.Windows.Forms.Button cmdHighlight;
    }
}