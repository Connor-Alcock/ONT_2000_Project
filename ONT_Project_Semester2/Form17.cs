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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btnRegister_Click(object sender, EventArgs e)
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

        private void Form17_Load(object sender, EventArgs e)
        {

            txtTenantID.Enabled = false;
            cmbStatus.Items.Add("Working");
            cmbStatus.Items.Add("Unemployeed");
            cmbStatus.Items.Add("Retired");
            cmbStatus.Items.Add("Self Employeed");
            cmbStatus.Items.Add("Student");

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenantID_Validated(object sender, EventArgs e)
        {

        }

        private void txtTenantID_Validating(object sender, CancelEventArgs e)
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

        private void txtSurname_Validated(object sender, EventArgs e)
        {

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
