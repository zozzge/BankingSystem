using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankingSystem
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void btnSearchTrans_Click(object sender, EventArgs e)
        {
            //grdCustomersTrans.SelectionChanged -= grdCustomersTrans_SelectionChanged;

            CustomerOperations.SearchCustomer(grdCustomersTrans, txtNameTransactions.Text);

            //grdAccountsTrans.ClearSelection();
            //grdCustomersTrans.SelectionChanged += grdCustomersTrans_SelectionChanged;

        }

        public string EmptyIfNull(SqlDataReader reader, int columnIndex)
        {
            if (reader.IsDBNull(columnIndex))
                return "";
            return reader.GetString(columnIndex);
        }

        private void grdCustomersTrans_SelectionChanged(object sender, EventArgs e)
        {

            if (grdCustomersTrans.SelectedRows.Count > 0)
            {

                grdAccountsTrans.Rows.Clear();

                string selectedCustomerId = grdCustomersTrans.SelectedRows[0].Cells[0].Value.ToString();

                string ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

                
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select a.id, a.account_type , a.account_name , c.symbol, a.amount, a.creation_time  " +
                                      "from accounts a " +
                                      "left join currency c on c.id = a.currency_id " +
                                      "where a.customer_id = @id";

                    cmd.Parameters.AddWithValue("@id", selectedCustomerId);
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();
                    grdAccountsTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(grdAccountsTrans);

                            row.Cells[0].Value = reader.GetInt32(0);
                            row.Cells[1].Value = reader.GetInt32(1);
                            row.Cells[2].Value = EmptyIfNull(reader, 2);
                            row.Cells[3].Value = reader.GetString(3);
                            row.Cells[4].Value = reader.GetDecimal(4);
                            row.Cells[5].Value = reader.GetDateTime(5);

                            grdAccountsTrans.Rows.Add(row);
                        }
                    }
                    reader.Close();
                }

                grdAccountsTrans.ClearSelection();
                
            }
        }

       

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            string customerId = grdCustomersTrans.SelectedRows[0].Cells[0].Value.ToString();
            string accountId = grdAccountsTrans.SelectedRows[0].Cells[0].Value.ToString();

            string sourceCustomerId = grdCustomersTrans.SelectedRows[0].Cells[0].Value.ToString();
            string sourceAccountId = grdAccountsTrans.SelectedRows[0].Cells[0].Value.ToString();

            frmTransactionTypes frmTransaction = new frmTransactionTypes();
            frmTransaction.customerID = Convert.ToInt32(customerId);
            frmTransaction.accountID = Convert.ToInt32(accountId);
            frmTransaction.sourceCustomerID = Convert.ToInt32(sourceCustomerId);
            frmTransaction.sourceAccountID = Convert.ToInt32(sourceAccountId);
            frmTransaction.ShowDialog();

            
        }
    }
}
