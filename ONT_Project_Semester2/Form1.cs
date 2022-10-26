using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using BLL;


namespace ONT_Project_Semester2
{
    public partial class HomePage : Form
        
    {

    public HomePage()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbUserType.Items.Add("Admin");
            cmbUserType.Items.Add("Agent");
            cmbUserType.Items.Add("Tenant");

        }

        private void ProptertyType_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Properties_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void Cities_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void Suburbes_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();

        }

        private void Provinces_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void Agencies_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void Agents_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }

        private void Tenants_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }

        private void PropertyAgents_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
            this.Hide();
        }

        private void Rentals_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (cmbUserType.SelectedItem.Equals("Agent"))
            {
                DataTable dt = bll.GetLoginAgent(txtUserName.Text, txtUserPassoword.Text);

                string userName, userPassword;

                try
                {
                    if (dt.Rows.Count > 0)
                    {

                        userName = txtUserName.Text;
                        userPassword = txtUserPassoword.Text;

                        Form2 form = new Form2();
                        form.Show();
                        this.Hide();

                    }
                    else
                    {

                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Clear();
                        txtUserPassoword.Clear();
                        txtUserName.Focus();

                    }
                }
                catch
                {

                    MessageBox.Show("Error");

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtUserPassoword.Clear();
            txtUserName.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {

                Application.Exit();

            }
            else
            {

                this.Show();

            }
        }
    }
}
