
namespace ONT_Project_Semester2
{
    partial class Form7
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnListAgency = new System.Windows.Forms.Button();
            this.cmbSuburbID = new System.Windows.Forms.ComboBox();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.txtAgencyID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAgencies = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnListAgency);
            this.groupBox1.Controls.Add(this.cmbSuburbID);
            this.groupBox1.Controls.Add(this.txtAgencyName);
            this.groupBox1.Controls.Add(this.txtAgencyID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agencies";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Agency";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(675, 238);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(119, 46);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(516, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Agency";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnListAgency
            // 
            this.btnListAgency.Location = new System.Drawing.Point(391, 238);
            this.btnListAgency.Name = "btnListAgency";
            this.btnListAgency.Size = new System.Drawing.Size(119, 46);
            this.btnListAgency.TabIndex = 3;
            this.btnListAgency.Text = "List Agency";
            this.btnListAgency.UseVisualStyleBackColor = true;
            this.btnListAgency.Click += new System.EventHandler(this.btnListAgency_Click);
            // 
            // cmbSuburbID
            // 
            this.cmbSuburbID.FormattingEnabled = true;
            this.cmbSuburbID.Location = new System.Drawing.Point(277, 178);
            this.cmbSuburbID.Name = "cmbSuburbID";
            this.cmbSuburbID.Size = new System.Drawing.Size(424, 28);
            this.cmbSuburbID.TabIndex = 2;
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.Location = new System.Drawing.Point(277, 118);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(424, 27);
            this.txtAgencyName.TabIndex = 1;
            // 
            // txtAgencyID
            // 
            this.txtAgencyID.Location = new System.Drawing.Point(277, 66);
            this.txtAgencyID.Name = "txtAgencyID";
            this.txtAgencyID.Size = new System.Drawing.Size(424, 27);
            this.txtAgencyID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suburb ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agency Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agency ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAgencies);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agencies List";
            // 
            // dgvAgencies
            // 
            this.dgvAgencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgencies.Location = new System.Drawing.Point(7, 35);
            this.dgvAgencies.Name = "dgvAgencies";
            this.dgvAgencies.RowHeadersWidth = 51;
            this.dgvAgencies.RowTemplate.Height = 24;
            this.dgvAgencies.Size = new System.Drawing.Size(856, 170);
            this.dgvAgencies.TabIndex = 0;
            this.dgvAgencies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgencies_CellClick);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnListAgency;
        private System.Windows.Forms.ComboBox cmbSuburbID;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.TextBox txtAgencyID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAgencies;
    }
}