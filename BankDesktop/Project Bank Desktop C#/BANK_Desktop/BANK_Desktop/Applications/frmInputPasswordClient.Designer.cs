namespace BANK_Desktop.Applications
{
    partial class frmInputPasswordClient
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
            this.lblInputPasswordClient = new System.Windows.Forms.Label();
            this.txtInputPasswordClient = new System.Windows.Forms.TextBox();
            this.btnOkPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputPasswordClient
            // 
            this.lblInputPasswordClient.AutoSize = true;
            this.lblInputPasswordClient.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblInputPasswordClient.Location = new System.Drawing.Point(135, 55);
            this.lblInputPasswordClient.Name = "lblInputPasswordClient";
            this.lblInputPasswordClient.Size = new System.Drawing.Size(214, 27);
            this.lblInputPasswordClient.TabIndex = 0;
            this.lblInputPasswordClient.Text = "Input Your Password";
            // 
            // txtInputPasswordClient
            // 
            this.txtInputPasswordClient.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtInputPasswordClient.Location = new System.Drawing.Point(140, 116);
            this.txtInputPasswordClient.Name = "txtInputPasswordClient";
            this.txtInputPasswordClient.Size = new System.Drawing.Size(209, 33);
            this.txtInputPasswordClient.TabIndex = 1;
            // 
            // btnOkPassword
            // 
            this.btnOkPassword.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnOkPassword.Location = new System.Drawing.Point(204, 179);
            this.btnOkPassword.Name = "btnOkPassword";
            this.btnOkPassword.Size = new System.Drawing.Size(75, 36);
            this.btnOkPassword.TabIndex = 2;
            this.btnOkPassword.Text = "OK";
            this.btnOkPassword.UseVisualStyleBackColor = true;
            this.btnOkPassword.Click += new System.EventHandler(this.btnOkPassword_Click);
            // 
            // frmInputPasswordClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(503, 258);
            this.Controls.Add(this.btnOkPassword);
            this.Controls.Add(this.txtInputPasswordClient);
            this.Controls.Add(this.lblInputPasswordClient);
            this.Name = "frmInputPasswordClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Password Client";
            this.Load += new System.EventHandler(this.frmInputPasswordClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputPasswordClient;
        private System.Windows.Forms.TextBox txtInputPasswordClient;
        private System.Windows.Forms.Button btnOkPassword;
    }
}