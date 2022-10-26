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
using System.Text.RegularExpressions;


namespace ONT_Project_Semester2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Form2_Load(object sender, EventArgs e)
        {
            txtPropertyTypeID.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();

        }

        private void txtPropertyID_TextChanged(object sender, EventArgs e)
        {
            txtPropertyTypeID.Enabled = false;
        }

        private void txtPropertyDescription_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {

            PropertyType propertyType = new PropertyType();

            propertyType.PropertyTypeDescription = txtPropertyTypeDescription.Text;
            /*
            if (string.IsNullOrEmpty(txtPropertyTypeDescription.Text) || (Regex.IsMatch(txtPropertyTypeDescription.Text,))
            {
                errPropertyDescription.SetError(txtPropertyTypeDescription, "Please enter text only");
            }
            */
            
            int x = bll.InsertPropertyType(propertyType);
            if(x > 0)
            {
                string message = "Property Type Added";
                string title = "Property Type";
                MessageBox.Show(x + message, title);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyType.DataSource = bll.GetPropertyType();
        }

        private void dgvPropertyType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtPropertyTypeDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPropertyTypeDescription.Text))
            {
                e.Cancel = true;
                txtPropertyTypeDescription.Focus();
                errorProvider1.SetError(txtPropertyTypeDescription, "Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPropertyTypeDescription, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 form2 = new Form11();
            form2.Show();
            this.Hide();

        }
    }
}
