using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_Desktop.Clients
{
    public partial class frmClientInfo : Form
    {

        private int _ClientID=-1;



        public frmClientInfo()
        {
            InitializeComponent();
        }
        public frmClientInfo(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void frmClientInfo_Load(object sender, EventArgs e)
        {
            ctrlClientCard1.LoadClientInfo(_ClientID);
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        private void ctrlClientCard1_Load(object sender, EventArgs e)
        {

        }


    }
}
