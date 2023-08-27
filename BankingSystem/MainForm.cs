using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactions frmTransactions = new frmTransactions();
            frmTransactions.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomerOperations customerOperations = new frmCustomerOperations();
            customerOperations.ShowDialog();
        }

        private void btnAccountOperations_Click(object sender, EventArgs e)
        {
            frmAccountOperations frmAccountOperations = new frmAccountOperations();
            frmAccountOperations.ShowDialog();
        }
    }
}
