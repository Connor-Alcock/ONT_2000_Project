
namespace ONT_Project_Semester2
{
    partial class Form11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.home = new System.Windows.Forms.Button();
            this.btnListRentals = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTenatID = new System.Windows.Forms.ComboBox();
            this.cmbPropertyAgentID = new System.Windows.Forms.ComboBox();
            this.txtRenatalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.home);
            this.groupBox1.Controls.Add(this.btnListRentals);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.StartDate);
            this.groupBox1.Controls.Add(this.EndDate);
            this.groupBox1.Controls.Add(this.cmbTenatID);
            this.groupBox1.Controls.Add(this.cmbPropertyAgentID);
            this.groupBox1.Controls.Add(this.txtRenatalID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rentals";
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(572, 280);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(114, 35);
            this.home.TabIndex = 4;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // btnListRentals
            // 
            this.btnListRentals.Location = new System.Drawing.Point(452, 280);
            this.btnListRentals.Name = "btnListRentals";
            this.btnListRentals.Size = new System.Drawing.Size(114, 35);
            this.btnListRentals.TabIndex = 4;
            this.btnListRentals.Text = "Rental List ";
            this.btnListRentals.UseVisualStyleBackColor = true;
            this.btnListRentals.Click += new System.EventHandler(this.btnListRentals_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(332, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(286, 176);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(318, 27);
            this.StartDate.TabIndex = 3;
            this.StartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(286, 210);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(318, 27);
            this.EndDate.TabIndex = 3;
            this.EndDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbTenatID
            // 
            this.cmbTenatID.FormattingEnabled = true;
            this.cmbTenatID.Location = new System.Drawing.Point(286, 136);
            this.cmbTenatID.Name = "cmbTenatID";
            this.cmbTenatID.Size = new System.Drawing.Size(425, 28);
            this.cmbTenatID.TabIndex = 2;
            this.cmbTenatID.SelectedIndexChanged += new System.EventHandler(this.cmbTenantID_SelectedIndexChanged);
            // 
            // cmbPropertyAgentID
            // 
            this.cmbPropertyAgentID.FormattingEnabled = true;
            this.cmbPropertyAgentID.Location = new System.Drawing.Point(286, 101);
            this.cmbPropertyAgentID.Name = "cmbPropertyAgentID";
            this.cmbPropertyAgentID.Size = new System.Drawing.Size(425, 28);
            this.cmbPropertyAgentID.TabIndex = 2;
            this.cmbPropertyAgentID.SelectedIndexChanged += new System.EventHandler(this.cmbTenantID_SelectedIndexChanged);
            // 
            // txtRenatalID
            // 
            this.txtRenatalID.Location = new System.Drawing.Point(286, 63);
            this.txtRenatalID.Name = "txtRenatalID";
            this.txtRenatalID.Size = new System.Drawing.Size(429, 27);
            this.txtRenatalID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tenant ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Property Agent ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRentals);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental List";
            // 
            // dgvRentals
            // 
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(10, 39);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.RowTemplate.Height = 24;
            this.dgvRentals.Size = new System.Drawing.Size(739, 131);
            this.dgvRentals.TabIndex = 0;
            this.dgvRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentals_CellClick);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPropertyAgentID;
        private System.Windows.Forms.TextBox txtRenatalID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.ComboBox cmbTenatID;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button btnListRentals;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRentals;
    }
}