
namespace BankingSystem
{
    partial class frmCustomerType
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
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pagePersonal = new System.Windows.Forms.TabPage();
            this.txtPersonalDistrict = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pageCorporate = new System.Windows.Forms.TabPage();
            this.txtOwnerIdNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOwnerLastName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDistrictCorporate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCityCorporate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddressLine2Corporate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddressLine1Corporate = new System.Windows.Forms.TextBox();
            this.btnAddCorporate = new System.Windows.Forms.Button();
            this.txtCorporatePhoneNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTaxIdNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOwnerFirstName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCorporateName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.pagePersonal.SuspendLayout();
            this.pageCorporate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "Personal",
            "Corporate"});
            this.cmbCustomerType.Location = new System.Drawing.Point(12, 45);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(166, 24);
            this.cmbCustomerType.TabIndex = 0;
            this.cmbCustomerType.SelectedValueChanged += new System.EventHandler(this.cmb_SelectedValueChanged);
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the customer type";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pagePersonal);
            this.tabMain.Controls.Add(this.pageCorporate);
            this.tabMain.Location = new System.Drawing.Point(15, 80);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(869, 400);
            this.tabMain.TabIndex = 2;
            // 
            // pagePersonal
            // 
            this.pagePersonal.Controls.Add(this.txtPersonalDistrict);
            this.pagePersonal.Controls.Add(this.label8);
            this.pagePersonal.Controls.Add(this.txtCity);
            this.pagePersonal.Controls.Add(this.txtDistrict);
            this.pagePersonal.Controls.Add(this.txtAddressLine2);
            this.pagePersonal.Controls.Add(this.label6);
            this.pagePersonal.Controls.Add(this.label5);
            this.pagePersonal.Controls.Add(this.txtAddressLine1);
            this.pagePersonal.Controls.Add(this.btnAdd);
            this.pagePersonal.Controls.Add(this.txtPhoneNum);
            this.pagePersonal.Controls.Add(this.label4);
            this.pagePersonal.Controls.Add(this.txtIdNum);
            this.pagePersonal.Controls.Add(this.label3);
            this.pagePersonal.Controls.Add(this.txtLastName);
            this.pagePersonal.Controls.Add(this.label2);
            this.pagePersonal.Controls.Add(this.txtName);
            this.pagePersonal.Controls.Add(this.label7);
            this.pagePersonal.Location = new System.Drawing.Point(4, 25);
            this.pagePersonal.Name = "pagePersonal";
            this.pagePersonal.Padding = new System.Windows.Forms.Padding(3);
            this.pagePersonal.Size = new System.Drawing.Size(861, 371);
            this.pagePersonal.TabIndex = 0;
            this.pagePersonal.Text = "Personal";
            this.pagePersonal.UseVisualStyleBackColor = true;
            this.pagePersonal.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtPersonalDistrict
            // 
            this.txtPersonalDistrict.Location = new System.Drawing.Point(359, 183);
            this.txtPersonalDistrict.Name = "txtPersonalDistrict";
            this.txtPersonalDistrict.Size = new System.Drawing.Size(188, 22);
            this.txtPersonalDistrict.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(359, 248);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(188, 22);
            this.txtCity.TabIndex = 39;
            // 
            // txtDistrict
            // 
            this.txtDistrict.AutoSize = true;
            this.txtDistrict.Location = new System.Drawing.Point(356, 159);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(51, 17);
            this.txtDistrict.TabIndex = 38;
            this.txtDistrict.Text = "District";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(359, 123);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(188, 22);
            this.txtAddressLine2.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Address Line 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Address Line 1";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(359, 64);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(188, 22);
            this.txtAddressLine1.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(683, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 49);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add New Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(30, 248);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(188, 22);
            this.txtPhoneNum.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone Number";
            // 
            // txtIdNum
            // 
            this.txtIdNum.Location = new System.Drawing.Point(30, 183);
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.Size = new System.Drawing.Size(188, 22);
            this.txtIdNum.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(30, 123);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 22);
            this.txtLastName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fırst Name";
            // 
            // pageCorporate
            // 
            this.pageCorporate.Controls.Add(this.txtOwnerIdNo);
            this.pageCorporate.Controls.Add(this.label20);
            this.pageCorporate.Controls.Add(this.txtOwnerLastName);
            this.pageCorporate.Controls.Add(this.label19);
            this.pageCorporate.Controls.Add(this.txtDistrictCorporate);
            this.pageCorporate.Controls.Add(this.label11);
            this.pageCorporate.Controls.Add(this.txtCityCorporate);
            this.pageCorporate.Controls.Add(this.label12);
            this.pageCorporate.Controls.Add(this.txtAddressLine2Corporate);
            this.pageCorporate.Controls.Add(this.label13);
            this.pageCorporate.Controls.Add(this.label14);
            this.pageCorporate.Controls.Add(this.txtAddressLine1Corporate);
            this.pageCorporate.Controls.Add(this.btnAddCorporate);
            this.pageCorporate.Controls.Add(this.txtCorporatePhoneNum);
            this.pageCorporate.Controls.Add(this.label15);
            this.pageCorporate.Controls.Add(this.txtTaxIdNo);
            this.pageCorporate.Controls.Add(this.label16);
            this.pageCorporate.Controls.Add(this.txtOwnerFirstName);
            this.pageCorporate.Controls.Add(this.label17);
            this.pageCorporate.Controls.Add(this.txtCorporateName);
            this.pageCorporate.Controls.Add(this.label18);
            this.pageCorporate.Controls.Add(this.label10);
            this.pageCorporate.Controls.Add(this.label9);
            this.pageCorporate.Location = new System.Drawing.Point(4, 25);
            this.pageCorporate.Name = "pageCorporate";
            this.pageCorporate.Padding = new System.Windows.Forms.Padding(3);
            this.pageCorporate.Size = new System.Drawing.Size(861, 371);
            this.pageCorporate.TabIndex = 1;
            this.pageCorporate.Text = "Corporate";
            this.pageCorporate.UseVisualStyleBackColor = true;
            this.pageCorporate.Click += new System.EventHandler(this.pageCorporate_Click);
            // 
            // txtOwnerIdNo
            // 
            this.txtOwnerIdNo.Location = new System.Drawing.Point(42, 241);
            this.txtOwnerIdNo.Name = "txtOwnerIdNo";
            this.txtOwnerIdNo.Size = new System.Drawing.Size(188, 22);
            this.txtOwnerIdNo.TabIndex = 62;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 221);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 17);
            this.label20.TabIndex = 61;
            this.label20.Text = "Owner Id No";
            // 
            // txtOwnerLastName
            // 
            this.txtOwnerLastName.Location = new System.Drawing.Point(42, 182);
            this.txtOwnerLastName.Name = "txtOwnerLastName";
            this.txtOwnerLastName.Size = new System.Drawing.Size(188, 22);
            this.txtOwnerLastName.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 17);
            this.label19.TabIndex = 59;
            this.label19.Text = "Owner Last Name";
            // 
            // txtDistrictCorporate
            // 
            this.txtDistrictCorporate.Location = new System.Drawing.Point(371, 241);
            this.txtDistrictCorporate.Name = "txtDistrictCorporate";
            this.txtDistrictCorporate.Size = new System.Drawing.Size(188, 22);
            this.txtDistrictCorporate.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "City";
            // 
            // txtCityCorporate
            // 
            this.txtCityCorporate.Location = new System.Drawing.Point(371, 301);
            this.txtCityCorporate.Name = "txtCityCorporate";
            this.txtCityCorporate.Size = new System.Drawing.Size(188, 22);
            this.txtCityCorporate.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "District";
            // 
            // txtAddressLine2Corporate
            // 
            this.txtAddressLine2Corporate.Location = new System.Drawing.Point(371, 182);
            this.txtAddressLine2Corporate.Name = "txtAddressLine2Corporate";
            this.txtAddressLine2Corporate.Size = new System.Drawing.Size(188, 22);
            this.txtAddressLine2Corporate.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Address Line 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Address Line 1";
            // 
            // txtAddressLine1Corporate
            // 
            this.txtAddressLine1Corporate.Location = new System.Drawing.Point(371, 123);
            this.txtAddressLine1Corporate.Name = "txtAddressLine1Corporate";
            this.txtAddressLine1Corporate.Size = new System.Drawing.Size(188, 22);
            this.txtAddressLine1Corporate.TabIndex = 51;
            // 
            // btnAddCorporate
            // 
            this.btnAddCorporate.Location = new System.Drawing.Point(695, 301);
            this.btnAddCorporate.Name = "btnAddCorporate";
            this.btnAddCorporate.Size = new System.Drawing.Size(98, 49);
            this.btnAddCorporate.TabIndex = 50;
            this.btnAddCorporate.Text = "Add New Corporate";
            this.btnAddCorporate.UseVisualStyleBackColor = true;
            this.btnAddCorporate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCorporatePhoneNum
            // 
            this.txtCorporatePhoneNum.Location = new System.Drawing.Point(371, 68);
            this.txtCorporatePhoneNum.Name = "txtCorporatePhoneNum";
            this.txtCorporatePhoneNum.Size = new System.Drawing.Size(188, 22);
            this.txtCorporatePhoneNum.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 17);
            this.label15.TabIndex = 48;
            this.label15.Text = "Corporate Phone Number";
            // 
            // txtTaxIdNo
            // 
            this.txtTaxIdNo.Location = new System.Drawing.Point(42, 301);
            this.txtTaxIdNo.Name = "txtTaxIdNo";
            this.txtTaxIdNo.Size = new System.Drawing.Size(188, 22);
            this.txtTaxIdNo.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "Tax ID Number";
            // 
            // txtOwnerFirstName
            // 
            this.txtOwnerFirstName.Location = new System.Drawing.Point(42, 123);
            this.txtOwnerFirstName.Name = "txtOwnerFirstName";
            this.txtOwnerFirstName.Size = new System.Drawing.Size(188, 22);
            this.txtOwnerFirstName.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "Owner First Name";
            // 
            // txtCorporateName
            // 
            this.txtCorporateName.Location = new System.Drawing.Point(42, 68);
            this.txtCorporateName.Name = "txtCorporateName";
            this.txtCorporateName.Size = new System.Drawing.Size(188, 22);
            this.txtCorporateName.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 17);
            this.label18.TabIndex = 42;
            this.label18.Text = "Corporate Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 2;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 0;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // frmCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 503);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCustomerType);
            this.Name = "frmCustomerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding New Customer";
            this.Shown += new System.EventHandler(this.DetermineCustomerType_Shown);
            this.tabMain.ResumeLayout(false);
            this.pagePersonal.ResumeLayout(false);
            this.pagePersonal.PerformLayout();
            this.pageCorporate.ResumeLayout(false);
            this.pageCorporate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pagePersonal;
        private System.Windows.Forms.TabPage pageCorporate;
        private System.Windows.Forms.TextBox txtPersonalDistrict;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label txtDistrict;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDistrictCorporate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCityCorporate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddressLine2Corporate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddressLine1Corporate;
        private System.Windows.Forms.Button btnAddCorporate;
        private System.Windows.Forms.TextBox txtCorporatePhoneNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTaxIdNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOwnerFirstName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCorporateName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOwnerLastName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOwnerIdNo;
        private System.Windows.Forms.Label label20;
    }
}