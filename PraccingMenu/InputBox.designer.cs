namespace PraccingMenu
{
    partial class InputBox
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmCancel = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(14, 81);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(307, 20);
            this.txtInput.TabIndex = 0;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(271, 9);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(50, 22);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmCancel
            // 
            this.cmCancel.Location = new System.Drawing.Point(271, 37);
            this.cmCancel.Name = "cmCancel";
            this.cmCancel.Size = new System.Drawing.Size(50, 23);
            this.cmCancel.TabIndex = 2;
            this.cmCancel.Text = "Cancel";
            this.cmCancel.UseVisualStyleBackColor = true;
            this.cmCancel.Click += new System.EventHandler(this.cmCancel_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(11, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(55, 13);
            this.lblPrompt.TabIndex = 3;
            this.lblPrompt.Text = "Enter text:";
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 110);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.cmCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtInput);
            this.Name = "InputBox";
            this.Text = "Enter text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmCancel;
        private System.Windows.Forms.Label lblPrompt;
    }
}