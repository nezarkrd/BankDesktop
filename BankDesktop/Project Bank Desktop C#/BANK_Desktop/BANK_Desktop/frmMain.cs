
using BANK_BuisnessLayer;
using BANK_Desktop.Applications;
using BANK_Desktop.Applications.CurrencyExchange;
using BANK_Desktop.Applications.Transfer;
using BANK_Desktop.Clients;
using BANK_Desktop.Global_Classes;
using BANK_Desktop.Login;
using BANK_Desktop.People;
using BANK_Desktop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BANK_BuisnessLayer.clsUser;

namespace BANK_Desktop
{
    public partial class frmMain : Form
    {

        frmLogin _frmLogin;

        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pPeople)) {
                frmListPeople frm = new frmListPeople();
                frm.ShowDialog();

            }
               
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pUser)) {
                frmListUsers frm = new frmListUsers();
                frm.ShowDialog();


            }

           
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pClient)) {

                frmListClients frm = new frmListClients();
                frm.ShowDialog();

            }
           
        }

        private void transationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void WithdrawDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pWithdrawDeposit))
            {
                frmWithdrawsDepositsList frm = new frmWithdrawsDepositsList();
                frm.ShowDialog();

            }
          
        }

        private void tranferToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pTransfer)) {

                frmTranfersList frm = new frmTranfersList();
                frm.ShowDialog();
            }
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();   
        }

        private void currentUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm=new frmUserInfo(clsGlobal.CurrentUser.UserID);  
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm=new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();   
        }

        private void currencyExchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pCurrencyCalucator))
            {
                frmCurrencyCalucator frm = new frmCurrencyCalucator();
                frm.ShowDialog();

            }
           
            
        }

        private void currencyExchangeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pCurrencyExchangeList))
            {
                frmCurrencyExchangeList frm = new frmCurrencyExchangeList();
                frm.ShowDialog();

            }
                
           
        }

        private void addCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pAddCurrency))
            {
                frmAddUpdateCurrency frm = new frmAddUpdateCurrency();
                frm.ShowDialog();
            }
          
        }
    }
}
