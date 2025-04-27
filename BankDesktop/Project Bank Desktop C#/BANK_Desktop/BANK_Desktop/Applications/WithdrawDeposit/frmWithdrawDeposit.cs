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
    public partial class frmWithdrawDeopsit : Form
    {

        private int _ClientID = -1;

        public frmWithdrawDeopsit()
        {
            InitializeComponent();

        }

        private void frmWithdrawDeopsit_Load(object sender, EventArgs e)
        {
            if (_ClientID != -1)
            {
                ctrlClientCardWithFilter1.LoadClientInfo(_ClientID);
            }


        }
        private void ctrlClientCardWithFilter1_OnClientSelected(int obj)
        {
            _ClientID = obj;
        }


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw frm = new frmWithdraw(_ClientID);
            frm.DataBack += Form_DataBack;
            frm.ShowDialog();
            frmWithdrawDeopsit_Load(null, null);



        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit frm = new frmDeposit(_ClientID);
            frm.DataBack += Form_DataBack;
            frm.ShowDialog();
            frmWithdrawDeopsit_Load(null, null);
        }


          public void Form_DataBack(object sender, int ClientID)
            {

            _ClientID=ClientID;


            }

        private void ctrlClientCard1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlClientCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
