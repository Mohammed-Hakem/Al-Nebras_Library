using System.Data;
using DataAccessLayer;
using System;

namespace Library_BusinessLayer
{
    public class clsBook
    {
        public enum enModes { AddNew = 0, Update = 1 }
        enModes enMode = enModes.AddNew;

        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string AdditionalNotes { get; set; }
        public DateTime PublishmentDate { get; set; }

        public string IsAvailableString { get { return (IsAvailable) ? "Available" : "Unvailable"; } }

        public bool IsAvailable { get; set; }

        public int TotalCopies { get; set; }

        public clsBook()
        {
            BookID = -1;
            Title = "";
            ISBN = "";
            Genre = "";
            AdditionalNotes = "";
            PublishmentDate = DateTime.Now;
            TotalCopies = 0;

            enMode = enModes.AddNew;
        }

        private clsBook(int BookID ,string ISBN, string Genre, DateTime PublicationDate, string Title, string AdditionalNotes, bool IsAvailable, int TotalCopies)
        {
            this.ISBN = ISBN;
            this.BookID = BookID;
            this.Genre = Genre;
            this.AdditionalNotes = AdditionalNotes;
            this.PublishmentDate = PublicationDate;
            this.Title = Title;
            this.IsAvailable = IsAvailable;
            this.TotalCopies = TotalCopies;

            enMode = enModes.Update;
        }

        public static DataTable GetAllBooks()
        {
            return DataAccessLayer.BooksData.GetAllBooks();
        }

        public static clsBook Find(int BookID)
        {
            string ISBN = ""; string Genre = "";  DateTime PublicationDate = DateTime.Now; string Title = ""; string AdditionalNotes = ""; bool IsAvailable = false; int TotalCopies = 0;
            if (DataAccessLayer.BooksData.GetBookInfoByBookID(BookID, ref ISBN, ref Genre, ref PublicationDate, ref Title, ref AdditionalNotes, ref IsAvailable,ref TotalCopies))
            {
                return new clsBook(BookID, ISBN, Genre, PublicationDate, Title, AdditionalNotes, IsAvailable,TotalCopies);
            }
            else
            {
                return null;
            }


        }

    }// Class End
}
