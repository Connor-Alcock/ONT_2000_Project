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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Form4_Load(object sender, EventArgs e)
        {
            txtProvinceID.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();

        }

        private void btnAddProvince_Click(object sender, EventArgs e)
        {
            Province  province = new Province();

            province.ProvinceDescription = txtProvinceDescription.Text;

            int x = bll.InsertProvince(province);
            if (x > 0)
            {
                string message = "Province Added";
                string title = "Province";
                MessageBox.Show(x + message, title);
            }
            
        }

        private void btnDisplayProvince_Click(object sender, EventArgs e)
        {

            dgvProvince.DataSource = bll.GetProvince();

        }

        private void dvgProvince_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtProvinceDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProvinceDescription.Text))
            {
                e.Cancel = true;
                txtProvinceDescription.Focus();
                errorProvider1.SetError(txtProvinceDescription, "Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtProvinceDescription, "");
            }
        }
    }
}
