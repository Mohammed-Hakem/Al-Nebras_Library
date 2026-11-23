
using System.Data.SqlClient;
using System;
using System.Data;
using System.Net;

namespace DataAccessLayer
{
    public class BooksData
    {
        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            //string query =
            //  @" SELECT Books.BookID, Title, PublicationDate, Genre, AdditionalDetails, AvailabilityStatus, 
            //  COUNT(BookCopies.BookID) AS [Number of copies]
            //     FROM Books INNER JOIN BookCopies ON BookCopies.BookID = Books.BookID
            //     GROUP BY Books.BookID, Title, PublicationDate, Genre, AdditionalDetails, AvailabilityStatus;

            //  ";

            string query = "Select * From [Library].[dbo].[BooksDetails]";

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

        public static int AddNewBook(string ISBN, string Genre, DateTime PublicationDate, string Title, string AdditionalDetails)
        {
            int BookID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Insert into Books(Books.ISBN,Books.Genre,Books.PublicationDate,Books.Title,Books.AdditionalDetails, ) 
			values (@ISBN, @Genre, @PublicationDate, @Title, @AdditionalDetails)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);


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

        public static bool GetBookInfoByBookID(int BookID,ref string ISBN, ref string Genre, ref DateTime PublicationDate,
                                               ref string Title, ref string AdditionalDetails, ref bool IsAvailable,ref int TotalCopies)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT [BookID]
                             ,[Title]
                             ,[PublicationDate]
                             ,[Genre]
                             ,[AdditionalDetails]
                             ,[AvailabilityStates]
                             ,[TotalCopies]
                             ,[ISBN]
                             FROM [Library].[dbo].[BooksDetails]
                                where BookID = @BookID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ISBN = (string)reader["ISBN"];
                    Genre = (string)reader["Genre"];
                    PublicationDate = (DateTime)reader["PublicationDate"];
                    Title = (string)reader["Title"];
                    AdditionalDetails = (string)reader["AdditionalDetails"];
                    if((int)reader["AvailabilityStates"] == 1)
                        IsAvailable = true;
                    else IsAvailable = false;
                    TotalCopies = (int)reader["TotalCopies"];
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


    }// Class End
}
