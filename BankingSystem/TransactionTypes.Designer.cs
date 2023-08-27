
namespace BankingSystem
{
    partial class frmTransactionTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransactions = new System.Windows.Forms.ComboBox();
            this.tabTransfers = new System.Windows.Forms.TabControl();
            this.tabLodgement = new System.Windows.Forms.TabPage();
            this.btnLodge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLodgeAmount = new System.Windows.Forms.TextBox();
            this.tabWithdrawal = new System.Windows.Forms.TabPage();
            this.btnWithdrawl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWithdrawlAmount = new System.Windows.Forms.TextBox();
            this.tab2Customers = new System.Windows.Forms.TabPage();
            this.btnTransfer2Customers = new System.Windows.Forms.Button();
            this.txtAmount2Customers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdCustomers2Customers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2Accounts = new System.Windows.Forms.TabPage();
            this.btnTransfer2Accounts = new System.Windows.Forms.Button();
            this.txtAmount2Accounts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdAccounts2Accounts = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTransfers.SuspendLayout();
            this.tabLodgement.SuspendLayout();
            this.tabWithdrawal.SuspendLayout();
            this.tab2Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers2Customers)).BeginInit();
            this.tab2Accounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts2Accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the transaction type.";
            // 
            // cmbTransactions
            // 
            this.cmbTransactions.FormattingEnabled = true;
            this.cmbTransactions.Items.AddRange(new object[] {
            "Lodgement",
            "Withdrawal",
            "Transfer 2 Customers",
            "Transfer 2 Accounts"});
            this.cmbTransactions.Location = new System.Drawing.Point(12, 29);
            this.cmbTransactions.Name = "cmbTransactions";
            this.cmbTransactions.Size = new System.Drawing.Size(180, 24);
            this.cmbTransactions.TabIndex = 1;
            this.cmbTransactions.SelectedValueChanged += new System.EventHandler(this.cmbTransactions_SelectedValueChanged);
            // 
            // tabTransfers
            // 
            this.tabTransfers.Controls.Add(this.tabLodgement);
            this.tabTransfers.Controls.Add(this.tabWithdrawal);
            this.tabTransfers.Controls.Add(this.tab2Customers);
            this.tabTransfers.Controls.Add(this.tab2Accounts);
            this.tabTransfers.Location = new System.Drawing.Point(12, 71);
            this.tabTransfers.Name = "tabTransfers";
            this.tabTransfers.SelectedIndex = 0;
            this.tabTransfers.Size = new System.Drawing.Size(823, 473);
            this.tabTransfers.TabIndex = 2;
            // 
            // tabLodgement
            // 
            this.tabLodgement.Controls.Add(this.btnLodge);
            this.tabLodgement.Controls.Add(this.label2);
            this.tabLodgement.Controls.Add(this.txtLodgeAmount);
            this.tabLodgement.Location = new System.Drawing.Point(4, 25);
            this.tabLodgement.Name = "tabLodgement";
            this.tabLodgement.Padding = new System.Windows.Forms.Padding(3);
            this.tabLodgement.Size = new System.Drawing.Size(815, 444);
            this.tabLodgement.TabIndex = 0;
            this.tabLodgement.Text = "Lodgement";
            this.tabLodgement.UseVisualStyleBackColor = true;
            // 
            // btnLodge
            // 
            this.btnLodge.Location = new System.Drawing.Point(647, 352);
            this.btnLodge.Name = "btnLodge";
            this.btnLodge.Size = new System.Drawing.Size(97, 39);
            this.btnLodge.TabIndex = 2;
            this.btnLodge.Text = "Lodge";
            this.btnLodge.UseVisualStyleBackColor = true;
            this.btnLodge.Click += new System.EventHandler(this.btnLodge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "The amount you want to lodge.";
            // 
            // txtLodgeAmount
            // 
            this.txtLodgeAmount.Location = new System.Drawing.Point(19, 49);
            this.txtLodgeAmount.Name = "txtLodgeAmount";
            this.txtLodgeAmount.Size = new System.Drawing.Size(157, 22);
            this.txtLodgeAmount.TabIndex = 0;
            // 
            // tabWithdrawal
            // 
            this.tabWithdrawal.Controls.Add(this.btnWithdrawl);
            this.tabWithdrawal.Controls.Add(this.label3);
            this.tabWithdrawal.Controls.Add(this.txtWithdrawlAmount);
            this.tabWithdrawal.Location = new System.Drawing.Point(4, 25);
            this.tabWithdrawal.Name = "tabWithdrawal";
            this.tabWithdrawal.Padding = new System.Windows.Forms.Padding(3);
            this.tabWithdrawal.Size = new System.Drawing.Size(815, 444);
            this.tabWithdrawal.TabIndex = 1;
            this.tabWithdrawal.Text = "Withdrawal";
            this.tabWithdrawal.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawl
            // 
            this.btnWithdrawl.Location = new System.Drawing.Point(682, 375);
            this.btnWithdrawl.Name = "btnWithdrawl";
            this.btnWithdrawl.Size = new System.Drawing.Size(97, 39);
            this.btnWithdrawl.TabIndex = 4;
            this.btnWithdrawl.Text = "Withdrawl";
            this.btnWithdrawl.UseVisualStyleBackColor = true;
            this.btnWithdrawl.Click += new System.EventHandler(this.btnWithdrawl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "The amount you want to withdrawl.";
            // 
            // txtWithdrawlAmount
            // 
            this.txtWithdrawlAmount.Location = new System.Drawing.Point(19, 44);
            this.txtWithdrawlAmount.Name = "txtWithdrawlAmount";
            this.txtWithdrawlAmount.Size = new System.Drawing.Size(157, 22);
            this.txtWithdrawlAmount.TabIndex = 2;
            // 
            // tab2Customers
            // 
            this.tab2Customers.Controls.Add(this.btnTransfer2Customers);
            this.tab2Customers.Controls.Add(this.txtAmount2Customers);
            this.tab2Customers.Controls.Add(this.label4);
            this.tab2Customers.Controls.Add(this.grdCustomers2Customers);
            this.tab2Customers.Location = new System.Drawing.Point(4, 25);
            this.tab2Customers.Name = "tab2Customers";
            this.tab2Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab2Customers.Size = new System.Drawing.Size(815, 444);
            this.tab2Customers.TabIndex = 2;
            this.tab2Customers.Text = "2 Customers";
            this.tab2Customers.UseVisualStyleBackColor = true;
            // 
            // btnTransfer2Customers
            // 
            this.btnTransfer2Customers.Location = new System.Drawing.Point(667, 365);
            this.btnTransfer2Customers.Name = "btnTransfer2Customers";
            this.btnTransfer2Customers.Size = new System.Drawing.Size(94, 32);
            this.btnTransfer2Customers.TabIndex = 7;
            this.btnTransfer2Customers.Text = "Transfer";
            this.btnTransfer2Customers.UseVisualStyleBackColor = true;
            this.btnTransfer2Customers.Click += new System.EventHandler(this.btnTransfer2Customers_Click);
            // 
            // txtAmount2Customers
            // 
            this.txtAmount2Customers.Location = new System.Drawing.Point(15, 309);
            this.txtAmount2Customers.Name = "txtAmount2Customers";
            this.txtAmount2Customers.Size = new System.Drawing.Size(167, 22);
            this.txtAmount2Customers.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "The amount you want to transfer.";
            // 
            // grdCustomers2Customers
            // 
            this.grdCustomers2Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers2Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerName,
            this.Surname,
            this.IdNumber,
            this.PhoneNumber});
            this.grdCustomers2Customers.Location = new System.Drawing.Point(15, 18);
            this.grdCustomers2Customers.Name = "grdCustomers2Customers";
            this.grdCustomers2Customers.RowHeadersWidth = 51;
            this.grdCustomers2Customers.RowTemplate.Height = 24;
            this.grdCustomers2Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomers2Customers.Size = new System.Drawing.Size(553, 191);
            this.grdCustomers2Customers.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // IdNumber
            // 
            this.IdNumber.HeaderText = "Id Number";
            this.IdNumber.MinimumWidth = 6;
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // tab2Accounts
            // 
            this.tab2Accounts.Controls.Add(this.btnTransfer2Accounts);
            this.tab2Accounts.Controls.Add(this.txtAmount2Accounts);
            this.tab2Accounts.Controls.Add(this.label5);
            this.tab2Accounts.Controls.Add(this.grdAccounts2Accounts);
            this.tab2Accounts.Location = new System.Drawing.Point(4, 25);
            this.tab2Accounts.Name = "tab2Accounts";
            this.tab2Accounts.Padding = new System.Windows.Forms.Padding(3);
            this.tab2Accounts.Size = new System.Drawing.Size(815, 444);
            this.tab2Accounts.TabIndex = 3;
            this.tab2Accounts.Text = "2 Accounts";
            this.tab2Accounts.UseVisualStyleBackColor = true;
            // 
            // btnTransfer2Accounts
            // 
            this.btnTransfer2Accounts.Location = new System.Drawing.Point(669, 367);
            this.btnTransfer2Accounts.Name = "btnTransfer2Accounts";
            this.btnTransfer2Accounts.Size = new System.Drawing.Size(94, 32);
            this.btnTransfer2Accounts.TabIndex = 10;
            this.btnTransfer2Accounts.Text = "Transfer";
            this.btnTransfer2Accounts.UseVisualStyleBackColor = true;
            this.btnTransfer2Accounts.Click += new System.EventHandler(this.btnTransfer2Accounts_Click);
            // 
            // txtAmount2Accounts
            // 
            this.txtAmount2Accounts.Location = new System.Drawing.Point(17, 311);
            this.txtAmount2Accounts.Name = "txtAmount2Accounts";
            this.txtAmount2Accounts.Size = new System.Drawing.Size(167, 22);
            this.txtAmount2Accounts.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "The amount you want to transfer.";
            // 
            // grdAccounts2Accounts
            // 
            this.grdAccounts2Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccounts2Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.Type,
            this.AccountName,
            this.Currency,
            this.Amount,
            this.CreationDate});
            this.grdAccounts2Accounts.Location = new System.Drawing.Point(17, 20);
            this.grdAccounts2Accounts.Name = "grdAccounts2Accounts";
            this.grdAccounts2Accounts.RowHeadersWidth = 51;
            this.grdAccounts2Accounts.RowTemplate.Height = 24;
            this.grdAccounts2Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccounts2Accounts.Size = new System.Drawing.Size(677, 232);
            this.grdAccounts2Accounts.TabIndex = 5;
            // 
            // customerId
            // 
            this.customerId.HeaderText = "Customer Id";
            this.customerId.MinimumWidth = 6;
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            this.customerId.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "Account Name";
            this.AccountName.MinimumWidth = 6;
            this.AccountName.Name = "AccountName";
            this.AccountName.Width = 125;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.MinimumWidth = 6;
            this.Currency.Name = "Currency";
            this.Currency.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "Creation Date";
            this.CreationDate.MinimumWidth = 6;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Width = 125;
            // 
            // frmTransactionTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 581);
            this.Controls.Add(this.tabTransfers);
            this.Controls.Add(this.cmbTransactions);
            this.Controls.Add(this.label1);
            this.Name = "frmTransactionTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.tabTransfers.ResumeLayout(false);
            this.tabLodgement.ResumeLayout(false);
            this.tabLodgement.PerformLayout();
            this.tabWithdrawal.ResumeLayout(false);
            this.tabWithdrawal.PerformLayout();
            this.tab2Customers.ResumeLayout(false);
            this.tab2Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers2Customers)).EndInit();
            this.tab2Accounts.ResumeLayout(false);
            this.tab2Accounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts2Accounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransactions;
        private System.Windows.Forms.TabControl tabTransfers;
        private System.Windows.Forms.TabPage tabLodgement;
        private System.Windows.Forms.Button btnLodge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLodgeAmount;
        private System.Windows.Forms.TabPage tabWithdrawal;
        private System.Windows.Forms.Button btnWithdrawl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWithdrawlAmount;
        private System.Windows.Forms.TabPage tab2Customers;
        private System.Windows.Forms.TabPage tab2Accounts;
        private System.Windows.Forms.DataGridView grdCustomers2Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button btnTransfer2Customers;
        private System.Windows.Forms.TextBox txtAmount2Customers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTransfer2Accounts;
        private System.Windows.Forms.TextBox txtAmount2Accounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdAccounts2Accounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
    }
}