
namespace BankingSystem
{
    partial class frmCreateAccount
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
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.tabCreatingAcc = new System.Windows.Forms.TabControl();
            this.pageDepositAccount = new System.Windows.Forms.TabPage();
            this.cmbCurrencyDeposit = new System.Windows.Forms.ComboBox();
            this.txtDepositAccAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pageCheckingAccount = new System.Windows.Forms.TabPage();
            this.cmbCurrencyChecking = new System.Windows.Forms.ComboBox();
            this.txtCheckingAccAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageForeignCurrency = new System.Windows.Forms.TabPage();
            this.cmbCurrencyForeign = new System.Windows.Forms.ComboBox();
            this.txtForeignCurrencyAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pageInvestment = new System.Windows.Forms.TabPage();
            this.cmbCurrencyInvestment = new System.Windows.Forms.ComboBox();
            this.txtInvestmentAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreatingAccount = new System.Windows.Forms.Button();
            this.txtaccountName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCreatingAcc.SuspendLayout();
            this.pageDepositAccount.SuspendLayout();
            this.pageCheckingAccount.SuspendLayout();
            this.pageForeignCurrency.SuspendLayout();
            this.pageInvestment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the account type.";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Deposit Account",
            "Checking Account",
            "Foreign Currency",
            "Investment Account"});
            this.cmbAccountType.Location = new System.Drawing.Point(12, 29);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(169, 24);
            this.cmbAccountType.TabIndex = 1;
            this.cmbAccountType.SelectedValueChanged += new System.EventHandler(this.cmbAccountType_SelectedValueChanged);
            // 
            // tabCreatingAcc
            // 
            this.tabCreatingAcc.Controls.Add(this.pageDepositAccount);
            this.tabCreatingAcc.Controls.Add(this.pageCheckingAccount);
            this.tabCreatingAcc.Controls.Add(this.pageForeignCurrency);
            this.tabCreatingAcc.Controls.Add(this.pageInvestment);
            this.tabCreatingAcc.Location = new System.Drawing.Point(12, 147);
            this.tabCreatingAcc.Name = "tabCreatingAcc";
            this.tabCreatingAcc.SelectedIndex = 0;
            this.tabCreatingAcc.Size = new System.Drawing.Size(504, 230);
            this.tabCreatingAcc.TabIndex = 4;
            // 
            // pageDepositAccount
            // 
            this.pageDepositAccount.Controls.Add(this.cmbCurrencyDeposit);
            this.pageDepositAccount.Controls.Add(this.txtDepositAccAmount);
            this.pageDepositAccount.Controls.Add(this.label8);
            this.pageDepositAccount.Controls.Add(this.label7);
            this.pageDepositAccount.Location = new System.Drawing.Point(4, 25);
            this.pageDepositAccount.Name = "pageDepositAccount";
            this.pageDepositAccount.Padding = new System.Windows.Forms.Padding(3);
            this.pageDepositAccount.Size = new System.Drawing.Size(496, 201);
            this.pageDepositAccount.TabIndex = 0;
            this.pageDepositAccount.Text = "Deposit Account";
            this.pageDepositAccount.UseVisualStyleBackColor = true;
            // 
            // cmbCurrencyDeposit
            // 
            this.cmbCurrencyDeposit.FormattingEnabled = true;
            this.cmbCurrencyDeposit.Location = new System.Drawing.Point(6, 54);
            this.cmbCurrencyDeposit.Name = "cmbCurrencyDeposit";
            this.cmbCurrencyDeposit.Size = new System.Drawing.Size(131, 24);
            this.cmbCurrencyDeposit.TabIndex = 11;
            // 
            // txtDepositAccAmount
            // 
            this.txtDepositAccAmount.Location = new System.Drawing.Point(6, 117);
            this.txtDepositAccAmount.Name = "txtDepositAccAmount";
            this.txtDepositAccAmount.Size = new System.Drawing.Size(131, 22);
            this.txtDepositAccAmount.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Currency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Amount";
            // 
            // pageCheckingAccount
            // 
            this.pageCheckingAccount.Controls.Add(this.cmbCurrencyChecking);
            this.pageCheckingAccount.Controls.Add(this.txtCheckingAccAmount);
            this.pageCheckingAccount.Controls.Add(this.label2);
            this.pageCheckingAccount.Controls.Add(this.label3);
            this.pageCheckingAccount.Location = new System.Drawing.Point(4, 25);
            this.pageCheckingAccount.Name = "pageCheckingAccount";
            this.pageCheckingAccount.Padding = new System.Windows.Forms.Padding(3);
            this.pageCheckingAccount.Size = new System.Drawing.Size(496, 201);
            this.pageCheckingAccount.TabIndex = 1;
            this.pageCheckingAccount.Text = "Checking Account";
            this.pageCheckingAccount.UseVisualStyleBackColor = true;
            // 
            // cmbCurrencyChecking
            // 
            this.cmbCurrencyChecking.FormattingEnabled = true;
            this.cmbCurrencyChecking.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "GBP"});
            this.cmbCurrencyChecking.Location = new System.Drawing.Point(3, 49);
            this.cmbCurrencyChecking.Name = "cmbCurrencyChecking";
            this.cmbCurrencyChecking.Size = new System.Drawing.Size(131, 24);
            this.cmbCurrencyChecking.TabIndex = 17;
            // 
            // txtCheckingAccAmount
            // 
            this.txtCheckingAccAmount.Location = new System.Drawing.Point(3, 104);
            this.txtCheckingAccAmount.Name = "txtCheckingAccAmount";
            this.txtCheckingAccAmount.Size = new System.Drawing.Size(131, 22);
            this.txtCheckingAccAmount.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount";
            // 
            // pageForeignCurrency
            // 
            this.pageForeignCurrency.Controls.Add(this.cmbCurrencyForeign);
            this.pageForeignCurrency.Controls.Add(this.txtForeignCurrencyAmount);
            this.pageForeignCurrency.Controls.Add(this.label5);
            this.pageForeignCurrency.Controls.Add(this.label6);
            this.pageForeignCurrency.Location = new System.Drawing.Point(4, 25);
            this.pageForeignCurrency.Name = "pageForeignCurrency";
            this.pageForeignCurrency.Padding = new System.Windows.Forms.Padding(3);
            this.pageForeignCurrency.Size = new System.Drawing.Size(496, 201);
            this.pageForeignCurrency.TabIndex = 2;
            this.pageForeignCurrency.Text = "Foreign Currency";
            this.pageForeignCurrency.UseVisualStyleBackColor = true;
            // 
            // cmbCurrencyForeign
            // 
            this.cmbCurrencyForeign.FormattingEnabled = true;
            this.cmbCurrencyForeign.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "GBP"});
            this.cmbCurrencyForeign.Location = new System.Drawing.Point(6, 53);
            this.cmbCurrencyForeign.Name = "cmbCurrencyForeign";
            this.cmbCurrencyForeign.Size = new System.Drawing.Size(131, 24);
            this.cmbCurrencyForeign.TabIndex = 17;
            // 
            // txtForeignCurrencyAmount
            // 
            this.txtForeignCurrencyAmount.Location = new System.Drawing.Point(6, 110);
            this.txtForeignCurrencyAmount.Name = "txtForeignCurrencyAmount";
            this.txtForeignCurrencyAmount.Size = new System.Drawing.Size(131, 22);
            this.txtForeignCurrencyAmount.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Amount";
            // 
            // pageInvestment
            // 
            this.pageInvestment.Controls.Add(this.cmbCurrencyInvestment);
            this.pageInvestment.Controls.Add(this.txtInvestmentAmount);
            this.pageInvestment.Controls.Add(this.label10);
            this.pageInvestment.Controls.Add(this.label11);
            this.pageInvestment.Location = new System.Drawing.Point(4, 25);
            this.pageInvestment.Name = "pageInvestment";
            this.pageInvestment.Padding = new System.Windows.Forms.Padding(3);
            this.pageInvestment.Size = new System.Drawing.Size(496, 201);
            this.pageInvestment.TabIndex = 3;
            this.pageInvestment.Text = "Investment";
            this.pageInvestment.UseVisualStyleBackColor = true;
            // 
            // cmbCurrencyInvestment
            // 
            this.cmbCurrencyInvestment.FormattingEnabled = true;
            this.cmbCurrencyInvestment.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "GBP"});
            this.cmbCurrencyInvestment.Location = new System.Drawing.Point(6, 68);
            this.cmbCurrencyInvestment.Name = "cmbCurrencyInvestment";
            this.cmbCurrencyInvestment.Size = new System.Drawing.Size(131, 24);
            this.cmbCurrencyInvestment.TabIndex = 17;
            // 
            // txtInvestmentAmount
            // 
            this.txtInvestmentAmount.Location = new System.Drawing.Point(6, 124);
            this.txtInvestmentAmount.Name = "txtInvestmentAmount";
            this.txtInvestmentAmount.Size = new System.Drawing.Size(131, 22);
            this.txtInvestmentAmount.TabIndex = 16;
            this.txtInvestmentAmount.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Currency";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Amount";
            // 
            // btnCreatingAccount
            // 
            this.btnCreatingAccount.Location = new System.Drawing.Point(615, 333);
            this.btnCreatingAccount.Name = "btnCreatingAccount";
            this.btnCreatingAccount.Size = new System.Drawing.Size(107, 44);
            this.btnCreatingAccount.TabIndex = 0;
            this.btnCreatingAccount.Text = "Create Account";
            this.btnCreatingAccount.UseVisualStyleBackColor = true;
            this.btnCreatingAccount.Click += new System.EventHandler(this.btnCreatingAccount_Click);
            // 
            // txtaccountName
            // 
            this.txtaccountName.Location = new System.Drawing.Point(12, 94);
            this.txtaccountName.Name = "txtaccountName";
            this.txtaccountName.Size = new System.Drawing.Size(169, 22);
            this.txtaccountName.TabIndex = 5;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter your account\'s name";
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaccountName);
            this.Controls.Add(this.btnCreatingAccount);
            this.Controls.Add(this.tabCreatingAcc);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating New Account";
            this.Shown += new System.EventHandler(this.frmCreateAccount_Shown);
            this.tabCreatingAcc.ResumeLayout(false);
            this.pageDepositAccount.ResumeLayout(false);
            this.pageDepositAccount.PerformLayout();
            this.pageCheckingAccount.ResumeLayout(false);
            this.pageCheckingAccount.PerformLayout();
            this.pageForeignCurrency.ResumeLayout(false);
            this.pageForeignCurrency.PerformLayout();
            this.pageInvestment.ResumeLayout(false);
            this.pageInvestment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.TabControl tabCreatingAcc;
        private System.Windows.Forms.TabPage pageDepositAccount;
        private System.Windows.Forms.TabPage pageCheckingAccount;
        private System.Windows.Forms.TabPage pageForeignCurrency;
        private System.Windows.Forms.TabPage pageInvestment;
        private System.Windows.Forms.Button btnCreatingAccount;
        private System.Windows.Forms.TextBox txtDepositAccAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCheckingAccAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtForeignCurrencyAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvestmentAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCurrencyDeposit;
        private System.Windows.Forms.ComboBox cmbCurrencyChecking;
        private System.Windows.Forms.ComboBox cmbCurrencyForeign;
        private System.Windows.Forms.ComboBox cmbCurrencyInvestment;
        private System.Windows.Forms.TextBox txtaccountName;
        private System.Windows.Forms.Label label4;
    }
}