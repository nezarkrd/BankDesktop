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

namespace BANK_Desktop.Clients.Controls
{
    public partial class ctrlClientCard : UserControl
    {

        private int _ClientID= -1;
        private clsClient _Client;

        public int ClientID
        {
            get { return _ClientID; }
        }

        public clsClient SelectClientInfo
        {

            get { return _Client; }
        }


        public ctrlClientCard()
        {
            InitializeComponent();
        }



        private void _FillClientInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_Client.PersonID);
            lblClientID.Text = _Client.ClientID.ToString();
            lblAccountNumber.Text = _Client.AccountNumber;
            lblBalance.Text= _Client.Balance.ToString();

        }


        private void _ResetClientInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblClientID.Text = "????";
            lblAccountNumber.Text = "????";
            lblBalance.Text = "????";


        }

        public void LoadClientInfo(int ClientID)
        {
            _Client = clsClient.Find(ClientID);
            if (_Client == null)
            {
                _ResetClientInfo();
                MessageBox.Show("No Client with ClientID = " + ClientID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _FillClientInfo();

        }
        public void LoadClientInfo(string AccountNumber)
        {
            _Client = clsClient.Find(AccountNumber);
            if (_Client == null)
            {
                _ResetClientInfo();
                MessageBox.Show("No Client with Account Number = " + ClientID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillClientInfo();




        }


        private void ctrlClientCard_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
