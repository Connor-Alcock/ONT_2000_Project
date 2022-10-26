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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void cmbTenantID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rentals rentals = new Rentals();

            rentals.PropertyAgentID = Convert.ToInt32(cmbPropertyAgentID.SelectedValue.ToString());
            rentals.TenantID = Convert.ToInt32(cmbTenatID.SelectedValue.ToString());
            rentals.StartDate = StartDate.Value;
            rentals.EndDate = EndDate.Value;

            int x = bll.InsertRental(rentals);
            if (x > 0)
            {
                string message = " Rentals Added";
                string title = "Rentals";
                MessageBox.Show(x + message, title);
            }

        }

        private void Form11_Load(object sender, EventArgs e)
        {

            txtRenatalID.Enabled = false;

            cmbPropertyAgentID.DataSource = bll.GetPropertyAgent();
            cmbPropertyAgentID.DisplayMember = "AgentID";
            cmbPropertyAgentID.ValueMember = "PropertyAgentID";

            cmbTenatID.DataSource = bll.GetTenant();
            cmbTenatID.DisplayMember = "Name";
            cmbTenatID.ValueMember = "TenantID";


        }

        private void btnListRentals_Click(object sender, EventArgs e)
        {
            dgvRentals.DataSource = bll.GetRental();
        }

        private void dgvRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRentals.SelectedRows.Count > 0)
            {

                txtRenatalID.Text = dgvRentals.SelectedRows[0].Cells["RentalID"].Value.ToString();
                cmbPropertyAgentID.Text = dgvRentals.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbTenatID.Text = dgvRentals.SelectedRows[0].Cells["TenantID"].Value.ToString();
                StartDate.Text = dgvRentals.SelectedRows[0].Cells["StartDate"].Value.ToString();
                EndDate.Text = dgvRentals.SelectedRows[0].Cells["EndDate"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rentals rentals = new Rentals();

            rentals.StartDate = StartDate.Value;
            rentals.EndDate = EndDate.Value;
            rentals.RentalID = int.Parse(txtRenatalID.Text);


            int l = bll.UpdateRental(rentals);

            string message = " Updated";
            string title = "Updated";
            MessageBox.Show(message, title);
        }

        private void cmbPropertyAgentID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPropertyAgentID.Text))
            {
                e.Cancel = true;
                cmbPropertyAgentID.Focus();
                errorProvider1.SetError(cmbPropertyAgentID, "Property Agent ID should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbPropertyAgentID, "");
            }
        }

        private void cmbTenatID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTenatID.Text))
            {
                e.Cancel = true;
                cmbTenatID.Focus();
                errorProvider2.SetError(cmbTenatID, "Tenant ID should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(cmbTenatID, "");
            }
        }
    }   
}
