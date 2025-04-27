namespace BANK_Desktop.Applications
{
    partial class frmWithdrawDeopsit
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.ctrlClientCardWithFilter1 = new BANK_Desktop.Clients.Controls.ctrlClientCardWithFilter();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnWithdraw.Location = new System.Drawing.Point(240, 620);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(109, 38);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDeposit.Location = new System.Drawing.Point(564, 620);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(95, 38);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // ctrlClientCardWithFilter1
            // 
            this.ctrlClientCardWithFilter1.BackColor = System.Drawing.Color.LightBlue;
            this.ctrlClientCardWithFilter1.FilterEnabled = true;
            this.ctrlClientCardWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ctrlClientCardWithFilter1.Name = "ctrlClientCardWithFilter1";
            this.ctrlClientCardWithFilter1.Size = new System.Drawing.Size(909, 591);
            this.ctrlClientCardWithFilter1.TabIndex = 3;
            this.ctrlClientCardWithFilter1.OnClientSelected += new System.Action<int>(this.ctrlClientCardWithFilter1_OnClientSelected);
            this.ctrlClientCardWithFilter1.Load += new System.EventHandler(this.ctrlClientCardWithFilter1_Load);
            // 
            // frmWithdrawDeopsit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(923, 672);
            this.Controls.Add(this.ctrlClientCardWithFilter1);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Name = "frmWithdrawDeopsit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw/Deopsit";
            this.Load += new System.EventHandler(this.frmWithdrawDeopsit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private Clients.Controls.ctrlClientCardWithFilter ctrlClientCardWithFilter1;
    }
}