using Library_BusinessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Nebras_LibraryPresentationLayer
{
    public partial class frmAccountSettings : Form
    {
        public enum enMode { NewLogin = 1, ShowAccountInfo = 2 }
        enMode Mode = enMode.NewLogin;

        byte AdministrativeLevel = 0;
       
        public  delegate void DataBackEventHandler(byte Level);

        public event DataBackEventHandler DataBack;

        public frmAccountSettings(enMode Mode = enMode.NewLogin)
        {
            InitializeComponent();
            this.Mode = Mode;
        }


        private void ConvertToNewLoginMode(bool Value = true)
        {
            Mode = enMode.NewLogin;
            pnlLoginPanel.Visible = Value;
            pnlLoginPanel.Enabled = Value;
            pnlAcountInfo.Enabled = !Value;
            pnlAcountInfo.Visible = !Value;

            tbUserName.Text = "";
            tbPassword.Text = "";

        }

        private void LoadAccountInfo()
        {
            if (clsGlobal.CurrentUser != null)
            {
                lblCurrentUserFullName.Text = clsGlobal.CurrentUser.Name;
                lblCurrentUserUsername.Text = '@' + clsGlobal.CurrentUser.Username;
                lblAdmin.Visible = clsGlobal.CurrentUser.IsAdmine;
                lblActive.Visible = clsGlobal.CurrentUser.IsActiveAdmine;
                lblInactive.Visible = !clsGlobal.CurrentUser.IsActiveAdmine;
            }
            else
            {
                lblCurrentUserFullName.Text = "Gest";
                lblCurrentUserUsername.Text = "@Gest";
                lblAdmin.Visible = false;
                lblInactive.Visible = false;
            }
        }

        private void ConvertToShowAccountInfoMode(bool Value = true)
        {
            Mode = enMode.ShowAccountInfo;
            pnlAcountInfo.Enabled = Value;
            pnlAcountInfo.Visible = Value;
            pnlLoginPanel.Visible = !Value;
            pnlLoginPanel.Enabled = !Value;
            LoadAccountInfo();
           
        }

        private void CheckMode()
        {

            if (Mode == enMode.NewLogin)
            {
                ConvertToNewLoginMode();
            }
            else if (Mode == enMode.ShowAccountInfo)
            {
                ConvertToShowAccountInfoMode();
            }
        }

        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.NewLogin)
            {
                ConvertToNewLoginMode();
            }
            else if (Mode == enMode.ShowAccountInfo)
            {
                ConvertToShowAccountInfoMode();
            }
           
        }

        private void tbUserName_tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                btnLogin.Enabled = true;
                btnLogin.BackColor = Color.LimeGreen;
            }
            else
            {
                btnLogin.Enabled = false;
                btnLogin.BackColor = Color.Gainsboro;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int UserID = clsUser.CheckUserExistsByUserNameAndPassword(tbUserName.Text, tbPassword.Text);

            if (UserID != -1)
            {
                clsGlobal.CurrentUser = clsUser.Find(UserID);

                if (clsGlobal.CurrentUser.IsAdmine)
                {
                    AdministrativeLevel = 2;
                }
                else
                {
                    AdministrativeLevel = 1;
                }
                lblWrongData.Visible = false;

                Mode = enMode.ShowAccountInfo;
                frmAccountSettings_Load(null, null);
            }
            else
            {
                //MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblWrongData.Visible = true;
            }

            DataBack?.Invoke(AdministrativeLevel);

        }

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tbPassword.Focus(); 
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(null, null);
            }
        }



        private void EditMode(bool EditMode)
        {
            lblNewPassword.Visible = EditMode;
            lblNewPassword.Enabled = EditMode;
            lblNewUsername.Visible = EditMode;
            lblNewUsername.Enabled = EditMode;

            txtNewPassword.Visible = EditMode;
            txtNewPassword.Enabled = EditMode;
            txtNewUsername.Enabled = EditMode;
            txtNewUsername.Visible = EditMode;

            btnConfirm.Visible = EditMode;
            btnConfirm.Enabled = EditMode;
        }

        private void llblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditMode(true);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EditMode(false);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Warring", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AdministrativeLevel = 0;
                DataBack?.Invoke(AdministrativeLevel);
                ConvertToNewLoginMode();
            }
        }


    }//Class End
}
