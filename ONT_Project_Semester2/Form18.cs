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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        static int LogID = HomePage.LoginID;

        private void Form18_Load(object sender, EventArgs e)
        {
            txtTenantID.Enabled = false;
            cmbStatus.Items.Add("Working");
            cmbStatus.Items.Add("Unemployeed");
            cmbStatus.Items.Add("Retired");
            cmbStatus.Items.Add("Self Employeed");
            cmbStatus.Items.Add("Student");

            DataTable dt = new DataTable();

            dt= bll.getLoggedTenant(LogID);

            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtSurname.Text = dt.Rows[0]["Surname"].ToString();
            txtTenantID.Text = dt.Rows[0]["TenantID"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();



        }

        private void dgvTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();

            tenant.TenantEmail = txtEmail.Text;
            tenant.TenantPassword = txtPassword.Text;
            tenant.TenantPhone = int.Parse(txtPhone.Text);
            tenant.TenantStatus = cmbStatus.SelectedItem.ToString();
            tenant.TenantID = int.Parse(txtTenantID.Text);

            int l = bll.UpdateTenant(tenant);

            string message = " Updated";
            string title = "Updated";
            MessageBox.Show(message, title);
        }

        private void btnListTenant_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Form14 form = new Form14();
            form.Show();
            this.Hide();

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}