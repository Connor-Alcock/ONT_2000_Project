
namespace ONT_Project_Semester2
{
    partial class Form3
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
            this.Properties = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnDisplayProperty = new System.Windows.Forms.Button();
            this.cmbPropertyType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbSuburb = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // Properties
            // 
            this.Properties.Controls.Add(this.pictureBox1);
            this.Properties.Controls.Add(this.btnImage);
            this.Properties.Controls.Add(this.btnAddProperty);
            this.Properties.Controls.Add(this.btnUpdateProperty);
            this.Properties.Controls.Add(this.btnHome);
            this.Properties.Controls.Add(this.btnDeleteProperty);
            this.Properties.Controls.Add(this.btnDisplayProperty);
            this.Properties.Controls.Add(this.cmbPropertyType);
            this.Properties.Controls.Add(this.cmbStatus);
            this.Properties.Controls.Add(this.cmbSuburb);
            this.Properties.Controls.Add(this.txtDescription);
            this.Properties.Controls.Add(this.txtPrice);
            this.Properties.Controls.Add(this.txtPropertyID);
            this.Properties.Controls.Add(this.label8);
            this.Properties.Controls.Add(this.label7);
            this.Properties.Controls.Add(this.label6);
            this.Properties.Controls.Add(this.label5);
            this.Properties.Controls.Add(this.label4);
            this.Properties.Controls.Add(this.label3);
            this.Properties.Controls.Add(this.label2);
            this.Properties.Controls.Add(this.label1);
            this.Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Properties.Location = new System.Drawing.Point(19, 22);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(1170, 398);
            this.Properties.TabIndex = 0;
            this.Properties.TabStop = false;
            this.Properties.Text = "Properties";
            this.Properties.Enter += new System.EventHandler(this.Properties_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(948, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 296);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(374, 186);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(521, 33);
            this.btnImage.TabIndex = 4;
            this.btnImage.Text = "Browse";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            this.btnImage.Validating += new System.ComponentModel.CancelEventHandler(this.btnImage_Validating);
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(103, 337);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(154, 44);
            this.btnAddProperty.TabIndex = 3;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(423, 337);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(154, 44);
            this.btnUpdateProperty.TabIndex = 3;
            this.btnUpdateProperty.Text = "Update Property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(743, 337);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(154, 44);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(583, 337);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(154, 44);
            this.btnDeleteProperty.TabIndex = 3;
            this.btnDeleteProperty.Text = "Delete Properties";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnDisplayProperty
            // 
            this.btnDisplayProperty.Location = new System.Drawing.Point(263, 337);
            this.btnDisplayProperty.Name = "btnDisplayProperty";
            this.btnDisplayProperty.Size = new System.Drawing.Size(154, 44);
            this.btnDisplayProperty.TabIndex = 3;
            this.btnDisplayProperty.Text = "List Properties";
            this.btnDisplayProperty.UseVisualStyleBackColor = true;
            this.btnDisplayProperty.Click += new System.EventHandler(this.btnDisplayProperty_Click);
            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.FormattingEnabled = true;
            this.cmbPropertyType.Location = new System.Drawing.Point(360, 232);
            this.cmbPropertyType.Name = "cmbPropertyType";
            this.cmbPropertyType.Size = new System.Drawing.Size(537, 28);
            this.cmbPropertyType.TabIndex = 2;
            this.cmbPropertyType.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.cmbPropertyType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPropertyType_Validating);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(360, 269);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(537, 28);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStatus_Validating);
            // 
            // cmbSuburb
            // 
            this.cmbSuburb.FormattingEnabled = true;
            this.cmbSuburb.Location = new System.Drawing.Point(360, 303);
            this.cmbSuburb.Name = "cmbSuburb";
            this.cmbSuburb.Size = new System.Drawing.Size(537, 28);
            this.cmbSuburb.TabIndex = 2;
            this.cmbSuburb.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSuburb_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(374, 116);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(523, 27);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(374, 149);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(523, 27);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(374, 83);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.Size = new System.Drawing.Size(523, 27);
            this.txtPropertyID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Suburb: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Property Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Image:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Property ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProperties);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1170, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property List";
            // 
            // dgvProperties
            // 
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Location = new System.Drawing.Point(6, 35);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.RowHeadersWidth = 51;
            this.dgvProperties.RowTemplate.Height = 24;
            this.dgvProperties.Size = new System.Drawing.Size(1150, 224);
            this.dgvProperties.TabIndex = 0;
            this.dgvProperties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProperties_CellContentClick);
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 714);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Properties);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Properties.ResumeLayout(false);
            this.Properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Properties;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSuburb;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnDisplayProperty;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}