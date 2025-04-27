using BANK_BuisnessLayer;
using BANK_Desktop.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_Desktop.Applications
{
    public partial class frmWithdraw : Form
    {
        public delegate void DataBackEventHandler(object sender, int ClientID);
        public event DataBackEventHandler DataBack;









        private bool _CheckPasswordWithdrwa = false;

        private int _ClientID = -1;

        public frmWithdraw(int clientID)
        {
            InitializeComponent();
            _ClientID = clientID;
        }


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
           
            clsClient Client = clsClient.Find(_ClientID);

            int AmountDeposit = int.Parse(txtAmount.Text.Trim());

            frmInputPasswordClient frmCheckPassword =new frmInputPasswordClient(Client.ClientID);
            frmCheckPassword.DataBack += frmCheckPassword_DataBack;
            frmCheckPassword.ShowDialog();


            if (_CheckPasswordWithdrwa)
            {
                if (!clsWithdrawDepositClient.BalanceIsEnough(Client.Balance, AmountDeposit))
                {
                    MessageBox.Show("Account is not enough");
                }

                else
                {
                    clsWithdrawDepositClient WithdrawDepositClient = new clsWithdrawDepositClient();
                    WithdrawDepositClient.ClientID = _ClientID;
                    WithdrawDepositClient.DateTime = DateTime.Now;
                    WithdrawDepositClient.AccountNumber = Client.AccountNumber;
                    WithdrawDepositClient.OldBalance = Client.Balance;
                    WithdrawDepositClient.Amount = AmountDeposit;
                    WithdrawDepositClient.TypeTransaction = 2;
                    WithdrawDepositClient.CurrentBalance = Client.Balance - AmountDeposit;
                    WithdrawDepositClient.UserID = clsGlobal.CurrentUser.UserID;

                    if (WithdrawDepositClient.Save())
                    {

                        MessageBox.Show("succesfuly Save");
                        DataBack?.Invoke(this, _ClientID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Faild Save");
                    }
                }
            }
            else {
                MessageBox.Show("password is not correct .... Dont Withdraw");
            
            }

           
        }

        private void frmCheckPassword_DataBack(object sender,bool CheckPassword)
        {
            _CheckPasswordWithdrwa = CheckPassword;

        }



















        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
