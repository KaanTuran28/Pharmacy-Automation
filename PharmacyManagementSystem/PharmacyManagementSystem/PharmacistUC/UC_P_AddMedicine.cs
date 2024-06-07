using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        string connectionString = "Data Source=KAAN;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        string query;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "" && txtMedicineName.Text != "" && txtMedicineNumber.Text != "" && txtQuantity.Text != "" && txtPricepUnit.Text != "")
            {
                string mid = txtMedicineID.Text;
                string mname = txtMedicineName.Text;
                string mnumber = txtMedicineNumber.Text;
                string mdate = Convert.ToDateTime(dateTimeMD.Value).ToString("yyyy-MM-dd");
                string edate = Convert.ToDateTime(dateTimeExpireDate.Value).ToString("yyyy-MM-dd");
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricepUnit.Text);
                string marka = txtMarka.Text;

                // Resmi byte dizisine dönüştürme
                byte[] pictureBytes = ImageToByteArray(resim.Image);

                // Veritabanına kayıt ekleme
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    query = "INSERT INTO medic (seriNo, isim, barkodNo, üretimTarih, sonTarih, adet, birimFyt, marka, resim) VALUES (@mid, @mname, @mnumber, @mdate, @edate, @quantity, @perunit, @marka, @picture)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@mid", mid);
                        command.Parameters.AddWithValue("@mname", mname);
                        command.Parameters.AddWithValue("@mnumber", mnumber);
                        command.Parameters.AddWithValue("@mdate", mdate);
                        command.Parameters.AddWithValue("@edate", edate);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@perunit", perunit);
                        command.Parameters.AddWithValue("@marka", marka);
                        // Resmi parametre olarak ekleme
                        command.Parameters.Add("@picture", SqlDbType.VarBinary).Value = (object)pictureBytes ?? DBNull.Value;

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("İlaç Veritabanına Eklendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearAll();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tüm Verileri girin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }





        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtQuantity.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtPricepUnit.Clear();
            dateTimeMD.ResetText();
            dateTimeExpireDate.ResetText();
            txtMarka.Clear();
            resim.Image = null; // Resim kontrolünü temizle
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {
            // Varsayılan tarih formatı burada gereksiz, kaldırabilirsiniz.
            // DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resim.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
