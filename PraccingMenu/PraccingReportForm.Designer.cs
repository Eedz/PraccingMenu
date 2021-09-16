namespace PraccingMenu
{
    partial class PraccingReportForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSurvey = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.lblIssueFilters = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lstLastUpdateFrom = new System.Windows.Forms.ListBox();
            this.lstLastUpdateTo = new System.Windows.Forms.ListBox();
            this.lstLastUpdateDate = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.chkShadeAlternateRows = new System.Windows.Forms.CheckBox();
            this.chkIncludePrevNames = new System.Windows.Forms.CheckBox();
            this.chkIncludeQnums = new System.Windows.Forms.CheckBox();
            this.chkEmptyRow = new System.Windows.Forms.CheckBox();
            this.chkPraccInstructions = new System.Windows.Forms.CheckBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Praccing Issues - Report";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.goToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem,
            this.importToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.entryToolStripMenuItem.Text = "Entry";
            this.entryToolStripMenuItem.Click += new System.EventHandler(this.entryToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Survey";
            // 
            // cboSurvey
            // 
            this.cboSurvey.FormattingEnabled = true;
            this.cboSurvey.Location = new System.Drawing.Point(72, 79);
            this.cboSurvey.Name = "cboSurvey";
            this.cboSurvey.Size = new System.Drawing.Size(121, 21);
            this.cboSurvey.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboLanguage);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.lstTo);
            this.panel1.Controls.Add(this.lstFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstDate);
            this.panel1.Controls.Add(this.lblIssueFilters);
            this.panel1.Location = new System.Drawing.Point(6, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 293);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "To";
            // 
            // cboLanguage
            // 
            this.cboLanguage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(242, 180);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(116, 24);
            this.cboLanguage.TabIndex = 7;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(242, 206);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(116, 24);
            this.cboStatus.TabIndex = 6;
            // 
            // lstTo
            // 
            this.lstTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTo.FormattingEnabled = true;
            this.lstTo.ItemHeight = 16;
            this.lstTo.Location = new System.Drawing.Point(53, 166);
            this.lstTo.Name = "lstTo";
            this.lstTo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTo.Size = new System.Drawing.Size(116, 116);
            this.lstTo.TabIndex = 5;
            this.lstTo.Tag = "";
            this.lstTo.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lstFrom
            // 
            this.lstFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.ItemHeight = 16;
            this.lstFrom.Location = new System.Drawing.Point(242, 38);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFrom.Size = new System.Drawing.Size(116, 116);
            this.lstFrom.TabIndex = 4;
            this.lstFrom.Tag = "";
            this.lstFrom.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // lstDate
            // 
            this.lstDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDate.FormattingEnabled = true;
            this.lstDate.ItemHeight = 16;
            this.lstDate.Location = new System.Drawing.Point(53, 38);
            this.lstDate.Name = "lstDate";
            this.lstDate.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDate.Size = new System.Drawing.Size(116, 116);
            this.lstDate.TabIndex = 1;
            this.lstDate.Tag = "";
            this.lstDate.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lblIssueFilters
            // 
            this.lblIssueFilters.AutoSize = true;
            this.lblIssueFilters.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueFilters.Location = new System.Drawing.Point(3, 8);
            this.lblIssueFilters.Name = "lblIssueFilters";
            this.lblIssueFilters.Size = new System.Drawing.Size(109, 23);
            this.lblIssueFilters.TabIndex = 0;
            this.lblIssueFilters.Text = "Issue Filters";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lstLastUpdateFrom);
            this.panel2.Controls.Add(this.lstLastUpdateTo);
            this.panel2.Controls.Add(this.lstLastUpdateDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(384, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 292);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Last Update Filters";
            // 
            // lstLastUpdateFrom
            // 
            this.lstLastUpdateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLastUpdateFrom.FormattingEnabled = true;
            this.lstLastUpdateFrom.ItemHeight = 16;
            this.lstLastUpdateFrom.Location = new System.Drawing.Point(209, 38);
            this.lstLastUpdateFrom.Name = "lstLastUpdateFrom";
            this.lstLastUpdateFrom.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLastUpdateFrom.Size = new System.Drawing.Size(116, 116);
            this.lstLastUpdateFrom.TabIndex = 5;
            this.lstLastUpdateFrom.Tag = "";
            this.lstLastUpdateFrom.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lstLastUpdateTo
            // 
            this.lstLastUpdateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLastUpdateTo.FormattingEnabled = true;
            this.lstLastUpdateTo.ItemHeight = 16;
            this.lstLastUpdateTo.Location = new System.Drawing.Point(46, 166);
            this.lstLastUpdateTo.Name = "lstLastUpdateTo";
            this.lstLastUpdateTo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLastUpdateTo.Size = new System.Drawing.Size(116, 116);
            this.lstLastUpdateTo.TabIndex = 4;
            this.lstLastUpdateTo.Tag = "";
            this.lstLastUpdateTo.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lstLastUpdateDate
            // 
            this.lstLastUpdateDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLastUpdateDate.FormattingEnabled = true;
            this.lstLastUpdateDate.ItemHeight = 16;
            this.lstLastUpdateDate.Location = new System.Drawing.Point(46, 38);
            this.lstLastUpdateDate.Name = "lstLastUpdateDate";
            this.lstLastUpdateDate.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLastUpdateDate.Size = new System.Drawing.Size(116, 116);
            this.lstLastUpdateDate.TabIndex = 3;
            this.lstLastUpdateDate.Tag = "";
            this.lstLastUpdateDate.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmdGenerate);
            this.panel3.Controls.Add(this.chkShadeAlternateRows);
            this.panel3.Controls.Add(this.chkIncludePrevNames);
            this.panel3.Controls.Add(this.chkIncludeQnums);
            this.panel3.Controls.Add(this.chkEmptyRow);
            this.panel3.Controls.Add(this.chkPraccInstructions);
            this.panel3.Location = new System.Drawing.Point(5, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 105);
            this.panel3.TabIndex = 6;
            this.panel3.Visible = false;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerate.Location = new System.Drawing.Point(588, 32);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(116, 40);
            this.cmdGenerate.TabIndex = 6;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // chkShadeAlternateRows
            // 
            this.chkShadeAlternateRows.AutoSize = true;
            this.chkShadeAlternateRows.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShadeAlternateRows.Location = new System.Drawing.Point(217, 9);
            this.chkShadeAlternateRows.Name = "chkShadeAlternateRows";
            this.chkShadeAlternateRows.Size = new System.Drawing.Size(154, 20);
            this.chkShadeAlternateRows.TabIndex = 5;
            this.chkShadeAlternateRows.Text = "Shade Alternate Rows";
            this.chkShadeAlternateRows.UseVisualStyleBackColor = true;
            this.chkShadeAlternateRows.Visible = false;
            // 
            // chkIncludePrevNames
            // 
            this.chkIncludePrevNames.AutoSize = true;
            this.chkIncludePrevNames.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludePrevNames.Location = new System.Drawing.Point(29, 78);
            this.chkIncludePrevNames.Name = "chkIncludePrevNames";
            this.chkIncludePrevNames.Size = new System.Drawing.Size(144, 20);
            this.chkIncludePrevNames.TabIndex = 4;
            this.chkIncludePrevNames.Text = "Include Prev. Names";
            this.chkIncludePrevNames.UseVisualStyleBackColor = true;
            // 
            // chkIncludeQnums
            // 
            this.chkIncludeQnums.AutoSize = true;
            this.chkIncludeQnums.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeQnums.Location = new System.Drawing.Point(29, 55);
            this.chkIncludeQnums.Name = "chkIncludeQnums";
            this.chkIncludeQnums.Size = new System.Drawing.Size(112, 20);
            this.chkIncludeQnums.TabIndex = 3;
            this.chkIncludeQnums.Text = "Include Qnums";
            this.chkIncludeQnums.UseVisualStyleBackColor = true;
            // 
            // chkEmptyRow
            // 
            this.chkEmptyRow.AutoSize = true;
            this.chkEmptyRow.Checked = true;
            this.chkEmptyRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmptyRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmptyRow.Location = new System.Drawing.Point(29, 32);
            this.chkEmptyRow.Name = "chkEmptyRow";
            this.chkEmptyRow.Size = new System.Drawing.Size(136, 20);
            this.chkEmptyRow.TabIndex = 2;
            this.chkEmptyRow.Text = "Include Empty Row";
            this.chkEmptyRow.UseVisualStyleBackColor = true;
            // 
            // chkPraccInstructions
            // 
            this.chkPraccInstructions.AutoSize = true;
            this.chkPraccInstructions.Checked = true;
            this.chkPraccInstructions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPraccInstructions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPraccInstructions.Location = new System.Drawing.Point(29, 9);
            this.chkPraccInstructions.Name = "chkPraccInstructions";
            this.chkPraccInstructions.Size = new System.Drawing.Size(173, 20);
            this.chkPraccInstructions.TabIndex = 0;
            this.chkPraccInstructions.Text = "Include Pracc Instructions";
            this.chkPraccInstructions.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(738, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(26, 23);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "X";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Visible = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // PraccingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(222)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(764, 531);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboSurvey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PraccingReportForm";
            this.Text = "PraccingReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PraccingReportForm_FormClosed);
            this.Resize += new System.EventHandler(this.PraccingReportForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSurvey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.Label lblIssueFilters;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstLastUpdateFrom;
        private System.Windows.Forms.ListBox lstLastUpdateTo;
        private System.Windows.Forms.ListBox lstLastUpdateDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.CheckBox chkShadeAlternateRows;
        private System.Windows.Forms.CheckBox chkIncludePrevNames;
        private System.Windows.Forms.CheckBox chkIncludeQnums;
        private System.Windows.Forms.CheckBox chkEmptyRow;
        private System.Windows.Forms.CheckBox chkPraccInstructions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdClose;
    }
}