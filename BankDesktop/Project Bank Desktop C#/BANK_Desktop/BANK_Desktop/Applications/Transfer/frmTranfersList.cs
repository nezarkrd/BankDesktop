using BANK_BuisnessLayer;
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

namespace BANK_Desktop.Applications.Transfer
{
    public partial class frmTranfersList : Form
    {
        public frmTranfersList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

      


        private static DataTable _dtTransfers;


      



        private void frmTranfersList_Load(object sender, EventArgs e)
        {
            _dtTransfers =clsTransfer.GetAllTransfers();    
            dgvTransfers.DataSource = _dtTransfers;



            if (_dtTransfers == null || _dtTransfers.Rows.Count == 0)
            {
                MessageBox.Show("not found Operations Transfer ", "Do Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmTransfer frm = new frmTransfer();
                frm.ShowDialog();
                this.Close();
                return;
            }







            cbxFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvTransfers.Rows.Count.ToString();

            dgvTransfers.Columns[0].HeaderText = "Transfer ID";
            dgvTransfers.Columns[0].Width = 110;

            dgvTransfers.Columns[1].HeaderText = "Sender ID";
            dgvTransfers.Columns[1].Width = 110;



            dgvTransfers.Columns[2].HeaderText = "Deposit ID";
            dgvTransfers.Columns[2].Width = 110;

            dgvTransfers.Columns[3].HeaderText = "Date Time";
            dgvTransfers.Columns[3].Width = 140;

            dgvTransfers.Columns[4].HeaderText = "Amount";
            dgvTransfers.Columns[4].Width = 130;



            dgvTransfers.Columns[5].HeaderText = "UserName";
            dgvTransfers.Columns[5].Width = 110;



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


        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbxFilterBy.Text == "Transfer ID" || cbxFilterBy.Text == "Sender ID"|| cbxFilterBy.Text == "Deposit ID" )
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbxFilterBy.Text)
            {

                case "Transfer ID":
                    FilterColumn = "TransferID";
                    break;

                case "Sender ID":
                    FilterColumn = "SenderID";
                    break;

                case "Deposit ID":
                    FilterColumn = "DepositID";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtTransfers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvTransfers.Rows.Count.ToString();
                return;

            }
            
            
                _dtTransfers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            
           

            lblRecordsCount.Text = dgvTransfers.Rows.Count.ToString();
        }




        private void btnAddTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer();
            frm.ShowDialog();
            frmTranfersList_Load(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTransfers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }
    }
}
