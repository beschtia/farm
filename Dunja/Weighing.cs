using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dunja
{
    public partial class Weighing : Form
    {
        String lifeNumber;
        private string connectionString = "Data Source =.\\SQLEXPRESS;Initial Catalog = dunja; Integrated Security = True";

        public Weighing()
        {
            InitializeComponent();            
        }

        public Weighing(String lifeNumber)
        {
            InitializeComponent();
            this.lifeNumber = lifeNumber;
            txtLifeNumber.Text = lifeNumber;
            txtLifeNumber.ReadOnly = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lifeNumber = txtLifeNumber.Text.Trim();
            var date = dtpDate.Value.ToShortDateString();
            if (!int.TryParse(txtWeight.Text.Trim(), out int weight))
            {
                MessageBox.Show("Unesite cjelobrojnu vrijednost", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return;
            }

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand("WeighingCattleAdd", sqlConn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@weightDate", StringToDate(date));
                    sqlCommand.Parameters.AddWithValue("@weight", weight);
                    sqlCommand.Parameters.AddWithValue("@lifenumber", lifeNumber);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBase", MessageBoxButtons.OK);
                return;
            }
            

            this.Close();
        }

        private void TxtWeight_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtWeight.Text.Trim(), out int weight))
            {
                MessageBox.Show("Unesite cjelobrojnu vrijednost", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
            }
            if (weight < 0)
            {
                MessageBox.Show("Vrijednost ne smije biti negativna", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
            }
        }

        private void TxtLifeNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLifeNumber.Text.Trim()))
            {
                MessageBox.Show("Unesite broj markice", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLifeNumber.Focus();
                
            }
        }

        private DateTime StringToDate(String date)
        {
            String[] dateParts = date.Split('.');

            DateTime retDate = new
            DateTime(Convert.ToInt32(dateParts[2]),
            Convert.ToInt32(dateParts[1]),
            Convert.ToInt32(dateParts[0]));
            return retDate;
        }
    }
}
