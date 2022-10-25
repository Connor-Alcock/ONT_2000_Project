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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPropertyAgent.DataSource = bll.GetPropertyAgent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent propertyAgent = new PropertyAgent();

            propertyAgent.PropertyID = Convert.ToInt32(cmbPropertyID.SelectedValue.ToString());
            propertyAgent.AgentID = Convert.ToInt32(cmbAgentID.SelectedValue.ToString());
            propertyAgent.Date = dateTimePicker1.Value;

            int x = bll.InsertPropertyAgent(propertyAgent);
            if (x > 0)
            {
                string message = " Property Agent Added";
                string title = "Property Agent";
                MessageBox.Show(x + message, title);
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

            txtPropertyAgentID.Enabled = false;

            cmbPropertyID.DataSource = bll.GetProperty();
            cmbPropertyID.DisplayMember = "Description";
            cmbPropertyID.ValueMember = "PropertyID";

            cmbAgentID.DataSource = bll.GetAgent();
            cmbAgentID.DisplayMember = "Name";
            cmbAgentID.ValueMember = "AgentID";
        }

        private void dgvPropertyAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropertyAgent.SelectedRows.Count > 0)
            //if (e.MouseEventArgs.Button == System.Windows.Forms.MouseButtons.Right)
            {

                txtPropertyAgentID.Text = dgvPropertyAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbAgentID.Text = dgvPropertyAgent.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                cmbAgentID.Text = dgvPropertyAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                dateTimePicker1.Text = dgvPropertyAgent.SelectedRows[0].Cells["Date"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertyAgent propertyAgent = new PropertyAgent();

            propertyAgent.PropertyID = Convert.ToInt32(cmbPropertyID.SelectedValue.ToString());
            propertyAgent.AgentID = Convert.ToInt32(cmbAgentID.SelectedValue.ToString());
            propertyAgent.Date = dateTimePicker1.Value;
            propertyAgent.PropertyAgentID = int.Parse(txtPropertyAgentID.Text);

            int l = bll.UpdatePropertyAgent(propertyAgent);

            string message = " Updated";
            string title = "Updated";
            MessageBox.Show(message, title);
        }
    }
}
