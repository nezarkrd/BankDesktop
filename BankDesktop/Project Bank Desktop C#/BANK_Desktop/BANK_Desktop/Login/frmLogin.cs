using BANK_BuisnessLayer;
using BANK_Desktop.Global_Classes;
using BANKDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BANK_Desktop.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";
            if(clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;    
                txtPassword.Text = Password;    
                cbxRememberMe.Checked = true;
                
            }
            else
            {
                cbxRememberMe.Checked = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (User != null) {
            
              if(cbxRememberMe.Checked) {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                
                }
              else {
                    clsGlobal.RememberUsernameAndPassword("","");

                }


              if (!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }
            
            clsGlobal.CurrentUser = User;   
            this.Hide();    
            frmMain frm =new frmMain(this);
            frm.Show(); 
            
            
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsProps props = new clsProps();

            if (props.CheckShow == true)
            {
                MessageBox.Show("You are not allowed to modify network information.", "OK");
                Form frm = new frmCode();
                frm.ShowDialog();

            }
            else
            {
                Form frm = new frmSettingsNetwork();
                frm.ShowDialog();
            }
        }

        private void cbxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
