using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dunja
{
    public partial class Medicines : Form
    {
        private string connectionString = "Data Source =.\\SQLEXPRESS;Initial Catalog = dunja; Integrated Security = True";
        int medicineID;
        string link;
        public Medicines()
        {
            InitializeComponent();
            PopulateDgvMedicine();
        }

        private void PopulateDgvMedicine()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM medicine", sqlConn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvMedicine.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK);
                return;
            }
        }

       
        private void DgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgvMedicine.Rows[e.RowIndex].Cells["tbcName"].Value.ToString();
                txtDescription.Text = dgvMedicine.Rows[e.RowIndex].Cells["tbcDescription"].Value.ToString();
                txtQuarantine.Text = dgvMedicine.Rows[e.RowIndex].Cells["tbcQuarantine"].Value.ToString();
                txtStock.Text = dgvMedicine.Rows[e.RowIndex].Cells["tbcStock"].Value.ToString();
                link = dgvMedicine.Rows[e.RowIndex].Cells["tbcLink"].Value.ToString();
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            medicineID = 0;

            dgvMedicine.Enabled = false;

            btnUpdate.Visible = false;
            btnInsert.Visible = false;
            btnSave.Visible = true;

            txtName.Text = "";
            txtDescription.Text = "";
            txtQuarantine.Text = "";
            txtStock.Text = "";

            txtName.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtQuarantine.ReadOnly = false;
            txtStock.ReadOnly = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand("MedicineAddOrEdit", sqlConn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@medicineID", medicineID);
                    sqlCommand.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@quarantine", Convert.ToInt32(txtQuarantine.Text.Trim()));
                    sqlCommand.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text.Trim()));
                    sqlCommand.Parameters.AddWithValue("@link", DBNull.Value);

                    sqlCommand.ExecuteNonQuery();

                    dgvMedicine.Enabled = true;
                    PopulateDgvMedicine();
                    txtName.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    txtQuarantine.ReadOnly = true;
                    txtStock.ReadOnly = true;
                    btnUpdate.Visible = true;
                    btnInsert.Visible = true;
                    btnSave.Visible = false;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void LinkPDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(link))
            {
                Process.Start(link);
            }
            else
                return;
         //   Process.Start(@"C:\Users\beschtia\Desktop\dunja\Enroxil_5__injekcije_uputa_23_10_2018.pdf");
        }
    }
}
