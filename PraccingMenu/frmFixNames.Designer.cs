namespace PraccingMenu
{
    partial class frmFixNames
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDone = new System.Windows.Forms.Button();
            this.dgvNames = new System.Windows.Forms.DataGridView();
            this.chInvalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chValid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNames)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a valid name in the New Name column.";
            // 
            // cmdDone
            // 
            this.cmdDone.Location = new System.Drawing.Point(164, 225);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 4;
            this.cmdDone.Text = "Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // dgvNames
            // 
            this.dgvNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chInvalid,
            this.chValid});
            this.dgvNames.Location = new System.Drawing.Point(1, 24);
            this.dgvNames.Name = "dgvNames";
            this.dgvNames.RowHeadersVisible = false;
            this.dgvNames.Size = new System.Drawing.Size(238, 195);
            this.dgvNames.TabIndex = 3;
            // 
            // chInvalid
            // 
            this.chInvalid.HeaderText = "Invalid";
            this.chInvalid.Name = "chInvalid";
            // 
            // chValid
            // 
            this.chValid.HeaderText = "Valid";
            this.chValid.Name = "chValid";
            // 
            // frmFixNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDone);
            this.Controls.Add(this.dgvNames);
            this.Name = "frmFixNames";
            this.Text = "Fix Names";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDone;
        private System.Windows.Forms.DataGridView dgvNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn chInvalid;
        private System.Windows.Forms.DataGridViewComboBoxColumn chValid;
    }
}