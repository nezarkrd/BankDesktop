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
    public class clsTransfer
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int TransferID { get; set; }
        public int SenderID { get; set; }
        public int DepositID { get; set; }
        public DateTime dateTime { get; set; }
        public decimal Amount { get; set; }
        public int UserID { get; set; }
        public clsClient SenderInfo;
        public clsClient DepositInfo;


        public clsTransfer()
        {
            this.TransferID = -1;
            this.SenderID = -1;
            this.DepositID = -1;
            this.dateTime = DateTime.Now;
            this.Amount = 0;
            this.UserID = -1;

            Mode = enMode.AddMode;
        }


        private clsTransfer(int TransferID, int SenderID,int DepositID, DateTime dateTime,decimal Amount,  int UserID)
        {
            this.TransferID = TransferID;
            this.SenderID = SenderID;
            this.DepositID = DepositID;
            this.dateTime = dateTime;
            this.Amount = Amount;
            this.UserID = UserID;
            this.SenderInfo = clsClient.Find(SenderID);
            this.DepositInfo = clsClient.Find(DepositID);
            Mode = enMode.UpdateMode;
        }





        public static clsTransfer Find(int TransferID)
        {

            int SenderID = -1, DepositID = -1; DateTime dateTime = DateTime.Now;
            decimal Amount = 0; int UserID=-1;


            bool isFound = clsTransferData.GetTransfertByTransferID(TransferID, ref SenderID, ref DepositID, ref dateTime, ref Amount, ref UserID);



            if (isFound == true)
            {
                
                return new clsTransfer(TransferID, SenderID, DepositID, dateTime, Amount, UserID);
            }
            else
            {
                return null;
            }

        }






        private bool _AddTransfer()
        {
            
            this.TransferID = clsTransferData.AddTransfer(this.SenderID, this.DepositID, this.dateTime, this.Amount, this.UserID);

            return (this.TransferID != -1);


        }
        private bool _UpdateTransfer()
        {

            
            return clsTransferData.UpdateTranfer(this.TransferID, this.SenderID, this.DepositID, this.dateTime, this.Amount, this.UserID);


        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddTransfer())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateTransfer();

            }
            return false;
        }


        //public static bool DeleteWithdrawDepositClient(int ID)
        //{
        //    return clsDataWithdrawDepositClient.DeleteWithdrawDeposit(ID);


        //}




        public static DataTable GetAllTransfers()
        {
            
            return clsTransferData.GetAllTranfers();

        }



    }
}
