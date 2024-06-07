using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        string connectionString = "Data Source=KAAN;Initial Catalog=pharmacy;Integrated Security=True;";
        string query;
        DataSet ds;

        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select isim from medic where sonTarih >= getdate() and adet > 0";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select isim from medic where isim like @name and sonTarih >= getdate() and adet > 0";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", txtSearch.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                ds = new DataSet();
                adapter.Fill(ds);
            }

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                txtNoOfUnits.Clear();
                string name = listBox1.GetItemText(listBox1.SelectedItem);
                txtMedicineName.Text = name;

                query = "select seriNo, sonTarih, birimFyt, marka from medic where isim = @name";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        txtMedicineID.Text = row["seriNo"].ToString();
                        dateTimeEDate.Text = row["sonTarih"].ToString();
                        txtPricePerUnit.Text = row["birimFyt"].ToString();
                        txtMarka.Text = row["marka"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Seçilen ilaç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfUnits.Text != "")
            {
                string unitPrice = txtPricePerUnit.Text;
                string noOfUnit = txtNoOfUnits.Text;
                Int64 a = Int64.Parse(unitPrice);
                Int64 b = Int64.Parse(noOfUnit);
                Int64 totalAmount = a * b;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        private void btnPurchaseandPrint_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM sales WHERE seriNo = @seriNo";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@seriNo", txtMedicineID.Text);
                        int count = (int)checkCommand.ExecuteScalar();

                        string query;
                        if (count > 0)
                        {
                            query = "UPDATE sales SET isim = @isim, sonTarih = @sonTarih, birimFyt = @birimFyt, adet = @adet, TopFyt = @TopFyt, Doktor = @Doktor, Marka = @Marka, SatılanTarih = @SatılanTarih WHERE seriNo = @seriNo";
                        }
                        else
                        {
                            query = "INSERT INTO sales (seriNo, isim, sonTarih, birimFyt, adet, TopFyt, Doktor, Marka, SatılanTarih) VALUES (@seriNo, @isim, @sonTarih, @birimFyt, @adet, @TopFyt, @Doktor, @Marka, @SatılanTarih)";
                        }

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@seriNo", txtMedicineID.Text);
                            command.Parameters.AddWithValue("@isim", txtMedicineName.Text);
                            command.Parameters.AddWithValue("@sonTarih", dateTimeEDate.Value);
                            command.Parameters.AddWithValue("@birimFyt", txtPricePerUnit.Text);
                            command.Parameters.AddWithValue("@adet", txtNoOfUnits.Text);
                            command.Parameters.AddWithValue("@TopFyt", txtTotalPrice.Text);
                            command.Parameters.AddWithValue("@Doktor", txtDoktor.Text);
                            command.Parameters.AddWithValue("@Marka", txtMarka.Text);
                            command.Parameters.AddWithValue("@SatılanTarih", DateTime.Now.ToString()); // Şu anki tarih ve saat
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına kaydedilirken bir hata oluştu: " + ex.Message);
                }
            }

            DGVPrinter print = new DGVPrinter();
            print.Title = "Eczane Proje Ödevi";
            print.SubTitle = String.Format("Tarih: - {0}", DateTime.Now);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = false;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Toplam Ödenecek Tutar :" + lblTotalAmount.Text;
            print.FooterSpacing = 15;

            print.PageSettings.Landscape = false;
            print.PageSettings.Margins = new Margins(50, 50, 50, 50);
            print.PageSettings.PaperSize = new PaperSize("A4", 827, 1169); // A4 boyutları

            // Save original widths
            Dictionary<string, int> originalWidths = new Dictionary<string, int>();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                originalWidths[column.Name] = column.Width;
            }

            // Manually scale columns to fit the page width
            int totalWidth = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                totalWidth += column.Width;
            }

            int targetWidth = print.PageSettings.PaperSize.Width - (print.PageSettings.Margins.Left + print.PageSettings.Margins.Right);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                int newWidth = (int)((float)column.Width / totalWidth * targetWidth);
                column.Width = newWidth;
            }

            // Print the DataGridView
            print.PrintDataGridView(dataGridView1);

            // Restore original widths
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (originalWidths.ContainsKey(column.Name))
                {
                    column.Width = originalWidths[column.Name];
                }
            }

            totalAmount = 0;
            lblTotalAmount.Text = " TL. 00";
            dataGridView1.DataSource = null;
            clearAll();
        }

        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtNoOfUnits.Clear();
            txtPricePerUnit.Clear();
            txtSearch.Clear();
            txtTotalPrice.Clear();
            dateTimeEDate.ResetText();
            txtDoktor.ResetText();
            txtMarka.ResetText();
            dataGridView1.Rows.Clear();
        }



        int valueAmount;
        string valueId;
        int totalAmount;
        protected Int64 noOfunit;
        private void btnRemove_Click(object sender, EventArgs e)
        {
            clearAll();
            dataGridView1.Rows.Clear();
            totalAmount = 0;
            lblTotalAmount.Text = "TL. 00";
        }

        protected int n;
        protected Int64 quantity, newQuantity;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                query = "select adet from medic where seriNo='" + txtMedicineID.Text + "'";
                ds = fn.getData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                if (Int64.TryParse(txtNoOfUnits.Text, out noOfunit))
                {
                    newQuantity = quantity - noOfunit;
                    if (newQuantity >= 0)
                    {
                        n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = txtMedicineID.Text;
                        dataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                        dataGridView1.Rows[n].Cells[2].Value = dateTimeEDate.Text;
                        dataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                        dataGridView1.Rows[n].Cells[4].Value = txtNoOfUnits.Text;
                        dataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;
                        dataGridView1.Rows[n].Cells[6].Value = txtDoktor.Text;
                        dataGridView1.Rows[n].Cells[7].Value = txtMarka.Text;

                        totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                        lblTotalAmount.Text = "TL. " + totalAmount.ToString();
                        query = "update medic set adet ='" + newQuantity + "' where seriNo='" + txtMedicineID.Text + "'";
                        fn.setData(query, "İlaç Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("İlaç stokta yok.\n Sadece " + quantity + " Left", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir birim sayısı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
