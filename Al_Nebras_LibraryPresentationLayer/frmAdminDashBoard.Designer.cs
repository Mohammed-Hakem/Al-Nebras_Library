namespace PresentationLayer
{
    partial class frmAdminDashBoard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbTableType = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvAdminTable = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(2349, 1816);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(212, 94);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 1870);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 40);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date";
            // 
            // cbTableType
            // 
            this.cbTableType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTableType.FormattingEnabled = true;
            this.cbTableType.ItemHeight = 55;
            this.cbTableType.Location = new System.Drawing.Point(1955, 319);
            this.cbTableType.Margin = new System.Windows.Forms.Padding(2);
            this.cbTableType.Name = "cbTableType";
            this.cbTableType.Size = new System.Drawing.Size(494, 63);
            this.cbTableType.TabIndex = 40;
            this.cbTableType.Text = "Admin Table Type:   ";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Enabled = false;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(544, 319);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(620, 62);
            this.txtSearchBox.TabIndex = 38;
            this.txtSearchBox.Visible = false;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(40, 319);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(494, 63);
            this.cbFilterBy.TabIndex = 37;
            this.cbFilterBy.Text = "Filter By";
            // 
            // dgvAdminTable
            // 
            this.dgvAdminTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAdminTable.ColumnHeadersHeight = 100;
            this.dgvAdminTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAdminTable.Location = new System.Drawing.Point(40, 397);
            this.dgvAdminTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdminTable.Name = "dgvAdminTable";
            this.dgvAdminTable.ReadOnly = true;
            this.dgvAdminTable.RowHeadersWidth = 92;
            this.dgvAdminTable.RowTemplate.Height = 37;
            this.dgvAdminTable.Size = new System.Drawing.Size(2492, 845);
            this.dgvAdminTable.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblTitle.Location = new System.Drawing.Point(667, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1235, 163);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 1247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(2492, 452);
            this.button1.TabIndex = 42;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.BackColor = System.Drawing.Color.FloralWhite;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Al_Nebras_LibraryPresentationLayer.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh_48;
            this.btnRefresh.Location = new System.Drawing.Point(2453, 318);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 64);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.UseCompatibleTextRendering = true;
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // frmAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2572, 1921);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbTableType);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.dgvAdminTable);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAdminDashBoard";
            this.Text = "AdminDashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbTableType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.DataGridView dgvAdminTable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
    }
}