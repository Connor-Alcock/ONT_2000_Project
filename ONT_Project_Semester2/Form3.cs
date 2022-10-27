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
using System.IO;


namespace ONT_Project_Semester2
{
    public partial class Form3 : Form
    {

        private byte[] ReadFile(string sPath)
        {

            byte[] data = null;

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);
            return data;

        }

        public Form3()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Form3_Load(object sender, EventArgs e)
        {

            txtPropertyID.Enabled = false;

            cmbPropertyType.DataSource = bll.GetPropertyType();
            cmbPropertyType.DisplayMember = "PropertyTypeDescription";
            cmbPropertyType.ValueMember = "PropertyTypeID";
            cmbPropertyType.SelectedIndex = -1;

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
            cmbStatus.Items.Add("Pending");

            cmbSuburb.DataSource = bll.GetSuburb();
            cmbSuburb.DisplayMember = "SuburbDescription";
            cmbSuburb.ValueMember = "SuburbID";
            cmbSuburb.SelectedIndex = -1;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Property property = new Property();

            property.PropertyDescription = txtDescription.Text;
            property.PropertyPrice = int.Parse(txtPrice.Text);
            property.Picture = ReadFile(pictureBox1.ImageLocation.ToString());
            property.PropertyTypeID = Convert.ToInt32(cmbPropertyType.SelectedValue.ToString());
            property.PropertyStatus = cmbStatus.SelectedItem.ToString();
            property.SuburbID = Convert.ToInt32(cmbSuburb.SelectedValue.ToString());

            int x = bll.InsertProperty(property);
            if (x > 0)
            {
                string message = "Property Added";
                string title = "Property";
                MessageBox.Show(x + message, title);
            }
        }

        private void dgvProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDisplayProperty_Click(object sender, EventArgs e)
        {
            dgvProperties.DataSource = bll.GetProperty();
        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            if x = 1;

            { 
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPropertyID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Properties_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {

            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpe; *.jpeg; *.bmp) | *.jpg; *.jpeg; *.bmp";
            if (openFileDialog.ShowDialog(this)== DialogResult.OK)
            {
                try
                { 
                    if ((myStream= openFileDialog.OpenFile()) != null)
                    {
                        string FileName = openFileDialog.FileName;

                        if (myStream.Length > 512000)
                        {

                            MessageBox.Show("File Size limit exceeded");

                        }
                        else
                        {

                            pictureBox1.Load(FileName);

                        }
                    } 
                }
                catch(Exception)
                {

                    MessageBox.Show("File could not be loaded");

                }
            }
        }
            
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider1.SetError(txtDescription, "Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "");
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                e.Cancel = true;
                txtPrice.Focus();
                errorProvider2.SetError(txtPrice, "Price should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtPrice, "");
            }
        }

        private void btnImage_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cmbPropertyType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPropertyType.Text))
            {
                e.Cancel = true;
                cmbPropertyType.Focus();
                errorProvider3.SetError(cmbPropertyType, "Property Type should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(cmbPropertyType, "");
            }
        }

        private void cmbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                e.Cancel = true;
                cmbStatus.Focus();
                errorProvider4.SetError(cmbStatus, "Price should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(cmbStatus, "");
            }
        }

        private void cmbSuburb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSuburb.Text))
            {
                e.Cancel = true;
                cmbSuburb.Focus();
                errorProvider5.SetError(cmbSuburb, "Price should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(cmbSuburb, "");
            }
        }
    }
}

    

