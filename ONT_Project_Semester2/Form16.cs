using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace ONT_Project_Semester2
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            Report1.BringToFront();
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            userControl41.BringToFront();
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            userControl51.BringToFront();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userControl51_Load(object sender, EventArgs e)
        {

        }

        private void btnReport6_Click(object sender, EventArgs e)
        {
            userControl61.BringToFront();
        }

        private void btnReport7_Click(object sender, EventArgs e)
        {
            userControl71.BringToFront();
        }
    }
}
