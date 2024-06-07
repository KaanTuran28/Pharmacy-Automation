
namespace PharmacyManagementSystem
{
    partial class FrmPharmacist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIlac = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSellMedicine = new System.Windows.Forms.Button();
            this.btnModifyMedicine = new System.Windows.Forms.Button();
            this.btnMedicineValidityCheck = new System.Windows.Forms.Button();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_P_MedicineValidityCheck1 = new PharmacyManagementSystem.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_UpdateMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_ViewMedicines1 = new PharmacyManagementSystem.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_SellMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_SellMedicine();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnIlac);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnMedicineValidityCheck);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 782);
            this.panel1.TabIndex = 0;
            // 
            // btnIlac
            // 
            this.btnIlac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnIlac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIlac.FlatAppearance.BorderSize = 0;
            this.btnIlac.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnIlac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnIlac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnIlac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlac.ForeColor = System.Drawing.Color.White;
            this.btnIlac.Location = new System.Drawing.Point(53, 287);
            this.btnIlac.Name = "btnIlac";
            this.btnIlac.Size = new System.Drawing.Size(93, 43);
            this.btnIlac.TabIndex = 13;
            this.btnIlac.Text = "Katagori";
            this.btnIlac.UseVisualStyleBackColor = false;
            this.btnIlac.Click += new System.EventHandler(this.btnIlac_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblUsername.Location = new System.Drawing.Point(48, 716);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(152, 30);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Eczane Proje";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(12, 614);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(188, 43);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellMedicine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSellMedicine.FlatAppearance.BorderSize = 0;
            this.btnSellMedicine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnSellMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSellMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSellMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.Location = new System.Drawing.Point(0, 544);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(211, 43);
            this.btnSellMedicine.TabIndex = 9;
            this.btnSellMedicine.Text = "İlaç Satış";
            this.btnSellMedicine.UseVisualStyleBackColor = false;
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnModifyMedicine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifyMedicine.FlatAppearance.BorderSize = 0;
            this.btnModifyMedicine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnModifyMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnModifyMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnModifyMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.Location = new System.Drawing.Point(-5, 421);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(248, 43);
            this.btnModifyMedicine.TabIndex = 9;
            this.btnModifyMedicine.Text = "İlacı Güncelle";
            this.btnModifyMedicine.UseVisualStyleBackColor = false;
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnMedicineValidityCheck
            // 
            this.btnMedicineValidityCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnMedicineValidityCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMedicineValidityCheck.FlatAppearance.BorderSize = 0;
            this.btnMedicineValidityCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnMedicineValidityCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMedicineValidityCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMedicineValidityCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineValidityCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMedicineValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedicineValidityCheck.Location = new System.Drawing.Point(0, 482);
            this.btnMedicineValidityCheck.Name = "btnMedicineValidityCheck";
            this.btnMedicineValidityCheck.Size = new System.Drawing.Size(224, 43);
            this.btnMedicineValidityCheck.TabIndex = 10;
            this.btnMedicineValidityCheck.Text = "İlaç Kontrol";
            this.btnMedicineValidityCheck.UseVisualStyleBackColor = false;
            this.btnMedicineValidityCheck.Click += new System.EventHandler(this.btnMedicineValidityCheck_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMedicine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewMedicine.FlatAppearance.BorderSize = 0;
            this.btnViewMedicine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnViewMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnViewMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnViewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Location = new System.Drawing.Point(53, 355);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(137, 43);
            this.btnViewMedicine.TabIndex = 10;
            this.btnViewMedicine.Text = "İlacı Görüntüle";
            this.btnViewMedicine.UseVisualStyleBackColor = false;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedicine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMedicine.FlatAppearance.BorderSize = 0;
            this.btnAddMedicine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnAddMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Location = new System.Drawing.Point(53, 223);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(93, 43);
            this.btnAddMedicine.TabIndex = 11;
            this.btnAddMedicine.Text = "İlaç Ekle";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eczane";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 780);
            this.panel2.TabIndex = 0;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(249, -2);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1116, 777);
            this.uC_P_MedicineValidityCheck1.TabIndex = 17;
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(249, -2);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_UpdateMedicine1.TabIndex = 16;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(254, -2);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_ViewMedicines1.TabIndex = 16;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(254, -2);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1111, 780);
            this.uC_P_AddMedicine1.TabIndex = 16;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(249, -2);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(1116, 782);
            this.uC_P_SellMedicine1.TabIndex = 18;
            // 
            // FrmPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.uC_P_SellMedicine1);
            this.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.Controls.Add(this.uC_P_UpdateMedicine1);
            this.Controls.Add(this.uC_P_ViewMedicines1);
            this.Controls.Add(this.uC_P_AddMedicine1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.FrmPharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSellMedicine;
        private System.Windows.Forms.Button btnModifyMedicine;
        private System.Windows.Forms.Button btnMedicineValidityCheck;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnIlac;
    }
}