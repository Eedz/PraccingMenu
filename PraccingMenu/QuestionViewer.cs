using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITCLib;


namespace PraccingMenu
{
    public partial class QuestionViewer : Form
    {

        List<SurveyQuestion> Questions;

        BindingSource bsQuestions;
        BindingSource bsTranslations;
        BindingSource bsComments;

        public QuestionViewer(List<SurveyQuestion> questions)
        {
            InitializeComponent();

            Questions = questions;

            bsQuestions = new BindingSource();
            bsQuestions.DataSource = Questions;

            bsTranslations = new BindingSource();
            bsTranslations.DataSource = Questions;
            bsTranslations.DataMember = "Translations";

            bsComments = new BindingSource();
            bsComments.DataSource = Questions;
            bsComments.DataMember = "Comments";




            drQuestion.DataSource = bsQuestions;
            drTranslations.DataSource = bsTranslations;
            drComments.DataSource = bsComments;
            

           

            //rtbQuestion.DataBindings.Add(new Binding("Rtf", Questions, "Question"))

            // questions
            txtSurvey.DataBindings.Add(new Binding("Text", bsQuestions, "SurveyCode"));
            
            txtQnum.DataBindings.Add(new Binding("Text", bsQuestions, "Qnum"));

           


            // translations

            //txtLanguage.DataBindings.Add(new Binding("Text", bsTranslations, "Language"));
           // rtbTranslation.DataBindings.Add(new Binding("Rtf", bsTranslations, "TranslationRTF"));

            // comments
            txtNoteType.DataBindings.Add(new Binding("Text", bsComments, "NoteType"));
            //dtpNoteDate.DataBindings.Add(new Binding("Value", bsComments, "NoteDate", true));
            //txtComment.DataBindings.Add(new Binding("Text", bsComments, "Notes.NoteText"));



        }

        #region DataRepeater Bullshit

        private void dataRepeater1_ItemCloned(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            //var varBox = (ComboBox)e.DataRepeaterItem.Controls.Find("txtVarName", false)[0];
            ////Set the data source
           

            //var combo2 = (ComboBox)e.DataRepeaterItem.Controls.Find("cboResponseTo", false)[0];
            ////Set the data source
            //combo2.DisplayMember = "Name";
            //combo2.ValueMember = "ID";
            //combo2.DataSource = new List<Person>(PeopleList);
        }

        /// <summary>
        /// After Item is cloned, draw item. The index is now available to select the proper data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataRepeater1_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)sender;
            var datasource = (List<SurveyQuestion>)((BindingSource)dataRepeater.DataSource).DataSource;

            var varBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtVarName", false)[0];
            varBox.Text = datasource[e.DataRepeaterItem.ItemIndex].VarName.VarName;

            var varLabelBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtVarLabel", false)[0];
            varLabelBox.Text = datasource[e.DataRepeaterItem.ItemIndex].VarName.VarLabel;

            var contentBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtContent", false)[0];
            contentBox.Text = datasource[e.DataRepeaterItem.ItemIndex].VarName.Content.LabelText;

            var topicBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtTopic", false)[0];
            topicBox.Text = datasource[e.DataRepeaterItem.ItemIndex].VarName.Topic.LabelText;

            var domainBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtDomain", false)[0];
            domainBox.Text = datasource[e.DataRepeaterItem.ItemIndex].VarName.Domain.LabelText;

            var productBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtProduct", false)[0];
            productBox.Text = datasource[e.DataRepeaterItem.ItemIndex].VarName.Product.LabelText;

            var questionBox = (RichTextBox)e.DataRepeaterItem.Controls.Find("rtbQuestion", false)[0];
            questionBox.Rtf = datasource[e.DataRepeaterItem.ItemIndex].GetQuestionTextRich();

            


            
        }



        #endregion

        private void drTranslations_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)sender;
            var questionDataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)dataRepeater.Parent.Parent;
            var questionDataSource = ((BindingSource)questionDataRepeater.DataSource);
            var datasource = ((BindingSource)dataRepeater.DataSource);
            var currentQuestion = ((Translation)datasource[e.DataRepeaterItem.ItemIndex]);

            var translationBox = (RichTextBox)e.DataRepeaterItem.Controls.Find("rtbTranslation", false)[0];
            translationBox.Rtf = currentQuestion.TranslationRTF;

            var langBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtLanguage", false)[0];
            langBox.Text = currentQuestion.Language;

            var prepBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtPreP", false)[0];
            prepBox.Text = ((SurveyQuestion)questionDataSource.Current).PreP;

            var pstpBox = (TextBox)e.DataRepeaterItem.Controls.Find("txtPstP", false)[0];
            pstpBox.Text = ((SurveyQuestion)questionDataSource.Current).PstP;
        }

        private void drComments_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            var dataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)sender;
            var questionDataRepeater = (Microsoft.VisualBasic.PowerPacks.DataRepeater)dataRepeater.Parent.Parent;
            var datasource = ((BindingSource)dataRepeater.DataSource);
            var currentQuestion = ((QuestionComment)datasource[e.DataRepeaterItem.ItemIndex]);
            
            var noteType = (TextBox)e.DataRepeaterItem.Controls.Find("txtNoteType", false)[0];
            noteType.Text = currentQuestion.NoteType.TypeName; 

            var noteDate = (DateTimePicker)e.DataRepeaterItem.Controls.Find("dtpNoteDate", false)[0];
            noteDate.Value = currentQuestion.NoteDate.Value;

            var noteName = (TextBox)e.DataRepeaterItem.Controls.Find("txtNoteName", false)[0];
            noteName.Text = currentQuestion.Author.Name;

            var noteText = (TextBox)e.DataRepeaterItem.Controls.Find("txtComment", false)[0];
            noteText.Text = currentQuestion.Notes.NoteText;

            var noteSource = (TextBox)e.DataRepeaterItem.Controls.Find("txtNoteSource", false)[0];
            noteSource.Text = currentQuestion.Source;

            var noteSourceName = (TextBox)e.DataRepeaterItem.Controls.Find("txtNoteSourceName", false)[0];
            noteSourceName.Text = currentQuestion.SourceName;
        }
    }
}
