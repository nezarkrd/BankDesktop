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

namespace BANK_Desktop.Users
{
    public partial class frmPermissions : Form
    {
        public delegate void DataBackEventHandler(object sender, short Permission);
        public event DataBackEventHandler DataBack; 
        public short Permission = 0;
        private int _UserID;
        private clsUser _User;
        public frmPermissions(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxAllPermissions.Checked) { Permission = -1; }
            else {

                if (cbxPeople.Checked) { Permission += (short)clsUser.enPermissions.pPeople; }
                if (cbxUsers.Checked) { Permission += (short)clsUser.enPermissions.pUser; }
                if (cbxClients.Checked) { Permission += (short)clsUser.enPermissions.pClient; }
                if (cbxWithdrawDeposit.Checked) { Permission += (short)clsUser.enPermissions.pWithdrawDeposit; }
                if (cbxTransfer.Checked) { Permission += (short)clsUser.enPermissions.pTransfer; }
                if (cbxCurrencyCalucator.Checked) { Permission += (short)clsUser.enPermissions.pCurrencyCalucator; }
                if (cbxAddCurrency.Checked) { Permission += (short)clsUser.enPermissions.pAddCurrency; }
                if (cbxCurrencyExchangeList.Checked) { Permission += (short)clsUser.enPermissions.pCurrencyExchangeList; }




            }
       
           DataBack?.Invoke(this, Permission);
           this.Close();
        }
        
        private void frmPermissions_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(_UserID);

            if(_User.Permission==-1|| _User.Permission == 255)
            {

                cbxPeople.Checked = true;
                cbxUsers.Checked = true;
                cbxClients.Checked = true;
                cbxWithdrawDeposit.Checked = true;
                cbxTransfer.Checked = true;
                cbxCurrencyCalucator.Checked = true;
                cbxAddCurrency.Checked = true;
                cbxCurrencyExchangeList.Checked = true;
            }
            if (_User.Permission == 0)
            {

                cbxPeople.Checked = false;
                cbxUsers.Checked = false;
                cbxClients.Checked = false;
                cbxWithdrawDeposit.Checked = false;
                cbxTransfer.Checked = false;
                cbxCurrencyCalucator.Checked = false;
                cbxAddCurrency.Checked = false;
                cbxCurrencyExchangeList.Checked = false;
            }
            else
            {
                if (_User.CheckPermissions(clsUser.enPermissions.pPeople))
                {
                    cbxPeople.Checked = true;
                }

                if (_User.CheckPermissions(clsUser.enPermissions.pUser))
                {
                    cbxUsers.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pClient))
                {
                    cbxClients.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pWithdrawDeposit))
                {
                    cbxWithdrawDeposit.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pTransfer))
                {
                    cbxTransfer.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pCurrencyCalucator))
                {
                    cbxCurrencyCalucator.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pAddCurrency))
                {
                    cbxAddCurrency.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pCurrencyExchangeList))
                {
                    cbxCurrencyExchangeList.Checked = true;
                }


            }





        }

        private void cbxAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxAllPermissions.Checked) {

                cbxPeople.Checked = true;
                cbxUsers.Checked = true;
                cbxClients.Checked = true;
                cbxWithdrawDeposit.Checked = true;
                cbxTransfer.Checked = true;
                cbxCurrencyCalucator.Checked = true;
                cbxAddCurrency.Checked = true;
                cbxCurrencyExchangeList.Checked = true;

            }
            else
            {
                cbxPeople.Checked = false;
                cbxUsers.Checked = false;
                cbxClients.Checked = false;
                cbxWithdrawDeposit.Checked = false;
                cbxTransfer.Checked = false;
                cbxCurrencyCalucator.Checked = false;
                cbxAddCurrency.Checked = false;
                cbxCurrencyExchangeList.Checked = false;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
