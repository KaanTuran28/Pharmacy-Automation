using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class FrmLogin : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public FrmLogin()
        {
            InitializeComponent();

            txtUsername.KeyDown += TxtUsername_KeyDown;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            txtUsername.ForeColor = Color.Black; 
            txtPassword.ForeColor = Color.Red; 

            Font boldFont = new Font(txtUsername.Font, FontStyle.Bold); 
            txtUsername.Font = boldFont; 
            txtPassword.Font = boldFont; 
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.KeyCode != Keys.ShiftKey)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true; 
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && e.KeyCode != Keys.ShiftKey)
            {
                btnSignIn.PerformClick();
                e.SuppressKeyPress = true; 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "root" && txtPassword.Text == "root")
                {
                    FrmAdminstrator fr = new FrmAdminstrator();
                    fr.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where kullaniciAdı='" + txtUsername.Text + "' and sifre='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        FrmAdminstrator fr = new FrmAdminstrator();
                        fr.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        FrmPharmacist fr = new FrmPharmacist();
                        fr.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da parola yanlış ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
