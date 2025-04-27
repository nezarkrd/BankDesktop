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
    public partial class frmInputPasswordClient : Form
    {

        public delegate void DataBackEventHandler(object sender, bool CheckPassword);
        public event DataBackEventHandler DataBack; 

        private int _ClientID = -1;
        private clsClient _clsClient;   

        public frmInputPasswordClient(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;

        }

        private void frmInputPasswordClient_Load(object sender, EventArgs e)
        {
            txtInputPasswordClient.Text = "";
            txtInputPasswordClient.Focus();
        }

        private void btnOkPassword_Click(object sender, EventArgs e)
        {
            _clsClient = clsClient.Find(_ClientID);
           
            if(clsGlobal.CheckPasswordClient(_clsClient, txtInputPasswordClient.Text.Trim()))
            {
                
                MessageBox.Show("password is Correct");
                this.Close();
                DataBack?.Invoke(this, true);

            }
            else { MessageBox.Show("password is not Correct"); }
           
            


        }
    }
}
