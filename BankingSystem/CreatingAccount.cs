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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
            
        }

        public int _customerId;
        

        private void cmbAccountType_SelectedValueChanged(object sender, EventArgs e)
        {
            tabCreatingAcc.TabPages.Clear();
            tabCreatingAcc.Show();

            switch (cmbAccountType.SelectedIndex)
            {
                case 0:
                    tabCreatingAcc.TabPages.Add(pageDepositAccount);
                    pageDepositAccount.Show();
                    break;
                case 1:
                    tabCreatingAcc.TabPages.Add(pageCheckingAccount);
                    pageCheckingAccount.Show();
                    break;
                case 2:
                    tabCreatingAcc.TabPages.Add(pageForeignCurrency);
                    pageForeignCurrency.Show();
                    break;
                case 3:
                    tabCreatingAcc.TabPages.Add(pageInvestment);
                    pageInvestment.Show();
                    break;
            }
            cmbAccountType.Enabled = false;
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreatingAccount_Click(object sender, EventArgs e)
        {
            int accountType = cmbAccountType.SelectedIndex;
            decimal amount = 0;
            string accountName = txtaccountName.Text;

            if (accountType == 0)
            {
                int currency_id = (cmbCurrencyDeposit.SelectedItem as dynamic).Value;

                try
                {
                    amount = decimal.Parse(txtDepositAccAmount.Text);
                }
                catch
                {
                    amount = 0;
                }

                CustomerOperations.NewAccount(_customerId, accountType, accountName, currency_id, amount);

            }
            else if (accountType == 1)
            {
                int currency_id = (cmbCurrencyChecking.SelectedItem as dynamic).Value;

                try
                {
                    amount = decimal.Parse(txtCheckingAccAmount.Text);
                }
                catch
                {
                    amount = 0;
                }

                CustomerOperations.NewAccount(_customerId, accountType,accountName, currency_id, amount);
            }

            else if (accountType == 2)
            {
                int currency_id = (cmbCurrencyForeign.SelectedItem as dynamic).Value;

                try
                {
                    amount = decimal.Parse(txtForeignCurrencyAmount.Text);
                }
                catch
                {
                    amount = 0;
                }

                CustomerOperations.NewAccount(_customerId, accountType, accountName, currency_id, amount);

                
            }
            else if (accountType == 3)
            {
                int currency_id = (cmbCurrencyInvestment.SelectedItem as dynamic).Value;

                try
                {
                    amount = decimal.Parse(txtInvestmentAmount.Text);
                }
                catch
                {
                    amount = 0;
                }

                CustomerOperations.NewAccount(_customerId, accountType, accountName, currency_id, amount);
            }

  
        }

        private void frmCreateAccount_Shown(object sender, EventArgs e)
        {
            pageCheckingAccount.Hide();
            tabCreatingAcc.TabPages.Remove(pageCheckingAccount);

            pageDepositAccount.Hide();
            tabCreatingAcc.TabPages.Remove(pageDepositAccount);

            pageForeignCurrency.Hide();
            tabCreatingAcc.TabPages.Remove(pageForeignCurrency);

            pageInvestment.Hide();
            tabCreatingAcc.TabPages.Remove(pageInvestment);

            tabCreatingAcc.Hide();

            CustomerOperations.FillCurrencyComboBox(cmbCurrencyDeposit);
            CustomerOperations.FillCurrencyComboBox(cmbCurrencyChecking);
            CustomerOperations.FillCurrencyComboBox(cmbCurrencyForeign);
            CustomerOperations.FillCurrencyComboBox(cmbCurrencyInvestment);

        }

        
    }
}
