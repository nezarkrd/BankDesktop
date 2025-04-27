using BANKDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_BuisnessLayer
{
    public class clsWithdrawDepositClient
    {
       

        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int ID {  get; set; }    
        public int ClientID { get; set; }
        public DateTime DateTime{ get; set; }
        public string AccountNumber { get; set; }   
        public decimal OldBalance { get; set; }
        public decimal Amount { get; set; }
        public short TypeTransaction { get; set; }
        public decimal CurrentBalance { get; set; }
        public int UserID { get; set; }
        public clsClient ClientInfo;



        public clsWithdrawDepositClient()
        {
            this.ID = -1;
            this.DateTime = DateTime.Now;
            this.OldBalance = 0;
            this.Amount = 0;
            this.TypeTransaction = -1;
            this.CurrentBalance = 0;
            this.UserID = -1;

            Mode = enMode.AddMode;
        }


        private clsWithdrawDepositClient(int ID, int ClientID, DateTime DateTime,string AccountNumber, decimal OldBalance, decimal Amount, short TypeTransaction,decimal CurrentBalance,int UserID)
        {
            this.ID = ID;
            this.ClientID = ClientID;
            this.DateTime = DateTime;
            this.AccountNumber = AccountNumber;
            this.OldBalance = OldBalance;
            this.TypeTransaction = TypeTransaction;
            this.CurrentBalance = CurrentBalance;
            this.UserID=UserID;
            this.ClientInfo = clsClient.Find(ClientID);
            Mode = enMode.UpdateMode;
        }





        public static clsWithdrawDepositClient Find(int ID)
        {
              
            int ClientID = -1, UserID=-1; DateTime DateTime = DateTime.Now;
            decimal OldBalance = 0, Amount = 0, CurrentBalance = 0;
            string AccountNumber = "";
            short TypeTransaction = -1;

            bool isFound = clsDataWithdrawDepositClient.GetWithdrawDepositByID(ID, ref ClientID, ref DateTime, ref AccountNumber, ref OldBalance, ref Amount, ref TypeTransaction, ref CurrentBalance, ref UserID);



            if (isFound == true)
            {
                           
                return new clsWithdrawDepositClient(ID, ClientID, DateTime, AccountNumber, OldBalance, Amount, TypeTransaction, CurrentBalance, UserID);
            }
            else
            {
                return null;
            }

        }

      
       



        private bool _AddWithdrawDepositClient()
        {
            this.ID = clsDataWithdrawDepositClient.AddWithdrawDeposit(this.ClientID, this.DateTime, this.AccountNumber, this.OldBalance, this.Amount, this.TypeTransaction, this.CurrentBalance, this.UserID);

            return (this.ID != -1);


        }
        private bool _UpdateWithdrawDepositClient()
        {
            return clsDataWithdrawDepositClient.UpdateAddWithdrawDeposit(this.ID, this.ClientID, this.DateTime, this.AccountNumber, this.OldBalance, this.Amount, this.TypeTransaction, this.CurrentBalance, this.UserID);




        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddWithdrawDepositClient())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateWithdrawDepositClient();

            }
            return false;
        }


        public static bool DeleteWithdrawDepositClient(int ID)
        {
            return clsDataWithdrawDepositClient.DeleteWithdrawDeposit(ID);
           

        }




        public static DataTable GetAllWithdrawDepositClient()
        {
            return clsDataWithdrawDepositClient.GetAllWithdrawsDeposits();
        

        }


        public static bool BalanceIsEnough(decimal Account,decimal AmountWithdraw)
        {
           if(Account>= AmountWithdraw)
            { return true; }
            else
            {
                return false;
            }


        }











    }
}
