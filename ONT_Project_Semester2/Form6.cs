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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Form6_Load(object sender, EventArgs e)
        {
            txtSuburbID.Enabled = false;

            cmbCity.DataSource = bll.GetCity();
            cmbCity.DisplayMember = "CityDescription";
            cmbCity.ValueMember = "CityID";
            cmbCity.SelectedIndex = -1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }


        private void btnListSuburb_Click(object sender, EventArgs e)
        {
                dgvSuburb.DataSource = bll.GetSuburb();

        }

        private void txtSuburbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCityID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Suburbs suburbs = new Suburbs();

            suburbs.SuburbDescription = txtSuburbDescription.Text;
            suburbs.PostalCode = int.Parse(txtPostalCode.Text);
            suburbs.CityID = Convert.ToInt32(cmbCity.SelectedValue.ToString());


            int x = bll.InsertSuburb(suburbs);
            if (x > 0)
            {
                string message = "Surburb Added";
                string title = "Surburb";
                MessageBox.Show(x + message, title);
            }
        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuburbDescription_Validated(object sender, EventArgs e)
        {

        }

        private void txtSuburbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuburbDescription.Text))
            {
                e.Cancel = true;
                txtSuburbDescription.Focus();
                errorProvider1.SetError(txtSuburbDescription, "Suburb Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSuburbDescription, "");
            }
        }

        private void txtPostalCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPostalCode.Text))
            {
                e.Cancel = true;
                txtPostalCode.Focus();
                errorProvider2.SetError(txtPostalCode, "Postal Code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtPostalCode, "");
            }
        }

        private void cmbCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCity.Text))
            {
                e.Cancel = true;
                cmbCity.Focus();
                errorProvider3.SetError(cmbCity, "City should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(cmbCity, "");
            }
        }
    }
}
