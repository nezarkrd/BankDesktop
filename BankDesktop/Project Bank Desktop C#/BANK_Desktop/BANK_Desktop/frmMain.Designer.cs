namespace BANK_Desktop
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithdrawDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyExchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyExchangeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.transationsToolStripMenuItem,
            this.currencyExchangeToolStripMenuItem,
            this.AccountSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(91, 34);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(89, 34);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // transationsToolStripMenuItem
            // 
            this.transationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WithdrawDepositToolStripMenuItem,
            this.tranferToolStripMenuItem});
            this.transationsToolStripMenuItem.Name = "transationsToolStripMenuItem";
            this.transationsToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
            this.transationsToolStripMenuItem.Text = "Transations";
            this.transationsToolStripMenuItem.Click += new System.EventHandler(this.transationsToolStripMenuItem_Click);
            // 
            // WithdrawDepositToolStripMenuItem
            // 
            this.WithdrawDepositToolStripMenuItem.Name = "WithdrawDepositToolStripMenuItem";
            this.WithdrawDepositToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.WithdrawDepositToolStripMenuItem.Text = "Withdraw\\Deposit";
            this.WithdrawDepositToolStripMenuItem.Click += new System.EventHandler(this.WithdrawDepositToolStripMenuItem_Click);
            // 
            // tranferToolStripMenuItem
            // 
            this.tranferToolStripMenuItem.Name = "tranferToolStripMenuItem";
            this.tranferToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.tranferToolStripMenuItem.Text = "Transfer";
            this.tranferToolStripMenuItem.Click += new System.EventHandler(this.tranferToolStripMenuItem_Click);
            // 
            // currencyExchangeToolStripMenuItem
            // 
            this.currencyExchangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.addCurrencyToolStripMenuItem,
            this.currencyExchangeListToolStripMenuItem});
            this.currencyExchangeToolStripMenuItem.Name = "currencyExchangeToolStripMenuItem";
            this.currencyExchangeToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.currencyExchangeToolStripMenuItem.Text = "Currency Exchange";
            this.currencyExchangeToolStripMenuItem.Click += new System.EventHandler(this.currencyExchangeToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.cToolStripMenuItem.Text = "Currency Calucator";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // currencyExchangeListToolStripMenuItem
            // 
            this.currencyExchangeListToolStripMenuItem.Name = "currencyExchangeListToolStripMenuItem";
            this.currencyExchangeListToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.currencyExchangeListToolStripMenuItem.Text = "Currency Exchange List";
            this.currencyExchangeListToolStripMenuItem.Click += new System.EventHandler(this.currencyExchangeListToolStripMenuItem_Click);
            // 
            // AccountSettings
            // 
            this.AccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInformationToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.AccountSettings.Name = "AccountSettings";
            this.AccountSettings.Size = new System.Drawing.Size(186, 34);
            this.AccountSettings.Text = "Account Settings";
            // 
            // currentUserInformationToolStripMenuItem
            // 
            this.currentUserInformationToolStripMenuItem.Name = "currentUserInformationToolStripMenuItem";
            this.currentUserInformationToolStripMenuItem.Size = new System.Drawing.Size(328, 34);
            this.currentUserInformationToolStripMenuItem.Text = "Current User Information";
            this.currentUserInformationToolStripMenuItem.Click += new System.EventHandler(this.currentUserInformationToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(328, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(328, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BANK_Desktop.Properties.Resources.backgorund;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1254, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addCurrencyToolStripMenuItem
            // 
            this.addCurrencyToolStripMenuItem.Name = "addCurrencyToolStripMenuItem";
            this.addCurrencyToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.addCurrencyToolStripMenuItem.Text = "Add Currency";
            this.addCurrencyToolStripMenuItem.Click += new System.EventHandler(this.addCurrencyToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transationsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem AccountSettings;
        private System.Windows.Forms.ToolStripMenuItem WithdrawDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyExchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyExchangeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCurrencyToolStripMenuItem;
    }
}