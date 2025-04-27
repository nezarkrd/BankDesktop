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

namespace BANK_Desktop.Clients
{
    public partial class frmAddUpdateCustomer : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int ClientID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public enum enMode { AddMode = 0, UpdateMode = 1 };
        private enMode _Mode;
        clsClient _Client;
        private int _ClientID = -1;


        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateCustomer(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            _Mode = enMode.UpdateMode;
            
        }


        private void _ResetDefaultValue()
        {


            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "Add New Client";
                this.Text = "Add New Client";
                _Client = new clsClient();
                tabClientInfo.Enabled = false;
                ctrlPersonCardWithFilter1.Focus();
            }
            else
            {
                lblTitle.Text = "Update Client";
                this.Text = "Update Client";
                tcClientInfo.Enabled = true;
                btnSave.Enabled = false;
            }



            lblClientID.Text = "????";
            txtAccountNumber.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtBalance.Text = "0";
          



        }
        private void _LoadData()
        {
            _Client = clsClient.Find(_ClientID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            // lblPersonID.Text = _Person.PersonID.ToString();
            if (_Client == null)
            {
                MessageBox.Show("No Client with ID = " + _ClientID, "Client Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblClientID.Text = _Client.ClientID.ToString();
            txtAccountNumber.Text = _Client.AccountNumber;
            txtPassword.Text = _Client.Password;
            txtConfirmPassword.Text = _Client.Password;
            txtBalance.Text = _Client.Balance.ToString();
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Client.PersonID);


        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

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
        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAccountNumber, null);
            };

            if (_Mode == enMode.AddMode)
            {

                
                if (clsClient.isClientExist(txtAccountNumber.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtAccountNumber, "AccountNumber is used by another Client");
                }
                else
                {
                    errorProvider1.SetError(txtAccountNumber, null);
                };


            }
            else
            {

                //incase update make sure not to use anothers user name
                if (_Client.AccountNumber != txtAccountNumber.Text.Trim())
                {
                    
                    if(clsClient.isClientExist(txtAccountNumber.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtAccountNumber, "AccountNumber is used by another Client");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtAccountNumber, null);
                    };
                }

            }
        }

        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
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

        private void txtConfirmPassword_Validating_1(object sender, CancelEventArgs e)
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



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Client.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Client.AccountNumber = txtAccountNumber.Text.Trim();
            _Client.Password = txtPassword.Text.Trim();
            _Client.Balance= decimal.Parse(txtBalance.Text.Trim());  

           


            if (_Client.Save())
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User"; ;
                lblClientID.Text = _Client.ClientID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Client.ClientID);

            }

            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tabClientInfo.Enabled = true;
                tcClientInfo.SelectedTab = tcClientInfo.TabPages["tabClientInfo"];
                return;
            }
            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if (clsClient.isClientExistByPersonID(ctrlPersonCardWithFilter1.PersonID))

                {

                    MessageBox.Show("Selected Person already has a Client, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tabClientInfo.Enabled = true;
                    tcClientInfo.SelectedTab = tcClientInfo.TabPages["tabClientInfo"];

                }
            }

            else
            {

                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }



















        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {


        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tabClientInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
