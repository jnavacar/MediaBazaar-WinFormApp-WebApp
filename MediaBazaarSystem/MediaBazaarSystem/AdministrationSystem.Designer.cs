﻿namespace MediaBazaarSystem
{
    partial class AdministrationSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationSystem));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbControlAdmin = new System.Windows.Forms.TabControl();
            this.tbPageHome = new System.Windows.Forms.TabPage();
            this.cmboBoxFilter = new System.Windows.Forms.ComboBox();
            this.btnHomeSearch = new System.Windows.Forms.Button();
            this.txtBoxHomeSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnViewAllShifts = new System.Windows.Forms.Button();
            this.lblAssignEmployee = new System.Windows.Forms.Label();
            this.picBoxLogout = new System.Windows.Forms.PictureBox();
            this.dataAdminWorkSchedule = new System.Windows.Forms.DataGridView();
            this.dtpWorkSchedule = new System.Windows.Forms.DateTimePicker();
            this.tbPageStatistics = new System.Windows.Forms.TabPage();
            this.lBoxEmpStats = new System.Windows.Forms.ListBox();
            this.lblStaffIsAvilable = new System.Windows.Forms.Label();
            this.lBoxStatistics = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmboBoxStatsFilter = new System.Windows.Forms.ComboBox();
            this.btnViewAllDepartments = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxStatsSearch = new System.Windows.Forms.TextBox();
            this.btnViewAllEmployees = new System.Windows.Forms.Button();
            this.tbPageProfile = new System.Windows.Forms.TabPage();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pictureBoxAdminPhoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.lbEmployeeInfo = new System.Windows.Forms.ListBox();
            this.tbPageEmpManagement = new System.Windows.Forms.TabPage();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUndoEmpSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbManagers = new System.Windows.Forms.ListBox();
            this.btnViewEmployeeDetails = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.grpBoxManagers = new System.Windows.Forms.GroupBox();
            this.btnUndoManSelection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Timer(this.components);
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.clmnStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControlAdmin.SuspendLayout();
            this.tbPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminWorkSchedule)).BeginInit();
            this.tbPageStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tbPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPhoto)).BeginInit();
            this.tbPageEmpManagement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxManagers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlAdmin
            // 
            this.tbControlAdmin.Controls.Add(this.tbPageHome);
            this.tbControlAdmin.Controls.Add(this.tbPageStatistics);
            this.tbControlAdmin.Controls.Add(this.tbPageProfile);
            this.tbControlAdmin.Controls.Add(this.tbPageEmpManagement);
            this.tbControlAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlAdmin.Location = new System.Drawing.Point(12, 12);
            this.tbControlAdmin.Name = "tbControlAdmin";
            this.tbControlAdmin.SelectedIndex = 0;
            this.tbControlAdmin.Size = new System.Drawing.Size(878, 707);
            this.tbControlAdmin.TabIndex = 2;
            this.tbControlAdmin.SelectedIndexChanged += new System.EventHandler(this.tbControlAdmin_SelectedIndexChanged);
            // 
            // tbPageHome
            // 
            this.tbPageHome.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPageHome.Controls.Add(this.cmboBoxFilter);
            this.tbPageHome.Controls.Add(this.btnHomeSearch);
            this.tbPageHome.Controls.Add(this.txtBoxHomeSearch);
            this.tbPageHome.Controls.Add(this.btnSort);
            this.tbPageHome.Controls.Add(this.btnViewAllShifts);
            this.tbPageHome.Controls.Add(this.lblAssignEmployee);
            this.tbPageHome.Controls.Add(this.picBoxLogout);
            this.tbPageHome.Controls.Add(this.dataAdminWorkSchedule);
            this.tbPageHome.Controls.Add(this.dtpWorkSchedule);
            this.tbPageHome.Location = new System.Drawing.Point(4, 30);
            this.tbPageHome.Name = "tbPageHome";
            this.tbPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageHome.Size = new System.Drawing.Size(870, 673);
            this.tbPageHome.TabIndex = 0;
            this.tbPageHome.Text = "Home";
            // 
            // cmboBoxFilter
            // 
            this.cmboBoxFilter.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBoxFilter.FormattingEnabled = true;
            this.cmboBoxFilter.Items.AddRange(new object[] {
            "All",
            "Manager",
            "Employee"});
            this.cmboBoxFilter.Location = new System.Drawing.Point(28, 16);
            this.cmboBoxFilter.Name = "cmboBoxFilter";
            this.cmboBoxFilter.Size = new System.Drawing.Size(178, 29);
            this.cmboBoxFilter.TabIndex = 18;
            this.cmboBoxFilter.Text = "Filter";
            this.cmboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.cmboBoxFilter_SelectedIndexChanged);
            // 
            // btnHomeSearch
            // 
            this.btnHomeSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHomeSearch.Location = new System.Drawing.Point(565, 10);
            this.btnHomeSearch.Name = "btnHomeSearch";
            this.btnHomeSearch.Size = new System.Drawing.Size(172, 42);
            this.btnHomeSearch.TabIndex = 17;
            this.btnHomeSearch.Text = "Search";
            this.btnHomeSearch.UseVisualStyleBackColor = false;
            this.btnHomeSearch.Click += new System.EventHandler(this.btnHomeSearch_Click);
            // 
            // txtBoxHomeSearch
            // 
            this.txtBoxHomeSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHomeSearch.Location = new System.Drawing.Point(212, 16);
            this.txtBoxHomeSearch.Name = "txtBoxHomeSearch";
            this.txtBoxHomeSearch.Size = new System.Drawing.Size(347, 32);
            this.txtBoxHomeSearch.TabIndex = 16;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSort.Location = new System.Drawing.Point(452, 610);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(385, 42);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnViewAllShifts
            // 
            this.btnViewAllShifts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewAllShifts.Location = new System.Drawing.Point(28, 610);
            this.btnViewAllShifts.Name = "btnViewAllShifts";
            this.btnViewAllShifts.Size = new System.Drawing.Size(385, 42);
            this.btnViewAllShifts.TabIndex = 13;
            this.btnViewAllShifts.Text = "View All Shifts";
            this.btnViewAllShifts.UseVisualStyleBackColor = false;
            this.btnViewAllShifts.Click += new System.EventHandler(this.btnViewAllShifts_Click);
            // 
            // lblAssignEmployee
            // 
            this.lblAssignEmployee.AutoSize = true;
            this.lblAssignEmployee.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignEmployee.Location = new System.Drawing.Point(24, 88);
            this.lblAssignEmployee.Name = "lblAssignEmployee";
            this.lblAssignEmployee.Size = new System.Drawing.Size(538, 22);
            this.lblAssignEmployee.TabIndex = 8;
            this.lblAssignEmployee.Text = "Double click on employee\'s name to assign them to a task";
            // 
            // picBoxLogout
            // 
            this.picBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogout.Image")));
            this.picBoxLogout.Location = new System.Drawing.Point(757, 0);
            this.picBoxLogout.Name = "picBoxLogout";
            this.picBoxLogout.Size = new System.Drawing.Size(117, 39);
            this.picBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogout.TabIndex = 7;
            this.picBoxLogout.TabStop = false;
            this.picBoxLogout.Click += new System.EventHandler(this.picBoxLogout_Click);
            this.picBoxLogout.MouseEnter += new System.EventHandler(this.picBoxLogout_MouseEnter);
            this.picBoxLogout.MouseLeave += new System.EventHandler(this.picBoxLogout_MouseLeave);
            // 
            // dataAdminWorkSchedule
            // 
            this.dataAdminWorkSchedule.AllowUserToResizeColumns = false;
            this.dataAdminWorkSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdminWorkSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnStaffName,
            this.clmnRole,
            this.clmnStartTime,
            this.clmnEndTime,
            this.clmnWorkDate});
            this.dataAdminWorkSchedule.Location = new System.Drawing.Point(28, 125);
            this.dataAdminWorkSchedule.MultiSelect = false;
            this.dataAdminWorkSchedule.Name = "dataAdminWorkSchedule";
            this.dataAdminWorkSchedule.ReadOnly = true;
            this.dataAdminWorkSchedule.RowHeadersWidth = 51;
            this.dataAdminWorkSchedule.RowTemplate.Height = 24;
            this.dataAdminWorkSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAdminWorkSchedule.Size = new System.Drawing.Size(809, 412);
            this.dataAdminWorkSchedule.TabIndex = 5;
            this.dataAdminWorkSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAdminWorkSchedule_CellDoubleClick);
            // 
            // dtpWorkSchedule
            // 
            this.dtpWorkSchedule.Location = new System.Drawing.Point(240, 563);
            this.dtpWorkSchedule.Name = "dtpWorkSchedule";
            this.dtpWorkSchedule.Size = new System.Drawing.Size(385, 28);
            this.dtpWorkSchedule.TabIndex = 3;
            this.dtpWorkSchedule.ValueChanged += new System.EventHandler(this.dtpWorkSchedule_ValueChanged);
            // 
            // tbPageStatistics
            // 
            this.tbPageStatistics.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPageStatistics.Controls.Add(this.lBoxEmpStats);
            this.tbPageStatistics.Controls.Add(this.lblStaffIsAvilable);
            this.tbPageStatistics.Controls.Add(this.lBoxStatistics);
            this.tbPageStatistics.Controls.Add(this.chart1);
            this.tbPageStatistics.Controls.Add(this.cmboBoxStatsFilter);
            this.tbPageStatistics.Controls.Add(this.btnViewAllDepartments);
            this.tbPageStatistics.Controls.Add(this.btnSearch);
            this.tbPageStatistics.Controls.Add(this.txtBoxStatsSearch);
            this.tbPageStatistics.Controls.Add(this.btnViewAllEmployees);
            this.tbPageStatistics.Location = new System.Drawing.Point(4, 30);
            this.tbPageStatistics.Name = "tbPageStatistics";
            this.tbPageStatistics.Size = new System.Drawing.Size(870, 673);
            this.tbPageStatistics.TabIndex = 2;
            this.tbPageStatistics.Text = "Statistics";
            // 
            // lBoxEmpStats
            // 
            this.lBoxEmpStats.FormattingEnabled = true;
            this.lBoxEmpStats.ItemHeight = 21;
            this.lBoxEmpStats.Location = new System.Drawing.Point(29, 88);
            this.lBoxEmpStats.Name = "lBoxEmpStats";
            this.lBoxEmpStats.Size = new System.Drawing.Size(807, 214);
            this.lBoxEmpStats.TabIndex = 23;
            // 
            // lblStaffIsAvilable
            // 
            this.lblStaffIsAvilable.AutoSize = true;
            this.lblStaffIsAvilable.Location = new System.Drawing.Point(457, 336);
            this.lblStaffIsAvilable.Name = "lblStaffIsAvilable";
            this.lblStaffIsAvilable.Size = new System.Drawing.Size(361, 21);
            this.lblStaffIsAvilable.TabIndex = 22;
            this.lblStaffIsAvilable.Text = "Staff members that are available for work:";
            // 
            // lBoxStatistics
            // 
            this.lBoxStatistics.FormattingEnabled = true;
            this.lBoxStatistics.ItemHeight = 21;
            this.lBoxStatistics.Location = new System.Drawing.Point(436, 360);
            this.lBoxStatistics.Name = "lBoxStatistics";
            this.lBoxStatistics.Size = new System.Drawing.Size(400, 235);
            this.lBoxStatistics.TabIndex = 21;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(29, 315);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(401, 280);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // cmboBoxStatsFilter
            // 
            this.cmboBoxStatsFilter.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBoxStatsFilter.FormattingEnabled = true;
            this.cmboBoxStatsFilter.Items.AddRange(new object[] {
            "All",
            "Manager",
            "Employee"});
            this.cmboBoxStatsFilter.Location = new System.Drawing.Point(29, 34);
            this.cmboBoxStatsFilter.Name = "cmboBoxStatsFilter";
            this.cmboBoxStatsFilter.Size = new System.Drawing.Size(178, 29);
            this.cmboBoxStatsFilter.TabIndex = 19;
            this.cmboBoxStatsFilter.Text = "Filter";
            this.cmboBoxStatsFilter.SelectedIndexChanged += new System.EventHandler(this.cmboBoxStatsFilter_SelectedIndexChanged);
            // 
            // btnViewAllDepartments
            // 
            this.btnViewAllDepartments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewAllDepartments.Location = new System.Drawing.Point(29, 601);
            this.btnViewAllDepartments.Name = "btnViewAllDepartments";
            this.btnViewAllDepartments.Size = new System.Drawing.Size(401, 42);
            this.btnViewAllDepartments.TabIndex = 16;
            this.btnViewAllDepartments.Text = "View All Departments";
            this.btnViewAllDepartments.UseVisualStyleBackColor = false;
            this.btnViewAllDepartments.Click += new System.EventHandler(this.btnViewAllDepartments_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(646, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(190, 42);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxStatsSearch
            // 
            this.txtBoxStatsSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStatsSearch.Location = new System.Drawing.Point(213, 32);
            this.txtBoxStatsSearch.Name = "txtBoxStatsSearch";
            this.txtBoxStatsSearch.Size = new System.Drawing.Size(427, 32);
            this.txtBoxStatsSearch.TabIndex = 13;
            // 
            // btnViewAllEmployees
            // 
            this.btnViewAllEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewAllEmployees.Location = new System.Drawing.Point(436, 601);
            this.btnViewAllEmployees.Name = "btnViewAllEmployees";
            this.btnViewAllEmployees.Size = new System.Drawing.Size(400, 42);
            this.btnViewAllEmployees.TabIndex = 11;
            this.btnViewAllEmployees.Text = "View All Employees";
            this.btnViewAllEmployees.UseVisualStyleBackColor = false;
            this.btnViewAllEmployees.Click += new System.EventHandler(this.btnViewAllEmployees_Click);
            // 
            // tbPageProfile
            // 
            this.tbPageProfile.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPageProfile.Controls.Add(this.btnChangePwd);
            this.tbPageProfile.Controls.Add(this.lblAdminName);
            this.tbPageProfile.Controls.Add(this.pictureBoxAdminPhoto);
            this.tbPageProfile.Controls.Add(this.label6);
            this.tbPageProfile.Controls.Add(this.lblEmail);
            this.tbPageProfile.Controls.Add(this.txtBoxEmail);
            this.tbPageProfile.Controls.Add(this.lblAddress);
            this.tbPageProfile.Controls.Add(this.lblAge);
            this.tbPageProfile.Controls.Add(this.lblLastName);
            this.tbPageProfile.Controls.Add(this.lblFirstName);
            this.tbPageProfile.Controls.Add(this.txtBoxAddress);
            this.tbPageProfile.Controls.Add(this.txtBoxLastName);
            this.tbPageProfile.Controls.Add(this.txtBoxAge);
            this.tbPageProfile.Controls.Add(this.txtBoxFirstName);
            this.tbPageProfile.Controls.Add(this.btnUpdateProfile);
            this.tbPageProfile.Controls.Add(this.lbEmployeeInfo);
            this.tbPageProfile.Location = new System.Drawing.Point(4, 30);
            this.tbPageProfile.Name = "tbPageProfile";
            this.tbPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageProfile.Size = new System.Drawing.Size(870, 673);
            this.tbPageProfile.TabIndex = 1;
            this.tbPageProfile.Text = "Profile";
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangePwd.Location = new System.Drawing.Point(526, 614);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(297, 44);
            this.btnChangePwd.TabIndex = 17;
            this.btnChangePwd.Text = "Change Password";
            this.btnChangePwd.UseVisualStyleBackColor = false;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(15, 23);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(55, 21);
            this.lblAdminName.TabIndex = 15;
            this.lblAdminName.Text = "Hello,";
            // 
            // pictureBoxAdminPhoto
            // 
            this.pictureBoxAdminPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdminPhoto.Image")));
            this.pictureBoxAdminPhoto.Location = new System.Drawing.Point(526, 23);
            this.pictureBoxAdminPhoto.Name = "pictureBoxAdminPhoto";
            this.pictureBoxAdminPhoto.Size = new System.Drawing.Size(297, 263);
            this.pictureBoxAdminPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdminPhoto.TabIndex = 13;
            this.pictureBoxAdminPhoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(438, 509);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(526, 504);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(297, 32);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(429, 465);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 21);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(454, 415);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 21);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(403, 364);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(105, 21);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(405, 312);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 21);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(526, 460);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(297, 32);
            this.txtBoxAddress.TabIndex = 5;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(526, 359);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(297, 32);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.Location = new System.Drawing.Point(526, 410);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(297, 32);
            this.txtBoxAge.TabIndex = 3;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(526, 307);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(297, 32);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateProfile.Location = new System.Drawing.Point(526, 554);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(297, 44);
            this.btnUpdateProfile.TabIndex = 1;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // lbEmployeeInfo
            // 
            this.lbEmployeeInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbEmployeeInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeInfo.FormattingEnabled = true;
            this.lbEmployeeInfo.ItemHeight = 23;
            this.lbEmployeeInfo.Location = new System.Drawing.Point(19, 65);
            this.lbEmployeeInfo.Name = "lbEmployeeInfo";
            this.lbEmployeeInfo.Size = new System.Drawing.Size(330, 533);
            this.lbEmployeeInfo.TabIndex = 0;
            // 
            // tbPageEmpManagement
            // 
            this.tbPageEmpManagement.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPageEmpManagement.Controls.Add(this.lbEmployees);
            this.tbPageEmpManagement.Controls.Add(this.groupBox1);
            this.tbPageEmpManagement.Controls.Add(this.lbManagers);
            this.tbPageEmpManagement.Controls.Add(this.btnViewEmployeeDetails);
            this.tbPageEmpManagement.Controls.Add(this.btnAddEmployee);
            this.tbPageEmpManagement.Controls.Add(this.btnUpdateEmployee);
            this.tbPageEmpManagement.Controls.Add(this.btnFireEmployee);
            this.tbPageEmpManagement.Controls.Add(this.grpBoxManagers);
            this.tbPageEmpManagement.Location = new System.Drawing.Point(4, 30);
            this.tbPageEmpManagement.Name = "tbPageEmpManagement";
            this.tbPageEmpManagement.Size = new System.Drawing.Size(870, 673);
            this.tbPageEmpManagement.TabIndex = 3;
            this.tbPageEmpManagement.Text = "Employee Management";
            // 
            // lbEmployees
            // 
            this.lbEmployees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbEmployees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 23;
            this.lbEmployees.Location = new System.Drawing.Point(19, 82);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(403, 441);
            this.lbEmployees.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUndoEmpSelection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 542);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnUndoEmpSelection
            // 
            this.btnUndoEmpSelection.BackColor = System.Drawing.Color.Azure;
            this.btnUndoEmpSelection.Location = new System.Drawing.Point(242, 32);
            this.btnUndoEmpSelection.Name = "btnUndoEmpSelection";
            this.btnUndoEmpSelection.Size = new System.Drawing.Size(162, 30);
            this.btnUndoEmpSelection.TabIndex = 12;
            this.btnUndoEmpSelection.Text = "Undo Selection";
            this.btnUndoEmpSelection.UseVisualStyleBackColor = false;
            this.btnUndoEmpSelection.Click += new System.EventHandler(this.btnUndoEmpSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employees";
            // 
            // lbManagers
            // 
            this.lbManagers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbManagers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagers.FormattingEnabled = true;
            this.lbManagers.ItemHeight = 23;
            this.lbManagers.Location = new System.Drawing.Point(447, 82);
            this.lbManagers.Name = "lbManagers";
            this.lbManagers.Size = new System.Drawing.Size(403, 441);
            this.lbManagers.TabIndex = 8;
            // 
            // btnViewEmployeeDetails
            // 
            this.btnViewEmployeeDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewEmployeeDetails.Location = new System.Drawing.Point(447, 588);
            this.btnViewEmployeeDetails.Name = "btnViewEmployeeDetails";
            this.btnViewEmployeeDetails.Size = new System.Drawing.Size(211, 48);
            this.btnViewEmployeeDetails.TabIndex = 7;
            this.btnViewEmployeeDetails.Text = "View Details";
            this.btnViewEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnViewEmployeeDetails.Click += new System.EventHandler(this.btnViewEmployeeDetails_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddEmployee.Location = new System.Drawing.Point(19, 588);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(167, 48);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(227, 588);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(182, 48);
            this.btnUpdateEmployee.TabIndex = 5;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFireEmployee.Location = new System.Drawing.Point(688, 588);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(162, 48);
            this.btnFireEmployee.TabIndex = 3;
            this.btnFireEmployee.Text = "Delete";
            this.btnFireEmployee.UseVisualStyleBackColor = false;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // grpBoxManagers
            // 
            this.grpBoxManagers.Controls.Add(this.btnUndoManSelection);
            this.grpBoxManagers.Controls.Add(this.label2);
            this.grpBoxManagers.Location = new System.Drawing.Point(435, 3);
            this.grpBoxManagers.Name = "grpBoxManagers";
            this.grpBoxManagers.Size = new System.Drawing.Size(432, 542);
            this.grpBoxManagers.TabIndex = 11;
            this.grpBoxManagers.TabStop = false;
            // 
            // btnUndoManSelection
            // 
            this.btnUndoManSelection.BackColor = System.Drawing.Color.Azure;
            this.btnUndoManSelection.Location = new System.Drawing.Point(247, 32);
            this.btnUndoManSelection.Name = "btnUndoManSelection";
            this.btnUndoManSelection.Size = new System.Drawing.Size(162, 30);
            this.btnUndoManSelection.TabIndex = 12;
            this.btnUndoManSelection.Text = "Undo Selection";
            this.btnUndoManSelection.UseVisualStyleBackColor = false;
            this.btnUndoManSelection.Click += new System.EventHandler(this.btnUndoManSelection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Managers";
            // 
            // Refresh
            // 
            this.Refresh.Enabled = true;
            this.Refresh.Interval = 1500;
            this.Refresh.Tick += new System.EventHandler(this.Refresh_Tick);
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // clmnStaffName
            // 
            this.clmnStaffName.HeaderText = "Name";
            this.clmnStaffName.MinimumWidth = 6;
            this.clmnStaffName.Name = "clmnStaffName";
            this.clmnStaffName.ReadOnly = true;
            this.clmnStaffName.Width = 125;
            // 
            // clmnRole
            // 
            this.clmnRole.HeaderText = "Role";
            this.clmnRole.MinimumWidth = 6;
            this.clmnRole.Name = "clmnRole";
            this.clmnRole.ReadOnly = true;
            this.clmnRole.Width = 125;
            // 
            // clmnStartTime
            // 
            this.clmnStartTime.HeaderText = "Start Time";
            this.clmnStartTime.MinimumWidth = 6;
            this.clmnStartTime.Name = "clmnStartTime";
            this.clmnStartTime.ReadOnly = true;
            this.clmnStartTime.Width = 125;
            // 
            // clmnEndTime
            // 
            this.clmnEndTime.HeaderText = "End Time";
            this.clmnEndTime.MinimumWidth = 6;
            this.clmnEndTime.Name = "clmnEndTime";
            this.clmnEndTime.ReadOnly = true;
            this.clmnEndTime.Width = 125;
            // 
            // clmnWorkDate
            // 
            this.clmnWorkDate.HeaderText = "Date";
            this.clmnWorkDate.MinimumWidth = 6;
            this.clmnWorkDate.Name = "clmnWorkDate";
            this.clmnWorkDate.ReadOnly = true;
            this.clmnWorkDate.Width = 255;
            // 
            // AdministrationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(907, 733);
            this.Controls.Add(this.tbControlAdmin);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdministrationSystem";
            this.Text = "AdministrationSystem";
            this.tbControlAdmin.ResumeLayout(false);
            this.tbPageHome.ResumeLayout(false);
            this.tbPageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminWorkSchedule)).EndInit();
            this.tbPageStatistics.ResumeLayout(false);
            this.tbPageStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tbPageProfile.ResumeLayout(false);
            this.tbPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPhoto)).EndInit();
            this.tbPageEmpManagement.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxManagers.ResumeLayout(false);
            this.grpBoxManagers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlAdmin;
        private System.Windows.Forms.TabPage tbPageHome;
        private System.Windows.Forms.DateTimePicker dtpWorkSchedule;
        private System.Windows.Forms.TabPage tbPageStatistics;
        private System.Windows.Forms.TabPage tbPageProfile;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.PictureBox pictureBoxAdminPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TabPage tbPageEmpManagement;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.Button btnViewAllDepartments;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxStatsSearch;
        private System.Windows.Forms.Button btnViewAllEmployees;
        private System.Windows.Forms.Button btnViewEmployeeDetails;
        private System.Windows.Forms.DataGridView dataAdminWorkSchedule;
        private System.Windows.Forms.PictureBox picBoxLogout;
        private System.Windows.Forms.Timer Refresh;
        private System.Windows.Forms.ListBox lbManagers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label lblAssignEmployee;
        private System.Windows.Forms.Button btnViewAllShifts;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnHomeSearch;
        private System.Windows.Forms.TextBox txtBoxHomeSearch;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUndoEmpSelection;
        private System.Windows.Forms.GroupBox grpBoxManagers;
        private System.Windows.Forms.Button btnUndoManSelection;
        private System.Windows.Forms.ComboBox cmboBoxFilter;
        private System.Windows.Forms.ComboBox cmboBoxStatsFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox lBoxStatistics;
        private System.Windows.Forms.Label lblStaffIsAvilable;
        private System.Windows.Forms.ListBox lBoxEmpStats;
        private System.Windows.Forms.ListBox lbEmployeeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWorkDate;
    }
}