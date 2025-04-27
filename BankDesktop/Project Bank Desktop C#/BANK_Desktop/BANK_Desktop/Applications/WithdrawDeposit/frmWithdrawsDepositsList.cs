using BANK_BuisnessLayer;
using BANK_Desktop.Applications;
using BANK_Desktop.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_Desktop
{
    public partial class frmWithdrawsDepositsList : Form
    {


        private static DataTable _dtWithdrawsDeposits;

        public frmWithdrawsDepositsList()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWithdrawsDepositsList_Load(object sender, EventArgs e)
        {


            _dtWithdrawsDeposits = clsWithdrawDepositClient.GetAllWithdrawDepositClient();


            if (_dtWithdrawsDeposits == null || _dtWithdrawsDeposits.Rows.Count == 0)
            {
                MessageBox.Show("not found Operations Withdrwa-Deposit ", "add Withdrwa or Deposit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmWithdrawDeopsit frm = new frmWithdrawDeopsit();
                frm.ShowDialog();
                this.Close();
                return;
            }




            dgvWithdrawsDeposits.DataSource = _dtWithdrawsDeposits;

            cbxFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvWithdrawsDeposits.Rows.Count.ToString();

            dgvWithdrawsDeposits.Columns[0].HeaderText = "ID";
            dgvWithdrawsDeposits.Columns[0].Width = 110;

            dgvWithdrawsDeposits.Columns[1].HeaderText = "Client ID";
            dgvWithdrawsDeposits.Columns[1].Width = 110;



            dgvWithdrawsDeposits.Columns[2].HeaderText = "Date Time";
            dgvWithdrawsDeposits.Columns[2].Width = 140;


            dgvWithdrawsDeposits.Columns[3].HeaderText = "Account Number";
            dgvWithdrawsDeposits.Columns[3].Width = 140;

            dgvWithdrawsDeposits.Columns[4].HeaderText = "Old Balance";
            dgvWithdrawsDeposits.Columns[4].Width = 130;

            dgvWithdrawsDeposits.Columns[5].HeaderText = "Amount";
            dgvWithdrawsDeposits.Columns[5].Width = 130;

            dgvWithdrawsDeposits.Columns[6].HeaderText = "Type Transaction";
            dgvWithdrawsDeposits.Columns[6].Width = 130;

            dgvWithdrawsDeposits.Columns[7].HeaderText = "Current Balance";
            dgvWithdrawsDeposits.Columns[7].Width = 130;


            dgvWithdrawsDeposits.Columns[8].HeaderText = "UserName";
            dgvWithdrawsDeposits.Columns[8].Width = 130;
        }







        private void cbxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilterBy.Text == "Type Transaction")
            {
                cbTypeTransaction.Visible = true;
                cbTypeTransaction.Focus();
                cbTypeTransaction.SelectedIndex = 0;
                txtFilterValue.Visible = false;

            }
            else
            {
                txtFilterValue.Visible = (cbxFilterBy.Text != "None");
                cbTypeTransaction.Visible = false;
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
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

                //we allow number incase person id or user id is selected.
                if (cbxFilterBy.Text == "Transaction ID" || cbxFilterBy.Text == "Client ID" || cbxFilterBy.Text == "User ID")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void cbTypeTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "TypeTransiction";
            string FilterValue = cbTypeTransaction.Text;
            short Value = 0;
            switch (FilterValue)
            {
                case "All":
                    break;
                case "Deposit":
                    Value = 1;
                    break;
                case "Withdraw":
                    Value =2;
                    break;
            }

            if (FilterValue == "All")
            {
                _dtWithdrawsDeposits.DefaultView.RowFilter = "";
            }
            else
            {
                _dtWithdrawsDeposits.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Value);

            }
            lblRecordsCount.Text = dgvWithdrawsDeposits.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbxFilterBy.Text)
            {

                case "Transaction ID":
                    FilterColumn = "ID";
                    break;

                case "Client ID":
                    FilterColumn = "ClientID";
                    break;
                
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Account Number":
                    FilterColumn = "AccountNumber";
                    break;
                case "Type Transaction":
                    FilterColumn = "TypeTransiction";
                    break;
                    
                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtWithdrawsDeposits.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvWithdrawsDeposits.Rows.Count.ToString();
                return;

            }
            if (FilterColumn != "AccountNumber")
            {
                _dtWithdrawsDeposits.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                
            }
            else
            {
                _dtWithdrawsDeposits.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvWithdrawsDeposits.Rows.Count.ToString();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmWithdrawDeopsit frm = new frmWithdrawDeopsit();
            frm.ShowDialog();
            frmWithdrawsDepositsList_Load(null,null);
        }
    }
}
