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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();

            tenant.TenantName = txtName.Text;
            tenant.TenantSurname = txtSurname.Text;
            tenant.TenantEmail = txtEmail.Text;
            tenant.TenantPassword = txtPassword.Text;
            tenant.TenantPhone = int.Parse(txtPhone.Text);
            tenant.TenantStatus = cmbStatus.SelectedItem.ToString();

            int x = bll.InsertTenant(tenant);
            if (x > 0)
            {
                string message = " Added Tenant.";
                string title = "Tenant";
                MessageBox.Show(x + message, title);

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

            txtTenantID.Enabled = false;
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");

        }

        private void btnListTenant_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.GetTenant();
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            //if (e.MouseEventArgs.Button == System.Windows.Forms.MouseButtons.Right)
            {

                txtTenantID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();

            tenant.TenantEmail = txtEmail.Text;
            tenant.TenantPhone = int.Parse(txtPhone.Text);
            tenant.TenantStatus = cmbStatus.SelectedItem.ToString();
            tenant.TenantID = int.Parse(txtTenantID.Text);

            int l = bll.UpdateTenant(tenant);

            string message = " Updated";
            string title = "Updated";
            MessageBox.Show(message, title);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();

            tenant.TenantID = int.Parse(txtTenantID.Text);

            int r = bll.DeleteTenant(tenant);

            string message = " Deleted";
            string title = "Delete";
            MessageBox.Show(message, title);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Tenant Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                e.Cancel = true;
               txtSurname.Focus();
                errorProvider2.SetError(txtSurname, "Tenant Surname should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtSurname, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider3.SetError(txtEmail, "Tenant Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtEmail, "");
            }
        }

        private void txtPassword_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider4.SetError(txtPassword, "Tenant Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtPassword, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider5.SetError(txtPhone, "Tenant Phone should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(txtPhone, "");
            }
        }

        private void cmbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                e.Cancel = true;
                cmbStatus.Focus();
                errorProvider6.SetError(cmbStatus, "Staus should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider6.SetError(cmbStatus, "");
            }
        }
    }
}
