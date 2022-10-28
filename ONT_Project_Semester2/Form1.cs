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
        public static int LoginID ;

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbUserType.Items.Add("Admin");
            cmbUserType.Items.Add("Agent");
            cmbUserType.Items.Add("Tenant");

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

                        UserAccess.Instance.UserType = cmbUserType.SelectedItem.ToString();
                        UserAccess.Instance.username = txtUserName.Text;
                        UserAccess.Instance.password = txtUserPassoword.Text;

                      Form12 form = new Form12();
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
            else if(cmbUserType.SelectedItem.Equals("Admin"))
            {
                DataTable dt = bll.GetAdminLogin(txtUserName.Text, txtUserPassoword.Text);

                string userName, userPassword;

                try
                {
                    if (dt.Rows.Count > 0)
                    {

                        userName = txtUserName.Text;
                        userPassword = txtUserPassoword.Text;

                        UserAccess.Instance.UserType = cmbUserType.SelectedItem.ToString();
                        UserAccess.Instance.username = txtUserName.Text;
                        UserAccess.Instance.password = txtUserPassoword.Text;

                        Form13 form = new Form13();
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
            else if (cmbUserType.SelectedItem.Equals("Tenant"))
            {
                DataTable dt = bll.getTenantLogin(txtUserName.Text, txtUserPassoword.Text);

                LoginID = Convert.ToInt32(dt.Rows[0]["TenantID"].ToString());


                string userName, userPassword;

                try
                {
                    if (dt.Rows.Count > 0)
                    {

                        userName = txtUserName.Text;
                        userPassword = txtUserPassoword.Text;

                        UserAccess.Instance.UserType = cmbUserType.SelectedItem.ToString();
                        UserAccess.Instance.username = txtUserName.Text;
                        UserAccess.Instance.password = txtUserPassoword.Text;

                        Form14 form = new Form14();
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.Show();
            this.Hide(); 
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            form.Show();
            this.Hide();
        }
    }
}
