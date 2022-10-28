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
    public partial class Form5 : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public Form5()
        {
            InitializeComponent();

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            Cities  cities = new Cities();

            cities.CityDescription = txtCityDescription.Text;
            cities.ProvinceID =  Convert.ToInt32(cmbProvince.SelectedValue.ToString());

            int x = bll.InsertCity(cities);
            if (x > 0)
            {
                string message = "City Added";
                string title = "Cities";
                MessageBox.Show(x + message, title);
            }

        }
        
        private void btnCityList_Click(object sender, EventArgs e)
        {
            dgvCities.DataSource = bll.GetCity();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            txtCityID.Enabled = false;

            cmbProvince.DataSource = bll.GetProvince();
            cmbProvince.DisplayMember = "ProvinceDescription";
            cmbProvince.ValueMember = "ProvinceID";
            cmbProvince.SelectedIndex = -1;

        }

        private void txtCityID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCityDescription_Validated(object sender, EventArgs e)
        {

        }

        private void txtCityDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCityDescription.Text))
            {
                e.Cancel = true;
                txtCityDescription.Focus();
                errorProvider1.SetError(txtCityDescription, "City Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCityDescription, "");
            }
        }

        private void txtCityDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvince_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbProvince.Text))
            {
                e.Cancel = true;
                cmbProvince.Focus();
                errorProvider2.SetError(cmbProvince, "Province should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(cmbProvince, "");
            }
        }

        private void dgvCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
