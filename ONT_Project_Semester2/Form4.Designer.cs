
namespace ONT_Project_Semester2
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDisplayProvince = new System.Windows.Forms.Button();
            this.btnAddProvince = new System.Windows.Forms.Button();
            this.txtProvinceDescription = new System.Windows.Forms.TextBox();
            this.txtProvinceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProvince = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnDisplayProvince);
            this.groupBox1.Controls.Add(this.btnAddProvince);
            this.groupBox1.Controls.Add(this.txtProvinceDescription);
            this.groupBox1.Controls.Add(this.txtProvinceID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provinces";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(601, 149);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(157, 47);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDisplayProvince
            // 
            this.btnDisplayProvince.Location = new System.Drawing.Point(438, 149);
            this.btnDisplayProvince.Name = "btnDisplayProvince";
            this.btnDisplayProvince.Size = new System.Drawing.Size(157, 47);
            this.btnDisplayProvince.TabIndex = 2;
            this.btnDisplayProvince.Text = "List Provinces";
            this.btnDisplayProvince.UseVisualStyleBackColor = true;
            this.btnDisplayProvince.Click += new System.EventHandler(this.btnDisplayProvince_Click);
            // 
            // btnAddProvince
            // 
            this.btnAddProvince.Location = new System.Drawing.Point(275, 149);
            this.btnAddProvince.Name = "btnAddProvince";
            this.btnAddProvince.Size = new System.Drawing.Size(157, 47);
            this.btnAddProvince.TabIndex = 2;
            this.btnAddProvince.Text = "Add Province";
            this.btnAddProvince.UseVisualStyleBackColor = true;
            this.btnAddProvince.Click += new System.EventHandler(this.btnAddProvince_Click);
            // 
            // txtProvinceDescription
            // 
            this.txtProvinceDescription.Location = new System.Drawing.Point(265, 88);
            this.txtProvinceDescription.Name = "txtProvinceDescription";
            this.txtProvinceDescription.Size = new System.Drawing.Size(480, 27);
            this.txtProvinceDescription.TabIndex = 1;
            this.txtProvinceDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtProvinceDescription_Validating);
            // 
            // txtProvinceID
            // 
            this.txtProvinceID.Location = new System.Drawing.Point(265, 55);
            this.txtProvinceID.Name = "txtProvinceID";
            this.txtProvinceID.Size = new System.Drawing.Size(480, 27);
            this.txtProvinceID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Province ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProvince);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Province List";
            // 
            // dgvProvince
            // 
            this.dgvProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvince.Location = new System.Drawing.Point(6, 40);
            this.dgvProvince.Name = "dgvProvince";
            this.dgvProvince.RowHeadersWidth = 51;
            this.dgvProvince.RowTemplate.Height = 24;
            this.dgvProvince.Size = new System.Drawing.Size(758, 211);
            this.dgvProvince.TabIndex = 0;
            this.dgvProvince.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProvince_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDisplayProvince;
        private System.Windows.Forms.Button btnAddProvince;
        private System.Windows.Forms.TextBox txtProvinceDescription;
        private System.Windows.Forms.TextBox txtProvinceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProvince;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}