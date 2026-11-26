using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccessLayer
{
    public class clsAdmineData
    {
        public static bool GetAdmineInfoByAdministratorID(int AdministratorID,ref int UserID , ref DateTime JoiningDate, ref bool IsActive )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [Library].[dbo].[Administrators]
                                where AdministratorID = @AdministratorID";
    
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdministratorID", AdministratorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    JoiningDate = (DateTime)reader["JoiningDate"];
                    IsActive = ((byte)reader["IsActive"]) == 1 ? true : false;
                    UserID = (int)reader["UserID"];


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
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        /*public static bool GetAdmineLoginInfoByAdministratorID(int AdministratorID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT UserName,Password,IsActive FROM [Library].[dbo].[Administrators]
                                where AdministratorID = @AdministratorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdministratorID", AdministratorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                    IsActive = ((byte)reader["IsActive"]) == 1 ? true : false;
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
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }
        */

        public static bool UpdateAdmineActivationState(int AdministratorID, ref bool NewActivationState)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"UPDATE [Administrators]
                              SET [IsActive] = @NewActivationState                                    
                             WHERE AdministratorID = @AdministratorID;";
                                
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@AdministratorID", AdministratorID);
            command.Parameters.AddWithValue("@NewActivationState", (NewActivationState) == true? 1:0);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return rowsAffected != 0;
        }

        public static bool CheckAdmine(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT UserID FROM [Library].[dbo].[Administrators]
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.Read();
                
                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool IsActiveAdmine(int UserID)
        {
            bool IsActive = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT IsActive FROM [Library].[dbo].[Administrators]
                                where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    // The record was not found
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsActive;
        }




    }//Class End
}
