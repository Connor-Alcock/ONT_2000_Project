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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();

            agents.Name = txtAgentName.Text;
            agents.Surname = txtAgentSurname.Text;
            agents.Email = txtAgentEmail.Text;
            agents.Password = txtAgentPassword.Text;
            agents.Phone = int.Parse(txtAgentPhone.Text);
            agents.Status = cmbStatus.SelectedItem.ToString();
            agents.AgencyID = Convert.ToInt32(cmbAgencyID.SelectedValue.ToString());

            int x = bll.InsertAgent(agents);
            if (x > 0)
            {

                MessageBox.Show(x + "Added.");
            }
        }



        private void btnListAgent_Click(object sender, EventArgs e)
        {

            dgvAgent.DataSource = bll.GetAgent();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();

            agents.AgentID = int.Parse(txtAgentID.Text);

            int r = bll.DeleteAgent(agents);

                string message = " Deleted";
                string title = "Delete";
                MessageBox.Show(message, title);
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            txtAgentID.Enabled = false;

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");

            cmbAgencyID.DataSource = bll.GetAgency();
            cmbAgencyID.DisplayMember = "AgencyName";
            cmbAgencyID.ValueMember = "AgencyID";

        }

        private void dgvAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

  

        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgent.SelectedRows.Count > 0)
            //if (e.MouseEventArgs.Button == System.Windows.Forms.MouseButtons.Right)
            {

                txtAgentID.Text = dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txtAgentName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtAgentSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtAgentEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtAgentPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txtAgentPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgencyID.Text = dgvAgent.SelectedRows[0].Cells["AgencyID"].Value.ToString();

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();

            agents.Email = txtAgentEmail.Text;
            agents.Phone = int.Parse(txtAgentPhone.Text);
            agents.Status = cmbStatus.SelectedItem.ToString();
            agents.AgentID = int.Parse(txtAgentID.Text);

            int l = bll.UpdateAgent(agents);

                string message = " Updated";
                string title = "Updated";
                MessageBox.Show(message, title);
            
        }
    }
 }

