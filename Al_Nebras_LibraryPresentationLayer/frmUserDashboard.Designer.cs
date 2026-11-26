namespace Al_Nebras_LibraryPresentationLayer
{
    partial class frmUserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTableType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUserTable = new System.Windows.Forms.DataGridView();
            this.ctrlBookInfo = new Al_Nebras_LibraryPresentationLayer.Controls.BookInfo();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 1847);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 40);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(2336, 1794);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(212, 94);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTableType);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnAdminDashboard);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.cbFilterBy);
            this.panel1.Controls.Add(this.btnReserve);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvUserTable);
            this.panel1.Controls.Add(this.ctrlBookInfo);
            this.panel1.Controls.Add(this.btnAccountSettings);
            this.panel1.Location = new System.Drawing.Point(28, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2520, 1751);
            this.panel1.TabIndex = 24;
            // 
            // cbTableType
            // 
            this.cbTableType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTableType.FormattingEnabled = true;
            this.cbTableType.ItemHeight = 55;
            this.cbTableType.Location = new System.Drawing.Point(1929, 245);
            this.cbTableType.Margin = new System.Windows.Forms.Padding(2);
            this.cbTableType.Name = "cbTableType";
            this.cbTableType.Size = new System.Drawing.Size(494, 63);
            this.cbTableType.TabIndex = 35;
            this.cbTableType.Text = "User Table Type:   ";
            this.cbTableType.SelectedIndexChanged += new System.EventHandler(this.cbTableType_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::Al_Nebras_LibraryPresentationLayer.Properties.Resources.Mahm0udwally_All_Flat_User_48;
            this.btnLogin.Location = new System.Drawing.Point(14, 13);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 83);
            this.btnLogin.TabIndex = 33;
            this.btnLogin.Text = " Log in";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.BackColor = System.Drawing.Color.White;
            this.btnAdminDashboard.Enabled = false;
            this.btnAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashboard.Location = new System.Drawing.Point(2137, 1173);
            this.btnAdminDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(369, 71);
            this.btnAdminDashboard.TabIndex = 32;
            this.btnAdminDashboard.Text = "Admin Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = false;
            this.btnAdminDashboard.Visible = false;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.BackColor = System.Drawing.Color.FloralWhite;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Al_Nebras_LibraryPresentationLayer.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh_48;
            this.btnRefresh.Location = new System.Drawing.Point(2427, 244);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 64);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.UseCompatibleTextRendering = true;
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Enabled = false;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(518, 245);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(620, 62);
            this.txtSearchBox.TabIndex = 28;
            this.txtSearchBox.Visible = false;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(14, 245);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(494, 63);
            this.cbFilterBy.TabIndex = 27;
            this.cbFilterBy.Text = "Filter By";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.FloralWhite;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(2261, 1641);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(245, 83);
            this.btnReserve.TabIndex = 26;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblTitle.Location = new System.Drawing.Point(609, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1253, 163);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "AL-Nebras Library";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2261, 1641);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 83);
            this.button1.TabIndex = 29;
            this.button1.Text = "Borrow";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // dgvUserTable
            // 
            this.dgvUserTable.AllowUserToAddRows = false;
            this.dgvUserTable.AllowUserToDeleteRows = false;
            this.dgvUserTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUserTable.ColumnHeadersHeight = 100;
            this.dgvUserTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUserTable.Location = new System.Drawing.Point(14, 323);
            this.dgvUserTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserTable.MultiSelect = false;
            this.dgvUserTable.Name = "dgvUserTable";
            this.dgvUserTable.ReadOnly = true;
            this.dgvUserTable.RowHeadersWidth = 92;
            this.dgvUserTable.RowTemplate.Height = 37;
            this.dgvUserTable.ShowEditingIcon = false;
            this.dgvUserTable.ShowRowErrors = false;
            this.dgvUserTable.Size = new System.Drawing.Size(2492, 845);
            this.dgvUserTable.TabIndex = 24;
            this.dgvUserTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBooks_CellClick);
            this.dgvUserTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBooks_CellClick);
            this.dgvUserTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBooks_CellClick);
            // 
            // ctrlBookInfo
            // 
            this.ctrlBookInfo.BookID = -1;
            this.ctrlBookInfo.Enabled = false;
            this.ctrlBookInfo.Location = new System.Drawing.Point(14, 1173);
            this.ctrlBookInfo.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlBookInfo.Name = "ctrlBookInfo";
            this.ctrlBookInfo.Size = new System.Drawing.Size(2492, 551);
            this.ctrlBookInfo.TabIndex = 30;
            this.ctrlBookInfo.Visible = false;
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAccountSettings.Enabled = false;
            this.btnAccountSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSettings.Image = global::Al_Nebras_LibraryPresentationLayer.Properties.Resources.Mahm0udwally_All_Flat_User_48;
            this.btnAccountSettings.Location = new System.Drawing.Point(14, 13);
            this.btnAccountSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(415, 83);
            this.btnAccountSettings.TabIndex = 36;
            this.btnAccountSettings.Text = " Account Settings";
            this.btnAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountSettings.UseVisualStyleBackColor = false;
            this.btnAccountSettings.Visible = false;
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2564, 1896);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmUserDashboard";
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUserTable;
        private Controls.BookInfo ctrlBookInfo;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cbTableType;
        private System.Windows.Forms.Button btnAccountSettings;
    }
}