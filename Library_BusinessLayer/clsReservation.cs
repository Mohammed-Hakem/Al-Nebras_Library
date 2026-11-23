
using System;
using System.Data;
using DataAccessLayer;

public class clsReservation
{
    public enum enModes { AddNew = 0, Update = 1 }
    public enModes enMode = enModes.AddNew;

    public int ReservationID { get; set; }
    public int CopyID { get; set; }
    public int UserID { get; set; }
    public DateTime ReservationDate { get; set; }
    public DateTime ReservationEnd { get; set; }
    public bool IsActive { get; set; }

    public clsReservation()
    {
        ReservationID = -1;
        CopyID = -1;
        UserID = -1;
        ReservationDate = DateTime.Now;
        ReservationEnd = DateTime.Now;
        IsActive = true;

        enMode = enModes.AddNew;
    }

    private clsReservation(int ReservationID, int CopyID, int UserID, DateTime ReservationDate, DateTime ReservationEnd, bool IsActive)
    {
        this.ReservationID = ReservationID;
        this.CopyID = CopyID;
        this.UserID = UserID;
        this.ReservationDate = ReservationDate;
        this.ReservationEnd = ReservationEnd;
        this.IsActive = IsActive;

        enMode = enModes.Update;
    }

    public static DataTable GetAllReservationsByUserID(int UserID)
    {
        return clsReservationData.GetAllReservationByUserID(UserID);
    }

    public static DataTable GetAllReservations()
    {
        return DataAccessLayer.clsReservationData.GetAllReservationByUserID();
    }


    public static clsReservation Find(int ReservationID)
    {
        int CopyID = -1, UserID = -1;
        DateTime ReservationDate = DateTime.Now, ReservationEnd = DateTime.Now;
        bool IsActive = false;

        if (clsReservationData.GetReservationInfo(ReservationID, ref CopyID, ref UserID, ref ReservationDate, ref ReservationEnd, ref IsActive))
        {
            return new clsReservation(ReservationID, CopyID, UserID, ReservationDate, ReservationEnd, IsActive);
        }

        return null;
    }

    private bool _AddNewReservation()
    {
        this.ReservationID = clsReservationData.AddNewReservation(CopyID, UserID, ReservationDate, ReservationEnd, IsActive);
        return this.ReservationID != -1;
    }

    private bool _UpdateReservation()
    {
        return clsReservationData.UpdateReservation(ReservationID, ReservationDate, ReservationEnd, IsActive);
    }

    public bool Save()
    {
        switch (enMode)
        {
            case enModes.AddNew:
                if (_AddNewReservation())
                {
                    enMode = enModes.Update;
                    return true;
                }
                return false;

            case enModes.Update:
                return _UpdateReservation();
        }

        return false;
    }
}
