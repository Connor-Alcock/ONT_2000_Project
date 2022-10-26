
namespace ONT_Project_Semester2
{
    partial class Form5
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
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCityList = new System.Windows.Forms.Button();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.txtCityDescription = new System.Windows.Forms.TextBox();
            this.txtCityID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCity);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnCityList);
            this.groupBox1.Controls.Add(this.cmbProvince);
            this.groupBox1.Controls.Add(this.txtCityDescription);
            this.groupBox1.Controls.Add(this.txtCityID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cities";
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(346, 189);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(129, 38);
            this.btnAddCity.TabIndex = 3;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(616, 189);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(129, 38);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCityList
            // 
            this.btnCityList.Location = new System.Drawing.Point(481, 189);
            this.btnCityList.Name = "btnCityList";
            this.btnCityList.Size = new System.Drawing.Size(129, 38);
            this.btnCityList.TabIndex = 3;
            this.btnCityList.Text = "City List";
            this.btnCityList.UseVisualStyleBackColor = true;
            this.btnCityList.Click += new System.EventHandler(this.btnCityList_Click);
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(276, 115);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(361, 28);
            this.cmbProvince.TabIndex = 2;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            this.cmbProvince.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProvince_Validating);
            // 
            // txtCityDescription
            // 
            this.txtCityDescription.Location = new System.Drawing.Point(263, 82);
            this.txtCityDescription.Name = "txtCityDescription";
            this.txtCityDescription.Size = new System.Drawing.Size(374, 27);
            this.txtCityDescription.TabIndex = 1;
            this.txtCityDescription.TextChanged += new System.EventHandler(this.txtCityDescription_TextChanged);
            this.txtCityDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtCityDescription_Validating);
            this.txtCityDescription.Validated += new System.EventHandler(this.txtCityDescription_Validated);
            // 
            // txtCityID
            // 
            this.txtCityID.Location = new System.Drawing.Point(263, 49);
            this.txtCityID.Name = "txtCityID";
            this.txtCityID.Size = new System.Drawing.Size(374, 27);
            this.txtCityID.TabIndex = 1;
            this.txtCityID.TextChanged += new System.EventHandler(this.txtCityID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Province";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "City Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCities);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cities List";
            // 
            // dgvCities
            // 
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Location = new System.Drawing.Point(6, 47);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.RowHeadersWidth = 51;
            this.dgvCities.RowTemplate.Height = 24;
            this.dgvCities.Size = new System.Drawing.Size(741, 187);
            this.dgvCities.TabIndex = 0;
            this.dgvCities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCities_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCityDescription;
        private System.Windows.Forms.TextBox txtCityID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCityList;
        private System.Windows.Forms.DataGridView dvgCities;
        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}