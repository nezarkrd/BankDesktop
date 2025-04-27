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

namespace BANK_Desktop.Clients
{
    public partial class frmListClients : Form
    {

        private static DataTable _dtClients;


        public frmListClients()
        {
            InitializeComponent();
        }




        private void frmListClients_Load(object sender, EventArgs e)
        {
            _dtClients = clsClient.GetAllClients();
            dgvClints.DataSource = _dtClients;

            if (_dtClients == null || _dtClients.Rows.Count == 0)
            {
                MessageBox.Show("Not found Clients", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
                frm.ShowDialog();
                this.Close();
                return;
            }


            cbxFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvClints.Rows.Count.ToString();

            dgvClints.Columns[0].HeaderText = "Client ID";
            dgvClints.Columns[0].Width = 110;

            dgvClints.Columns[1].HeaderText = "Person ID";
            dgvClints.Columns[1].Width = 110;



            dgvClints.Columns[2].HeaderText = "Account Number";
            dgvClints.Columns[2].Width = 140;

         



            dgvClints.Columns[3].HeaderText = "Balance";
            dgvClints.Columns[3].Width = 140;



        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();
            frmListClients_Load(null, null);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (cbxFilterBy.Text == "Person ID" || cbxFilterBy.Text == "Client ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }














        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            switch (cbxFilterBy.Text)
            {

                case "Client ID":
                    FilterColumn = "ClientID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Account Number":
                    FilterColumn = "AccountNumber";
                    break;

                case "Balance":
                    FilterColumn = "Balance";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtClients.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvClints.Rows.Count.ToString();
                return;

            }
            if (FilterColumn != "AccountNumber")
            {
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else
            {
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvClints.Rows.Count.ToString();
        }













       

       

      

       

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo frm=new frmClientInfo((int)dgvClints.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();
            frmListClients_Load(null, null);
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer((int)dgvClints.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListClients_Load(null, null);
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsClient.DeleteClient((int)dgvClints.CurrentRow.Cells[0].Value);
            frmListClients_Load(null, null);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePasswordClient frm = new frmChangePasswordClient((int)dgvClints.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListClients_Load(null, null);    
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }













    }
}
