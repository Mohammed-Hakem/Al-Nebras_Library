namespace Al_Nebras_LibraryPresentationLayer
{
    partial class frmAccountSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLoginPanel = new System.Windows.Forms.Panel();
            this.lblWrongData = new System.Windows.Forms.Label();
            this.pnlAcountInfo = new System.Windows.Forms.Panel();
            this.lblInactive = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.llblEdit = new System.Windows.Forms.LinkLabel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblCurrentUserUsername = new System.Windows.Forms.Label();
            this.lblCurrentUserFullName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLoginPanel.SuspendLayout();
            this.pnlAcountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(200, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(200, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblTitle.Location = new System.Drawing.Point(351, 80);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(583, 122);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "User Login";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(208, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(846, 20);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(446, 398);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(608, 55);
            this.tbUserName.TabIndex = 28;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_tbPassword_TextChanged);
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(446, 522);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(608, 55);
            this.tbPassword.TabIndex = 29;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbUserName_tbPassword_TextChanged);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(6, 1000);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 36);
            this.lblTime.TabIndex = 30;
            this.lblTime.Text = "Time";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(856, 701);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(198, 66);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLoginPanel
            // 
            this.pnlLoginPanel.Controls.Add(this.lblTitle);
            this.pnlLoginPanel.Controls.Add(this.lblWrongData);
            this.pnlLoginPanel.Controls.Add(this.btnLogin);
            this.pnlLoginPanel.Controls.Add(this.lblTime);
            this.pnlLoginPanel.Controls.Add(this.tbPassword);
            this.pnlLoginPanel.Controls.Add(this.tbUserName);
            this.pnlLoginPanel.Controls.Add(this.button1);
            this.pnlLoginPanel.Controls.Add(this.label2);
            this.pnlLoginPanel.Controls.Add(this.label1);
            this.pnlLoginPanel.Enabled = false;
            this.pnlLoginPanel.Location = new System.Drawing.Point(12, 12);
            this.pnlLoginPanel.Name = "pnlLoginPanel";
            this.pnlLoginPanel.Size = new System.Drawing.Size(1269, 1045);
            this.pnlLoginPanel.TabIndex = 33;
            this.pnlLoginPanel.Visible = false;
            // 
            // lblWrongData
            // 
            this.lblWrongData.AutoSize = true;
            this.lblWrongData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongData.ForeColor = System.Drawing.Color.Red;
            this.lblWrongData.Location = new System.Drawing.Point(438, 599);
            this.lblWrongData.Name = "lblWrongData";
            this.lblWrongData.Size = new System.Drawing.Size(265, 48);
            this.lblWrongData.TabIndex = 33;
            this.lblWrongData.Text = "Wrong Data!";
            this.lblWrongData.Visible = false;
            // 
            // pnlAcountInfo
            // 
            this.pnlAcountInfo.Controls.Add(this.llblEdit);
            this.pnlAcountInfo.Controls.Add(this.btnLogOut);
            this.pnlAcountInfo.Controls.Add(this.label6);
            this.pnlAcountInfo.Controls.Add(this.txtNewPassword);
            this.pnlAcountInfo.Controls.Add(this.txtNewUsername);
            this.pnlAcountInfo.Controls.Add(this.lblNewPassword);
            this.pnlAcountInfo.Controls.Add(this.lblNewUsername);
            this.pnlAcountInfo.Controls.Add(this.lblActive);
            this.pnlAcountInfo.Controls.Add(this.lblAdmin);
            this.pnlAcountInfo.Controls.Add(this.lblCurrentUserUsername);
            this.pnlAcountInfo.Controls.Add(this.lblCurrentUserFullName);
            this.pnlAcountInfo.Controls.Add(this.button2);
            this.pnlAcountInfo.Controls.Add(this.label4);
            this.pnlAcountInfo.Controls.Add(this.pictureBox1);
            this.pnlAcountInfo.Controls.Add(this.btnConfirm);
            this.pnlAcountInfo.Controls.Add(this.lblInactive);
            this.pnlAcountInfo.Enabled = false;
            this.pnlAcountInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlAcountInfo.Name = "pnlAcountInfo";
            this.pnlAcountInfo.Size = new System.Drawing.Size(1269, 1045);
            this.pnlAcountInfo.TabIndex = 34;
            this.pnlAcountInfo.Visible = false;
            // 
            // lblInactive
            // 
            this.lblInactive.AutoSize = true;
            this.lblInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactive.ForeColor = System.Drawing.Color.Gray;
            this.lblInactive.Location = new System.Drawing.Point(599, 455);
            this.lblInactive.Name = "lblInactive";
            this.lblInactive.Size = new System.Drawing.Size(173, 48);
            this.lblInactive.TabIndex = 42;
            this.lblInactive.Text = "Inactive";
            this.lblInactive.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(901, 885);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(203, 83);
            this.btnConfirm.TabIndex = 53;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // llblEdit
            // 
            this.llblEdit.AutoSize = true;
            this.llblEdit.Enabled = false;
            this.llblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblEdit.Location = new System.Drawing.Point(396, 522);
            this.llblEdit.Name = "llblEdit";
            this.llblEdit.Size = new System.Drawing.Size(79, 40);
            this.llblEdit.TabIndex = 52;
            this.llblEdit.TabStop = true;
            this.llblEdit.Text = "Edit";
            this.llblEdit.Visible = false;
            this.llblEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEdit_LinkClicked);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::Al_Nebras_LibraryPresentationLayer.Properties.Resources.Aniket_Suvarna_Box_Regular_Bx_log_out_48;
            this.btnLogOut.Location = new System.Drawing.Point(901, 885);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(203, 83);
            this.btnLogOut.TabIndex = 50;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(3, 1000);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 36);
            this.label6.TabIndex = 48;
            this.label6.Text = "Time";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(481, 752);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(623, 55);
            this.txtNewPassword.TabIndex = 47;
            this.txtNewPassword.Visible = false;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Enabled = false;
            this.txtNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUsername.Location = new System.Drawing.Point(481, 631);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(623, 55);
            this.txtNewUsername.TabIndex = 46;
            this.txtNewUsername.Visible = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Enabled = false;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewPassword.Location = new System.Drawing.Point(121, 755);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(322, 48);
            this.lblNewPassword.TabIndex = 45;
            this.lblNewPassword.Text = "New Password:";
            this.lblNewPassword.Visible = false;
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Enabled = false;
            this.lblNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewUsername.Location = new System.Drawing.Point(121, 634);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(331, 48);
            this.lblNewUsername.TabIndex = 44;
            this.lblNewUsername.Text = "New Username:";
            this.lblNewUsername.Visible = false;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblActive.Location = new System.Drawing.Point(599, 455);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(141, 48);
            this.lblActive.TabIndex = 43;
            this.lblActive.Text = "Active";
            this.lblActive.Visible = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Gray;
            this.lblAdmin.Location = new System.Drawing.Point(394, 455);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(144, 48);
            this.lblAdmin.TabIndex = 41;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Visible = false;
            // 
            // lblCurrentUserUsername
            // 
            this.lblCurrentUserUsername.AutoSize = true;
            this.lblCurrentUserUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentUserUsername.Location = new System.Drawing.Point(395, 385);
            this.lblCurrentUserUsername.Name = "lblCurrentUserUsername";
            this.lblCurrentUserUsername.Size = new System.Drawing.Size(113, 48);
            this.lblCurrentUserUsername.TabIndex = 40;
            this.lblCurrentUserUsername.Text = "Gest";
            // 
            // lblCurrentUserFullName
            // 
            this.lblCurrentUserFullName.AutoSize = true;
            this.lblCurrentUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentUserFullName.Location = new System.Drawing.Point(391, 308);
            this.lblCurrentUserFullName.Name = "lblCurrentUserFullName";
            this.lblCurrentUserFullName.Size = new System.Drawing.Size(145, 63);
            this.lblCurrentUserFullName.TabIndex = 39;
            this.lblCurrentUserFullName.Text = "Gest";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(208, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(846, 20);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(291, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(663, 122);
            this.label4.TabIndex = 37;
            this.label4.Text = "Account Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Al_Nebras_LibraryPresentationLayer.Properties.Resources.user256;
            this.pictureBox1.Location = new System.Drawing.Point(129, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 1069);
            this.Controls.Add(this.pnlAcountInfo);
            this.Controls.Add(this.pnlLoginPanel);
            this.Name = "frmAccountSettings";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.frmAccountSettings_Load);
            this.pnlLoginPanel.ResumeLayout(false);
            this.pnlLoginPanel.PerformLayout();
            this.pnlAcountInfo.ResumeLayout(false);
            this.pnlAcountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLoginPanel;
        private System.Windows.Forms.Label lblWrongData;
        private System.Windows.Forms.Panel pnlAcountInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentUserUsername;
        private System.Windows.Forms.Label lblCurrentUserFullName;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblInactive;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.LinkLabel llblEdit;
        private System.Windows.Forms.Button btnConfirm;
    }
}