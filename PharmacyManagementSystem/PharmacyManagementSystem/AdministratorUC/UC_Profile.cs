using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        string connectionString = "Data Source=KAAN;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        string query;

        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set
            {
                lblUsername.Text = value;
            }
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            // Load işlemleri
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            query = "SELECT * FROM users WHERE kullaniciAdı = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", lblUsername.Text);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cmbUserRole.Text = reader["kullaniciRol"].ToString();
                                txtName.Text = reader["isim"].ToString();
                                txtDOB.Text = reader["dob"].ToString();
                                txtMobileNo.Text = reader["tel"].ToString();
                                txtEmailAddress.Text = reader["email"].ToString();
                                txtPassword.Text = reader["sifre"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı datası bulunamadı.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadUserProfile(); // Formu sıfırladıktan sonra tekrar yükler
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string role = cmbUserRole.Text;
            string name = txtName.Text;
            string dob = txtDOB.Text;
            string mobile = txtMobileNo.Text;
            string email = txtEmailAddress.Text;
            string username = lblUsername.Text;
            string pass = txtPassword.Text;

            query = "UPDATE users SET kullaniciRol = @UserRole, isim = @Name, dob = @DOB, tel = @Mobile, email = @Email, sifre = @Pass WHERE kullaniciAdı = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserRole", role);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@Mobile", mobile);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Pass", pass);
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected + " satır güncellendi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearFields()
        {
            cmbUserRole.SelectedIndex = -1;
            txtName.Clear();
            txtDOB.Clear();
            txtMobileNo.Clear();
            txtEmailAddress.Clear();
            txtPassword.Clear();
        }
    }
}
