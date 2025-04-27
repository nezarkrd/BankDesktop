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

namespace BANK_Desktop.People
{
    public partial class frmListPeople : Form
    {

        private static DataTable _dtAllPeople=clsPerson.GetAllPeople();    

        private DataTable _dtPeople= _dtAllPeople.DefaultView.ToTable(false,"PersonID","FirstName","LastName","Phone","Email","Gendor","DateBirth","ImagePath", "Nationality", "NationalNO");

        private void _RefreshPeoplList()
        {
           _dtAllPeople = clsPerson.GetAllPeople();

           _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "FirstName", "LastName", "Phone", "Email", "Gendor", "DateBirth", "ImagePath", "Nationality", "NationalNO");

            dgvPeple.DataSource = _dtPeople;
            lblRecordsCount.Text=dgvPeple.Rows.Count.ToString();
        }





        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvPeple.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text=dgvPeple.Rows.Count.ToString();
            if (dgvPeple.Rows.Count>0) {

                dgvPeple.Columns[0].HeaderText = "Person ID";
                dgvPeple.Columns[0].Width = 120;

           

                dgvPeple.Columns[1].HeaderText = "First Name";
                dgvPeple.Columns[1].Width = 150;

                dgvPeple.Columns[2].HeaderText = "Last Name";
                dgvPeple.Columns[2].Width = 150;


                dgvPeple.Columns[3].HeaderText = "Phone";
                dgvPeple.Columns[3].Width = 170;


                dgvPeple.Columns[4].HeaderText = "Email";
                dgvPeple.Columns[4].Width = 190;


                dgvPeple.Columns[5].HeaderText = "Gendor";
                dgvPeple.Columns[5].Width = 120;

                dgvPeple.Columns[6].HeaderText = "Date Birth";
                dgvPeple.Columns[6].Width = 190;


                dgvPeple.Columns[7].HeaderText = "ImagePath";
                dgvPeple.Columns[7].Width = 190;

                dgvPeple.Columns[8].HeaderText = "Nationalty";
                dgvPeple.Columns[8].Width = 120;

                dgvPeple.Columns[9].HeaderText = "National NO";
                dgvPeple.Columns[9].Width = 130;



            }

        }


        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {


            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                case "Gendor":
                    FilterColumn = "Gendor";
                    break;
                
                case "Nationalty":
                    FilterColumn = "Nationality";
                    break;
                case "National NO":
                    FilterColumn = "NationalNO";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtPeople.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            lblRecordsCount.Text = dgvPeple.Rows.Count.ToString();

        }








        private void dgvPeple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }



        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
            

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            if(clsPerson.DeletePerson(PersonID)) 
            {
                MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _RefreshPeoplList(); 
            }
            else
            {
                MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeple_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeple.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only input number for Person ID
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
