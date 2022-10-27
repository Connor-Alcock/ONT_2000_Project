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
    public partial class Report1 : UserControl
    {
        public Report1()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DgvReport1.DataSource = bll.GetReport1();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
