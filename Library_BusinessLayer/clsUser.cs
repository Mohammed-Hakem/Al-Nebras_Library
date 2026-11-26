using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BusinessLayer
{

    using System;
    using Library_DataAccessLayer;

    public class clsUser
    {
        public enum enModes { AddNew = 0, Update = 1 }
        public enModes enMode = enModes.AddNew;

        public int UserID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }
        public string LibraryCardNumber { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public bool IsAdmine { get ; set; }

        public bool IsActiveAdmine { get; set; }

        // Constructor for adding a new user
        public clsUser()
        {
            UserID = -1;
            Name = "";
            ContactInformation = "";
            LibraryCardNumber = "";
            Password = "";
            Username = "";
            IsAdmine = false;
            IsActiveAdmine = false;

            enMode = enModes.AddNew;
        }

        // Constructor for loading an existing user
        private clsUser(int UserID, string Name,string ContactInformation, string LibraryCardNumber,
            string Password, string Username, bool IsAdmin)
        { 
            this.UserID = UserID;
            this.Name = Name;
            this.ContactInformation = ContactInformation;
            this.LibraryCardNumber = LibraryCardNumber;
            this.Password = Password;
            this.Username = Username;
            this.IsAdmine = IsAdmin;
            this.IsActiveAdmine = clsAdmin.IsActiveAdmine(this.UserID);

            enMode = enModes.Update;

        }

        public static clsUser Find(int UserID)
        {
            string Name = "";string ContactInformation = "";string LibraryCardNumber = "";string Password = "";string Username = "";bool IsAdmin = false;

            if (clsUserData.GetUserInfoByUserID(
                UserID,ref Name,ref ContactInformation,ref LibraryCardNumber,ref Password,ref Username,ref IsAdmin))
            {
                return new clsUser(UserID,Name,ContactInformation,LibraryCardNumber,Password,Username,IsAdmin);
            }
            else
            {
                return null;
            }
        }

        public static int CheckUserExistsByUserNameAndPassword(string Username, string Password)
        {
            return clsUserData.checkUserExistsByUserNameAndPassword(Username, Password);
        }

        public DataTable GetAllResevations()
        {
            return clsReservation.GetAllReservationsByUserID(this.UserID);
        }

        public DataTable GetAllFines()
        {
            return clsFine.GetAllFinesByUserID(this.UserID);
        }

    }//Class End
}
