using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT_Project_Semester2
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void btnProperties_Click(object sender, EventArgs e)
        {


            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void btnCities_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void btnSuburbs_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void btnAgencies_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }

        private void btnpropertyAgent_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
            this.Hide();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }
    }
}
