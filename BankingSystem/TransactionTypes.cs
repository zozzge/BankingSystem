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

    public partial class frmTransactionTypes : Form
    {
        public int customerID;
        public int accountID;
        public int sourceCustomerID;
        public int sourceAccountID;
        public int targetCustomerID;
        public int targetAccountID;

        public frmTransactionTypes()
        {
            InitializeComponent();
        }

        public string EmptyIfNull(SqlDataReader reader, int columnIndex)
        {
            if (reader.IsDBNull(columnIndex))
                return "";
            return reader.GetString(columnIndex);
        }

        private void cmbTransactions_SelectedValueChanged(object sender, EventArgs e)
        {
            tabTransfers.TabPages.Clear();
            tabTransfers.Show();

            switch (cmbTransactions.SelectedIndex)
            {
                case 0:
                    tabTransfers.TabPages.Add(tabLodgement);
                    tabLodgement.Show();
                    break;
                case 1:
                    tabTransfers.TabPages.Add(tabWithdrawal);
                    tabWithdrawal.Show();
                    break;
                case 2:
                    tabTransfers.TabPages.Add(tab2Customers);
                    tab2Customers.Show();

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
                    conn.Open();

                    //id=@id,first_name=@first_name,last_name=@last_name,id_no=@id_no,phone_num=@phone_num

                    using (SqlCommand selectCmd = new SqlCommand("select id, first_name, last_name, id_no, phone_num from customers where id <> @id", conn))
                    {
                        selectCmd.Parameters.AddWithValue("@id", sourceCustomerID);
                        SqlDataReader reader = selectCmd.ExecuteReader();

                        grdCustomers2Customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(grdCustomers2Customers);

                                row.Cells[0].Value = reader.GetInt32(0);
                                row.Cells[1].Value = reader.GetString(1);
                                row.Cells[2].Value = reader.GetString(2);
                                row.Cells[3].Value = EmptyIfNull(reader, 3);
                                row.Cells[4].Value = EmptyIfNull(reader, 4);

                                grdCustomers2Customers.Rows.Add(row);
                            }
                        }

                        reader.Close();
                    }

                    break;
                case 3:
                    tabTransfers.TabPages.Add(tab2Accounts);
                    tab2Accounts.Show();

                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
                    connection.Open();

                    using (SqlCommand selectCmd = new SqlCommand("select id,account_type,account_name,currency_id,amount,creation_time from accounts where id<>@id ", connection))
                    {
                        selectCmd.Parameters.AddWithValue("@id", sourceAccountID);
                        SqlDataReader reader = selectCmd.ExecuteReader();

                        grdAccounts2Accounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(grdAccounts2Accounts);

                                row.Cells[0].Value = reader.GetInt32(0);
                                row.Cells[1].Value = reader.GetInt32(1);
                                row.Cells[2].Value = EmptyIfNull(reader, 2);
                                row.Cells[3].Value = reader.GetInt32(3);
                                row.Cells[4].Value = reader.GetDecimal(4);
                                row.Cells[5].Value = reader.GetDateTime(5);

                                grdAccounts2Accounts.Rows.Add(row);
                            }
                        }
                        reader.Close();

                    }

                    break;
            }
            cmbTransactions.Enabled = false;
        }

        private void btnLodge_Click(object sender, EventArgs e)
        {
            
            try
            {
                CustomerOperations.InsertTransaction(Globals.TransactionType.ttLodge, customerID, accountID, Convert.ToDecimal(txtLodgeAmount.Text));
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerOperations.InsertTransaction(Globals.TransactionType.ttWithdrawl, customerID, accountID, Convert.ToDecimal(txtWithdrawlAmount.Text));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnTransfer2Customers_Click(object sender, EventArgs e)
        {
            string targetCustomerID = grdCustomers2Customers.SelectedRows[0].Cells[0].Value.ToString();
            CustomerOperations.InsertMoneyTransfer(sourceAccountID,sourceCustomerID,targetAccountID,Convert.ToInt32(targetCustomerID), Convert.ToDecimal(txtAmount2Customers.Text));
        }

        private void btnTransfer2Accounts_Click(object sender, EventArgs e)
        {
            
            string targetAccountID = grdAccounts2Accounts.SelectedRows[0].Cells[0].Value.ToString();
            CustomerOperations.InsertMoneyTransfer(sourceAccountID, sourceCustomerID, Convert.ToInt32(targetAccountID), targetCustomerID, Convert.ToDecimal(txtAmount2Customers.Text));

        }
    }
}
