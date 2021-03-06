﻿
namespace HHF_APP
{
    partial class viewAdminDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewAdminDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Maintab = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.panelAddEmp = new System.Windows.Forms.Panel();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbATMLog = new System.Windows.Forms.ListBox();
            this.btnSelectLogFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAtmLogPath = new System.Windows.Forms.TextBox();
            this.panelMom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTBalance = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelTicketS = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelPVis = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.VisitCount = new System.Windows.Forms.Label();
            this.panelSpots = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblFreeSpots = new System.Windows.Forms.Label();
            this.lblBookedSpots = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelTSpent = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTotalV = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalVisitors = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbReserve = new System.Windows.Forms.CheckBox();
            this.rbMoney = new System.Windows.Forms.RadioButton();
            this.rbCamping = new System.Windows.Forms.RadioButton();
            this.rbArticle = new System.Windows.Forms.RadioButton();
            this.chartComplex = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ofdATMLog = new System.Windows.Forms.OpenFileDialog();
            this.passwordPanel1 = new HHF_APP.PasswordPanel();
            this.addEmployee2 = new HHF_APP.AddEmployee();
            this.tabControl1.SuspendLayout();
            this.Maintab.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.panelAddEmp.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panelMom.SuspendLayout();
            this.panelTBalance.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panelTicketS.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelPVis.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSpots.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panelTSpent.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelTotalV.SuspendLayout();
            this.panel13.SuspendLayout();
            this.Statistics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartComplex)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Maintab);
            this.tabControl1.Controls.Add(this.Statistics);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // Maintab
            // 
            this.Maintab.Controls.Add(this.panel10);
            this.Maintab.Controls.Add(this.panel21);
            this.Maintab.Controls.Add(this.panelMom);
            this.Maintab.Location = new System.Drawing.Point(4, 22);
            this.Maintab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Maintab.Name = "Maintab";
            this.Maintab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Maintab.Size = new System.Drawing.Size(826, 538);
            this.Maintab.TabIndex = 0;
            this.Maintab.Text = "Main";
            this.Maintab.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.BurlyWood;
            this.panel10.Controls.Add(this.pnlPassword);
            this.panel10.Controls.Add(this.panelAddEmp);
            this.panel10.Controls.Add(this.btnRemoveEmployee);
            this.panel10.Controls.Add(this.btnAddEmployee);
            this.panel10.Controls.Add(this.tbSearchEmployee);
            this.panel10.Controls.Add(this.btnSearchEmployee);
            this.panel10.Controls.Add(this.btnChangePassword);
            this.panel10.Controls.Add(this.lbEmployees);
            this.panel10.Location = new System.Drawing.Point(-2, 273);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(824, 184);
            this.panel10.TabIndex = 101;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Moccasin;
            this.pnlPassword.Controls.Add(this.passwordPanel1);
            this.pnlPassword.Location = new System.Drawing.Point(497, 28);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(170, 152);
            this.pnlPassword.TabIndex = 6;
            this.pnlPassword.Visible = false;
            // 
            // panelAddEmp
            // 
            this.panelAddEmp.BackColor = System.Drawing.Color.SeaShell;
            this.panelAddEmp.Controls.Add(this.addEmployee2);
            this.panelAddEmp.Location = new System.Drawing.Point(8, 28);
            this.panelAddEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAddEmp.Name = "panelAddEmp";
            this.panelAddEmp.Size = new System.Drawing.Size(487, 155);
            this.panelAddEmp.TabIndex = 1;
            this.panelAddEmp.Visible = false;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.Orange;
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(694, 95);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(115, 27);
            this.btnRemoveEmployee.TabIndex = 5;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Orange;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(694, 63);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(115, 27);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Location = new System.Drawing.Point(694, 11);
            this.tbSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(115, 20);
            this.tbSearchEmployee.TabIndex = 3;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.Orange;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(694, 32);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(115, 27);
            this.btnSearchEmployee.TabIndex = 2;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Orange;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(705, 127);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(97, 56);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.Location = new System.Drawing.Point(4, 11);
            this.lbEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(667, 173);
            this.lbEmployees.TabIndex = 0;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged_1);
            this.lbEmployees.SelectedValueChanged += new System.EventHandler(this.lbEmployees_SelectedValueChanged);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.BurlyWood;
            this.panel21.Controls.Add(this.label13);
            this.panel21.Controls.Add(this.lbATMLog);
            this.panel21.Controls.Add(this.btnSelectLogFile);
            this.panel21.Controls.Add(this.label12);
            this.panel21.Controls.Add(this.tbAtmLogPath);
            this.panel21.Location = new System.Drawing.Point(-1, 457);
            this.panel21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(823, 81);
            this.panel21.TabIndex = 102;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(609, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Log:";
            // 
            // lbATMLog
            // 
            this.lbATMLog.FormattingEnabled = true;
            this.lbATMLog.Location = new System.Drawing.Point(452, 19);
            this.lbATMLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbATMLog.Name = "lbATMLog";
            this.lbATMLog.Size = new System.Drawing.Size(357, 56);
            this.lbATMLog.TabIndex = 4;
            // 
            // btnSelectLogFile
            // 
            this.btnSelectLogFile.BackColor = System.Drawing.Color.Orange;
            this.btnSelectLogFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLogFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLogFile.Location = new System.Drawing.Point(22, 43);
            this.btnSelectLogFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectLogFile.Name = "btnSelectLogFile";
            this.btnSelectLogFile.Size = new System.Drawing.Size(417, 30);
            this.btnSelectLogFile.TabIndex = 2;
            this.btnSelectLogFile.Text = "Select/Read Log File";
            this.btnSelectLogFile.UseVisualStyleBackColor = false;
            this.btnSelectLogFile.Click += new System.EventHandler(this.btnSelectLogFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(187, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "ATM LOG Path:";
            // 
            // tbAtmLogPath
            // 
            this.tbAtmLogPath.Location = new System.Drawing.Point(22, 19);
            this.tbAtmLogPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAtmLogPath.Name = "tbAtmLogPath";
            this.tbAtmLogPath.Size = new System.Drawing.Size(417, 20);
            this.tbAtmLogPath.TabIndex = 0;
            // 
            // panelMom
            // 
            this.panelMom.BackColor = System.Drawing.Color.BurlyWood;
            this.panelMom.Controls.Add(this.label1);
            this.panelMom.Controls.Add(this.panelTBalance);
            this.panelMom.Controls.Add(this.panelTicketS);
            this.panelMom.Controls.Add(this.btnRefresh);
            this.panelMom.Controls.Add(this.panelPVis);
            this.panelMom.Controls.Add(this.panelSpots);
            this.panelMom.Controls.Add(this.panelTSpent);
            this.panelMom.Controls.Add(this.panelTotalV);
            this.panelMom.Location = new System.Drawing.Point(-3, 1);
            this.panelMom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMom.Name = "panelMom";
            this.panelMom.Size = new System.Drawing.Size(825, 272);
            this.panelMom.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employees";
            // 
            // panelTBalance
            // 
            this.panelTBalance.BackColor = System.Drawing.Color.Transparent;
            this.panelTBalance.Controls.Add(this.panel18);
            this.panelTBalance.Controls.Add(this.panel19);
            this.panelTBalance.Location = new System.Drawing.Point(6, 128);
            this.panelTBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTBalance.Name = "panelTBalance";
            this.panelTBalance.Size = new System.Drawing.Size(243, 114);
            this.panelTBalance.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.AutoSize = true;
            this.panel18.BackColor = System.Drawing.Color.Aqua;
            this.panel18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel18.BackgroundImage")));
            this.panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Location = new System.Drawing.Point(15, 9);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(56, 53);
            this.panel18.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Controls.Add(this.lblTotalBalance);
            this.panel19.Controls.Add(this.label10);
            this.panel19.Location = new System.Drawing.Point(3, 36);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(218, 75);
            this.panel19.TabIndex = 0;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalance.Location = new System.Drawing.Point(111, 31);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(49, 19);
            this.lblTotalBalance.TabIndex = 1;
            this.lblTotalBalance.Text = "00000";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Balance";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelTicketS
            // 
            this.panelTicketS.BackColor = System.Drawing.Color.Transparent;
            this.panelTicketS.Controls.Add(this.panel5);
            this.panelTicketS.Controls.Add(this.panel6);
            this.panelTicketS.Location = new System.Drawing.Point(249, -2);
            this.panelTicketS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTicketS.Name = "panelTicketS";
            this.panelTicketS.Size = new System.Drawing.Size(243, 114);
            this.panelTicketS.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(18, 9);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(56, 53);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblTicketsSold);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 36);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 75);
            this.panel6.TabIndex = 0;
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsSold.Location = new System.Drawing.Point(111, 31);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(49, 19);
            this.lblTicketsSold.TabIndex = 1;
            this.lblTicketsSold.Text = "00000";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tickets Sold";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(720, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 232);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelPVis
            // 
            this.panelPVis.BackColor = System.Drawing.Color.Transparent;
            this.panelPVis.Controls.Add(this.panel3);
            this.panelPVis.Controls.Add(this.panel2);
            this.panelPVis.Location = new System.Drawing.Point(4, -2);
            this.panelPVis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPVis.Name = "panelPVis";
            this.panelPVis.Size = new System.Drawing.Size(243, 114);
            this.panelPVis.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(16, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(56, 53);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblVisitors);
            this.panel2.Controls.Add(this.VisitCount);
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 75);
            this.panel2.TabIndex = 0;
            // 
            // lblVisitors
            // 
            this.lblVisitors.AutoSize = true;
            this.lblVisitors.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitors.Location = new System.Drawing.Point(111, 31);
            this.lblVisitors.Name = "lblVisitors";
            this.lblVisitors.Size = new System.Drawing.Size(49, 19);
            this.lblVisitors.TabIndex = 1;
            this.lblVisitors.Text = "00000";
            // 
            // VisitCount
            // 
            this.VisitCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitCount.AutoSize = true;
            this.VisitCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitCount.Location = new System.Drawing.Point(88, 2);
            this.VisitCount.Name = "VisitCount";
            this.VisitCount.Size = new System.Drawing.Size(106, 19);
            this.VisitCount.TabIndex = 0;
            this.VisitCount.Text = "Present Visitors";
            // 
            // panelSpots
            // 
            this.panelSpots.BackColor = System.Drawing.Color.Transparent;
            this.panelSpots.Controls.Add(this.panel15);
            this.panelSpots.Controls.Add(this.panel16);
            this.panelSpots.Location = new System.Drawing.Point(495, 128);
            this.panelSpots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSpots.Name = "panelSpots";
            this.panelSpots.Size = new System.Drawing.Size(243, 114);
            this.panelSpots.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.AutoSize = true;
            this.panel15.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel15.BackgroundImage")));
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(15, 9);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(56, 53);
            this.panel15.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.lblFreeSpots);
            this.panel16.Controls.Add(this.lblBookedSpots);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Location = new System.Drawing.Point(3, 36);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(218, 75);
            this.panel16.TabIndex = 0;
            // 
            // lblFreeSpots
            // 
            this.lblFreeSpots.AutoSize = true;
            this.lblFreeSpots.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeSpots.Location = new System.Drawing.Point(150, 34);
            this.lblFreeSpots.Name = "lblFreeSpots";
            this.lblFreeSpots.Size = new System.Drawing.Size(33, 19);
            this.lblFreeSpots.TabIndex = 2;
            this.lblFreeSpots.Text = "000";
            // 
            // lblBookedSpots
            // 
            this.lblBookedSpots.AutoSize = true;
            this.lblBookedSpots.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookedSpots.Location = new System.Drawing.Point(75, 34);
            this.lblBookedSpots.Name = "lblBookedSpots";
            this.lblBookedSpots.Size = new System.Drawing.Size(33, 19);
            this.lblBookedSpots.TabIndex = 1;
            this.lblBookedSpots.Text = "000";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Booked && Free Spots";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelTSpent
            // 
            this.panelTSpent.BackColor = System.Drawing.Color.Transparent;
            this.panelTSpent.Controls.Add(this.panel8);
            this.panelTSpent.Controls.Add(this.panel9);
            this.panelTSpent.Location = new System.Drawing.Point(495, -2);
            this.panelTSpent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTSpent.Name = "panelTSpent";
            this.panelTSpent.Size = new System.Drawing.Size(243, 114);
            this.panelTSpent.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(15, 9);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(56, 53);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.lblTotalSpent);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(3, 36);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 75);
            this.panel9.TabIndex = 0;
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.AutoSize = true;
            this.lblTotalSpent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpent.Location = new System.Drawing.Point(111, 31);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(49, 19);
            this.lblTotalSpent.TabIndex = 1;
            this.lblTotalSpent.Text = "00000";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Spent";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelTotalV
            // 
            this.panelTotalV.BackColor = System.Drawing.Color.Transparent;
            this.panelTotalV.Controls.Add(this.panel12);
            this.panelTotalV.Controls.Add(this.panel13);
            this.panelTotalV.Location = new System.Drawing.Point(248, 128);
            this.panelTotalV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTotalV.Name = "panelTotalV";
            this.panelTotalV.Size = new System.Drawing.Size(243, 114);
            this.panelTotalV.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(15, 9);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(56, 53);
            this.panel12.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.lblTotalVisitors);
            this.panel13.Location = new System.Drawing.Point(3, 36);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(218, 75);
            this.panel13.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Visitiors";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalVisitors
            // 
            this.lblTotalVisitors.AutoSize = true;
            this.lblTotalVisitors.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVisitors.Location = new System.Drawing.Point(111, 31);
            this.lblTotalVisitors.Name = "lblTotalVisitors";
            this.lblTotalVisitors.Size = new System.Drawing.Size(49, 19);
            this.lblTotalVisitors.TabIndex = 1;
            this.lblTotalVisitors.Text = "00000";
            // 
            // Statistics
            // 
            this.Statistics.Controls.Add(this.label3);
            this.Statistics.Controls.Add(this.rbAmount);
            this.Statistics.Controls.Add(this.groupBox1);
            this.Statistics.Controls.Add(this.chartComplex);
            this.Statistics.Location = new System.Drawing.Point(4, 22);
            this.Statistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Statistics.Name = "Statistics";
            this.Statistics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Statistics.Size = new System.Drawing.Size(826, 538);
            this.Statistics.TabIndex = 1;
            this.Statistics.Text = "Statistics & Graphs";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Checked = true;
            this.rbAmount.Location = new System.Drawing.Point(461, 390);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(14, 13);
            this.rbAmount.TabIndex = 0;
            this.rbAmount.TabStop = true;
            this.rbAmount.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cbReserve);
            this.groupBox1.Controls.Add(this.rbMoney);
            this.groupBox1.Controls.Add(this.rbCamping);
            this.groupBox1.Controls.Add(this.rbArticle);
            this.groupBox1.Location = new System.Drawing.Point(61, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbReserve
            // 
            this.cbReserve.AutoSize = true;
            this.cbReserve.Location = new System.Drawing.Point(14, 155);
            this.cbReserve.Name = "cbReserve";
            this.cbReserve.Size = new System.Drawing.Size(88, 17);
            this.cbReserve.TabIndex = 7;
            this.cbReserve.Text = "Reservations";
            this.cbReserve.UseVisualStyleBackColor = true;
            this.cbReserve.Visible = false;
            this.cbReserve.CheckedChanged += new System.EventHandler(this.cbReserve_CheckedChanged);
            // 
            // rbMoney
            // 
            this.rbMoney.AutoSize = true;
            this.rbMoney.Location = new System.Drawing.Point(14, 245);
            this.rbMoney.Name = "rbMoney";
            this.rbMoney.Size = new System.Drawing.Size(86, 17);
            this.rbMoney.TabIndex = 6;
            this.rbMoney.Text = "Revenue";
            this.rbMoney.UseVisualStyleBackColor = true;
            this.rbMoney.CheckedChanged += new System.EventHandler(this.rbMoney_CheckedChanged);
            // 
            // rbCamping
            // 
            this.rbCamping.AutoSize = true;
            this.rbCamping.Location = new System.Drawing.Point(14, 132);
            this.rbCamping.Name = "rbCamping";
            this.rbCamping.Size = new System.Drawing.Size(66, 17);
            this.rbCamping.TabIndex = 5;
            this.rbCamping.Text = "Camping";
            this.rbCamping.UseVisualStyleBackColor = true;
            this.rbCamping.CheckedChanged += new System.EventHandler(this.rbCamping_CheckedChanged);
            // 
            // rbArticle
            // 
            this.rbArticle.AutoSize = true;
            this.rbArticle.Checked = true;
            this.rbArticle.Location = new System.Drawing.Point(14, 58);
            this.rbArticle.Name = "rbArticle";
            this.rbArticle.Size = new System.Drawing.Size(54, 17);
            this.rbArticle.TabIndex = 4;
            this.rbArticle.TabStop = true;
            this.rbArticle.Text = "Article";
            this.rbArticle.UseVisualStyleBackColor = true;
            this.rbArticle.Click += new System.EventHandler(this.rbArticle_Click);
            // 
            // chartComplex
            // 
            chartArea2.Name = "ChartArea1";
            this.chartComplex.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartComplex.Legends.Add(legend2);
            this.chartComplex.Location = new System.Drawing.Point(229, 20);
            this.chartComplex.Name = "chartComplex";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Amount";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Reserved";
            this.chartComplex.Series.Add(series3);
            this.chartComplex.Series.Add(series4);
            this.chartComplex.Size = new System.Drawing.Size(548, 364);
            this.chartComplex.TabIndex = 0;
            this.chartComplex.Text = "chart1";
            // 
            // ofdATMLog
            // 
            this.ofdATMLog.FileName = "ofdATMLog";
            // 
            // passwordPanel1
            // 
            this.passwordPanel1.Location = new System.Drawing.Point(10, 2);
            this.passwordPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordPanel1.Name = "passwordPanel1";
            this.passwordPanel1.Size = new System.Drawing.Size(150, 150);
            this.passwordPanel1.TabIndex = 0;
            // 
            // addEmployee2
            // 
            this.addEmployee2.Location = new System.Drawing.Point(16, 2);
            this.addEmployee2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEmployee2.Name = "addEmployee2";
            this.addEmployee2.Size = new System.Drawing.Size(445, 150);
            this.addEmployee2.TabIndex = 0;
            // 
            // viewAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewAdminDashboard";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(834, 570);
            this.Load += new System.EventHandler(this.viewAdminDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.Maintab.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.panelAddEmp.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panelMom.ResumeLayout(false);
            this.panelMom.PerformLayout();
            this.panelTBalance.ResumeLayout(false);
            this.panelTBalance.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panelTicketS.ResumeLayout(false);
            this.panelTicketS.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelPVis.ResumeLayout(false);
            this.panelPVis.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSpots.ResumeLayout(false);
            this.panelSpots.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panelTSpent.ResumeLayout(false);
            this.panelTSpent.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelTotalV.ResumeLayout(false);
            this.panelTotalV.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.Statistics.ResumeLayout(false);
            this.Statistics.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartComplex)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Maintab;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pnlPassword;
        private PasswordPanel passwordPanel1;
        private System.Windows.Forms.Panel panelAddEmp;
        private AddEmployee addEmployee2;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbATMLog;
        private System.Windows.Forms.Button btnSelectLogFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAtmLogPath;
        private System.Windows.Forms.Panel panelMom;
        private System.Windows.Forms.Panel panelTBalance;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelTicketS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTicketsSold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelPVis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVisitors;
        private System.Windows.Forms.Label VisitCount;
        private System.Windows.Forms.Panel panelSpots;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblFreeSpots;
        private System.Windows.Forms.Label lblBookedSpots;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelTSpent;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTotalV;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalVisitors;
        private System.Windows.Forms.TabPage Statistics;
        private System.Windows.Forms.OpenFileDialog ofdATMLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComplex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMoney;
        private System.Windows.Forms.RadioButton rbCamping;
        private System.Windows.Forms.RadioButton rbArticle;
        private System.Windows.Forms.CheckBox cbReserve;
    }
}
