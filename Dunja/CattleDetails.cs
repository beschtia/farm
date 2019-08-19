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
    public partial class CattleDetails : Form
    {
        String lifeNumber;
        private string connectionString = "Data Source =.\\SQLEXPRESS;Initial Catalog = dunja; Integrated Security = True";
        public CattleDetails(String lifeNumber)
        {
            InitializeComponent();
            this.lifeNumber = lifeNumber;
            PopulateCattle();
            PopulateDgvWeighings();
        }

        private void PopulateDgvWeighings()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("CattleWeighings", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@lifeNumber", lifeNumber);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvWeighings.DataSource = dt;
                chart1.DataSource = dt;
                
            }
        }

        private void PopulateCattle()
        {
            DataTable dt = new DataTable();
            
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("CattleDetailsById", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Life_number", lifeNumber);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);                
                sda.Fill(dt);
            }
            
            DataRow row = dt.Rows[0];
            txtLifeNumber.Text = lifeNumber;
            txtArrivalDate.Text = row[1].ToString().TrimEnd(':','0');
            txtBuyPrice.Text = row[2].ToString();
            txtSex.Text = row[4].ToString();
            txtBreed.Text = row[5].ToString();
            txtInputWeight.Text = row[6].ToString();
            txtArrivalWeight.Text = row[7].ToString();
            txtNoBreedingDays.Text = row[8].ToString();
            txtKalo.Text = row[9].ToString();
        }

        private void BtnVaganje_Click(object sender, EventArgs e)
        {
            Weighing weighing = new Weighing(lifeNumber);
            weighing.ShowDialog();
        }

        private void CattleDetails_Activated(object sender, EventArgs e)
        {
            PopulateDgvWeighings();
        }

        private void DgvWeighings_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {           
           
            if (MessageBox.Show("Želite li obrisati vaganje iz baze?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand("WeighingDelete", sqlConn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@lifeNumber", lifeNumber);
                    sqlCommand.Parameters.AddWithValue("@date", StringToDate(dgvWeighings.CurrentRow.Cells["tbcWeightDate"].Value.ToString()));
                    sqlCommand.ExecuteNonQuery();
                }
            }
            else
                e.Cancel = true;
           
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
