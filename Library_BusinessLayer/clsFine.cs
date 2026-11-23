using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Library_BusinessLayer
{
    public class clsFine
    {
        public enum enModes { AddNew = 0, Update = 1 }
        public enModes enMode = enModes.AddNew;

        public int FineID { get; set; }
        public int UserID { get; set; }
        public int BorrowingRecordID { get; set; }
        public int FineAmount { get; set; }
        public int NumberOfLateDays { get; set; }
        public bool PaymentStatus { get; set; }

        public clsFine()
        {
            FineID = -1;
            UserID = -1;
            BorrowingRecordID = -1;
            FineAmount = 0;
            NumberOfLateDays = 0;
            PaymentStatus = false;

            enMode = enModes.AddNew;
        }

        private clsFine(int FineID, int UserID, int BorrowingRecordID, int FineAmount, int NumberOfLateDays, bool PaymentStatus)
        {
            this.FineID = FineID;
            this.UserID = UserID;
            this.BorrowingRecordID = BorrowingRecordID;
            this.FineAmount = FineAmount;
            this.NumberOfLateDays = NumberOfLateDays;
            this.PaymentStatus = PaymentStatus;

            enMode = enModes.Update;
        }

        public static DataTable GetAllFines()
        {
            return clsFineData.GetAllFines();
        }

        public static DataTable GetAllFinesByUserID(int UserID)
        {
            return clsFineData.GetAllFinesByUserID(UserID);
        }

        private bool _AddNewFine()
        {
            this.FineID = clsFineData.AddNewFine(UserID, BorrowingRecordID, FineAmount, NumberOfLateDays, PaymentStatus);
            return this.FineID != -1;
        }

        public bool SetAsPaid()
        {
            if (FineID == -1)
                return false;

            if (clsFineData.setFineAsPaid(FineID))
            {
                this.PaymentStatus = true;
                return true;
            }

            return false;
        }

        public bool Save()
        {
            switch (enMode)
            {
                case enModes.AddNew:
                    if (_AddNewFine())
                    {
                        enMode = enModes.Update;
                        return true;
                    }
                    return false;

                case enModes.Update:
                    return false;
            }

            return false;
        }


    }//Class Find
}
