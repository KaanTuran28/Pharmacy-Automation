using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        string query;
        String currentUser = "";
        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set
            {
                currentUser = value;
            }
        }
        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);

            DataGridViewCellStyle cellStyle = dataGridView1.DefaultCellStyle;

            cellStyle.Font = new Font(cellStyle.Font.FontFamily, 12); 

            dataGridView1.DefaultCellStyle = cellStyle;

            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where kullaniciAdı like'" + txtUsername.Text + "%'";
            DataSet ds = fn.getData(query);                                       
            dataGridView1.DataSource = ds.Tables[0];

        }
        string userName;  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misin?", "Silmek istediğine !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                if (currentUser != userName)
                {
                    query = "delete from users where kullaniciAdı='" + userName + "'";  
                    fn.setData(query, "Kullanıcı Kaydı Silindi.");
                }
                else
                {
                    MessageBox.Show("silmeye çalışıyorsun \n Kendi Profilini.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                }
            }
        }
    }
}
