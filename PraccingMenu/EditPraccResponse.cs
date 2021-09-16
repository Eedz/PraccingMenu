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
    public partial class EditPraccResponse : Form
    {
        public PraccingResponse ToEdit;
        BindingSource bsResponses;

        public EditPraccResponse(PraccingResponse response)
        {
            InitializeComponent();

            ToEdit = new PraccingResponse();
            ToEdit.ID = response.ID;
            ToEdit.IssueID = response.IssueID;
            ToEdit.Response = string.Copy(response.Response);
            ToEdit.ResponseFrom = new Person(string.Copy(response.ResponseFrom.Name), response.ResponseFrom.ID);
            ToEdit.ResponseTo = new Person(string.Copy(response.ResponseTo.Name), response.ResponseTo.ID);
            ToEdit.ResponseDate = response.ResponseDate;

            List<Person> peopleList = DBAction.GetPeople();

            cboFrom.DisplayMember = "Name";
            cboFrom.ValueMember = "ID";
            cboFrom.DataSource = new List<Person>(peopleList);

            cboTo.DisplayMember = "Name";
            cboTo.ValueMember = "ID";
            cboTo.DataSource = new List<Person>(peopleList);

            bsResponses = new BindingSource();
            bsResponses.DataSource = ToEdit;

            BindProperties();
        }

        private void BindControl(System.Windows.Forms.Control ctl, string prop, object datasource, string dataMember, bool formatting = false)
        {
            ctl.DataBindings.Clear();
            ctl.DataBindings.Add(prop, datasource, dataMember, formatting);
        }

        private void BindProperties()
        {
            

            // responses
            BindControl(rtbResponse, "Rtf", bsResponses, "ResponseRTF");
            BindControl(dtpResponseDate, "Value", bsResponses, "ResponseDate");
            BindControl(dtpResponseTime, "Value", bsResponses, "ResponseDate");
            BindControl(cboFrom, "SelectedItem", bsResponses, "ResponseFrom");
            BindControl(cboTo, "SelectedItem", bsResponses, "ResponseTo");

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
