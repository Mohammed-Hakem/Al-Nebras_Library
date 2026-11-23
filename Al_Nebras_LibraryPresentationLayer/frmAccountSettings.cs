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
        byte AdministrativeLevel = 0;
       
        public  delegate void DataBackEventHandler(byte Level);

        public event DataBackEventHandler DataBack;

        public frmAccountSettings()
        {
            InitializeComponent();
        }

        private void tbUserName_tbPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int UserID = clsUser.CheckUserExistsByUserNameAndPassword(tbUserName.Text, tbPassword.Text);

            if (UserID != -1)
            {
                clsGlobal.CurrentUser = clsUser.Find(UserID);

                if (clsGlobal.CurrentUser.IsAdmin)
                {
                    AdministrativeLevel = 2;
                }
                else
                {
                    AdministrativeLevel = 1;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataBack?.Invoke(AdministrativeLevel);
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            this.Activate();
            tbUserName.Focus();
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
    }//Class End
}
