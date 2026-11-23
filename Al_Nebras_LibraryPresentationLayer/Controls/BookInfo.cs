using Library_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Al_Nebras_LibraryPresentationLayer.Controls
{
    public partial class BookInfo : UserControl
    {
        int _BookID = -1;
        clsBook Book;

        public int BookID { get { return _BookID; } set { _BookID = value; } }

        public BookInfo(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        public BookInfo()
        {
            InitializeComponent();
        }

        public void LoadBookInfo()
        {
            Book = clsBook.Find(_BookID);

            if (Book != null)
            {

                lblBookTitle.Text = Book.Title;
                lblGenre.Text = Book.Genre;
                lblPublishmentDate.Text = Book.PublishmentDate.ToString();
                lblISBN.Text = Book.ISBN;
                txtAdditionalNotes.Text = Book.AdditionalNotes;

                if (Book.IsAvailable)
                {
                    lblAvailabiltyState.Text = "Available";
                    lblAvailabiltyState.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    lblAvailabiltyState.Text = "Unavailable!";
                    lblAvailabiltyState.BackColor = Color.DarkSalmon;
                }
               
            }
            else
            {
                MessageBox.Show("There is no Book with this ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

       

       
    }//Class End
}
