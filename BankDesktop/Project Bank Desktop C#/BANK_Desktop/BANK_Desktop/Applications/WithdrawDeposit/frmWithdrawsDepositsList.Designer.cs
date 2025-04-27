namespace BANK_Desktop
{
    partial class frmWithdrawsDepositsList
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbxFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dgvWithdrawsDeposits = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeTransaction = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawsDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label3.Location = new System.Drawing.Point(517, -53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 121;
            this.label3.Text = "Manage Clients";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(296, 222);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(266, 27);
            this.txtFilterValue.TabIndex = 119;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbxFilterBy
            // 
            this.cbxFilterBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxFilterBy.FormattingEnabled = true;
            this.cbxFilterBy.Items.AddRange(new object[] {
            "None",
            "Transaction ID",
            "Client ID",
            "User ID",
            "Account Number",
            "Type Transaction"});
            this.cbxFilterBy.Location = new System.Drawing.Point(110, 222);
            this.cbxFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFilterBy.Name = "cbxFilterBy";
            this.cbxFilterBy.Size = new System.Drawing.Size(160, 27);
            this.cbxFilterBy.TabIndex = 118;
            this.cbxFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbxFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(32, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 117;
            this.label1.Text = "Filter By :";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddClient.Location = new System.Drawing.Point(889, 218);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(249, 33);
            this.btnAddClient.TabIndex = 116;
            this.btnAddClient.Text = "Add Deposit/Withdraw";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dgvWithdrawsDeposits
            // 
            this.dgvWithdrawsDeposits.AllowUserToAddRows = false;
            this.dgvWithdrawsDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWithdrawsDeposits.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvWithdrawsDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawsDeposits.Location = new System.Drawing.Point(29, 270);
            this.dgvWithdrawsDeposits.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWithdrawsDeposits.Name = "dgvWithdrawsDeposits";
            this.dgvWithdrawsDeposits.Size = new System.Drawing.Size(1109, 397);
            this.dgvWithdrawsDeposits.TabIndex = 115;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Location = new System.Drawing.Point(1038, 699);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 33);
            this.btnClose.TabIndex = 124;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(128, 705);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(25, 19);
            this.lblRecordsCount.TabIndex = 123;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 705);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "# Records:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label4.Location = new System.Drawing.Point(438, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 29);
            this.label4.TabIndex = 125;
            this.label4.Text = "List Withdraws And Deposits";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbTypeTransaction
            // 
            this.cbTypeTransaction.FormattingEnabled = true;
            this.cbTypeTransaction.Items.AddRange(new object[] {
            "All",
            "Deposit",
            "Withdraw"});
            this.cbTypeTransaction.Location = new System.Drawing.Point(296, 225);
            this.cbTypeTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypeTransaction.Name = "cbTypeTransaction";
            this.cbTypeTransaction.Size = new System.Drawing.Size(116, 21);
            this.cbTypeTransaction.TabIndex = 126;
            this.cbTypeTransaction.SelectedIndexChanged += new System.EventHandler(this.cbTypeTransaction_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BANK_Desktop.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(519, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // frmWithdrawsDepositsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1160, 762);
            this.Controls.Add(this.cbTypeTransaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbxFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dgvWithdrawsDeposits);
            this.Name = "frmWithdrawsDepositsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraws/Deposits List";
            this.Load += new System.EventHandler(this.frmWithdrawsDepositsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawsDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbxFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView dgvWithdrawsDeposits;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeTransaction;
    }
}