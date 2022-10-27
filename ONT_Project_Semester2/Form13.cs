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

        }
    }
}
