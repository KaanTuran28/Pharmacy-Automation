using PharmacyManagementSystem.PharmacistUC;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class FrmPharmacist : Form
    {
        public FrmPharmacist()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();
            fr.Show();
            this.Hide();
        }

        private void FrmPharmacist_Load(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_ViewMedicines1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicines1.Visible = true;
            uC_P_ViewMedicines1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void btnMedicineValidityCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }

        private void btnIlac_Click(object sender, EventArgs e)
        {
            // İlgili web sitesinin URL'sini tanımlayın
            string websiteUrl = "file:///C:/xampp/htdocs/Eczane%20web%20site/index.html";

            // Belirtilen URL'yi varsayılan web tarayıcısında aç
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

    }
}
 