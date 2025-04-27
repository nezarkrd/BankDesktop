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

namespace BANK_Desktop.Applications
{
    public partial class frmDeposit : Form
    {
        public delegate void DataBackEventHandler(object sender, int ClientID);
        public event DataBackEventHandler DataBack;



        private bool _CheckPasswordDeposit = false;
        private int _ClientID = -1;
        public frmDeposit(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;   
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {

        }
        private void frmCheckPassword_DataBack(object sender, bool CheckPassword)
        {
            _CheckPasswordDeposit = CheckPassword;

        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            clsClient Client = clsClient.Find(_ClientID);
            int AmountDeposit= int.Parse(txtAmount.Text.Trim());


            frmInputPasswordClient frmCheckPassword = new frmInputPasswordClient(Client.ClientID);
            frmCheckPassword.DataBack += frmCheckPassword_DataBack;
            frmCheckPassword.ShowDialog();

            if (_CheckPasswordDeposit) {
                clsWithdrawDepositClient WithdrawDepositClient = new clsWithdrawDepositClient();
                WithdrawDepositClient.ClientID = _ClientID;
                WithdrawDepositClient.DateTime = DateTime.Now;
                WithdrawDepositClient.AccountNumber = Client.AccountNumber;
                WithdrawDepositClient.OldBalance = Client.Balance;
                WithdrawDepositClient.Amount = AmountDeposit;
                WithdrawDepositClient.TypeTransaction = 1;
                WithdrawDepositClient.CurrentBalance = Client.Balance + AmountDeposit;
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

            else
            {
                MessageBox.Show("password is not correct .... Dont Withdraw");

            }


        }
    }
}
