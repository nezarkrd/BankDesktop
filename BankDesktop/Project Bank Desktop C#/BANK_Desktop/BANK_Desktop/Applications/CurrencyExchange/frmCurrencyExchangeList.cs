using BANK_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_Desktop.Applications.CurrencyExchange
{
    public partial class frmCurrencyExchangeList : Form
    {
        public frmCurrencyExchangeList()
        {
            InitializeComponent();
        }


        private static DataTable _dtCurrencies;


        private void CurrencyExchangeList_Load(object sender, EventArgs e)
        {
            _dtCurrencies =clsCurrency.GetAllCurrencies();  
            dgvCurrencies.DataSource = _dtCurrencies;

            cbxFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvCurrencies.Rows.Count.ToString();



            dgvCurrencies.Columns[0].HeaderText = "Currency ID";
            dgvCurrencies.Columns[0].Width = 110;

            dgvCurrencies.Columns[1].HeaderText = "Country";
            dgvCurrencies.Columns[1].Width = 110;



            dgvCurrencies.Columns[2].HeaderText = "Code";
            dgvCurrencies.Columns[2].Width = 110;

           
        }
      






        private void cbxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbxFilterBy.Text != "None");

            if (cbxFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }

            else
            {
                txtFilterValue.Enabled = true;

            }

            txtFilterValue.Focus();
            txtFilterValue.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbxFilterBy.Text)
            {

                case "Currency ID":
                    FilterColumn = "CurrencyID";
                    break;

                case "Country":
                    FilterColumn = "Country";
                    break;

                case "Code":
                    FilterColumn = "Code";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtCurrencies.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCurrencies.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "CurrencyID")
            {
                _dtCurrencies.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtCurrencies.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }





            lblRecordsCount.Text = dgvCurrencies.Rows.Count.ToString();
        }


        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbxFilterBy.Text == "Currency ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddTransfer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCurrency frm=new frmAddUpdateCurrency();    
            frm.ShowDialog();
            CurrencyExchangeList_Load(null, null);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCurrency frm= new frmAddUpdateCurrency((int)dgvCurrencies.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            CurrencyExchangeList_Load(null, null);

        }
    }
}
