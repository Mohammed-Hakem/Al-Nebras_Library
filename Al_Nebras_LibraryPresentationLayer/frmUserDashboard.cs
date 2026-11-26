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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Al_Nebras_LibraryPresentationLayer
{
    public partial class frmUserDashboard : Form
    {
        private bool IsUser = false;
        private bool IsAdministrator = false;

        private byte AdministrativeLevel = 0;

        public frmUserDashboard()
        {
            InitializeComponent();
        }
        DataTable dtUserTableData;

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            cbTableType.Items.Clear();
            cbTableType.Items.Add("Books");
            cbTableType.SelectedIndex = 0;

            _RefreshData();

            

            if (dgvUserTable.RowCount > 0)
            {
               
                dgvUserTable.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                dgvUserTable.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                dgvUserTable.RowTemplate.Height = 100;
                dgvUserTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvUserTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

            if (IsUser)
            {
                cbTableType.Items.AddRange(new object[] { "Reservstion", "Fines" });
            }

        }

        private void _RefreshData()
        {
            if (cbTableType.SelectedIndex == 0)
            {
                LoadBooksData();
            }

            lblDate.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void dgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ctrlBookInfo.BookID = int.Parse(dgvUserTable.CurrentRow.Cells[0].Value.ToString());
            ctrlBookInfo.LoadBookInfo();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void CheckAdministrativeLevel(byte Level)
        {
            if (Level == 0)
            {
                AdministrativeLevel = 0;
                IsUser = false;
            }
            else if (Level == 1)
            {
                AdministrativeLevel = 1;
                IsUser = true;
            }
            else if(Level == 2)
            {
                AdministrativeLevel = 2;
                IsUser = true;
                IsAdministrator = true;
            }
            IsAdministrator = (AdministrativeLevel == 2) ? true : false;
            IsUser = (AdministrativeLevel == 1 || AdministrativeLevel == 2) ? true : false;
            btnAccountSettings.Enabled = IsUser;
            btnAccountSettings.Visible = IsUser;
            btnLogin.Enabled = !IsUser;
            btnLogin.Visible = !IsUser;

            btnAdminDashboard.Enabled = IsAdministrator;
            btnAdminDashboard.Visible = IsAdministrator;
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmAccountSettings LoginForm = new frmAccountSettings();
            LoginForm.DataBack += CheckAdministrativeLevel;
            LoginForm.ShowDialog();
            UserDashboard_Load(null, null);
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            if (AdministrativeLevel == 2)
            {
                frmAdminDashBoard frm = new frmAdminDashBoard();
                frm.ShowDialog();
            }

        }

        private void LoadBooksData()
        {
            dtUserTableData = clsBook.GetAllBooks();
            dgvUserTable.DataSource = dtUserTableData;

            dgvUserTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            dgvUserTable.Columns[3].Visible = false;
            dgvUserTable.Columns[4].Visible = false;
            dgvUserTable.Columns[5].Visible = false;
            dgvUserTable.Columns[6].Visible = false;
            dgvUserTable.Columns[7].Visible = false;

            dgvUserTable.Columns[8].HeaderText = "Availability";

            ctrlBookInfo.Enabled = true;
            ctrlBookInfo.Visible = true;
            btnReserve.Visible = true;
            btnReserve.Enabled = true;
        }

        private void LoadReservationsData()
        {
            dtUserTableData = clsGlobal.CurrentUser.GetAllResevations();
            dgvUserTable.DataSource = dtUserTableData;

            dgvUserTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ctrlBookInfo.Enabled = false;
            ctrlBookInfo.Visible = false;
            btnReserve.Visible = false;
            btnReserve.Enabled = false;
        }

        private void LoadFinesData()
        {
            dtUserTableData = clsGlobal.CurrentUser.GetAllFines();
            dgvUserTable.DataSource = dtUserTableData;

            dgvUserTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ctrlBookInfo.Enabled = false;
            ctrlBookInfo.Visible = false;
            btnReserve.Visible = false;
            btnReserve.Enabled = false;
        }

        private void cbTableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTableType.SelectedIndex)
            {
                case 1:
                    LoadReservationsData();
                    break;
                case 2:
                    LoadFinesData();
                    break;
                default:
                    LoadBooksData();
                    break;
            }

        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            frmAccountSettings frm = new frmAccountSettings(frmAccountSettings.enMode.ShowAccountInfo);
            frm.DataBack += CheckAdministrativeLevel;
            frm.ShowDialog();
            UserDashboard_Load(null, null);
        }
    }//Class End
}
