using BANKDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BANKDataAccessLayer;

namespace BANK_BuisnessLayer
{
    public class clsClient
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int ClientID { get; set; }
        public int PersonID { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
      




        public clsClient()
        {
            this.ClientID = -1;
           
            this.AccountNumber = "";
            this.Password = "";
            this.Balance = 0;
           

            Mode = enMode.AddMode;
        }


        private clsClient(int ClientID, int PersonID, string AccountNumber, string Password, decimal Balance)
        {
            this.ClientID = ClientID;
            this.PersonID = PersonID;
            this.AccountNumber = AccountNumber;
            this.Password = Password;
            this.Balance = Balance;
            Mode = enMode.UpdateMode;

        }





        public static clsClient Find(int ClientID)
        {

            int PersonID = -1; string AccountNumber = "", Password = "";
            decimal Balance = 0;

            bool isFound = clsClientData.GetClientByClientID(ClientID, ref PersonID, ref AccountNumber, ref Password, ref Balance);


            if (isFound == true)
            {
                //clsUser(int UserID, int PersonID, string UserName, string Password, int Permission, bool IsActive)
                return new clsClient(ClientID, PersonID, AccountNumber, Password, Balance);
            }
            else
            {
                return null;
            }

        }

        public static clsClient Find(string AccountNumber)
        {

            int PersonID = -1, ClientID = -1;string Password = "";
            decimal Balance = 0;

            bool isFound = clsClientData.GetClientByAccountNumber(AccountNumber,ref ClientID,ref PersonID,ref Password,ref Balance);


            if (isFound == true)
            {
                //clsUser(int UserID, int PersonID, string UserName, string Password, int Permission, bool IsActive)
                return new clsClient(ClientID, PersonID, AccountNumber, Password, Balance);
            }
            else
            {
                return null;
            }

        }
        public static clsClient FindByPersonID(int PersonID)
        {

            int ClientID = -1; string Password = "", AccountNumber = "";
            decimal Balance = 0;

            bool isFound = clsClientData.GetClientByPersonID(PersonID, ref ClientID, ref AccountNumber, ref Password, ref Balance);


            if (isFound == true)
            {
                //clsUser(int UserID, int PersonID, string UserName, string Password, int Permission, bool IsActive)
                return new clsClient(ClientID, PersonID, AccountNumber, Password, Balance);
            }
            else
            {
                return null;
            }

        }






        public static bool isClientExist(int ClientID)
        {
       
            return clsClientData.IsClientExist(ClientID);
        }
        public static bool isClientExist(string AccountNumber)
        {

            return clsClientData.IsClientExist(AccountNumber);

        }
        public static bool isClientExistByPersonID(int PersonID)
        {
            
            return clsClientData.IsClientExistPersonID(PersonID);

        }



        private bool _AddNewClient()
        { 
            this.ClientID = clsClientData.AddNewClient(PersonID, AccountNumber, Password, Balance);
            return (this.ClientID != -1);


        }
        private bool _UpdateClient()
        {


            return clsClientData.UpdateClient(ClientID, PersonID, AccountNumber, Password, Balance);

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewClient())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateClient();

            }
            return false;
        }


        public static bool DeleteClient(int ClientID)
        {
            return clsClientData.DeleteClient(ClientID);    

        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllUsers(); 

        }





    }
}
