using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingSystem
{
    class CustomerOperations
    {

        private static int _customerId;

        public static void SearchCustomer(DataGridView gvCustomers, string searchText)
        {

            gvCustomers.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id,first_name, last_name, id_no,COALESCE(tax_id_no, ''),corporate_name,owner_firstName,owner_lastName, phone_num from customers " +
                                "where (first_name like '%" + searchText + "%') or " +
                                "      (last_name like '%" + searchText + "%') or " +
                                "      (id_no like '%" + searchText + "%') or " +
                                "      (tax_id_no like '%" + searchText + "%') or " +
                                "      (corporate_name like '%" + searchText + "%') or " +
                                "      (owner_firstName like '%" + searchText + "%') or " +
                                "      (owner_lastName like '%" + searchText + "%') or " +
                                "      (phone_num like '%" + searchText + "%')";

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();

            gvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!reader.HasRows)
                MessageBox.Show("No customer found!");

            else
            {
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(gvCustomers);

                    row.Cells[0].Value = reader.GetValue(0);
                    row.Cells[1].Value = reader.GetValue(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);

                    gvCustomers.Rows.Add(row);
                }
            }
            reader.Close();
        }

        public static void FillCurrencyComboBox(ComboBox cmbIn)
        {

            cmbIn.Items.Clear();

            cmbIn.DisplayMember = "Text";
            cmbIn.ValueMember = "Value";

            string ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string insertQuery = "select id, symbol from currency";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmbIn.Items.Add(new { Text = reader.GetString(1), Value = reader.GetInt32(0) });
                        }
                    }
                    reader.Close();
                }
            }

            cmbIn.SelectedIndex = 0;
        }

        public static void NewAccount(int customerId, int accountType, string accountName, int currency_id, decimal amount)
        {
            string ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                _customerId = customerId;

                string insertQuery = "INSERT INTO accounts (customer_id,account_type,account_name, currency_id, amount, creation_time) " +
                                     "VALUES (@customer_id,@account_type,@account_name, @currency_id, @amount, @creation_time)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_id", customerId);
                    cmd.Parameters.AddWithValue("@account_type", accountType);
                    cmd.Parameters.AddWithValue("@account_name", accountName);
                    cmd.Parameters.AddWithValue("@currency_id", currency_id);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@creation_time", DateTime.Now);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Beklemediğim bi sorun oluştu! O sorunda şudur efendim -> " + e.Message);
                    }

                    MessageBox.Show("New account created for customer", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        public static void InsertTransaction(Globals.TransactionType transactionType, int customerId, int accountId, decimal amount)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
            connection.Open();

            decimal currentAmount = 0;
            using (SqlCommand selectCmd = new SqlCommand("select amount from accounts where id=@id ", connection))
            {


                selectCmd.Parameters.AddWithValue("@id", accountId);

                SqlDataReader reader = selectCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    currentAmount = reader.GetDecimal(0);
                }

                switch (transactionType)
                {
                    case Globals.TransactionType.ttWithdrawl:
                        currentAmount -= amount;
                        break;
                    case Globals.TransactionType.ttLodge:
                        currentAmount += amount;
                        break;
                }

                reader.Close();



                SqlTransaction transaction = connection.BeginTransaction("myTransaction");

                try
                {
                    string updateQuery = "UPDATE accounts SET amount = @prmAmount where id=@prmId";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, connection, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@prmId", accountId);
                        cmdUpdate.Parameters.AddWithValue("@prmAmount", currentAmount);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    string insertQuery = "INSERT INTO account_transactions (" +
                        " customer_id, account_id, amount_credit, amount_loan, transaction_type, transaction_time " +
                        ") VALUES (" +
                        "  @customer_id, @account_id, @amount_credit, @amount_loan, @transaction_type, @transaction_time " +
                        ")";

                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@customer_id", customerId);
                        cmdInsert.Parameters.AddWithValue("@account_id", accountId);

                        switch (transactionType)
                        {
                            case Globals.TransactionType.ttWithdrawl:
                                cmdInsert.Parameters.AddWithValue("@amount_credit", 0);
                                cmdInsert.Parameters.AddWithValue("@amount_loan", amount);
                                break;
                            case Globals.TransactionType.ttLodge:
                                cmdInsert.Parameters.AddWithValue("@amount_credit", amount);
                                cmdInsert.Parameters.AddWithValue("@amount_loan", 0);
                                break;
                        }

                        cmdInsert.Parameters.AddWithValue("@transaction_type", transactionType);
                        cmdInsert.Parameters.AddWithValue("@transaction_time", DateTime.Now);

                        cmdInsert.ExecuteNonQuery();
                    }

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Transaciton cannot be inserted! (" + ex.Message + ")");
                }

            }
        }

        public static void InsertMoneyTransfer(int sourceAccountId, int sourceCustomerId, int targetAccountId, int targetCustomerId, decimal amount)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction("myTransaction");

            try
            {
                //updating source account's amount

                decimal currentAmount = 0;
                using (SqlCommand selectCmd = new SqlCommand("select amount from accounts where id=@id ", connection))
                {


                    selectCmd.Parameters.AddWithValue("@id", sourceAccountId);

                    SqlDataReader reader = selectCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        currentAmount = reader.GetDecimal(0);
                        currentAmount -= amount;
                        reader.Close();
                    }

                    string updateQuery = "UPDATE accounts SET amount = @prmAmount where id=@prmId";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, connection, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@prmId", sourceAccountId);
                        cmdUpdate.Parameters.AddWithValue("@prmAmount", currentAmount);
                        cmdUpdate.ExecuteNonQuery();
                    }


                }

                //updating target account's amount

                using (SqlCommand selectCmd = new SqlCommand("select amount from accounts where id=@id ", connection))
                {


                    selectCmd.Parameters.AddWithValue("@id", targetAccountId);

                    SqlDataReader reader = selectCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        currentAmount = reader.GetDecimal(0);
                        currentAmount += amount;
                        reader.Close();
                    }

                    string updateQuery = "UPDATE accounts SET amount = @prmAmount where id=@prmId";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, connection, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@prmId", targetAccountId);
                        cmdUpdate.Parameters.AddWithValue("@prmAmount", currentAmount);
                        cmdUpdate.ExecuteNonQuery();
                    }


                }

                //inserting transaction as loan to source account

                string insertQuery = "INSERT INTO account_transactions (" +
                            " customer_id, account_id, amount_credit, amount_loan, transaction_type, transaction_time " +
                            ") VALUES (" +
                            "  @customer_id, @account_id, @amount_credit, @amount_loan, @transaction_type, @transaction_time " +
                            ")";

                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection, transaction))
                {
                    cmdInsert.Parameters.AddWithValue("@customer_id", sourceCustomerId);
                    cmdInsert.Parameters.AddWithValue("@account_id", sourceAccountId);
                    cmdInsert.Parameters.AddWithValue("@amount_credit", 0);
                    cmdInsert.Parameters.AddWithValue("@amount_loan", amount);
                    cmdInsert.Parameters.AddWithValue("@transaction_type", 3);
                    cmdInsert.Parameters.AddWithValue("@transaction_time", DateTime.Now);

                    cmdInsert.ExecuteNonQuery();

                }

                //inserting transaction as credit to target account

                string insertQuery2 = "INSERT INTO account_transactions (" +
                            " customer_id, account_id, amount_credit, amount_loan, transaction_type, transaction_time " +
                            ") VALUES (" +
                            "  @customer_id, @account_id, @amount_credit, @amount_loan, @transaction_type, @transaction_time " +
                            ")";

                using (SqlCommand cmdInsert = new SqlCommand(insertQuery2, connection, transaction))
                {
                    cmdInsert.Parameters.AddWithValue("@customer_id", targetCustomerId);
                    cmdInsert.Parameters.AddWithValue("@account_id", targetAccountId);
                    cmdInsert.Parameters.AddWithValue("@amount_credit", amount);
                    cmdInsert.Parameters.AddWithValue("@amount_loan", 0);
                    cmdInsert.Parameters.AddWithValue("@transaction_type", 3);
                    cmdInsert.Parameters.AddWithValue("@transaction_time", DateTime.Now);

                    cmdInsert.ExecuteNonQuery();

                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Transaciton cannot be inserted! (" + ex.Message + ")");
            }



        }

    }
}

