using BANK_BuisnessLayer;
using BANK_Desktop.Global_Classes;
using BANK_Desktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BANK_BuisnessLayer;
using static BANK_Desktop.People.frmAddUpdatePerson;

namespace BANK_Desktop.Users
{
    public partial class frmAddUpdateUser : Form
    {
       

        public enum enMode { AddMode = 0, UpdateMode = 1 };
      

        private enMode _Mode;
        clsUser _User;
        private int _UserID = -1;



        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;


        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.UpdateMode;
        }

      
        private void _ResetDefaultValue()
        {
            

            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "Add New User";
                this.Text= "Add New User";
                _User = new clsUser();
                tapLoginInfo.Enabled = false;
                ctrlPersonCardWithFilter1.Focus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text= "Update User";
                tapLoginInfo.Enabled = true;
                btnSave.Enabled = false;
            }



            lblUserID.Text = "????";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
           // rdbAllPermmissions.Checked = true;
            chxIsActive.Checked = true;
         


        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
           // lblPersonID.Text = _Person.PersonID.ToString();
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblUserID.Text=_User.UserID.ToString();
            txtUserName.Text=_User.UserName;
            txtPassword.Text=_User.Password;    
            txtPassword.Text=_User.Password;
            txtConfirmPassword.Text = _User.Password;
            //rdbAllPermmissions.Checked = true;
            chxIsActive.Checked=true;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);




        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
        }


     



        




        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };

            if (_Mode == enMode.AddMode)
            {
                if (clsUser.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };


            }
            else
            {

                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.isUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }

            }



        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tapLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tapLoginInfo"];
                return;
            }
            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {

                if (clsUser.isUserExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tapLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tapLoginInfo"];

                }
            }

            else
            {

                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }

        }


        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
           // if (rdbAllPermmissions.Checked) { _User.Permission = -1; }
            //else { 
              


            //    _User.Permission = 0; 
            
            
            //}
            _User.IsActive = chxIsActive.Checked;




            if (_User.Save())
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User"; ;
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }









        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbSelectPermmissions_CheckedChanged(object sender, EventArgs e)
        {
         

        }
        private void frmPermissions_DataBack(object sender,short Permissions) {

            _User.Permission = Permissions;
        }

        //private void rdbAllPermmissions_CheckedChanged(object sender, EventArgs e)
        //{
        //    _User.Permission = (short)clsUser.enPermissions.pAll; ;
        //}

        private void btnSelectPermmissions_Click(object sender, EventArgs e)
        {
            frmPermissions frm = new frmPermissions(_UserID);
            frm.DataBack += frmPermissions_DataBack;
            frm.ShowDialog();
        }
    }
}
