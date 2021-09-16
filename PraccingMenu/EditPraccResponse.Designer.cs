namespace PraccingMenu
{
    partial class EditPraccResponse
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
            this.dtpResponseDate = new System.Windows.Forms.DateTimePicker();
            this.dtpResponseTime = new System.Windows.Forms.DateTimePicker();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpResponseDate
            // 
            this.dtpResponseDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResponseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResponseDate.Location = new System.Drawing.Point(49, 12);
            this.dtpResponseDate.Name = "dtpResponseDate";
            this.dtpResponseDate.Size = new System.Drawing.Size(97, 23);
            this.dtpResponseDate.TabIndex = 0;
            // 
            // dtpResponseTime
            // 
            this.dtpResponseTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResponseTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpResponseTime.Location = new System.Drawing.Point(49, 38);
            this.dtpResponseTime.Name = "dtpResponseTime";
            this.dtpResponseTime.Size = new System.Drawing.Size(97, 23);
            this.dtpResponseTime.TabIndex = 1;
            // 
            // rtbResponse
            // 
            this.rtbResponse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResponse.Location = new System.Drawing.Point(152, 12);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(320, 96);
            this.rtbResponse.TabIndex = 2;
            this.rtbResponse.Text = "";
            // 
            // cboFrom
            // 
            this.cboFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(522, 12);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(65, 24);
            this.cboFrom.TabIndex = 3;
            // 
            // cboTo
            // 
            this.cboTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(522, 39);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(65, 24);
            this.cboTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "To";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(423, 120);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 9;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(504, 120);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // EditPraccResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 151);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTo);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.dtpResponseTime);
            this.Controls.Add(this.dtpResponseDate);
            this.Name = "EditPraccResponse";
            this.Text = "EditPraccResponse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpResponseDate;
        private System.Windows.Forms.DateTimePicker dtpResponseTime;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
    }
}