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
            Form13 form13 = new Form13();
            form13.Show();
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
            cmbAgencyID.SelectedIndex = -1;

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

        private void txtAgentName_Validated(object sender, EventArgs e)
        {

        }

        private void txtAgentName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgentName.Text))
            {
                e.Cancel = true;
                txtAgentName.Focus();
                errorProvider1.SetError(txtAgentName, "Agent Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAgentName, "");
            }
        }

        private void txtAgentSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgentSurname.Text))
            {
                e.Cancel = true;
                txtAgentSurname.Focus();
                errorProvider2.SetError(txtAgentSurname, "Agent Surname should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtAgentSurname, "");
            }
        }

        private void txtAgentEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgentEmail.Text))
            {
                e.Cancel = true;
                txtAgentEmail.Focus();
                errorProvider3.SetError(txtAgentEmail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtAgentEmail, "");
            }
        }

        private void txtAgentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgentPassword.Text))
            {
                e.Cancel = true;
                txtAgentPassword.Focus();
                errorProvider4.SetError(txtAgentPassword, "Agent Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtAgentPassword, "");
            }
        }

        private void txtAgentPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgentPhone.Text))
            {
                e.Cancel = true;
                txtAgentPhone.Focus();
                errorProvider5.SetError(txtAgentPhone, "Agent Phone should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(txtAgentPhone, "");
            }
        }

        private void cmbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                e.Cancel = true;
                cmbStatus.Focus();
                errorProvider6.SetError(cmbStatus, "Status should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider6.SetError(cmbStatus, "");
            }
        }

        private void cmbAgencyID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbAgencyID.Text))
            {
                e.Cancel = true;
                cmbAgencyID.Focus();
                errorProvider7.SetError(cmbAgencyID, "Aganecy ID should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider7.SetError(cmbAgencyID, "");
            }
        }
    }
 }

