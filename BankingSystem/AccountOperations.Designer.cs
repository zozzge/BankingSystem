
namespace BankingSystem
{
    partial class frmAccountOperations
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
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.grdAccOpAccount = new System.Windows.Forms.DataGridView();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdAccOpCustomers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccOpAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccOpCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(151, 406);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(130, 32);
            this.btnDeleteAccount.TabIndex = 13;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(17, 406);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(128, 32);
            this.btnNewAccount.TabIndex = 11;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // grdAccOpAccount
            // 
            this.grdAccOpAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccOpAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.AccountType,
            this.accountName,
            this.AccountCurrency,
            this.AccountAmount,
            this.AccountDate});
            this.grdAccOpAccount.Location = new System.Drawing.Point(17, 230);
            this.grdAccOpAccount.Name = "grdAccOpAccount";
            this.grdAccOpAccount.RowHeadersWidth = 51;
            this.grdAccOpAccount.RowTemplate.Height = 24;
            this.grdAccOpAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccOpAccount.Size = new System.Drawing.Size(553, 170);
            this.grdAccOpAccount.TabIndex = 10;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(310, 36);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(75, 32);
            this.btnSearchAccount.TabIndex = 9;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(17, 41);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(272, 22);
            this.tbCustomerName.TabIndex = 8;
            this.tbCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomerName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Name";
            // 
            // grdAccOpCustomers
            // 
            this.grdAccOpCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccOpCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grdAccOpCustomers.Location = new System.Drawing.Point(17, 78);
            this.grdAccOpCustomers.Name = "grdAccOpCustomers";
            this.grdAccOpCustomers.RowHeadersWidth = 51;
            this.grdAccOpCustomers.RowTemplate.Height = 24;
            this.grdAccOpCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccOpCustomers.Size = new System.Drawing.Size(553, 137);
            this.grdAccOpCustomers.TabIndex = 14;
            this.grdAccOpCustomers.SelectionChanged += new System.EventHandler(this.grdAccOpCustomers_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Id Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // customerId
            // 
            this.customerId.HeaderText = "customerId";
            this.customerId.MinimumWidth = 6;
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            this.customerId.Width = 125;
            // 
            // AccountType
            // 
            this.AccountType.HeaderText = "Type";
            this.AccountType.MinimumWidth = 6;
            this.AccountType.Name = "AccountType";
            this.AccountType.Width = 125;
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Account Name";
            this.accountName.MinimumWidth = 6;
            this.accountName.Name = "accountName";
            this.accountName.Width = 125;
            // 
            // AccountCurrency
            // 
            this.AccountCurrency.HeaderText = "Currency";
            this.AccountCurrency.MinimumWidth = 6;
            this.AccountCurrency.Name = "AccountCurrency";
            this.AccountCurrency.Width = 125;
            // 
            // AccountAmount
            // 
            this.AccountAmount.HeaderText = "Amount";
            this.AccountAmount.MinimumWidth = 6;
            this.AccountAmount.Name = "AccountAmount";
            this.AccountAmount.Width = 125;
            // 
            // AccountDate
            // 
            this.AccountDate.HeaderText = "Creation Date";
            this.AccountDate.MinimumWidth = 6;
            this.AccountDate.Name = "AccountDate";
            this.AccountDate.Width = 125;
            // 
            // frmAccountOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdAccOpCustomers);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.grdAccOpAccount);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "frmAccountOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Operations";
            ((System.ComponentModel.ISupportInitialize)(this.grdAccOpAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccOpCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.DataGridView grdAccOpAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdAccOpCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
    }
}