namespace PraccingMenu
{
    partial class QuestionViewer
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
            this.drQuestion = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drComments = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.txtNoteSourceName = new System.Windows.Forms.TextBox();
            this.txtNoteSource = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtNoteName = new System.Windows.Forms.TextBox();
            this.dtpNoteDate = new System.Windows.Forms.DateTimePicker();
            this.txtNoteType = new System.Windows.Forms.TextBox();
            this.drTranslations = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.txtPstP = new System.Windows.Forms.TextBox();
            this.txtPreP = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.rtbTranslation = new System.Windows.Forms.RichTextBox();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtVarLabel = new System.Windows.Forms.TextBox();
            this.txtQnum = new System.Windows.Forms.TextBox();
            this.txtVarName = new System.Windows.Forms.TextBox();
            this.txtSurvey = new System.Windows.Forms.TextBox();
            this.drQuestion.ItemTemplate.SuspendLayout();
            this.drQuestion.SuspendLayout();
            this.drComments.ItemTemplate.SuspendLayout();
            this.drComments.SuspendLayout();
            this.drTranslations.ItemTemplate.SuspendLayout();
            this.drTranslations.SuspendLayout();
            this.SuspendLayout();
            // 
            // drQuestion
            // 
            // 
            // drQuestion.ItemTemplate
            // 
            this.drQuestion.ItemTemplate.Controls.Add(this.label5);
            this.drQuestion.ItemTemplate.Controls.Add(this.label4);
            this.drQuestion.ItemTemplate.Controls.Add(this.label3);
            this.drQuestion.ItemTemplate.Controls.Add(this.label2);
            this.drQuestion.ItemTemplate.Controls.Add(this.label1);
            this.drQuestion.ItemTemplate.Controls.Add(this.drComments);
            this.drQuestion.ItemTemplate.Controls.Add(this.drTranslations);
            this.drQuestion.ItemTemplate.Controls.Add(this.rtbQuestion);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtProduct);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtDomain);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtTopic);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtContent);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtVarLabel);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtQnum);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtVarName);
            this.drQuestion.ItemTemplate.Controls.Add(this.txtSurvey);
            this.drQuestion.ItemTemplate.Size = new System.Drawing.Size(1105, 539);
            this.drQuestion.Location = new System.Drawing.Point(16, 21);
            this.drQuestion.Name = "drQuestion";
            this.drQuestion.Size = new System.Drawing.Size(1130, 543);
            this.drQuestion.TabIndex = 0;
            this.drQuestion.Text = "drQuestion";
            this.drQuestion.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.dataRepeater1_DrawItem);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Domain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "VarLabel";
            // 
            // drComments
            // 
            // 
            // drComments.ItemTemplate
            // 
            this.drComments.ItemTemplate.Controls.Add(this.txtNoteSourceName);
            this.drComments.ItemTemplate.Controls.Add(this.txtNoteSource);
            this.drComments.ItemTemplate.Controls.Add(this.txtComment);
            this.drComments.ItemTemplate.Controls.Add(this.txtNoteName);
            this.drComments.ItemTemplate.Controls.Add(this.dtpNoteDate);
            this.drComments.ItemTemplate.Controls.Add(this.txtNoteType);
            this.drComments.ItemTemplate.Size = new System.Drawing.Size(357, 225);
            this.drComments.Location = new System.Drawing.Point(722, 19);
            this.drComments.Name = "drComments";
            this.drComments.Size = new System.Drawing.Size(365, 516);
            this.drComments.TabIndex = 10;
            this.drComments.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.drComments_DrawItem);
            // 
            // txtNoteSourceName
            // 
            this.txtNoteSourceName.Location = new System.Drawing.Point(14, 199);
            this.txtNoteSourceName.Name = "txtNoteSourceName";
            this.txtNoteSourceName.Size = new System.Drawing.Size(320, 20);
            this.txtNoteSourceName.TabIndex = 5;
            // 
            // txtNoteSource
            // 
            this.txtNoteSource.Location = new System.Drawing.Point(14, 173);
            this.txtNoteSource.Name = "txtNoteSource";
            this.txtNoteSource.Size = new System.Drawing.Size(320, 20);
            this.txtNoteSource.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(14, 44);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(320, 123);
            this.txtComment.TabIndex = 3;
            // 
            // txtNoteName
            // 
            this.txtNoteName.Location = new System.Drawing.Point(234, 9);
            this.txtNoteName.Name = "txtNoteName";
            this.txtNoteName.Size = new System.Drawing.Size(100, 20);
            this.txtNoteName.TabIndex = 2;
            // 
            // dtpNoteDate
            // 
            this.dtpNoteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNoteDate.Location = new System.Drawing.Point(120, 9);
            this.dtpNoteDate.Name = "dtpNoteDate";
            this.dtpNoteDate.Size = new System.Drawing.Size(108, 20);
            this.dtpNoteDate.TabIndex = 1;
            // 
            // txtNoteType
            // 
            this.txtNoteType.Location = new System.Drawing.Point(14, 9);
            this.txtNoteType.Name = "txtNoteType";
            this.txtNoteType.Size = new System.Drawing.Size(100, 20);
            this.txtNoteType.TabIndex = 0;
            // 
            // drTranslations
            // 
            // 
            // drTranslations.ItemTemplate
            // 
            this.drTranslations.ItemTemplate.Controls.Add(this.txtPstP);
            this.drTranslations.ItemTemplate.Controls.Add(this.txtPreP);
            this.drTranslations.ItemTemplate.Controls.Add(this.txtLanguage);
            this.drTranslations.ItemTemplate.Controls.Add(this.rtbTranslation);
            this.drTranslations.ItemTemplate.Size = new System.Drawing.Size(374, 331);
            this.drTranslations.Location = new System.Drawing.Point(334, 19);
            this.drTranslations.Name = "drTranslations";
            this.drTranslations.Size = new System.Drawing.Size(382, 514);
            this.drTranslations.TabIndex = 9;
            this.drTranslations.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.drTranslations_DrawItem);
            // 
            // txtPstP
            // 
            this.txtPstP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPstP.Location = new System.Drawing.Point(3, 276);
            this.txtPstP.Multiline = true;
            this.txtPstP.Name = "txtPstP";
            this.txtPstP.Size = new System.Drawing.Size(347, 45);
            this.txtPstP.TabIndex = 3;
            // 
            // txtPreP
            // 
            this.txtPreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreP.Location = new System.Drawing.Point(3, 29);
            this.txtPreP.Multiline = true;
            this.txtPreP.Name = "txtPreP";
            this.txtPreP.Size = new System.Drawing.Size(347, 45);
            this.txtPreP.TabIndex = 2;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(3, 3);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(347, 20);
            this.txtLanguage.TabIndex = 1;
            // 
            // rtbTranslation
            // 
            this.rtbTranslation.Location = new System.Drawing.Point(3, 80);
            this.rtbTranslation.Name = "rtbTranslation";
            this.rtbTranslation.Size = new System.Drawing.Size(347, 190);
            this.rtbTranslation.TabIndex = 0;
            this.rtbTranslation.Text = "";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuestion.Location = new System.Drawing.Point(23, 172);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(305, 363);
            this.rtbQuestion.TabIndex = 8;
            this.rtbQuestion.Text = "";
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(74, 146);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(254, 23);
            this.txtProduct.TabIndex = 7;
            // 
            // txtDomain
            // 
            this.txtDomain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.Location = new System.Drawing.Point(74, 120);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(254, 23);
            this.txtDomain.TabIndex = 6;
            // 
            // txtTopic
            // 
            this.txtTopic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopic.Location = new System.Drawing.Point(74, 94);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(254, 23);
            this.txtTopic.TabIndex = 5;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(74, 68);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(254, 23);
            this.txtContent.TabIndex = 4;
            // 
            // txtVarLabel
            // 
            this.txtVarLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarLabel.Location = new System.Drawing.Point(74, 42);
            this.txtVarLabel.Name = "txtVarLabel";
            this.txtVarLabel.Size = new System.Drawing.Size(254, 23);
            this.txtVarLabel.TabIndex = 3;
            // 
            // txtQnum
            // 
            this.txtQnum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQnum.Location = new System.Drawing.Point(228, 17);
            this.txtQnum.Name = "txtQnum";
            this.txtQnum.Size = new System.Drawing.Size(100, 23);
            this.txtQnum.TabIndex = 2;
            // 
            // txtVarName
            // 
            this.txtVarName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarName.Location = new System.Drawing.Point(122, 17);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.Size = new System.Drawing.Size(100, 23);
            this.txtVarName.TabIndex = 1;
            // 
            // txtSurvey
            // 
            this.txtSurvey.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurvey.Location = new System.Drawing.Point(16, 17);
            this.txtSurvey.Name = "txtSurvey";
            this.txtSurvey.Size = new System.Drawing.Size(100, 23);
            this.txtSurvey.TabIndex = 0;
            // 
            // QuestionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 576);
            this.Controls.Add(this.drQuestion);
            this.Name = "QuestionViewer";
            this.Text = "Question Viewer";
            this.drQuestion.ItemTemplate.ResumeLayout(false);
            this.drQuestion.ItemTemplate.PerformLayout();
            this.drQuestion.ResumeLayout(false);
            this.drComments.ItemTemplate.ResumeLayout(false);
            this.drComments.ItemTemplate.PerformLayout();
            this.drComments.ResumeLayout(false);
            this.drTranslations.ItemTemplate.ResumeLayout(false);
            this.drTranslations.ItemTemplate.PerformLayout();
            this.drTranslations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.DataRepeater drQuestion;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater drComments;
        private System.Windows.Forms.TextBox txtNoteSourceName;
        private System.Windows.Forms.TextBox txtNoteSource;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtNoteName;
        private System.Windows.Forms.DateTimePicker dtpNoteDate;
        private System.Windows.Forms.TextBox txtNoteType;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater drTranslations;
        private System.Windows.Forms.TextBox txtPstP;
        private System.Windows.Forms.TextBox txtPreP;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.RichTextBox rtbTranslation;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtVarLabel;
        private System.Windows.Forms.TextBox txtQnum;
        private System.Windows.Forms.TextBox txtVarName;
        private System.Windows.Forms.TextBox txtSurvey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}