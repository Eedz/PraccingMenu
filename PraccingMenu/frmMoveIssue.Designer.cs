namespace PraccingMenu
{
    partial class frmMoveIssue
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
            this.cboIssueNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboIssueNo
            // 
            this.cboIssueNo.FormattingEnabled = true;
            this.cboIssueNo.Location = new System.Drawing.Point(101, 18);
            this.cboIssueNo.Name = "cboIssueNo";
            this.cboIssueNo.Size = new System.Drawing.Size(46, 21);
            this.cboIssueNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move to issue #:";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(12, 58);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(101, 58);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(4, 50);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(175, 2);
            this.lblSeparator.TabIndex = 4;
            this.lblSeparator.Text = "label2";
            // 
            // frmMoveIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 87);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIssueNo);
            this.Name = "frmMoveIssue";
            this.Text = "Move";
            this.Load += new System.EventHandler(this.frmMoveIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIssueNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblSeparator;
    }
}