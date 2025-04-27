using BANK_BuisnessLayer;
using BANK_Desktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BANK_Desktop.People.frmAddUpdatePerson;

namespace BANK_Desktop.Applications.CurrencyExchange
{
    public partial class frmAddUpdateCurrency : Form
    {
      


        public enum enMode { AddMode = 0, UpdateMode = 1 };
       

        private enMode _Mode;
        clsCurrency _Currency;
        private int _CurrencyID = -1;

        public frmAddUpdateCurrency()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }
        public frmAddUpdateCurrency(int CurrencyID)
        {
            InitializeComponent();
            _CurrencyID = CurrencyID;
            _Mode = enMode.UpdateMode;
        }


        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = new DataTable();
            dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow Row in dtCountries.Rows)
            {
                cbxCountries.Items.Add(Row["CountryName"]);
            }



        }
        private void _ResetDefaultValue()
        {
            _FillCountriesInComboBox();
            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "Add New Currency";
                _Currency = new clsCurrency();
            }
            else
            {
                lblTitle.Text = "Update Currency";

            }

            txtCode.Text = "";
            txtRate.Text = "";
            txtName.Text = "";
            cbxCountries.SelectedIndex = cbxCountries.FindString("Saudi Arabia");



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
        private void _LoadData()
        {
            
            _Currency = clsCurrency.Find(_CurrencyID);
            lblCurrencyID.Text = _Currency.CurrencyID.ToString();
            if (_Currency == null)
            {
                MessageBox.Show("No Person with ID = " + _CurrencyID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtName.Text = _Currency.Name;
            txtCode.Text = _Currency.Code;
            txtRate.Text = _Currency.Rate.ToString();

            
            cbxCountries.SelectedIndex = (clsCountry.Find(_Currency.Country).CountryID)-1;

        }

        private void frmAddUpdateCurrency_Load(object sender, EventArgs e)
        {
            cbxCountries.Focus();
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Currency.Name = txtName.Text.Trim();
            _Currency.Code = txtCode.Text.Trim();
            _Currency.Rate = decimal.Parse(txtRate.Text.Trim());

            int CountryID = clsCountry.Find(cbxCountries.Text).CountryID;
            _Currency.Country = clsCountry.Find(CountryID).CountryName;




            if (_Currency.Save())
            {
                lblTitle.Text = "Update Currency";
                lblCurrencyID.Text = _Currency.CurrencyID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // DataBack?.Invoke(this, _Currency.CurrencyID);
            }

            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
