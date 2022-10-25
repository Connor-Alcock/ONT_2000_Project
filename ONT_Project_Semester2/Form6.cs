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
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
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
    }
}
