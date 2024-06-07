using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        string connectionString = "Data Source=KAAN;Initial Catalog=pharmacy;Integrated Security=True;";
        string query;
        Image selectedImage; // Seçilen resmi saklamak için bir değişken

        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                query = "select * from medic where seriNo='" + txtMedicineID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2] != DBNull.Value ? ds.Tables[0].Rows[0][2].ToString() : string.Empty;
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3] != DBNull.Value ? ds.Tables[0].Rows[0][3].ToString() : string.Empty;
                    dateTimeManufacturingDate.Text = ds.Tables[0].Rows[0][4] != DBNull.Value ? ds.Tables[0].Rows[0][4].ToString() : DateTime.Now.ToString();
                    dateTimeExpireDate.Text = ds.Tables[0].Rows[0][5] != DBNull.Value ? ds.Tables[0].Rows[0][5].ToString() : DateTime.Now.ToString();
                    txtAQuantity.Text = ds.Tables[0].Rows[0][6] != DBNull.Value ? ds.Tables[0].Rows[0][6].ToString() : string.Empty;
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7] != DBNull.Value ? ds.Tables[0].Rows[0][7].ToString() : string.Empty;

                    byte[] imageData = ds.Tables[0].Rows[0][8] != DBNull.Value ? (byte[])ds.Tables[0].Rows[0][8] : null;
                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Bu ID ile bir ilaç yok: " + txtMedicineID.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtAQuantity.Clear();
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtPricePerUnit.Clear();
            dateTimeExpireDate.ResetText();
            dateTimeManufacturingDate.ResetText();
            pictureBox1.Image = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mname = txtMedicineName.Text;
            string mnumber = txtMedicineNumber.Text;
            string mdate = dateTimeManufacturingDate.Value.ToString("yyyy-MM-dd");
            string edate = dateTimeExpireDate.Value.ToString("yyyy-MM-dd");
            string quantity = txtAQuantity.Text;
            string unitprice = txtPricePerUnit.Text;
            byte[] imageData = selectedImage != null ? ImageToByteArray(selectedImage) : null; // Resmi byte dizisine dönüştür

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Temel SQL komutunu oluştur
                string sql = "UPDATE medic SET isim=@isim, barkodNo=@barkodNo, üretimTarih=@üretimTarih, sonTarih=@sonTarih, adet=@adet, birimFyt=@birimFyt";
                if (imageData != null)
                {
                    sql += ", resim=@resim"; // Eğer resim verisi varsa, SQL komutuna ekle
                }
                sql += " WHERE seriNo=@seriNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@isim", mname);
                    cmd.Parameters.AddWithValue("@barkodNo", mnumber);
                    cmd.Parameters.AddWithValue("@üretimTarih", mdate);
                    cmd.Parameters.AddWithValue("@sonTarih", edate);
                    cmd.Parameters.AddWithValue("@adet", quantity);
                    cmd.Parameters.AddWithValue("@birimFyt", unitprice);
                    if (imageData != null)
                    {
                        cmd.Parameters.AddWithValue("@resim", imageData); // Eğer resim verisi varsa, parametre olarak ekle
                    }
                    cmd.Parameters.AddWithValue("@seriNo", txtMedicineID.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("İlaç Bilgileri Güncellendi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAll(); // Güncelleme işleminden sonra tüm alanları sıfırla
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Resmi seçmek için dosya iletişim kutusunu aç
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                    // Seçilen resmi PictureBox'a yükle
                    pictureBox1.Image = Image.FromFile(imagePath);
                    selectedImage = pictureBox1.Image; // Seçilen resmi sakla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Resmi byte dizisine dönüştürme işlevi
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null; // image null kontrolü ekle
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
