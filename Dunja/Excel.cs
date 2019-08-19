using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dunja
{
    public partial class Excel : Form
    {
        DataTable dtSheets;
        DataTable dtExcel=new DataTable();

        private string sqlConnectionString = "Data Source =.\\SQLEXPRESS;Initial Catalog = dunja; Integrated Security = True";
        String sheet, date;

        public Excel()
        {
            InitializeComponent();
            dtExcel.Columns.Add("ArrivalDate");
            dtExcel.Columns.Add("LifeNumber", typeof(string));
            dtExcel.Columns.Add("Sex", typeof(char));
            dtExcel.Columns.Add("BreedID", typeof(char));
            dtExcel.Columns.Add("InputWeight", typeof(int));
            dtExcel.Columns.Add("ArrivalWeight", typeof(int));
            dtExcel.Columns.Add("BuyPrice", typeof(decimal));
            dtExcel.Columns.Add("Total", typeof(decimal));
            dtExcel.Columns["Total"].Expression = "BuyPrice*InputWeight";
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excell|*.xls;*.xlsx;"
            };
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Abort) return;
            if (dr == DialogResult.Cancel) return;
            txtPath.Text = ofd.FileName.ToString();

            dtSheets = SheetsInExcel(txtPath.Text);
            lbSheets.DisplayMember = "sheet";
            lbSheets.ValueMember = "sheet";
            lbSheets.DataSource = dtSheets;
            PopulateBreedComboBox();
        }

        private DataTable SheetsInExcel(string filePath)
        {
            pictureBox1.Visible = true;
            string connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=NO;IMEX=1""", filePath);
            DataTable dt = new DataTable();
            dt.Columns.Add("sheet");
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                foreach (DataRow drSheet in dtSheet.Rows)
                {
                    if (drSheet["TABLE_NAME"].ToString().Contains("$") && !drSheet["TABLE_NAME"].ToString().Contains("Filter"))//checks whether row contains '_xlnm#_FilterDatabase' or sheet name(i.e. sheet name always ends with $ sign)
                    {
                        DataRow newRow = dt.NewRow();
                        newRow["sheet"] = drSheet["TABLE_NAME"].ToString().Remove(0, 1).TrimEnd('\'');
                        dt.Rows.Add(newRow);
                    }
                }
                dtSheet.Clear();
                dtSheet.AcceptChanges();
            }
            pictureBox1.Visible = false;
            return dt;
        }

        private void PopulateBreedComboBox()
        {
            using (SqlConnection sqlConn = new SqlConnection(sqlConnectionString))
            {
                sqlConn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM breed", sqlConn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbBreed.ValueMember = "BreedID";
                cbBreed.DisplayMember = "Breed";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                cbBreed.DataSource = dt;
            }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, ','))
                e.Handled = true;
        }
        
        private void BtnReadExcel_Click(object sender, EventArgs e)
        {
            dtExcel.Clear();
            dtExcel.AcceptChanges();
            date = dateTimePicker1.Value.ToShortDateString();
            sheet = lbSheets.SelectedValue.ToString();
            var breed = cbBreed.SelectedValue.ToString();
            

            if (!Decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Netočan unos ulazne cijene.", "Upozorenje", MessageBoxButtons.OK);
                txtPrice.Focus();
                return;
            }
           
            if (breed == "0")
            {
                MessageBox.Show("Odaberite pasminu.", "Upozorenje", MessageBoxButtons.OK);
                cbBreed.Focus();
            }
            else
            {
                InsertExcelRecords(txtPath.Text, sheet, date, breed, price);
                btnUpload.Enabled = true;
            }
        }

        private void InsertExcelRecords(string filePath, string sheet, string date, string breed, decimal price)
        {
            pictureBox1.Visible = true;
            try
            {
                string excelConnectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=NO;IMEX=1""", filePath);
                string Query = string.Format("Select F2, F3, F4, F5, F6 FROM [{0}]", sheet);
                DataTable dt = new DataTable();


                using (OleDbConnection conn = new OleDbConnection(excelConnectionString))
                {
                    OleDbCommand odc = new OleDbCommand(Query, conn);
                    conn.Open();
                    OleDbDataAdapter oda = new OleDbDataAdapter(odc);
                    oda.Fill(dt);
                }

                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    if (dt.Rows[i]["F4"] == DBNull.Value || dt.Rows[i]["F5"] == DBNull.Value)
                    {
                        dt.Rows[i].Delete();
                    }
                }
                dt.AcceptChanges();

               // DataTable dtExcel = new DataTable();
                //dtExcel.Columns.Add("ArrivalDate");
                //dtExcel.Columns.Add("LifeNumber");
                //dtExcel.Columns.Add("Sex");
                //dtExcel.Columns.Add("BreedID");
                //dtExcel.Columns.Add("InputWeight", typeof(int));
                //dtExcel.Columns.Add("ArrivalWeight");
                //dtExcel.Columns.Add("BuyPrice", typeof(decimal));
                //dtExcel.Columns.Add("Total", typeof(decimal));
                //dtExcel.Columns["Total"].Expression = "BuyPrice*InputWeight";
                
                foreach (DataRow row in dt.Rows)
                {
                    DataRow newRow = dtExcel.NewRow();
                    newRow["LifeNumber"] = FixLenght(row["F2"].ToString(), 3) +
                        FixLenght(row["F3"].ToString(), 5) +
                        FixLenght(row["F4"].ToString(), 4);
                    newRow["Sex"] = row["F5"];
                    newRow["InputWeight"] = row["F6"];
                    newRow["ArrivalDate"] = date;
                    newRow["BreedID"] = breed;
                    newRow["BuyPrice"] = price;
                    dtExcel.Rows.Add(newRow);
                }

                dt.Clear();
                dt.AcceptChanges();

                dgv.DataSource = dtExcel;

                pictureBox1.Visible = false;
                MessageBox.Show("Data has been Imported successfully.", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                pictureBox1.Visible = false;
                MessageBox.Show(string.Format("Data has not been Imported due to :{0}", ex.Message), "Not Imported", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            
        }

        private String FixLenght(String value, int lenght)
        {
            if (value.Length < lenght)
            {
                while (value.Length < lenght)
                    value = value.Insert(0, "0");
            }
            return value;
        }

        private void Dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowDecimalOnly;
            e.Control.KeyPress -= AllowNumbersOnly;

            if (dgv.CurrentCell.ColumnIndex == 6)
            {
                e.Control.KeyPress += AllowDecimalOnly;
            }
            if (dgv.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void AllowDecimalOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, ','))
                e.Handled = true;
        }

        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            decimal totalCost = (decimal)dtExcel.Compute("SUM(Total)", string.Empty);
            int noCattle = dtExcel.Rows.Count;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(sqlConnectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand("PurchaseAdd", sqlConn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@date", StringToDate(date));
                    sqlCommand.Parameters.AddWithValue("@sheet", sheet);
                    sqlCommand.Parameters.AddWithValue("@noCattle", noCattle);
                    sqlCommand.Parameters.AddWithValue("@total", totalCost);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lista " + sheet + " je već unešena, odaberite drugu. Tip: " + ex.Message, "Upozorenje", MessageBoxButtons.OK);
                if (lbSheets.Items.Count > 0)
                {
                    dtSheets.Rows.RemoveAt(lbSheets.SelectedIndex);
                    dtSheets.AcceptChanges();
                    dtExcel.Clear();
                    dtExcel.AcceptChanges();
                }
                btnUpload.Enabled = false;
                return;
            }
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(sqlConnectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand("CattleExcelAdd", sqlConn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    foreach (DataRow row in dtExcel.Rows)
                    {
                        sqlCommand.Parameters.AddWithValue("@Arrival_date", StringToDate(row["ArrivalDate"].ToString()));
                        sqlCommand.Parameters.AddWithValue("@Buy_price", row["BuyPrice"]);
                        sqlCommand.Parameters.AddWithValue("@Life_number", row["LifeNumber"]);
                        sqlCommand.Parameters.AddWithValue("@Sex", row["Sex"]);
                        sqlCommand.Parameters.AddWithValue("@BreedID", row["BreedID"]);
                        sqlCommand.Parameters.AddWithValue("@Arrival_weight", row["ArrivalWeight"]);
                        sqlCommand.Parameters.AddWithValue("@Input_weight", row["InputWeight"]);
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Parameters.Clear();                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK);
                btnUpload.Enabled = false;
                return;
            }
            if (lbSheets.Items.Count > 0)
            {
                dtSheets.Rows.RemoveAt(lbSheets.SelectedIndex);
                dtSheets.AcceptChanges();
                dtExcel.Clear();
                dtExcel.AcceptChanges();
            }
            btnUpload.Enabled = false;
            
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
