using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKDataAccessLayer
{
    public class clsTransferData
    {

        public static bool GetTransfertByTransferID(int TransferID, ref int SenderID,ref int DepositID, ref DateTime DateTime, ref decimal Amount, ref int UserID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Transfers where TransferID=@TransferID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransferID", TransferID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    SenderID = (int)reader["SenderID"];
                    DepositID = (int)reader["DepositID"];
                    DateTime = (DateTime)reader["DateTime"];
                    Amount= (decimal)reader["Amount"];
                    UserID = (int)reader["UserID"];



                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex) { isFound = false; }
            finally { connection.Close(); }




            return isFound;
        }


        public static int AddTransfer(int SenderID, int DepositID,  DateTime DateTime, decimal Amount, int UserID)
        {

            int IDTransfer = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"BEGIN TRANSACTION
            BEGIN TRY
			declare @TransferID INT

		



	        INSERT INTO Transfers
           (SenderID
           ,DepositID
           ,DateTime
           ,Amount
           ,UserID)
            VALUES
           (@SenderID,@DepositID,@DateTime,@Amount,@UserID)
		  
           set @TransferID=SCOPE_IDENTITY();
		   select @TransferID
            
		   declare @OldBalanceSender DECIMAL
		   SET @OldBalanceSender=(select Balance from Clients where ClientID=@SenderID)

		   UPDATE Clients
           SET Balance =@OldBalanceSender-@Amount
		   WHERE ClientID=@SenderID

           INSERT INTO DetailsTransfer
           (TransferID
           ,ClientID
           ,Amount
           ,TypeTransaction
           ,OldAccount
           ,CurrentAccount)
            VALUES
           (@TransferID
           ,@SenderID
           ,@Amount
           ,2
           ,@OldBalanceSender
           ,@OldBalanceSender-@Amount)
		   
	

		   declare @OldBalanceDeposit DECIMAL
		   SET @OldBalanceDeposit=(select Balance from Clients where ClientID=@DepositID)

		   UPDATE Clients
           SET Balance =@OldBalanceDeposit+@Amount
		   WHERE ClientID=@DepositID

           INSERT INTO DetailsTransfer
           (TransferID
           ,ClientID
           ,Amount
           ,TypeTransaction
           ,OldAccount
           ,CurrentAccount)
            VALUES
           (@TransferID
           ,@DepositID
           ,@Amount
           ,1
           ,@OldBalanceDeposit
           ,@OldBalanceDeposit+@Amount)
		   




   
            COMMIT;
           END TRY



          BEGIN CATCH

           ROLLBACK;
          END CATCH

";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SenderID", SenderID);
            command.Parameters.AddWithValue("@DepositID", DepositID);
            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@UserID", UserID);
        
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    IDTransfer = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IDTransfer;

        }


        public static DataTable GetAllTranfers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Transfers.TransferID,Transfers.SenderID,Transfers.DepositID  ,Transfers.DateTime ,Transfers.Amount    ,Users.UserName  FROM Transfers inner join Users on Transfers.UserID=Users.UserID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }

            return dt;


        }




        public static bool UpdateTranfer(int TransferID,  int SenderID, int DepositID,  DateTime DateTime, decimal Amount, int UserID)
        { 
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Transfers SET TransferID =@TransferID,SenderID =@SenderID ,DepositID =@DepositID,DateTime =@DateTime,Amount=@Amount,UserID=@UserID WHERE TransferID=@TransferID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransferID", TransferID);
            command.Parameters.AddWithValue("@SenderID", SenderID);
            command.Parameters.AddWithValue("@DepositID", DepositID);
            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@UserID", UserID);
          
          
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        //public static bool DeleteWithdrawDeposit(int ID)
        //{
        //    int rowsAffected = 0;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string query = @"delete WithdrawDepositClient where ID=@ID;";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@ID", ID);
        //    try
        //    {
        //        connection.Open();
        //        rowsAffected = command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex) { }
        //    finally { connection.Close(); }


        //    return (rowsAffected > 0);


        //}







    }
}
