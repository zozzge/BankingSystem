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

    public partial class frmEditingCustomer : Form
    {
        public frmEditingCustomer()
        {
            InitializeComponent();
        }

        public int _customerId;

        private int GetCustomerTypeFromDatabase(int customerId)
        {
            int customerType = -1;

            string connectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT type FROM Customers WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", customerId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerType = reader.GetInt32(0);
                        }
                    }
                }

                connection.Close();

            }

            return customerType;
        }

        public string EmptyIfNull(SqlDataReader reader, int columnIndex)
        {
            if (reader.IsDBNull(columnIndex))
                return "";
            return reader.GetString(columnIndex);
        }

        public void LoadCustomer(int customerId)
        {
            _customerId = customerId;
            int customerType = GetCustomerTypeFromDatabase(_customerId);

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
            connection.Open();

            pagePersonalEditing.Hide();
            tabEditingCustomer.TabPages.Remove(pagePersonalEditing);
            pageCorporateEditing.Hide();
            tabEditingCustomer.TabPages.Remove(pageCorporateEditing);

            if (customerType == 0)
            {
                pagePersonalEditing.Visible = true;
                tabEditingCustomer.TabPages.Add(pagePersonalEditing);
                tabEditingCustomer.SelectedIndex = 0;
            }
            else if (customerType == 1)
            {
                pageCorporateEditing.Visible = true;
                tabEditingCustomer.TabPages.Add(pageCorporateEditing);
                tabEditingCustomer.SelectedIndex = 0;
            }

            using (SqlCommand selectCmd = new SqlCommand("select * from customers where id=@id", connection))
            {
                selectCmd.Parameters.AddWithValue("@id", customerId);

                SqlDataReader reader = selectCmd.ExecuteReader();

                if (customerType == 0 && reader.HasRows)
                {
                    reader.Read();


                    txtNamePersonalEditing.Text = EmptyIfNull(reader, 4);
                    txtLastNamePersonalEditing.Text = EmptyIfNull(reader, 5);
                    txtIdNumPersonalEditing.Text = EmptyIfNull(reader, 2);
                    txtPhoneNumPersonalEditing.Text = EmptyIfNull(reader, 6);
                    txtAddressLine1PersonalEditing.Text = EmptyIfNull(reader, 7);
                    txtAddressLine2PersonalEditing.Text = EmptyIfNull(reader, 8);
                    txtDistrict.Text = EmptyIfNull(reader, 9);
                    txtCityPersonalEditing.Text = EmptyIfNull(reader, 10);
                }

                else if (customerType == 1 && reader.HasRows)
                {
                    reader.Read();


                    txtCorporateNameEditing.Text = EmptyIfNull(reader, 11);
                    txtOwnerFirstNameEditing.Text = EmptyIfNull(reader, 4);
                    txtOwnerLastNameEditing.Text = EmptyIfNull(reader, 5);
                    txtOwnerIdNoEditing.Text = EmptyIfNull(reader, 2);
                    txtTaxIdNoEditing.Text = EmptyIfNull(reader, 3);
                    txtCorporatePhoneNumEditing.Text = EmptyIfNull(reader, 6);
                    txtAddressLine1CorporateEditing.Text = EmptyIfNull(reader, 7);
                    txtAddressLine2CorporateEditing.Text = EmptyIfNull(reader, 8);
                    txtDistrict.Text = EmptyIfNull(reader, 9);
                    txtCityCorporateEditing.Text = EmptyIfNull(reader, 10);

                }

                reader.Close();
                connection.Close();
            }

        }

        private void btnUpdateCorporate_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Customers SET corporate_name = @corporate_name,owner_firstName = @owner_firstName," +
                    "owner_lastName = @owner_lastName, id_no = @id_no,tax_id_no = @tax_id_no,phone_num=@phone_num," +
                    "address_line1=@address_line1,address_line2=@address_line2,district=@district,city=@city WHERE tax_id_no = @tax_id_no";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@corporate_name", txtCorporateNameEditing.Text);
                    command.Parameters.AddWithValue("@owner_firstName", txtOwnerFirstNameEditing.Text);
                    command.Parameters.AddWithValue("@owner_lastName", txtOwnerLastNameEditing.Text);
                    command.Parameters.AddWithValue("@id_no", txtOwnerIdNoEditing.Text);
                    command.Parameters.AddWithValue("@tax_id_no", txtTaxIdNoEditing.Text);
                    command.Parameters.AddWithValue("@phone_num", txtCorporatePhoneNumEditing.Text);
                    command.Parameters.AddWithValue("@address_line1", txtAddressLine1CorporateEditing.Text);
                    command.Parameters.AddWithValue("@address_line2", txtAddressLine2CorporateEditing.Text);
                    command.Parameters.AddWithValue("@district", txtDistrict.Text);
                    command.Parameters.AddWithValue("@city", txtCityCorporateEditing.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Corporate Updated", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No changes were made or the corporate with the given tax ID was not found.", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }


            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Customers SET first_name = @first_name," +
                    "last_name = @last_name, id_no = @id_no,phone_num=@phone_num," +
                    "address_line1=@address_line1,address_line2=@address_line2,district=@district,city=@city WHERE id_no = @id_no";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@first_name", txtNamePersonalEditing.Text);
                    command.Parameters.AddWithValue("@last_name", txtLastNamePersonalEditing.Text);
                    command.Parameters.AddWithValue("@id_no", txtIdNumPersonalEditing.Text);
                    command.Parameters.AddWithValue("@phone_num", txtPhoneNumPersonalEditing.Text);
                    command.Parameters.AddWithValue("@address_line1", txtAddressLine1PersonalEditing.Text);
                    command.Parameters.AddWithValue("@address_line2", txtAddressLine2PersonalEditing.Text);
                    command.Parameters.AddWithValue("@district", txtDistrict.Text);
                    command.Parameters.AddWithValue("@city", txtCityPersonalEditing.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer Updated", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No changes were made or the customer with the given ID was not found.", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }


            }


        }
    }
}
