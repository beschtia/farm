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
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source =.\\SQLEXPRESS;Initial Catalog = dunja; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        void PopulateBreedComboBox()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM breed", sqlConn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbBreed.ValueMember = "BreedID";
                cbBreed.DisplayMember = "Breed";                
                cbBreed.DataSource = dt;
            }
        }

        void PopulateDataGridView()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM cattle", sqlConn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvCattle.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateBreedComboBox();
            PopulateDataGridView();
        }

        private void DgvCattle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvCattle.CurrentRow != null)
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    DataGridViewRow dgvRow = dgvCattle.CurrentRow;
                    SqlCommand sqlCommand = new SqlCommand("CattleAddOrEdit", sqlConn);
                    
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtCattleID"].Value == DBNull.Value)
                    {
                        sqlCommand.Parameters.AddWithValue("@CattleID", "0");
                    }
                    else
                        sqlCommand.Parameters.AddWithValue("@CattleID", Convert.ToInt32(dgvRow.Cells["txtCattleID"].Value));
                    
                    sqlCommand.Parameters.AddWithValue("@Arrival_date", dgvRow.Cells["txtArrivalDate"].Value == DBNull.Value ? DateTime.Now : StringToDate(dgvRow.Cells["txtArrivalDate"].Value.ToString()));
                    //sqlCommand.Parameters.AddWithValue("@Buy_price", Convert.ToDecimal(dgvRow.Cells["txtBuyPrice"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtBuyPrice"].Value.ToString()));
                    sqlCommand.Parameters.AddWithValue("@Buy_price", dgvRow.Cells["txtBuyPrice"].Value != DBNull.Value ? Convert.ToDecimal(dgvRow.Cells["txtBuyPrice"].Value) : dgvRow.Cells["txtBuyPrice"].Value);
                    sqlCommand.Parameters.AddWithValue("@Life_number", dgvRow.Cells["txtLifeNumber"].Value.ToString());
                    sqlCommand.Parameters.AddWithValue("@Sex", dgvRow.Cells["txtSex"].Value.ToString().ToUpper());
                    //sqlCommand.Parameters.AddWithValue("@BreedID", dgvRow.Cells["cbBreed"].Value == DBNull.Value ? "M" : dgvRow.Cells["cbBreed"].Value.ToString());
                    sqlCommand.Parameters.AddWithValue("@BreedID", dgvRow.Cells["cbBreed"].Value != DBNull.Value ? dgvRow.Cells["cbBreed"].Value.ToString() : dgvRow.Cells["cbBreed"].Value);
                    //  sqlCommand.Parameters.AddWithValue("@Input_weight", Convert.ToInt32(dgvRow.Cells["txtInputWeight"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtInputWeight"].Value.ToString()));
                    //   sqlCommand.Parameters.AddWithValue("@Arrival_weight", Convert.ToInt32(dgvRow.Cells["txtArrivalWeight"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtArrivalWeight"].Value.ToString()));
                    sqlCommand.Parameters.AddWithValue("@Arrival_weight", dgvRow.Cells["txtArrivalWeight"].Value != DBNull.Value ? Convert.ToInt32(dgvRow.Cells["txtArrivalWeight"].Value) : dgvRow.Cells["txtArrivalWeight"].Value);
                    sqlCommand.Parameters.AddWithValue("@Input_weight", dgvRow.Cells["txtInputWeight"].Value != DBNull.Value ? Convert.ToInt32(dgvRow.Cells["txtInputWeight"].Value) : dgvRow.Cells["txtInputWeight"].Value);
                    sqlCommand.ExecuteNonQuery();
                    PopulateDataGridView();
                    
                }
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

       
        private void DgvCattle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowDateOnly;
            e.Control.KeyPress -= AllowDecimalOnly;
            e.Control.KeyPress -= AllowMFOnly;
            e.Control.KeyPress -= AllowNumbersOnly;

            if (dgvCattle.CurrentCell.ColumnIndex == 1)
            {
                e.Control.KeyPress += AllowDateOnly;
            }
            if (dgvCattle.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += AllowDecimalOnly;
            }
            if (dgvCattle.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress += AllowMFOnly;
            }
            if (dgvCattle.CurrentCell.ColumnIndex == 6 || dgvCattle.CurrentCell.ColumnIndex == 7)
            {
                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void AllowDateOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '.'))
            {
                e.Handled = true;
            }
        }

        private void AllowDecimalOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, ','))
                e.Handled = true;
        }

        private void AllowMFOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.Equals(e.KeyChar, 'M') && !char.Equals(e.KeyChar, 'm') && !char.Equals(e.KeyChar, 'F') && !char.Equals(e.KeyChar, 'f'))
                e.Handled = true;
        }
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void DgvCattle_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvCattle.CurrentRow.Cells["txtCattleID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Želite li obrisati govedo iz baze?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlConn = new SqlConnection(connectionString))
                    {
                        sqlConn.Open();
                        SqlCommand sqlCommand = new SqlCommand("CattleDeleteById", sqlConn);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@CattleID", Convert.ToInt32(dgvCattle.CurrentRow.Cells["txtCattleID"].Value));
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void DgvCattle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewCell cell = dgvCattle.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if (dgvCattle.Columns[e.ColumnIndex].Name == "txtBuyPrice")
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !Decimal.TryParse(e.FormattedValue.ToString(), out decimal price))
                {
                    dgvCattle.Rows[e.RowIndex].ErrorText = "Ispravite cijenu";
                    e.Cancel = true;
                }
            }

            if (dgvCattle.Columns[e.ColumnIndex].Name == "txtArrivalDate")
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !DateTime.TryParse(e.FormattedValue.ToString(), out DateTime date))
                {                   
                    dgvCattle.Rows[e.RowIndex].ErrorText = "Ispravite format datuma: dan.mjesec.godina";
                    e.Cancel = true;                    
                }
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && DateTime.TryParse(e.FormattedValue.ToString(), out DateTime dt))
                {
                    if (dt.Year < 2000)
                    {
                        dgvCattle.Rows[e.RowIndex].ErrorText = "Ispravite godinu.";
                        e.Cancel = true;
                    }
                    else if (dt > DateTime.Today)
                    {
                        dgvCattle.Rows[e.RowIndex].ErrorText = "Ispravite datum";
                        e.Cancel = true;
                    }
                }
                
            }
        }

        private void DgvCattle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.RowIndex<dgvCattle.Rows.Count-1)
            {
                var lifeNumber = dgvCattle[3, e.RowIndex].Value.ToString();
                CattleDetails cattleDetails = new CattleDetails(lifeNumber);
                cattleDetails.ShowDialog();
            }
            
        }

        private void BtnMedicine_Click(object sender, EventArgs e)
        {
            Medicines medicines = new Medicines();
            medicines.ShowDialog();
        }
    }
}
