using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ONT_Project_Semester2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Form7_Load(object sender, EventArgs e)
        {

            txtAgencyID.Enabled = false;

            cmbSuburbID.DataSource = bll.GetSuburb();
            cmbSuburbID.DisplayMember = "SuburbDescription";
            cmbSuburbID.ValueMember = "SuburbID";
            cmbSuburbID.SelectedIndex = -1;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agencies agencies = new Agencies();

            agencies.AgencyName = txtAgencyName.Text;
            agencies.SuburbID = Convert.ToInt32(cmbSuburbID.SelectedValue.ToString());

            int x = bll.InsertAgency(agencies);
            if (x > 0)
            {
                string message = "Agency Added";
                string title = "Agency";
                MessageBox.Show(x + message, title);
            }
        }

        private void btnListAgency_Click(object sender, EventArgs e)
        {
            dgvAgencies.DataSource = bll.GetAgency();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Agencies agencies = new Agencies();
            agencies.AgencyID = int.Parse(txtAgencyID.Text);
            bll.DeleteAgency(agencies);

            string message = " Deleted";
            string title = "Delete";
            MessageBox.Show(message, title);
        }

        private void dgvAgencies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgencies.SelectedRows.Count > 0)
            {

                txtAgencyID.Text = dgvAgencies.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txtAgencyName.Text = dgvAgencies.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmbSuburbID.Text = dgvAgencies.SelectedRows[0].Cells["SuburbID"].Value.ToString();
            }
        }

        private void txtAgencyName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgencyName.Text))
            {
                e.Cancel = true;
                txtAgencyName.Focus();
                errorProvider1.SetError(txtAgencyName, "Agency Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAgencyName, "");
            }

        }

        private void cmbSuburbID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSuburbID.Text))
            {
                e.Cancel = true;
                cmbSuburbID.Focus();
                errorProvider2.SetError(cmbSuburbID, "Suburb ID should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(cmbSuburbID, "");
            }
        }
    }
}
