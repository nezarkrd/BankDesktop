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

namespace BANK_Desktop.Applications.CurrencyExchange
{
    public partial class frmCurrencyCalucator : Form
    {
        
     


        public frmCurrencyCalucator()
        {
            InitializeComponent();
        }
        private void _FillCodesCurrenciesInComboBoxes()
        {
            DataTable dtCodesCurrenciesFrom = new DataTable();
            dtCodesCurrenciesFrom = clsCurrency.GetAllCurrencies();

            foreach (DataRow Row in dtCodesCurrenciesFrom.Rows)
            {
                cbxCurrencyCodeFrom.Items.Add(Row["Code"]);
            }




            DataTable dtCodesCurrenciesTo= new DataTable();
            dtCodesCurrenciesTo = clsCurrency.GetAllCurrencies();

            foreach (DataRow Row in dtCodesCurrenciesTo.Rows)
            {
                cbxCurrencyCodeTo.Items.Add(Row["Code"]);
            }


        }
        private void frmCurrencyCalucator_Load(object sender, EventArgs e)
        {
            _FillCodesCurrenciesInComboBoxes();
            //cbxCurrencyCodeFrom.SelectedIndex = clsCurrency.FindByCode("USD").CurrencyID;
            //cbxCurrencyCodeTo.SelectedIndex=clsCurrency.FindByCode("USD").CurrencyID;
            cbxCurrencyCodeFrom.Text = "USD";
            cbxCurrencyCodeTo.Text = "USD";
            lblResult.Visible=false;    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            
          
          clsCurrency _Currency1 = clsCurrency.FindByCode(cbxCurrencyCodeFrom.Text);
          clsCurrency _Currency2 = clsCurrency.FindByCode(cbxCurrencyCodeTo.Text);
          decimal Amount=decimal.Parse(txtAmount.Text.Trim());

          decimal Result= clsCurrency.ConvertToOtherCurrency(Amount, _Currency1, _Currency2);
          lblResult.Visible = true;
          lblResult.Text = Amount+ _Currency1.Code + " = " + Result.ToString() + _Currency2.Code;   


        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
