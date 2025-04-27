using BANK_BuisnessLayer;
using BANK_Desktop.People;
using BANK_Desktop.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_Desktop.Clients.Controls
{
    public partial class ctrlClientCardWithFilter : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnClientSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void ClientSelected(int ClientID)
        {
            Action<int> handler = OnClientSelected;
            if (handler != null)
            {
                handler(ClientID); // Raise the event with the parameter
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                cbFilterBy.Enabled = _FilterEnabled;
            }
        }


        private int _ClientID = -1;
        public int ClientID { get { return ctrlClientCard1.SelectClientInfo.ClientID; } }

        public clsClient SelectClientInfo { get { return ctrlClientCard1.SelectClientInfo; } }

        public ctrlClientCardWithFilter()
        {
            InitializeComponent();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }


        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }



        public void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Client ID":

                    ctrlClientCard1.LoadClientInfo(int.Parse(txtFilterValue.Text));
                    break;


                case "Account Number":

                    ctrlClientCard1.LoadClientInfo(txtFilterValue.Text);
                    break;


                default:
                    break;


            }

            if(OnClientSelected != null && FilterEnabled)
            {
                //if(ctrlClientCard1.SelectClientInfo.ClientID != -1)
                if (ctrlClientCard1.SelectClientInfo!= null)
                    ClientSelected(ctrlClientCard1.SelectClientInfo.ClientID);
               
            }
          


        }


        public void LoadClientInfo(int ClientID)
        {

            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = ClientID.ToString();
            FindNow();

        }


        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if Client id is selected
            if (cbFilterBy.Text == "Client ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DataBackEvent(object sender, int ClientID)
        {
            // Handle the data received

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = ClientID.ToString();
            ctrlClientCard1.LoadClientInfo(ClientID);
        }



        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void ctrlClientCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
