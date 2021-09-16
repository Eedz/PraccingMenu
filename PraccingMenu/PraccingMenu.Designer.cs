namespace PraccingMenu
{
    partial class PraccingMenu
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
            this.cmdOpenPraccingEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOpenIssuesImport = new System.Windows.Forms.Button();
            this.cmdOpenPraccingReport = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdPraccingForm = new System.Windows.Forms.Button();
            this.cmdPraccingSheet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOpenPraccingEntry
            // 
            this.cmdOpenPraccingEntry.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpenPraccingEntry.Location = new System.Drawing.Point(92, 88);
            this.cmdOpenPraccingEntry.Name = "cmdOpenPraccingEntry";
            this.cmdOpenPraccingEntry.Size = new System.Drawing.Size(116, 27);
            this.cmdOpenPraccingEntry.TabIndex = 0;
            this.cmdOpenPraccingEntry.Text = "Praccing Entry";
            this.cmdOpenPraccingEntry.UseVisualStyleBackColor = true;
            this.cmdOpenPraccingEntry.Click += new System.EventHandler(this.cmdOpenPraccingEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "SDI Praccing Menu";
            // 
            // cmdOpenIssuesImport
            // 
            this.cmdOpenIssuesImport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpenIssuesImport.Location = new System.Drawing.Point(92, 130);
            this.cmdOpenIssuesImport.Name = "cmdOpenIssuesImport";
            this.cmdOpenIssuesImport.Size = new System.Drawing.Size(116, 27);
            this.cmdOpenIssuesImport.TabIndex = 2;
            this.cmdOpenIssuesImport.Text = "Import Issues";
            this.cmdOpenIssuesImport.UseVisualStyleBackColor = true;
            this.cmdOpenIssuesImport.Click += new System.EventHandler(this.cmdOpenIssuesImport_Click);
            // 
            // cmdOpenPraccingReport
            // 
            this.cmdOpenPraccingReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpenPraccingReport.Location = new System.Drawing.Point(92, 172);
            this.cmdOpenPraccingReport.Name = "cmdOpenPraccingReport";
            this.cmdOpenPraccingReport.Size = new System.Drawing.Size(116, 27);
            this.cmdOpenPraccingReport.TabIndex = 3;
            this.cmdOpenPraccingReport.Text = "Praccing Report";
            this.cmdOpenPraccingReport.UseVisualStyleBackColor = true;
            this.cmdOpenPraccingReport.Click += new System.EventHandler(this.cmdOpenPraccingReport_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1484, 886);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdPraccingForm);
            this.tabPage1.Controls.Add(this.cmdPraccingSheet);
            this.tabPage1.Controls.Add(this.cmdOpenPraccingEntry);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmdOpenPraccingReport);
            this.tabPage1.Controls.Add(this.cmdOpenIssuesImport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1476, 860);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdPraccingForm
            // 
            this.cmdPraccingForm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPraccingForm.Location = new System.Drawing.Point(92, 255);
            this.cmdPraccingForm.Name = "cmdPraccingForm";
            this.cmdPraccingForm.Size = new System.Drawing.Size(116, 27);
            this.cmdPraccingForm.TabIndex = 5;
            this.cmdPraccingForm.Text = "Pracc Form";
            this.cmdPraccingForm.UseVisualStyleBackColor = true;
            this.cmdPraccingForm.Click += new System.EventHandler(this.cmdPraccingForm_Click);
            // 
            // cmdPraccingSheet
            // 
            this.cmdPraccingSheet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPraccingSheet.Location = new System.Drawing.Point(92, 214);
            this.cmdPraccingSheet.Name = "cmdPraccingSheet";
            this.cmdPraccingSheet.Size = new System.Drawing.Size(116, 27);
            this.cmdPraccingSheet.TabIndex = 4;
            this.cmdPraccingSheet.Text = "Pracc Sheet";
            this.cmdPraccingSheet.UseVisualStyleBackColor = true;
            this.cmdPraccingSheet.Click += new System.EventHandler(this.cmdPraccingSheet_Click);
            // 
            // PraccingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 886);
            this.Controls.Add(this.tabControl1);
            this.Name = "PraccingMenu";
            this.Text = "Praccing Menu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOpenPraccingEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdOpenIssuesImport;
        private System.Windows.Forms.Button cmdOpenPraccingReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdPraccingForm;
        private System.Windows.Forms.Button cmdPraccingSheet;
    }
}

