namespace BANK_Desktop.Users
{
    partial class frmPermissions
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxPeople = new System.Windows.Forms.CheckBox();
            this.cbxUsers = new System.Windows.Forms.CheckBox();
            this.cbxClients = new System.Windows.Forms.CheckBox();
            this.cbxWithdrawDeposit = new System.Windows.Forms.CheckBox();
            this.cbxTransfer = new System.Windows.Forms.CheckBox();
            this.cbxCurrencyCalucator = new System.Windows.Forms.CheckBox();
            this.cbxAddCurrency = new System.Windows.Forms.CheckBox();
            this.cbxCurrencyExchangeList = new System.Windows.Forms.CheckBox();
            this.cbxAllPermissions = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(165, 426);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxPeople
            // 
            this.cbxPeople.AutoSize = true;
            this.cbxPeople.Location = new System.Drawing.Point(18, 29);
            this.cbxPeople.Name = "cbxPeople";
            this.cbxPeople.Size = new System.Drawing.Size(84, 27);
            this.cbxPeople.TabIndex = 7;
            this.cbxPeople.Tag = "1";
            this.cbxPeople.Text = "People";
            this.cbxPeople.UseVisualStyleBackColor = true;
            // 
            // cbxUsers
            // 
            this.cbxUsers.AutoSize = true;
            this.cbxUsers.Location = new System.Drawing.Point(161, 29);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(74, 27);
            this.cbxUsers.TabIndex = 8;
            this.cbxUsers.Tag = "2";
            this.cbxUsers.Text = "Users";
            this.cbxUsers.UseVisualStyleBackColor = true;
            // 
            // cbxClients
            // 
            this.cbxClients.AutoSize = true;
            this.cbxClients.Location = new System.Drawing.Point(295, 29);
            this.cbxClients.Name = "cbxClients";
            this.cbxClients.Size = new System.Drawing.Size(83, 27);
            this.cbxClients.TabIndex = 9;
            this.cbxClients.Tag = "4";
            this.cbxClients.Text = "Clients";
            this.cbxClients.UseVisualStyleBackColor = true;
            // 
            // cbxWithdrawDeposit
            // 
            this.cbxWithdrawDeposit.AutoSize = true;
            this.cbxWithdrawDeposit.Location = new System.Drawing.Point(22, 27);
            this.cbxWithdrawDeposit.Name = "cbxWithdrawDeposit";
            this.cbxWithdrawDeposit.Size = new System.Drawing.Size(178, 27);
            this.cbxWithdrawDeposit.TabIndex = 10;
            this.cbxWithdrawDeposit.Tag = "8";
            this.cbxWithdrawDeposit.Text = "Withdraw\\Deposit";
            this.cbxWithdrawDeposit.UseVisualStyleBackColor = true;
            // 
            // cbxTransfer
            // 
            this.cbxTransfer.AutoSize = true;
            this.cbxTransfer.Location = new System.Drawing.Point(235, 29);
            this.cbxTransfer.Name = "cbxTransfer";
            this.cbxTransfer.Size = new System.Drawing.Size(99, 27);
            this.cbxTransfer.TabIndex = 11;
            this.cbxTransfer.Tag = "16";
            this.cbxTransfer.Text = "Transfer";
            this.cbxTransfer.UseVisualStyleBackColor = true;
            // 
            // cbxCurrencyCalucator
            // 
            this.cbxCurrencyCalucator.AutoSize = true;
            this.cbxCurrencyCalucator.Location = new System.Drawing.Point(16, 19);
            this.cbxCurrencyCalucator.Name = "cbxCurrencyCalucator";
            this.cbxCurrencyCalucator.Size = new System.Drawing.Size(188, 27);
            this.cbxCurrencyCalucator.TabIndex = 12;
            this.cbxCurrencyCalucator.Tag = "32";
            this.cbxCurrencyCalucator.Text = "Currency Calucator";
            this.cbxCurrencyCalucator.UseVisualStyleBackColor = true;
            // 
            // cbxAddCurrency
            // 
            this.cbxAddCurrency.AutoSize = true;
            this.cbxAddCurrency.Location = new System.Drawing.Point(235, 19);
            this.cbxAddCurrency.Name = "cbxAddCurrency";
            this.cbxAddCurrency.Size = new System.Drawing.Size(143, 27);
            this.cbxAddCurrency.TabIndex = 13;
            this.cbxAddCurrency.Tag = "32";
            this.cbxAddCurrency.Text = "Add Currency";
            this.cbxAddCurrency.UseVisualStyleBackColor = true;
            // 
            // cbxCurrencyExchangeList
            // 
            this.cbxCurrencyExchangeList.AutoSize = true;
            this.cbxCurrencyExchangeList.Location = new System.Drawing.Point(16, 64);
            this.cbxCurrencyExchangeList.Name = "cbxCurrencyExchangeList";
            this.cbxCurrencyExchangeList.Size = new System.Drawing.Size(225, 27);
            this.cbxCurrencyExchangeList.TabIndex = 14;
            this.cbxCurrencyExchangeList.Tag = "32";
            this.cbxCurrencyExchangeList.Text = "Currency Exchange List";
            this.cbxCurrencyExchangeList.UseVisualStyleBackColor = true;
            // 
            // cbxAllPermissions
            // 
            this.cbxAllPermissions.AutoSize = true;
            this.cbxAllPermissions.Location = new System.Drawing.Point(139, 372);
            this.cbxAllPermissions.Name = "cbxAllPermissions";
            this.cbxAllPermissions.Size = new System.Drawing.Size(150, 27);
            this.cbxAllPermissions.TabIndex = 15;
            this.cbxAllPermissions.Text = "All Permissions";
            this.cbxAllPermissions.UseVisualStyleBackColor = true;
            this.cbxAllPermissions.CheckedChanged += new System.EventHandler(this.cbxAllPermissions_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPeople);
            this.groupBox1.Controls.Add(this.cbxUsers);
            this.groupBox1.Controls.Add(this.cbxClients);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 85);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxWithdrawDeposit);
            this.groupBox2.Controls.Add(this.cbxTransfer);
            this.groupBox2.Location = new System.Drawing.Point(27, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 114);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxCurrencyCalucator);
            this.groupBox3.Controls.Add(this.cbxAddCurrency);
            this.groupBox3.Controls.Add(this.cbxCurrencyExchangeList);
            this.groupBox3.Location = new System.Drawing.Point(27, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 111);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(444, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxAllPermissions);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissions";
            this.Load += new System.EventHandler(this.frmPermissions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxPeople;
        private System.Windows.Forms.CheckBox cbxUsers;
        private System.Windows.Forms.CheckBox cbxClients;
        private System.Windows.Forms.CheckBox cbxWithdrawDeposit;
        private System.Windows.Forms.CheckBox cbxTransfer;
        private System.Windows.Forms.CheckBox cbxCurrencyCalucator;
        private System.Windows.Forms.CheckBox cbxAddCurrency;
        private System.Windows.Forms.CheckBox cbxCurrencyExchangeList;
        private System.Windows.Forms.CheckBox cbxAllPermissions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}