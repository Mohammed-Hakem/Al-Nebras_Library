using Library_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BusinessLayer
{
    public class clsAdmin
    {
        public enum enModes { AddNew = 0, Update = 1 }
        public enModes enMode = enModes.AddNew;

        public int AdministratorID { get; set; }
        public int UserID { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }

        public clsAdmin()
        {
            AdministratorID = -1;
            UserID = -1;
            JoiningDate = DateTime.Now;
            IsActive = true;

            enMode = enModes.AddNew;
        }

        private clsAdmin(int AdministratorID,int UsrID ,DateTime JoiningDate, bool IsActive)
        {
            this.AdministratorID = AdministratorID;
            this.JoiningDate = JoiningDate;
            this.IsActive = IsActive;
            this.UserID = UsrID;

            enMode = enModes.Update;
        }

        public static clsAdmin Find(int AdministratorID)
        {
            int UserID = -1; DateTime JoiningDate = DateTime.Now; bool IsActive = false;

            if (clsAdmineData.GetAdmineInfoByAdministratorID(AdministratorID,ref UserID , ref JoiningDate, ref IsActive))
            {
                return new clsAdmin(AdministratorID,UserID, JoiningDate, IsActive);
            }

            return null;
        }

        public bool UpdateActivationState(bool NewActivationState)
        {
            if (clsAdmineData.UpdateAdmineActivationState(this.AdministratorID, ref NewActivationState))
            {
                this.IsActive = NewActivationState;
                return true;
            }

            return false;
        }

        public static bool CheckAdmin(int UserID)
        {
            return clsAdmineData.CheckAdmin(UserID);

        }



    }//Class End
}
