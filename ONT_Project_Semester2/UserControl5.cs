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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void cmbAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

            cmbAmount.Items.Add("Between R1000 - R3000");
            cmbAmount.Items.Add("Between R3000 - R6000");
            cmbAmount.Items.Add("Between R6000 - R10000");

        }

        private void DvgReport5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            if (cmbAmount.SelectedItem.Equals("Between R1000 - R3000"))
            {

                DvgReport5.DataSource = bll.GetReport5();


            }
            else if(cmbAmount.SelectedItem.Equals("Between R3000 - R6000"))
            {




            }
            else if (cmbAmount.SelectedItem.Equals("Between R6000 - R10000"))
            {




            }
        }
    }
}
