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
    public partial class frmCustomerType : Form
    {
        public frmCustomerType()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DetermineCustomerType_Shown(object sender, EventArgs e)
        {
            pagePersonal.Hide();
            tabMain.TabPages.Remove(pagePersonal);
            pageCorporate.Hide();
            tabMain.TabPages.Remove(pageCorporate);
            tabMain.Hide();
        }

        private void cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            tabMain.Show();
            switch (cmbCustomerType.SelectedIndex)
            {
                case 0:
                    tabMain.TabPages.Add(pagePersonal);
                    pagePersonal.Show();
                    break;
                case 1:
                    tabMain.TabPages.Add(pageCorporate);
                    pageCorporate.Show();
                    break;
            }
            cmbCustomerType.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pageCorporate_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool TaxIdExists(SqlConnection connection, string taxId)
        {
            string selectQuery = "SELECT id FROM customers WHERE tax_id_no = @tax_id_no";

            using (SqlCommand cmdSelect = new SqlCommand(selectQuery, connection))
            {
                cmdSelect.Parameters.AddWithValue("@tax_id_no", taxId);
                SqlDataReader rdrSelect = cmdSelect.ExecuteReader();
                bool taxIdExists = rdrSelect.HasRows;
                rdrSelect.Close();
                return taxIdExists;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=ZOZGEDR\\ZOZGE;Database=zeynep;Trusted_Connection=True;";
                conn.Open();

                if (cmbCustomerType.SelectedIndex == 0)
                {
                    string query = "INSERT INTO customers (type, first_name, last_name, id_no, phone_num, address_line1, address_line2, district, city) " +
                                   "VALUES (@type, @first_name, @last_name, @id_no, @phone_num, @address_line1, @address_line2, @district, @city)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@type", cmbCustomerType.SelectedIndex);
                        cmd.Parameters.AddWithValue("@first_name", txtName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@id_no", txtIdNum.Text);
                        cmd.Parameters.AddWithValue("@phone_num", txtPhoneNum.Text);
                        cmd.Parameters.AddWithValue("@address_line1", txtAddressLine1.Text);
                        cmd.Parameters.AddWithValue("@address_line2", txtAddressLine2.Text);
                        cmd.Parameters.AddWithValue("@district", txtDistrict.Text);
                        cmd.Parameters.AddWithValue("@city", txtCity.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Customer Added", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cmbCustomerType.SelectedIndex == 1)
                {
                    if (TaxIdExists(conn, txtTaxIdNo.Text))
                    {
                        MessageBox.Show("Tax Id already exists!");
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO customers (type, corporate_name, owner_firstName, owner_lastName, id_no, tax_id_no, phone_num, address_line1, address_line2, district, city) " +
                                             "VALUES (@type, @corporate_name, @owner_firstName, @owner_lastName, @id_no, @tax_id_no, @phone_num, @address_line1, @address_line2, @district, @city)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            
                            cmd.Parameters.AddWithValue("@type", cmbCustomerType.SelectedIndex);
                            cmd.Parameters.AddWithValue("@corporate_name", txtCorporateName.Text);
                            cmd.Parameters.AddWithValue("@owner_firstName ", txtOwnerFirstName.Text);
                            cmd.Parameters.AddWithValue("@owner_lastName ", txtOwnerLastName.Text);
                            cmd.Parameters.AddWithValue("@id_no", txtOwnerIdNo.Text);
                            cmd.Parameters.AddWithValue("@tax_id_no", txtTaxIdNo.Text);
                            cmd.Parameters.AddWithValue("@phone_num", txtPhoneNum.Text);
                            cmd.Parameters.AddWithValue("@address_line1", txtAddressLine1.Text);
                            cmd.Parameters.AddWithValue("@address_line2", txtAddressLine2.Text);
                            cmd.Parameters.AddWithValue("@district", txtDistrict.Text);
                            cmd.Parameters.AddWithValue("@city", txtCity.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New Corporate Added", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


    }
}
