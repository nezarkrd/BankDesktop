namespace BANK_Desktop.Applications.Transfer
{
    partial class frmTransfer
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
            this.components = new System.ComponentModel.Container();
            this.tcTransfer = new System.Windows.Forms.TabControl();
            this.tapSender = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlClientCardWithFilter1 = new BANK_Desktop.Clients.Controls.ctrlClientCardWithFilter();
            this.tapReceiver = new System.Windows.Forms.TabPage();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.ctrlClientCardWithFilter2 = new BANK_Desktop.Clients.Controls.ctrlClientCardWithFilter();
            this.tabAmount = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtAmountTransfer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcTransfer.SuspendLayout();
            this.tapSender.SuspendLayout();
            this.tapReceiver.SuspendLayout();
            this.tabAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTransfer
            // 
            this.tcTransfer.Controls.Add(this.tapSender);
            this.tcTransfer.Controls.Add(this.tapReceiver);
            this.tcTransfer.Controls.Add(this.tabAmount);
            this.tcTransfer.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tcTransfer.Location = new System.Drawing.Point(12, 12);
            this.tcTransfer.Name = "tcTransfer";
            this.tcTransfer.SelectedIndex = 0;
            this.tcTransfer.Size = new System.Drawing.Size(1061, 863);
            this.tcTransfer.TabIndex = 0;
            // 
            // tapSender
            // 
            this.tapSender.BackColor = System.Drawing.Color.LightBlue;
            this.tapSender.Controls.Add(this.btnNext);
            this.tapSender.Controls.Add(this.ctrlClientCardWithFilter1);
            this.tapSender.Location = new System.Drawing.Point(4, 32);
            this.tapSender.Name = "tapSender";
            this.tapSender.Padding = new System.Windows.Forms.Padding(3);
            this.tapSender.Size = new System.Drawing.Size(1053, 827);
            this.tapSender.TabIndex = 0;
            this.tapSender.Text = "Sender";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(917, 767);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlClientCardWithFilter1
            // 
            this.ctrlClientCardWithFilter1.BackColor = System.Drawing.Color.LightBlue;
            this.ctrlClientCardWithFilter1.FilterEnabled = true;
            this.ctrlClientCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlClientCardWithFilter1.Location = new System.Drawing.Point(17, 8);
            this.ctrlClientCardWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlClientCardWithFilter1.Name = "ctrlClientCardWithFilter1";
            this.ctrlClientCardWithFilter1.Size = new System.Drawing.Size(1045, 762);
            this.ctrlClientCardWithFilter1.TabIndex = 0;
            this.ctrlClientCardWithFilter1.OnClientSelected += new System.Action<int>(this.ctrlClientCardWithFilter1_OnClientSelected);
            // 
            // tapReceiver
            // 
            this.tapReceiver.BackColor = System.Drawing.Color.LightBlue;
            this.tapReceiver.Controls.Add(this.btnNext2);
            this.tapReceiver.Controls.Add(this.ctrlClientCardWithFilter2);
            this.tapReceiver.Location = new System.Drawing.Point(4, 32);
            this.tapReceiver.Name = "tapReceiver";
            this.tapReceiver.Padding = new System.Windows.Forms.Padding(3);
            this.tapReceiver.Size = new System.Drawing.Size(1053, 827);
            this.tapReceiver.TabIndex = 1;
            this.tapReceiver.Text = "Receiver";
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(917, 778);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(120, 36);
            this.btnNext2.TabIndex = 3;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // ctrlClientCardWithFilter2
            // 
            this.ctrlClientCardWithFilter2.BackColor = System.Drawing.Color.LightBlue;
            this.ctrlClientCardWithFilter2.FilterEnabled = true;
            this.ctrlClientCardWithFilter2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlClientCardWithFilter2.Location = new System.Drawing.Point(8, 8);
            this.ctrlClientCardWithFilter2.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlClientCardWithFilter2.Name = "ctrlClientCardWithFilter2";
            this.ctrlClientCardWithFilter2.Size = new System.Drawing.Size(1049, 762);
            this.ctrlClientCardWithFilter2.TabIndex = 1;
            this.ctrlClientCardWithFilter2.OnClientSelected += new System.Action<int>(this.ctrlClientCardWithFilter2_OnClientSelected);
            // 
            // tabAmount
            // 
            this.tabAmount.BackColor = System.Drawing.Color.LightBlue;
            this.tabAmount.Controls.Add(this.btnSend);
            this.tabAmount.Controls.Add(this.txtAmountTransfer);
            this.tabAmount.Controls.Add(this.label1);
            this.tabAmount.Location = new System.Drawing.Point(4, 32);
            this.tabAmount.Name = "tabAmount";
            this.tabAmount.Size = new System.Drawing.Size(1053, 827);
            this.tabAmount.TabIndex = 2;
            this.tabAmount.Text = "Amount";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(471, 445);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtAmountTransfer
            // 
            this.txtAmountTransfer.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtAmountTransfer.Location = new System.Drawing.Point(402, 370);
            this.txtAmountTransfer.Name = "txtAmountTransfer";
            this.txtAmountTransfer.Size = new System.Drawing.Size(217, 33);
            this.txtAmountTransfer.TabIndex = 1;
            this.txtAmountTransfer.TextChanged += new System.EventHandler(this.txtAmountTransfer_TextChanged);
            this.txtAmountTransfer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountTransfer_KeyPress);
            this.txtAmountTransfer.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountTransfer_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(364, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Transfer Amount:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(795, 884);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(933, 884);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1091, 932);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcTransfer);
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tranfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.tcTransfer.ResumeLayout(false);
            this.tapSender.ResumeLayout(false);
            this.tapReceiver.ResumeLayout(false);
            this.tabAmount.ResumeLayout(false);
            this.tabAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTransfer;
        private System.Windows.Forms.TabPage tapSender;
        private Clients.Controls.ctrlClientCardWithFilter ctrlClientCardWithFilter1;
        private System.Windows.Forms.TabPage tapReceiver;
        private System.Windows.Forms.TabPage tabAmount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNext2;
        private Clients.Controls.ctrlClientCardWithFilter ctrlClientCardWithFilter2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtAmountTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}