
namespace PharmacyManagementSystem.PharmacistUC
{
    partial class UC_P_MedicineValidityCheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCheck = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "İlaç Geçerlilik Kontrolü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(425, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kontrol et";
            // 
            // cmbCheck
            // 
            this.cmbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCheck.FormattingEnabled = true;
            this.cmbCheck.Items.AddRange(new object[] {
            "Geçerli İlaçlar",
            "Süresi dolmuş ilaçlar",
            "Tüm İlaçları Görüntüle"});
            this.cmbCheck.Location = new System.Drawing.Point(429, 134);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.Size = new System.Drawing.Size(358, 37);
            this.cmbCheck.TabIndex = 18;
            this.cmbCheck.SelectedIndexChanged += new System.EventHandler(this.cmbCheck_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-9, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1110, 563);
            this.dataGridView1.TabIndex = 19;
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSet.Location = new System.Drawing.Point(48, 164);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(68, 24);
            this.lblSet.TabIndex = 20;
            this.lblSet.Text = "Ayarla";
            // 
            // UC_P_MedicineValidityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_MedicineValidityCheck";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_P_MedicineValidityCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCheck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSet;
    }
}
