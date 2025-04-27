using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BANKDataAccessLayer
{
    public class clsCurrenciesData
    {

        public static bool GetCurrencyByIDCurrency(int CurrencyID, ref string Country, ref string Code, ref string Name, ref decimal Rate)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Currencies where CurrencyID=@CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    Country = (string)reader["Country"];
                    Code = (string)reader["Code"];
                    Name = (string)reader["Name"];
                    Rate = (decimal)reader["Rate"];

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

        public static bool GetCurrencyByCountry(string Country,ref int CurrencyID, ref string Code, ref string Name, ref decimal Rate)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Currencies where Country=@Country";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    CurrencyID = (int)reader["CurrencyID"];
                    Code = (string)reader["Code"];
                    Name = (string)reader["Name"];
                    Rate = (decimal)reader["Rate"];

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

        public static bool GetCurrencyByCode(string Code, ref int CurrencyID, ref string Country, ref string Name, ref decimal Rate)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Currencies where Code=@Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", Code);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    CurrencyID = (int)reader["CurrencyID"];
                    Country = (string)reader["Country"];
                    Name = (string)reader["Name"];
                    Rate = (decimal)reader["Rate"];

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

        public static bool IsCurrencyExist(int CurrencyID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from people where CurrencyID=@CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;


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
        public static bool IsCurrencyExistByCountry(string Country)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from people where Country=@Country";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;


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
        public static bool IsCurrencyExistByCode(string Code)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FOUND=1 from people where Code=@Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", Code);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;


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

        public static int AddNewCurrency(string Country, string Code, string Name, decimal Rate)
        {

            int CurrencyID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Currencies
           (Country,Code,Name
           ,Rate)
            VALUES
           (@Country
           ,@Code
           ,@Name
           ,@Rate)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Rate", Rate);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    CurrencyID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return CurrencyID;

        }

        public static bool UpdateCurrency(int CurrencyID, string Country,  string Code,  string Name, decimal Rate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Currencies
                       SET Country =@Country 
                         ,Code = @Code
                         ,Name = @Name
                         ,Rate = @Rate
                       WHERE CurrencyID=@CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Rate", Rate);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }


            return (rowsAffected > 0);
        }

        public static bool DeleteCurrency(int CurrencyID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM Currencies
                             WHERE CurrencyID=@CurrencyID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);


        }

        public static DataTable GetAllCurrencies()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Currencies";
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
