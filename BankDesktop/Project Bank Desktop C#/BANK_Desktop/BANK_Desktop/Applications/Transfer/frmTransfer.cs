using BANK_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BANK_BuisnessLayer;
using BANK_Desktop.Global_Classes;

namespace BANK_Desktop.Applications.Transfer
{
    public partial class frmTransfer : Form
    {

        public delegate void DataBackEventHandler(object sender, int ClientID);
        public event DataBackEventHandler DataBack;



        private bool _CheckPasswordTransfer = false;



        private int _SenderClientID = -1;
        private int _RecieverClientID = -1;
        private clsClient _SenderClient;
        private clsClient _RecieverClient;


        public frmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {

            tcTransfer.SelectedIndex = 0;
            tapReceiver.Enabled=false;
            tabAmount.Enabled = false;
        }

        private void ctrlClientCardWithFilter1_OnClientSelected(int obj)
        {
            _SenderClientID = obj;
        }

        private void ctrlClientCardWithFilter2_OnClientSelected(int obj)
        {
            _RecieverClientID = obj;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            tcTransfer.SelectedIndex =1;
            tapReceiver.Enabled = true;
            tabAmount.Enabled = false;


        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
          

           
        }

        private void txtAmountTransfer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountTransfer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmountTransfer.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAmountTransfer, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAmountTransfer, null);
            };



        }

        private void txtAmountTransfer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
     
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            tcTransfer.SelectedIndex = 2;
            tapReceiver.Enabled = true;
            tabAmount.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            clsTransfer Transfer = new clsTransfer();
            Transfer.SenderID = _SenderClientID;
            Transfer.DepositID = _RecieverClientID;
            Transfer.dateTime = DateTime.Now;   
            Transfer.Amount = decimal.Parse(txtAmountTransfer.Text.Trim());
            Transfer.UserID = clsGlobal.CurrentUser.UserID;
            Transfer.SenderInfo = clsClient.Find(_SenderClientID);
            Transfer.DepositInfo = clsClient.Find(_RecieverClientID);

            frmInputPasswordClient frmCheckPassword = new frmInputPasswordClient(Transfer.SenderInfo.ClientID);
            frmCheckPassword.DataBack += frmCheckPassword_DataBack;
            frmCheckPassword.ShowDialog();

            if (_CheckPasswordTransfer)
            {
                if (!clsWithdrawDepositClient.BalanceIsEnough(Transfer.SenderInfo.Balance, Transfer.Amount))
                {
                    MessageBox.Show("Account is not enough");
                }
                else
                {

                    if (Transfer.Save())
                    {
                        MessageBox.Show("succesfuly Save");
                        // DataBack?.Invoke(this, _ClientID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Faild Save");
                    }



                }
            }

            else
            {
                MessageBox.Show("password is not correct .... Dont Transfer");

            }



        }




        private void frmCheckPassword_DataBack(object sender, bool CheckPassword)
        {
            _CheckPasswordTransfer = CheckPassword;

        }
    }
}
