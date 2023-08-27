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
    public partial class frmAccountOperations : Form
    {
        public frmAccountOperations()
        {
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            int customerId = 0;

            if (grdAccOpCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdAccOpCustomers.SelectedRows[0];
                customerId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Please select a customer from the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount._customerId = customerId;
            frmCreateAccount.ShowDialog();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CustomerOperations.SearchCustomer(grdAccOpCustomers, tbCustomerName.Text);
        }

        private void tbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchAccount.PerformClick();
        }

        public string EmptyIfNull(SqlDataReader reader, int columnIndex)
        {
            if (reader.IsDBNull(columnIndex))
                return "";
            return reader.GetString(columnIndex);
        }

        private void grdAccOpCustomers_SelectionChanged(object sender, EventArgs e)
         {
            
            if (grdAccOpCustomers.SelectedRows.Count > 0)
            {
                grdAccOpAccount.Rows.Clear();

                string selectedCustomerId = grdAccOpCustomers.SelectedRows[0].Cells[0].Value.ToString();

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
                    grdAccOpAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(grdAccOpAccount);

                            row.Cells[0].Value = reader.GetInt32(0); 
                            row.Cells[1].Value = reader.GetInt32(1);
                            row.Cells[2].Value = EmptyIfNull(reader, 2);
                            row.Cells[3].Value = reader.GetString(3);
                            row.Cells[4].Value = reader.GetDecimal(4); 
                            row.Cells[5].Value = reader.GetDateTime(5); 

                            grdAccOpAccount.Rows.Add(row);
                        }
                    }
                    reader.Close();
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = grdAccOpAccount.SelectedRows[0];
                    string customerId = selectedRow.Cells[0].Value.ToString();


                    string ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM accounts WHERE id = @id";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", customerId);
                            command.ExecuteNonQuery();

                            grdAccOpAccount.Rows.Remove(selectedRow);

                            MessageBox.Show("Account deleted from the database", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
