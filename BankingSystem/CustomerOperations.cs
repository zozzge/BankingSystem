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
    public partial class frmCustomerOperations : Form
    {
        public frmCustomerOperations()
        {
            InitializeComponent();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerType frmCustomerType = new frmCustomerType();
            frmCustomerType.ShowDialog();


        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

            if (gvCustomers.SelectedRows.Count > 0)
            {
                frmEditingCustomer frmEditingCustomer = new frmEditingCustomer();

                string customerId = gvCustomers.SelectedRows[0].Cells[0].Value.ToString();
                
                frmEditingCustomer.LoadCustomer(Convert.ToInt32(customerId));

                frmEditingCustomer.ShowDialog();
            }

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = gvCustomers.SelectedRows[0];
                    string customerId = selectedRow.Cells[0].Value.ToString();

                    
                    string ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Customers WHERE id = @id";
                        
                         using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                         {
                             command.Parameters.AddWithValue("@id", customerId);
                             command.ExecuteNonQuery();

                            gvCustomers.Rows.Remove(selectedRow);

                            MessageBox.Show("Customer deleted from the database", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
                         }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvCustomers.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id,first_name, last_name, id_no,COALESCE(tax_id_no, ''),corporate_name,owner_firstName,owner_lastName, phone_num from customers " +
                                "where (first_name like '%" + tbCustomerName.Text + "%') or " +
                                "      (last_name like '%" + tbCustomerName.Text + "%') or " +
                                "      (id_no like '%" + tbCustomerName.Text + "%') or " +
                                "      (tax_id_no like '%" + tbCustomerName.Text + "%') or " +
                                "      (corporate_name like '%" + tbCustomerName.Text + "%') or " +
                                "      (owner_firstName like '%" + tbCustomerName.Text + "%') or " +
                                "      (owner_lastName like '%" + tbCustomerName.Text + "%') or " +
                                "      (phone_num like '%" + tbCustomerName.Text + "%')";

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();

            gvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!reader.HasRows)
                MessageBox.Show("No customer found!");

            else
            {
                int rowIndex = 0;

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
                    rowIndex++;
                }
            }
            reader.Close();

        }

        private void tbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        
    }



}
