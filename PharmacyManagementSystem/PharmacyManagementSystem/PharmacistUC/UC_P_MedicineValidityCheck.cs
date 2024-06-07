using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void cmbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCheck.SelectedIndex == 0)
            {
                query = "select * from medic where sonTarih>=getdate()";
                setDataGridView(query, "Geçerli İlaçlar", Color.Black);

            }
            else if (cmbCheck.SelectedIndex == 1)
            {
                query = "select * from medic where sonTarih<= getdate()";
                setDataGridView(query, "Süresi dolmuş ilaçlar", Color.Red);
            }
            else if (cmbCheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                setDataGridView(query, "", Color.Black);
            }
        }


        private void setDataGridView(String query,string labelName,Color col)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            lblSet.Text = labelName;
            lblSet.ForeColor = col; 
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            lblSet.Text = "";  
        }
    }
}
