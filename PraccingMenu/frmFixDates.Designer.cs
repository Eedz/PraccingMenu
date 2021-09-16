namespace PraccingMenu
{
    partial class frmFixDates
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
            this.dgvDates = new System.Windows.Forms.DataGridView();
            this.cmdDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDates
            // 
            this.dgvDates.AllowUserToAddRows = false;
            this.dgvDates.AllowUserToDeleteRows = false;
            this.dgvDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDates.Location = new System.Drawing.Point(0, 26);
            this.dgvDates.Name = "dgvDates";
            this.dgvDates.RowHeadersVisible = false;
            this.dgvDates.Size = new System.Drawing.Size(238, 195);
            this.dgvDates.TabIndex = 0;
            // 
            // cmdDone
            // 
            this.cmdDone.Location = new System.Drawing.Point(163, 227);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 1;
            this.cmdDone.Text = "Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a valid date format (dd-Mmm-yyyy)";
            // 
            // frmFixDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDone);
            this.Controls.Add(this.dgvDates);
            this.Name = "frmFixDates";
            this.Text = "Fix Dates";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDates;
        private System.Windows.Forms.Button cmdDone;
        private System.Windows.Forms.Label label1;
    }
}