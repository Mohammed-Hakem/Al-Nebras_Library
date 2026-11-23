using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public class clsReservationData
    {
        public static DataTable GetAllReservationByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "Select * From Reservation where UserID = @UserID";

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
        public static DataTable GetAllReservationByUserID()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "Select * From Reservation";

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

        public static int AddNewReservation(int CopyID, int UserID, DateTime ReservationDate, DateTime ReservationEnd,bool IsActive)
        {
            int BookID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @" INSERT INTO Reservations (CopyID, UserID, ReservationDate,ReservationEnd,IsActive)
                              VALUES (@CopyID,@UserID ,@ReservationDate,@ReservationEnd ,@IsActive);
                              SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
            command.Parameters.AddWithValue("@ReservationEnd", ReservationEnd);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BookID = insertedID;
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

            return BookID;
        }

        public static bool GetReservationInfo(int ReservationID, ref int CopyID, ref int UserID, ref DateTime ReservationDate,
                                              ref DateTime ReservationEnd, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CopyID = (int)reader["CopyID"];
                    UserID = (int)reader["UserID"];
                    ReservationDate = (DateTime)reader["ReservationDate"];
                    ReservationEnd = (DateTime)reader["ReservationEnd"];
                    IsActive = (byte)reader["IsActive"] == 1? true:false;
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool UpdateReservation(int ReservationID, DateTime ReservationDate , DateTime ReservationEnd, bool IsActive)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"UPDATE [Reservations]
                              SET [IsActive] = @IsActive  
                              SET ReservationDate = @ReservationDate
                              SET ReservationEnd = @ReservationEnd
                             WHERE ReservationID = @ReservationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
               
            }
            finally
            {
                connection.Close();
            }


            return rowsAffected > 0;
        }

    }//Class End
}
