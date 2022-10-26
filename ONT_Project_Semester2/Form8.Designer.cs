
namespace ONT_Project_Semester2
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnListAgent = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAgencyID = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.txtAgentPhone = new System.Windows.Forms.TextBox();
            this.txtAgentPassword = new System.Windows.Forms.TextBox();
            this.txtAgentEmail = new System.Windows.Forms.TextBox();
            this.txtAgentSurname = new System.Windows.Forms.TextBox();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAgent = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Controls.Add(this.btnUpdate);
            this.txtName.Controls.Add(this.btnDelete);
            this.txtName.Controls.Add(this.btnHome);
            this.txtName.Controls.Add(this.btnListAgent);
            this.txtName.Controls.Add(this.btnAdd);
            this.txtName.Controls.Add(this.cmbAgencyID);
            this.txtName.Controls.Add(this.cmbStatus);
            this.txtName.Controls.Add(this.txtAgentID);
            this.txtName.Controls.Add(this.txtAgentPhone);
            this.txtName.Controls.Add(this.txtAgentPassword);
            this.txtName.Controls.Add(this.txtAgentEmail);
            this.txtName.Controls.Add(this.txtAgentSurname);
            this.txtName.Controls.Add(this.txtAgentName);
            this.txtName.Controls.Add(this.label8);
            this.txtName.Controls.Add(this.label7);
            this.txtName.Controls.Add(this.label6);
            this.txtName.Controls.Add(this.label5);
            this.txtName.Controls.Add(this.label4);
            this.txtName.Controls.Add(this.label3);
            this.txtName.Controls.Add(this.label2);
            this.txtName.Controls.Add(this.label1);
            this.txtName.Location = new System.Drawing.Point(8, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(785, 513);
            this.txtName.TabIndex = 0;
            this.txtName.TabStop = false;
            this.txtName.Text = "Agencts";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(195, 457);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Agent";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(467, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Agent";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(603, 457);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 43);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnListAgent
            // 
            this.btnListAgent.Location = new System.Drawing.Point(331, 457);
            this.btnListAgent.Name = "btnListAgent";
            this.btnListAgent.Size = new System.Drawing.Size(130, 43);
            this.btnListAgent.TabIndex = 3;
            this.btnListAgent.Text = "Agent List";
            this.btnListAgent.UseVisualStyleBackColor = true;
            this.btnListAgent.Click += new System.EventHandler(this.btnListAgent_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Agent";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAgencyID
            // 
            this.cmbAgencyID.FormattingEnabled = true;
            this.cmbAgencyID.Location = new System.Drawing.Point(268, 381);
            this.cmbAgencyID.Name = "cmbAgencyID";
            this.cmbAgencyID.Size = new System.Drawing.Size(474, 24);
            this.cmbAgencyID.TabIndex = 2;
            this.cmbAgencyID.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAgencyID_Validating);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(268, 336);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(474, 24);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStatus_Validating);
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(268, 59);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(474, 22);
            this.txtAgentID.TabIndex = 1;
            // 
            // txtAgentPhone
            // 
            this.txtAgentPhone.Location = new System.Drawing.Point(268, 291);
            this.txtAgentPhone.Name = "txtAgentPhone";
            this.txtAgentPhone.Size = new System.Drawing.Size(474, 22);
            this.txtAgentPhone.TabIndex = 1;
            this.txtAgentPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgentPhone_Validating);
            // 
            // txtAgentPassword
            // 
            this.txtAgentPassword.Location = new System.Drawing.Point(268, 247);
            this.txtAgentPassword.Name = "txtAgentPassword";
            this.txtAgentPassword.Size = new System.Drawing.Size(474, 22);
            this.txtAgentPassword.TabIndex = 1;
            this.txtAgentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgentPassword_Validating);
            // 
            // txtAgentEmail
            // 
            this.txtAgentEmail.Location = new System.Drawing.Point(268, 202);
            this.txtAgentEmail.Name = "txtAgentEmail";
            this.txtAgentEmail.Size = new System.Drawing.Size(474, 22);
            this.txtAgentEmail.TabIndex = 1;
            this.txtAgentEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgentEmail_Validating);
            // 
            // txtAgentSurname
            // 
            this.txtAgentSurname.Location = new System.Drawing.Point(268, 159);
            this.txtAgentSurname.Name = "txtAgentSurname";
            this.txtAgentSurname.Size = new System.Drawing.Size(474, 22);
            this.txtAgentSurname.TabIndex = 1;
            this.txtAgentSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgentSurname_Validating);
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(268, 113);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(474, 22);
            this.txtAgentName.TabIndex = 1;
            this.txtAgentName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgentName_Validating);
            this.txtAgentName.Validated += new System.EventHandler(this.txtAgentName_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Agency ID:";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAgent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 539);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent List";
            // 
            // dgvAgent
            // 
            this.dgvAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgent.Location = new System.Drawing.Point(16, 26);
            this.dgvAgent.Name = "dgvAgent";
            this.dgvAgent.RowHeadersWidth = 51;
            this.dgvAgent.RowTemplate.Height = 24;
            this.dgvAgent.Size = new System.Drawing.Size(742, 270);
            this.dgvAgent.TabIndex = 0;
            this.dgvAgent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgent_CellClick);
            this.dgvAgent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgent_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 869);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.txtName.ResumeLayout(false);
            this.txtName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAgencyID;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.TextBox txtAgentPhone;
        private System.Windows.Forms.TextBox txtAgentPassword;
        private System.Windows.Forms.TextBox txtAgentEmail;
        private System.Windows.Forms.TextBox txtAgentSurname;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnListAgent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAgent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
    }
}