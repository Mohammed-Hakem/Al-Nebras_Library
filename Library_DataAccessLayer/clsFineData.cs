using System.Data.SqlClient;
using System;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public class clsFineData
    {
        public static DataTable GetAllFinesByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "Select * From Fines where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetAllFines()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "Select * From Fines";

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

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewFine(int UserID, int BorrowingRecordID, int FineAmount, int NumberOfLateDays, bool PaymentStatus)
        {
            int FineID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Insert into Fines (Fines.UserID, Fines.BorrowingRecordID, Fines.FineAmount,
                             Fines.NumberOfLateDays, Fines.PaymentStatus ) 
			                 values (@UserID,@BorrowingRecordID,@FineAmount,@NumberOfLateDays,@PaymentStatus ) 
                             Select Scope_Identity()   ";

            SqlCommand command = new SqlCommand(query, connection);

            
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
            command.Parameters.AddWithValue("@FineAmount", FineAmount);
            command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
            
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    FineID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return FineID;

        }

        public static bool setFineAsPaid(int FineID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @" Update  Fines  set Fines.PaymentStatus = 1;";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        }// Class End
}
