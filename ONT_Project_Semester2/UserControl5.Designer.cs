
namespace ONT_Project_Semester2
{
    partial class UserControl5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DvgReport5 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgReport5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DvgReport5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAmount);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renatal based on specific amounts";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(6, 43);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(141, 45);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cmbAmount
            // 
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Location = new System.Drawing.Point(153, 60);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(571, 28);
            this.cmbAmount.TabIndex = 2;
            this.cmbAmount.SelectedIndexChanged += new System.EventHandler(this.cmbAmount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Specific Amounts";
            // 
            // DvgReport5
            // 
            this.DvgReport5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgReport5.Location = new System.Drawing.Point(12, 107);
            this.DvgReport5.Name = "DvgReport5";
            this.DvgReport5.RowHeadersWidth = 51;
            this.DvgReport5.RowTemplate.Height = 24;
            this.DvgReport5.Size = new System.Drawing.Size(785, 393);
            this.DvgReport5.TabIndex = 4;
            this.DvgReport5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgReport5_CellContentClick);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(829, 533);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgReport5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DvgReport5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.Button btnDisplay;
    }
}
