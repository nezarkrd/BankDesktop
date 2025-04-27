using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKDataAccessLayer
{
    public class clsDataWithdrawDepositClient
    {


        //public static bool GetWithdrawDepositByClientID(int ClientID, ref int ID, ref DateTime DateTime, ref string AccountNumber, ref decimal OldBalance, ref decimal Amount, ref short TypeTransaction, ref decimal CurrentBalance, ref int UserID)
        //{

        //    bool isFound = false;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string query = "select * from WithdrawDepositClient where ClientID=@ClientID";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@ClientID", ClientID);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            isFound = true;
        //            ID = (int)reader["ID"];
        //            DateTime = (DateTime)reader["DateTime"];
        //            AccountNumber = (string)reader["AccountNumber"];
        //            OldBalance = (decimal)reader["OldBalance"];
        //            Amount = (decimal)reader["Amount"];
        //            TypeTransaction = (short)reader["TypeTransaction"];
        //            CurrentBalance = (decimal)reader["CurrentBalance"];
        //            UserID = (int)reader["UserID"];



        //        }
        //        else
        //        {
        //            isFound = false;
        //        }

        //        reader.Close();


        //    }
        //    catch (Exception ex) { isFound = false; }
        //    finally { connection.Close(); }




        //    return isFound;
        //}
        //public static bool GetWithdrawDepositByAccountNumber(string AccountNumber,ref int ClientID, ref int ID, ref DateTime DateTime, ref decimal OldBalance, ref decimal Amount, ref short TypeTransaction, ref decimal CurrentBalance, ref int UserID)
        //{

        //    bool isFound = false;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string query = "select * from WithdrawDepositClient where AccountNumber=@AccountNumber";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            isFound = true;
        //            ClientID = (int)reader["ClientID"];
        //            ID = (int)reader["ID"];
        //            DateTime = (DateTime)reader["DateTime"];
        //            OldBalance = (decimal)reader["OldBalance"];
        //            Amount = (decimal)reader["Amount"];
        //            TypeTransaction = (short)reader["TypeTransaction"];
        //            CurrentBalance = (decimal)reader["CurrentBalance"];
        //            UserID = (int)reader["UserID"];



        //        }
        //        else
        //        {
        //            isFound = false;
        //        }

        //        reader.Close();


        //    }
        //    catch (Exception ex) { isFound = false; }
        //    finally { connection.Close(); }




        //    return isFound;
        //}
        //public static bool GetWithdrawDepositByTypeTransaction(short TypeTransaction,ref string AccountNumber, ref int ClientID, ref int ID, ref DateTime DateTime, ref decimal OldBalance, ref decimal Amount, ref decimal CurrentBalance, ref int UserID)
        //{

        //    bool isFound = false;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string query = "select * from WithdrawDepositClient where TypeTransaction=@TypeTransaction";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@TypeTransaction", TypeTransaction);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            isFound = true;
        //            ClientID = (int)reader["ClientID"];
        //            ID = (int)reader["ID"];
        //            AccountNumber = (string)reader["AccountNumber"];
        //            DateTime = (DateTime)reader["DateTime"];
        //            OldBalance = (decimal)reader["OldBalance"];
        //            Amount = (decimal)reader["Amount"];
        //            CurrentBalance = (decimal)reader["CurrentBalance"];
        //            UserID = (int)reader["UserID"];



        //        }
        //        else
        //        {
        //            isFound = false;
        //        }

        //        reader.Close();


        //    }
        //    catch (Exception ex) { isFound = false; }
        //    finally { connection.Close(); }




        //    return isFound;
        //}


        //public static bool GetWithdrawDepositByID(int ID, ref int ClientID, ref DateTime DateTime, ref string AccountNumber, ref decimal OldBalance, ref decimal Amount, ref short TypeTransaction,ref decimal CurrentBalance,ref int UserID)
        //{

        //    bool isFound = false;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string query = "select * from WithdrawDepositClient where ID=@ID";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@ID", ID);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            isFound = true;
        //            ClientID = (int)reader["ClientID"];
        //            DateTime = (DateTime)reader["DateTime"];
        //            AccountNumber = (string)reader["AccountNumber"];
        //            OldBalance = (decimal)reader["OldBalance"];
        //            Amount = (decimal)reader["Amount"];
        //            TypeTransaction = (short)reader["TypeTransaction"];
        //            CurrentBalance = (decimal)reader["CurrentBalance"];
        //            UserID = (int)reader["UserID"];



        //        }
        //        else
        //        {
        //            isFound = false;
        //        }

        //        reader.Close();


        //    }
        //    catch (Exception ex) { isFound = false; }
        //    finally { connection.Close(); }




        //    return isFound;
        //}

        public static bool GetWithdrawDepositByID(int ID, ref int ClientID, ref DateTime DateTime, ref string AccountNumber, ref decimal OldBalance, ref decimal Amount, ref short TypeTransaction, ref decimal CurrentBalance, ref int UserID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from WithdrawDepositClient where ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ClientID = (int)reader["ClientID"];
                    DateTime = (DateTime)reader["DateTime"];
                    AccountNumber = (string)reader["AccountNumber"];
                    OldBalance = (decimal)reader["OldBalance"];
                    Amount = (decimal)reader["Amount"];
                    TypeTransaction = (short)reader["TypeTransaction"];
                    CurrentBalance = (decimal)reader["CurrentBalance"];
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


        public static int  AddWithdrawDeposit(int ClientID, DateTime DateTime, string AccountNumber, decimal OldBalance, decimal Amount, short TypeTransaction,  decimal CurrentBalance, int UserID)
        {

            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"BEGIN TRANSACTION
            BEGIN TRY
			
			INSERT INTO WithdrawDepositClient
           (ClientID
           ,DateTime
           ,AccountNumber
           ,OldBalance
           ,Amount
           ,TypeTransiction
           ,CurrentBalance
           ,UserID)
           VALUES
           (@ClientID
           ,@DateTime
           ,@AccountNumber
           ,@OldBalance
           ,@Amount
           ,@TypeTransiction
           ,@CurrentBalance
           ,@UserID)

		   select SCOPE_IDENTITY();


		   UPDATE Clients
           SET Balance =
		   (case
		   when @TypeTransiction=1 THEN  @OldBalance+@Amount
		   when @TypeTransiction=2 THEN  @OldBalance-@Amount
		   END)
		  
		   WHERE ClientID=@ClientID

    

   
            COMMIT;
           END TRY



          BEGIN CATCH

           ROLLBACK;
          END CATCH

";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@OldBalance", OldBalance);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TypeTransiction", TypeTransaction);
            command.Parameters.AddWithValue("@CurrentBalance", CurrentBalance);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    UserID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return UserID;

        }

        public static bool UpdateAddWithdrawDeposit(int ID,int ClientID, DateTime DateTime, string AccountNumber, decimal OldBalance, decimal Amount, short TypeTransaction, decimal CurrentBalance, int UserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE WithdrawDepositClient SET ClientID =@ClientID,DateTime =@DateTime ,AccountNumber =@AccountNumber,OldBalance =@OldBalance,Amount=@Amount,TypeTransaction=@TypeTransaction,CurrentBalance=@CurrentBalance,UserID=@UserID WHERE ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@OldBalance", OldBalance);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TypeTransaction", TypeTransaction);
            command.Parameters.AddWithValue("@CurrentBalance", CurrentBalance);
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

        public static bool DeleteWithdrawDeposit(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"delete WithdrawDepositClient where ID=@ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllWithdrawsDeposits()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT WithdrawDepositClient.Id\r\n      ,WithdrawDepositClient.ClientID\r\n      ,WithdrawDepositClient.DateTime\r\n      ,WithdrawDepositClient.AccountNumber\r\n      ,WithdrawDepositClient.OldBalance\r\n      ,WithdrawDepositClient.Amount\r\n      ,  (CASE\r\n    WHEN WithdrawDepositClient.TypeTransiction=1 THEN 'Deposit'\r\n    WHEN WithdrawDepositClient.TypeTransiction=2 THEN 'Withdraw'\r\n    \r\nEND )as TypeTransiction\r\n      ,WithdrawDepositClient.CurrentBalance\r\n      ,Users.UserName\r\n  FROM WithdrawDepositClient inner join Users on Users.UserID=WithdrawDepositClient.UserID";
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




    }
}
