namespace PraccingMenu
{
    partial class frmPraccingIssuesImport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPraccingIssuesImport));
            this.cboSurvey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdImport = new System.Windows.Forms.Button();
            this.panelResults = new System.Windows.Forms.Panel();
            this.panelNew = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.drNewResponses = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.label19 = new System.Windows.Forms.Label();
            this.cmdMoveResponse = new System.Windows.Forms.Button();
            this.rtbNewResponse = new System.Windows.Forms.RichTextBox();
            this.lblResponseImages = new System.Windows.Forms.Label();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cboNewFrom = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboNewTo = new System.Windows.Forms.ComboBox();
            this.chkKeepResponse = new System.Windows.Forms.CheckBox();
            this.dtpNewTime = new System.Windows.Forms.DateTimePicker();
            this.panelExisting = new System.Windows.Forms.Panel();
            this.drExisting = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOldTo = new System.Windows.Forms.TextBox();
            this.txtOldFrom = new System.Windows.Forms.TextBox();
            this.rtbOldResponse = new System.Windows.Forms.RichTextBox();
            this.dtpOldTime = new System.Windows.Forms.DateTimePicker();
            this.dtpOldDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdMoveIssue = new System.Windows.Forms.Button();
            this.lblIssueImages = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.navIssues = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chkKeepIssue = new System.Windows.Forms.CheckBox();
            this.chkResolved = new System.Windows.Forms.CheckBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.txtVarNames = new System.Windows.Forms.TextBox();
            this.txtIssueNo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboResName = new System.Windows.Forms.ComboBox();
            this.dtpResDate = new System.Windows.Forms.DateTimePicker();
            this.panelResults.SuspendLayout();
            this.panelNew.SuspendLayout();
            this.drNewResponses.ItemTemplate.SuspendLayout();
            this.drNewResponses.SuspendLayout();
            this.panelExisting.SuspendLayout();
            this.drExisting.ItemTemplate.SuspendLayout();
            this.drExisting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navIssues)).BeginInit();
            this.navIssues.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSurvey
            // 
            this.cboSurvey.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSurvey.FormattingEnabled = true;
            this.cboSurvey.Location = new System.Drawing.Point(165, 65);
            this.cboSurvey.Name = "cboSurvey";
            this.cboSurvey.Size = new System.Drawing.Size(121, 24);
            this.cboSurvey.TabIndex = 0;
            this.cboSurvey.SelectedIndexChanged += new System.EventHandler(this.cboSurvey_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Praccing Issues - Import";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Survey";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(165, 95);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(290, 36);
            this.txtPath.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "File";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.Location = new System.Drawing.Point(461, 94);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(75, 36);
            this.cmdBrowse.TabIndex = 15;
            this.cmdBrowse.Text = "Browse...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.Location = new System.Drawing.Point(542, 94);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(75, 36);
            this.cmdLoad.TabIndex = 16;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Visible = false;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdImport
            // 
            this.cmdImport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImport.Location = new System.Drawing.Point(623, 94);
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Size = new System.Drawing.Size(75, 36);
            this.cmdImport.TabIndex = 17;
            this.cmdImport.Text = "Import";
            this.cmdImport.UseVisualStyleBackColor = true;
            this.cmdImport.Visible = false;
            this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.cboResName);
            this.panelResults.Controls.Add(this.dtpResDate);
            this.panelResults.Controls.Add(this.panelNew);
            this.panelResults.Controls.Add(this.panelExisting);
            this.panelResults.Controls.Add(this.cmdMoveIssue);
            this.panelResults.Controls.Add(this.lblIssueImages);
            this.panelResults.Controls.Add(this.rtbDescription);
            this.panelResults.Controls.Add(this.navIssues);
            this.panelResults.Controls.Add(this.chkKeepIssue);
            this.panelResults.Controls.Add(this.chkResolved);
            this.panelResults.Controls.Add(this.txtStatus);
            this.panelResults.Controls.Add(this.label11);
            this.panelResults.Controls.Add(this.label10);
            this.panelResults.Controls.Add(this.label9);
            this.panelResults.Controls.Add(this.label8);
            this.panelResults.Controls.Add(this.label7);
            this.panelResults.Controls.Add(this.dtpIssueDate);
            this.panelResults.Controls.Add(this.cboCategory);
            this.panelResults.Controls.Add(this.cboTo);
            this.panelResults.Controls.Add(this.cboFrom);
            this.panelResults.Controls.Add(this.txtVarNames);
            this.panelResults.Controls.Add(this.txtIssueNo);
            this.panelResults.Location = new System.Drawing.Point(12, 136);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(939, 710);
            this.panelResults.TabIndex = 18;
            this.panelResults.Visible = false;
            // 
            // panelNew
            // 
            this.panelNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNew.Controls.Add(this.label18);
            this.panelNew.Controls.Add(this.drNewResponses);
            this.panelNew.Location = new System.Drawing.Point(11, 395);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(919, 287);
            this.panelNew.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "New Responses";
            // 
            // drNewResponses
            // 
            // 
            // drNewResponses.ItemTemplate
            // 
            this.drNewResponses.ItemTemplate.Controls.Add(this.label19);
            this.drNewResponses.ItemTemplate.Controls.Add(this.cmdMoveResponse);
            this.drNewResponses.ItemTemplate.Controls.Add(this.rtbNewResponse);
            this.drNewResponses.ItemTemplate.Controls.Add(this.lblResponseImages);
            this.drNewResponses.ItemTemplate.Controls.Add(this.dtpNewDate);
            this.drNewResponses.ItemTemplate.Controls.Add(this.label15);
            this.drNewResponses.ItemTemplate.Controls.Add(this.cboNewFrom);
            this.drNewResponses.ItemTemplate.Controls.Add(this.label14);
            this.drNewResponses.ItemTemplate.Controls.Add(this.cboNewTo);
            this.drNewResponses.ItemTemplate.Controls.Add(this.chkKeepResponse);
            this.drNewResponses.ItemTemplate.Controls.Add(this.dtpNewTime);
            this.drNewResponses.ItemTemplate.Size = new System.Drawing.Size(879, 96);
            this.drNewResponses.Location = new System.Drawing.Point(10, 24);
            this.drNewResponses.Name = "drNewResponses";
            this.drNewResponses.Size = new System.Drawing.Size(887, 255);
            this.drNewResponses.TabIndex = 0;
            this.drNewResponses.Text = "dataRepeater1";
            this.drNewResponses.ItemCloned += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.drNewResponses_ItemCloned);
            this.drNewResponses.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.drNewResponses_DrawItem);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "Date";
            // 
            // cmdMoveResponse
            // 
            this.cmdMoveResponse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmdMoveResponse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoveResponse.Location = new System.Drawing.Point(789, 31);
            this.cmdMoveResponse.Name = "cmdMoveResponse";
            this.cmdMoveResponse.Size = new System.Drawing.Size(72, 23);
            this.cmdMoveResponse.TabIndex = 25;
            this.cmdMoveResponse.Text = "Move";
            this.cmdMoveResponse.UseVisualStyleBackColor = false;
            this.cmdMoveResponse.Click += new System.EventHandler(this.cmdMoveResponse_Click);
            // 
            // rtbNewResponse
            // 
            this.rtbNewResponse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNewResponse.Location = new System.Drawing.Point(237, 3);
            this.rtbNewResponse.Name = "rtbNewResponse";
            this.rtbNewResponse.Size = new System.Drawing.Size(546, 82);
            this.rtbNewResponse.TabIndex = 21;
            this.rtbNewResponse.Text = "";
            // 
            // lblResponseImages
            // 
            this.lblResponseImages.AutoSize = true;
            this.lblResponseImages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponseImages.ForeColor = System.Drawing.Color.Red;
            this.lblResponseImages.Location = new System.Drawing.Point(13, 72);
            this.lblResponseImages.Name = "lblResponseImages";
            this.lblResponseImages.Size = new System.Drawing.Size(190, 16);
            this.lblResponseImages.TabIndex = 24;
            this.lblResponseImages.Text = "Images found for this response.";
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpNewDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewDate.Location = new System.Drawing.Point(39, 3);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(95, 23);
            this.dtpNewDate.TabIndex = 4;
            this.dtpNewDate.Value = new System.DateTime(2021, 6, 24, 14, 21, 43, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "To";
            // 
            // cboNewFrom
            // 
            this.cboNewFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNewFrom.FormattingEnabled = true;
            this.cboNewFrom.Location = new System.Drawing.Point(39, 26);
            this.cboNewFrom.Name = "cboNewFrom";
            this.cboNewFrom.Size = new System.Drawing.Size(194, 24);
            this.cboNewFrom.TabIndex = 5;
            this.cboNewFrom.SelectedIndexChanged += new System.EventHandler(this.cboNewFrom_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "From";
            // 
            // cboNewTo
            // 
            this.cboNewTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNewTo.FormattingEnabled = true;
            this.cboNewTo.Location = new System.Drawing.Point(39, 48);
            this.cboNewTo.Name = "cboNewTo";
            this.cboNewTo.Size = new System.Drawing.Size(194, 24);
            this.cboNewTo.TabIndex = 6;
            this.cboNewTo.SelectedIndexChanged += new System.EventHandler(this.cboNewTo_SelectedIndexChanged);
            // 
            // chkKeepResponse
            // 
            this.chkKeepResponse.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKeepResponse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkKeepResponse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeepResponse.Location = new System.Drawing.Point(789, 4);
            this.chkKeepResponse.Name = "chkKeepResponse";
            this.chkKeepResponse.Size = new System.Drawing.Size(72, 23);
            this.chkKeepResponse.TabIndex = 8;
            this.chkKeepResponse.Text = "Keep?";
            this.chkKeepResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkKeepResponse.UseVisualStyleBackColor = false;
            this.chkKeepResponse.CheckedChanged += new System.EventHandler(this.chkKeepResponse_CheckedChanged);
            this.chkKeepResponse.Click += new System.EventHandler(this.chkKeepResponse_Click);
            // 
            // dtpNewTime
            // 
            this.dtpNewTime.CustomFormat = "HH:mm:ss tt";
            this.dtpNewTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNewTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewTime.Location = new System.Drawing.Point(140, 3);
            this.dtpNewTime.Name = "dtpNewTime";
            this.dtpNewTime.Size = new System.Drawing.Size(93, 23);
            this.dtpNewTime.TabIndex = 20;
            // 
            // panelExisting
            // 
            this.panelExisting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExisting.Controls.Add(this.drExisting);
            this.panelExisting.Controls.Add(this.label13);
            this.panelExisting.Location = new System.Drawing.Point(11, 145);
            this.panelExisting.Name = "panelExisting";
            this.panelExisting.Size = new System.Drawing.Size(919, 244);
            this.panelExisting.TabIndex = 23;
            // 
            // drExisting
            // 
            // 
            // drExisting.ItemTemplate
            // 
            this.drExisting.ItemTemplate.Controls.Add(this.label4);
            this.drExisting.ItemTemplate.Controls.Add(this.label12);
            this.drExisting.ItemTemplate.Controls.Add(this.label5);
            this.drExisting.ItemTemplate.Controls.Add(this.txtOldTo);
            this.drExisting.ItemTemplate.Controls.Add(this.txtOldFrom);
            this.drExisting.ItemTemplate.Controls.Add(this.rtbOldResponse);
            this.drExisting.ItemTemplate.Controls.Add(this.dtpOldTime);
            this.drExisting.ItemTemplate.Controls.Add(this.dtpOldDate);
            this.drExisting.ItemTemplate.Size = new System.Drawing.Size(892, 81);
            this.drExisting.Location = new System.Drawing.Point(10, 23);
            this.drExisting.Name = "drExisting";
            this.drExisting.Size = new System.Drawing.Size(900, 216);
            this.drExisting.TabIndex = 22;
            this.drExisting.Text = "dataRepeater1";
            this.drExisting.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.drExisting_DrawItem);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "To";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "From";
            // 
            // txtOldTo
            // 
            this.txtOldTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldTo.Location = new System.Drawing.Point(41, 48);
            this.txtOldTo.Name = "txtOldTo";
            this.txtOldTo.Size = new System.Drawing.Size(198, 23);
            this.txtOldTo.TabIndex = 30;
            // 
            // txtOldFrom
            // 
            this.txtOldFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldFrom.Location = new System.Drawing.Point(41, 26);
            this.txtOldFrom.Name = "txtOldFrom";
            this.txtOldFrom.Size = new System.Drawing.Size(198, 23);
            this.txtOldFrom.TabIndex = 29;
            // 
            // rtbOldResponse
            // 
            this.rtbOldResponse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOldResponse.Location = new System.Drawing.Point(245, 4);
            this.rtbOldResponse.Name = "rtbOldResponse";
            this.rtbOldResponse.Size = new System.Drawing.Size(629, 73);
            this.rtbOldResponse.TabIndex = 28;
            this.rtbOldResponse.Text = "";
            // 
            // dtpOldTime
            // 
            this.dtpOldTime.CustomFormat = "HH:mm:ss tt";
            this.dtpOldTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOldTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOldTime.Location = new System.Drawing.Point(146, 3);
            this.dtpOldTime.Name = "dtpOldTime";
            this.dtpOldTime.Size = new System.Drawing.Size(93, 23);
            this.dtpOldTime.TabIndex = 27;
            // 
            // dtpOldDate
            // 
            this.dtpOldDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpOldDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOldDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOldDate.Location = new System.Drawing.Point(41, 3);
            this.dtpOldDate.Name = "dtpOldDate";
            this.dtpOldDate.Size = new System.Drawing.Size(99, 23);
            this.dtpOldDate.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Existing Responses";
            // 
            // cmdMoveIssue
            // 
            this.cmdMoveIssue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoveIssue.Location = new System.Drawing.Point(865, 28);
            this.cmdMoveIssue.Name = "cmdMoveIssue";
            this.cmdMoveIssue.Size = new System.Drawing.Size(71, 23);
            this.cmdMoveIssue.TabIndex = 21;
            this.cmdMoveIssue.Text = "Move";
            this.cmdMoveIssue.UseVisualStyleBackColor = true;
            this.cmdMoveIssue.Click += new System.EventHandler(this.cmdMoveIssue_Click);
            // 
            // lblIssueImages
            // 
            this.lblIssueImages.AutoSize = true;
            this.lblIssueImages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueImages.ForeColor = System.Drawing.Color.Red;
            this.lblIssueImages.Location = new System.Drawing.Point(332, 15);
            this.lblIssueImages.Name = "lblIssueImages";
            this.lblIssueImages.Size = new System.Drawing.Size(167, 16);
            this.lblIssueImages.TabIndex = 20;
            this.lblIssueImages.Text = "Images found for this issue.";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(206, 37);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(639, 102);
            this.rtbDescription.TabIndex = 19;
            this.rtbDescription.Text = "";
            // 
            // navIssues
            // 
            this.navIssues.AddNewItem = null;
            this.navIssues.CountItem = this.bindingNavigatorCountItem;
            this.navIssues.DeleteItem = null;
            this.navIssues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navIssues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.navIssues.Location = new System.Drawing.Point(0, 685);
            this.navIssues.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navIssues.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navIssues.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navIssues.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navIssues.Name = "navIssues";
            this.navIssues.PositionItem = this.bindingNavigatorPositionItem;
            this.navIssues.Size = new System.Drawing.Size(939, 25);
            this.navIssues.TabIndex = 18;
            this.navIssues.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // chkKeepIssue
            // 
            this.chkKeepIssue.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKeepIssue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeepIssue.Location = new System.Drawing.Point(865, 3);
            this.chkKeepIssue.Name = "chkKeepIssue";
            this.chkKeepIssue.Size = new System.Drawing.Size(71, 23);
            this.chkKeepIssue.TabIndex = 15;
            this.chkKeepIssue.Text = "Keep?";
            this.chkKeepIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkKeepIssue.UseVisualStyleBackColor = true;
            this.chkKeepIssue.CheckedChanged += new System.EventHandler(this.chkKeepIssue_CheckedChanged);
            // 
            // chkResolved
            // 
            this.chkResolved.AutoSize = true;
            this.chkResolved.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResolved.Location = new System.Drawing.Point(851, 69);
            this.chkResolved.Name = "chkResolved";
            this.chkResolved.Size = new System.Drawing.Size(78, 20);
            this.chkResolved.TabIndex = 14;
            this.chkResolved.Text = "Resolved";
            this.chkResolved.UseVisualStyleBackColor = true;
            this.chkResolved.CheckedChanged += new System.EventHandler(this.chkResolved_CheckedChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(754, 12);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(91, 23);
            this.txtStatus.TabIndex = 13;
            this.txtStatus.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "VarNames";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Issue No";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(206, 12);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(105, 23);
            this.dtpIssueDate.TabIndex = 6;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(73, 118);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 24);
            this.cboCategory.TabIndex = 5;
            // 
            // cboTo
            // 
            this.cboTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(73, 91);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(121, 24);
            this.cboTo.TabIndex = 4;
            // 
            // cboFrom
            // 
            this.cboFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(73, 64);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(121, 24);
            this.cboFrom.TabIndex = 3;
            // 
            // txtVarNames
            // 
            this.txtVarNames.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarNames.Location = new System.Drawing.Point(73, 38);
            this.txtVarNames.Name = "txtVarNames";
            this.txtVarNames.Size = new System.Drawing.Size(121, 23);
            this.txtVarNames.TabIndex = 1;
            // 
            // txtIssueNo
            // 
            this.txtIssueNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueNo.Location = new System.Drawing.Point(73, 12);
            this.txtIssueNo.Name = "txtIssueNo";
            this.txtIssueNo.Size = new System.Drawing.Size(121, 23);
            this.txtIssueNo.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Move";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(222, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Images found for this response.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 121);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(394, -38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 23);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Keep?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(46, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 21);
            this.comboBox2.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(13, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 26;
            this.dateTimePicker2.Value = new System.DateTime(2021, 6, 24, 14, 21, 43, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 19;
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
            // cboResName
            // 
            this.cboResName.FormattingEnabled = true;
            this.cboResName.Location = new System.Drawing.Point(851, 118);
            this.cboResName.Name = "cboResName";
            this.cboResName.Size = new System.Drawing.Size(85, 21);
            this.cboResName.TabIndex = 20;
            // 
            // dtpResDate
            // 
            this.dtpResDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResDate.Location = new System.Drawing.Point(851, 95);
            this.dtpResDate.Name = "dtpResDate";
            this.dtpResDate.Size = new System.Drawing.Size(85, 20);
            this.dtpResDate.TabIndex = 21;
            // 
            // frmPraccingIssuesImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(222)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(986, 869);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.cmdImport);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSurvey);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPraccingIssuesImport";
            this.Text = "Praccing Issues - Import";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.drNewResponses.ItemTemplate.ResumeLayout(false);
            this.drNewResponses.ItemTemplate.PerformLayout();
            this.drNewResponses.ResumeLayout(false);
            this.panelExisting.ResumeLayout(false);
            this.panelExisting.PerformLayout();
            this.drExisting.ItemTemplate.ResumeLayout(false);
            this.drExisting.ItemTemplate.PerformLayout();
            this.drExisting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navIssues)).EndInit();
            this.navIssues.ResumeLayout(false);
            this.navIssues.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSurvey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdImport;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.BindingNavigator navIssues;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.CheckBox chkKeepIssue;
        private System.Windows.Forms.CheckBox chkResolved;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.TextBox txtVarNames;
        private System.Windows.Forms.TextBox txtIssueNo;
        private System.Windows.Forms.ComboBox cboNewTo;
        private System.Windows.Forms.ComboBox cboNewFrom;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.CheckBox chkKeepResponse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpNewTime;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.RichTextBox rtbNewResponse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIssueImages;
        private System.Windows.Forms.Label lblResponseImages;
        private System.Windows.Forms.Button cmdMoveIssue;
        private System.Windows.Forms.Button cmdMoveResponse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater drExisting;
        private System.Windows.Forms.Panel panelNew;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater drNewResponses;
        private System.Windows.Forms.Panel panelExisting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbOldResponse;
        private System.Windows.Forms.DateTimePicker dtpOldTime;
        private System.Windows.Forms.DateTimePicker dtpOldDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOldTo;
        private System.Windows.Forms.TextBox txtOldFrom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboResName;
        private System.Windows.Forms.DateTimePicker dtpResDate;
    }
}

