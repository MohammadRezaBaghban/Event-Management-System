﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.Remoting.Channels;
using System.Web.Hosting;

namespace HHF_APP
{
    public partial class Form1 : Form
    {   DataHelper dh=new DataHelper();
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();

            
            panel3.Visible = false;
            sidepanelforBTNs.Height = ticketsBtn.Height;
            sidepanelforBTNs.Top = ticketsBtn.Top;
            viewLogin1.BringToFront();

            viewCamping1.Enabled = true;
            viewLending1.Enabled = true;
            viewStore1.Enabled = false;
            viewCamping1.LoadAvailable();
         
            lblbal.Text = "......";
            lblname.Text = "......";
        }


      


        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.DarkRed;
        }


        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void viewCheckInOut1_Load(object sender, EventArgs e)
        {
        }

        private void viewTickets1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.sidepanelforBTNs = new System.Windows.Forms.Panel();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.lendBtn = new System.Windows.Forms.Button();
            this.campBtn = new System.Windows.Forms.Button();
            this.checkinBTn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.ticketsBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblbal = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnscanBarcodeMainForm = new System.Windows.Forms.Button();
            this.viewTickets1 = new HHF_APP.viewTickets();
            this.viewStore1 = new HHF_APP.viewStore();
            this.viewLending1 = new HHF_APP.viewLending();
            this.viewCheckInOut1 = new HHF_APP.viewCheckInOut();
            this.viewCamping1 = new HHF_APP.viewCamping();
            this.viewAdminDashboard1 = new HHF_APP.viewAdminDashboard();
            this.viewLogin1 = new HHF_APP.viewLogin();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(104)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 786);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(19, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(86, 110);
            this.panel6.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 102);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(149, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(104)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Controls.Add(this.sidepanelforBTNs);
            this.panel2.Controls.Add(this.AdminBtn);
            this.panel2.Controls.Add(this.lendBtn);
            this.panel2.Controls.Add(this.campBtn);
            this.panel2.Controls.Add(this.checkinBTn);
            this.panel2.Controls.Add(this.storeBtn);
            this.panel2.Controls.Add(this.ticketsBtn);
            this.panel2.Location = new System.Drawing.Point(3, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 677);
            this.panel2.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Black;
            this.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(73, 628);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(148, 46);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click_1);
            // 
            // sidepanelforBTNs
            // 
            this.sidepanelforBTNs.BackColor = System.Drawing.Color.Black;
            this.sidepanelforBTNs.Location = new System.Drawing.Point(3, 18);
            this.sidepanelforBTNs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidepanelforBTNs.Name = "sidepanelforBTNs";
            this.sidepanelforBTNs.Size = new System.Drawing.Size(10, 59);
            this.sidepanelforBTNs.TabIndex = 0;
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AdminBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AdminBtn.FlatAppearance.BorderSize = 0;
            this.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminBtn.Image")));
            this.AdminBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBtn.Location = new System.Drawing.Point(16, 2);
            this.AdminBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(289, 92);
            this.AdminBtn.TabIndex = 4;
            this.AdminBtn.Text = "              Admin Dashboard";
            this.AdminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click_1);
            // 
            // lendBtn
            // 
            this.lendBtn.BackColor = System.Drawing.Color.Transparent;
            this.lendBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lendBtn.FlatAppearance.BorderSize = 0;
            this.lendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendBtn.Image = ((System.Drawing.Image)(resources.GetObject("lendBtn.Image")));
            this.lendBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lendBtn.Location = new System.Drawing.Point(16, 473);
            this.lendBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lendBtn.Name = "lendBtn";
            this.lendBtn.Size = new System.Drawing.Size(289, 92);
            this.lendBtn.TabIndex = 3;
            this.lendBtn.Text = "              Material Lend";
            this.lendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lendBtn.UseVisualStyleBackColor = false;
            this.lendBtn.Click += new System.EventHandler(this.lendBtn_Click_1);
            // 
            // campBtn
            // 
            this.campBtn.BackColor = System.Drawing.Color.Transparent;
            this.campBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.campBtn.FlatAppearance.BorderSize = 0;
            this.campBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campBtn.Image = ((System.Drawing.Image)(resources.GetObject("campBtn.Image")));
            this.campBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campBtn.Location = new System.Drawing.Point(16, 379);
            this.campBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campBtn.Name = "campBtn";
            this.campBtn.Size = new System.Drawing.Size(295, 92);
            this.campBtn.TabIndex = 2;
            this.campBtn.Text = "              Camping Check                             in/out";
            this.campBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campBtn.UseVisualStyleBackColor = false;
            this.campBtn.Click += new System.EventHandler(this.campBtn_Click_1);
            // 
            // checkinBTn
            // 
            this.checkinBTn.BackColor = System.Drawing.Color.Transparent;
            this.checkinBTn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.checkinBTn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkinBTn.FlatAppearance.BorderSize = 0;
            this.checkinBTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinBTn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBTn.Image = ((System.Drawing.Image)(resources.GetObject("checkinBTn.Image")));
            this.checkinBTn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBTn.Location = new System.Drawing.Point(16, 191);
            this.checkinBTn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkinBTn.Name = "checkinBTn";
            this.checkinBTn.Size = new System.Drawing.Size(289, 92);
            this.checkinBTn.TabIndex = 1;
            this.checkinBTn.Text = "               Check in/out";
            this.checkinBTn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBTn.UseVisualStyleBackColor = false;
            this.checkinBTn.Click += new System.EventHandler(this.checkinBTn_Click);
            // 
            // storeBtn
            // 
            this.storeBtn.BackColor = System.Drawing.Color.Transparent;
            this.storeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.storeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.storeBtn.FlatAppearance.BorderSize = 0;
            this.storeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBtn.Image = ((System.Drawing.Image)(resources.GetObject("storeBtn.Image")));
            this.storeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storeBtn.Location = new System.Drawing.Point(16, 286);
            this.storeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(289, 92);
            this.storeBtn.TabIndex = 1;
            this.storeBtn.Text = "              Store";
            this.storeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storeBtn.UseVisualStyleBackColor = false;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // ticketsBtn
            // 
            this.ticketsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ticketsBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ticketsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ticketsBtn.FlatAppearance.BorderSize = 0;
            this.ticketsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBtn.Image")));
            this.ticketsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketsBtn.Location = new System.Drawing.Point(16, 97);
            this.ticketsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ticketsBtn.Name = "ticketsBtn";
            this.ticketsBtn.Size = new System.Drawing.Size(289, 92);
            this.ticketsBtn.TabIndex = 0;
            this.ticketsBtn.Text = "              Tickets";
            this.ticketsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketsBtn.UseVisualStyleBackColor = false;
            this.ticketsBtn.Click += new System.EventHandler(this.ticketsBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(936, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Size = new System.Drawing.Size(31, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chocolate;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(314, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 86);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.lblbal);
            this.panel3.Controls.Add(this.lblname);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbBarcode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnscanBarcodeMainForm);
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 48);
            this.panel3.TabIndex = 4;
            // 
            // lblbal
            // 
            this.lblbal.AutoSize = true;
            this.lblbal.Font = new System.Drawing.Font("Sitka Small", 9.8F, System.Drawing.FontStyle.Bold);
            this.lblbal.Location = new System.Drawing.Point(693, 9);
            this.lblbal.Name = "lblbal";
            this.lblbal.Size = new System.Drawing.Size(60, 25);
            this.lblbal.TabIndex = 7;
            this.lblbal.Text = "........";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Sitka Small", 9.8F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(426, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 25);
            this.lblname.TabIndex = 6;
            this.lblname.Text = ".........";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(278, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barcode:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(102, 12);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(170, 24);
            this.tbBarcode.TabIndex = 3;
            this.tbBarcode.KeyPress += new KeyPressEventHandler(enterClick);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // btnscanBarcodeMainForm
            // 
            this.btnscanBarcodeMainForm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnscanBarcodeMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnscanBarcodeMainForm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscanBarcodeMainForm.Location = new System.Drawing.Point(791, 2);
            this.btnscanBarcodeMainForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnscanBarcodeMainForm.Name = "btnscanBarcodeMainForm";
            this.btnscanBarcodeMainForm.Size = new System.Drawing.Size(174, 43);
            this.btnscanBarcodeMainForm.TabIndex = 0;
            this.btnscanBarcodeMainForm.Text = "Scan Barcode";
            this.btnscanBarcodeMainForm.UseVisualStyleBackColor = false;
            this.btnscanBarcodeMainForm.Click += new System.EventHandler(this.btnscanBarcodeMainForm_Click);
            // 
            // viewTickets1
            // 
            this.viewTickets1.BackColor = System.Drawing.Color.Linen;
            this.viewTickets1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewTickets1.Location = new System.Drawing.Point(318, 79);
            this.viewTickets1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewTickets1.Name = "viewTickets1";
            this.viewTickets1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.viewTickets1.Size = new System.Drawing.Size(964, 727);
            this.viewTickets1.TabIndex = 8;
            // 
            // viewStore1
            // 
            this.viewStore1.BackColor = System.Drawing.Color.Linen;
            this.viewStore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewStore1.Location = new System.Drawing.Point(314, 78);
            this.viewStore1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewStore1.Name = "viewStore1";
            this.viewStore1.Size = new System.Drawing.Size(973, 702);
            this.viewStore1.TabIndex = 7;
            // 
            // viewLending1
            // 
            this.viewLending1.BackColor = System.Drawing.Color.Linen;
            this.viewLending1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewLending1.Location = new System.Drawing.Point(314, 78);
            this.viewLending1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewLending1.Name = "viewLending1";
            this.viewLending1.Size = new System.Drawing.Size(965, 702);
            this.viewLending1.TabIndex = 6;
            // 
            // viewCheckInOut1
            // 
            this.viewCheckInOut1.BackColor = System.Drawing.Color.Linen;
            this.viewCheckInOut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewCheckInOut1.Location = new System.Drawing.Point(314, 78);
            this.viewCheckInOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCheckInOut1.Name = "viewCheckInOut1";
            this.viewCheckInOut1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.viewCheckInOut1.Size = new System.Drawing.Size(973, 702);
            this.viewCheckInOut1.TabIndex = 5;
            // 
            // viewCamping1
            // 
            this.viewCamping1.BackColor = System.Drawing.Color.Linen;
            this.viewCamping1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewCamping1.Location = new System.Drawing.Point(314, 85);
            this.viewCamping1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCamping1.Name = "viewCamping1";
            this.viewCamping1.Size = new System.Drawing.Size(973, 702);
            this.viewCamping1.TabIndex = 4;
            // 
            // viewAdminDashboard1
            // 
            this.viewAdminDashboard1.BackColor = System.Drawing.Color.Linen;
            this.viewAdminDashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewAdminDashboard1.Location = new System.Drawing.Point(314, 85);
            this.viewAdminDashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAdminDashboard1.Name = "viewAdminDashboard1";
            this.viewAdminDashboard1.Padding = new System.Windows.Forms.Padding(5);
            this.viewAdminDashboard1.Size = new System.Drawing.Size(968, 702);
            this.viewAdminDashboard1.TabIndex = 3;
            // 
            // viewLogin1
            // 
            this.viewLogin1.Location = new System.Drawing.Point(0, 0);
            this.viewLogin1.Margin = new System.Windows.Forms.Padding(2);
            this.viewLogin1.Name = "viewLogin1";
            this.viewLogin1.Size = new System.Drawing.Size(1282, 806);
            this.viewLogin1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1282, 786);
            this.Controls.Add(this.viewTickets1);
            this.Controls.Add(this.viewStore1);
            this.Controls.Add(this.viewLending1);
            this.Controls.Add(this.viewCheckInOut1);
            this.Controls.Add(this.viewCamping1);
            this.Controls.Add(this.viewAdminDashboard1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewLogin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

       

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            viewLogin1.BringToFront();
        }

        
        private void btnscanBarcodeMainForm_Click(object sender, EventArgs e)
        {
            this.tbBarcode.Clear();
            tbBarcode.Focus();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AdminBtn_Click_1(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = AdminBtn.Height;
            sidepanelforBTNs.Top = AdminBtn.Top;
            viewAdminDashboard1.btnRefresh_Click(sender,e);
            panel3.Visible = false;
            viewAdminDashboard1.BringToFront();
        }

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = ticketsBtn.Height;
            sidepanelforBTNs.Top = ticketsBtn.Top;
            panel3.Visible = false;
            viewTickets1.BringToFront();
        }

        private void checkinBTn_Click(object sender, EventArgs e)
        {
            
            sidepanelforBTNs.Height = checkinBTn.Height;
            sidepanelforBTNs.Top = checkinBTn.Top;
            panel3.Visible = false;
            viewCheckInOut1.BringToFront();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = storeBtn.Height;
            sidepanelforBTNs.Top = storeBtn.Top;
            
            panel3.Visible = true;
            viewStore1.BringToFront();
        }

        private void campBtn_Click_1(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = campBtn.Height;
            sidepanelforBTNs.Top = campBtn.Top;
            panel3.Visible = true;
            viewCamping1.BringToFront();
            
        }

        private void lendBtn_Click_1(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = lendBtn.Height;
            sidepanelforBTNs.Top = lendBtn.Top;
            panel3.Visible = true;
            
            viewLending1.BringToFront();
        }

        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            viewLogin1.BringToFront();
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                viewLending1.accountFound = false;
                
                Person p = dh.checkTicket(Convert.ToInt32(tbBarcode.Text));
                if (p != null)
                {
                    int input = p.getActId;
                    viewLending1.Enabled = true;
                    viewStore1.Enabled = true;
                    viewCamping1.Enabled = true;
                    lblbal.Text = p.getBalance.ToString();
                    lblname.Text = p.getName;
                    if (sidepanelforBTNs.Top == storeBtn.Top)
                    {

                        if (p.getTicketvalidity!="VALID" && p.getBalance <= 0)
                        {
                            viewStore1.Enabled = false;
                            MessageBox.Show("OPss, this account is either Invalid or has no sufficent balance to create a transaction");
                        }
                    }

                    if (sidepanelforBTNs.Top == campBtn.Top)
                    {
                        viewCamping1.userId = p.getUserId;
                        
                            foreach (DataGridViewRow r in viewCamping1.DG_ReservedSpots.Rows)
                            {
                                r.Selected = false;

                            }

                            if (!dh.CheckCampReservation(p.getActId))
                            {
                                MessageBox.Show($"There is no reserved camping spot for this account!");

                            }
                            else
                            {
                                foreach (DataGridViewRow r in viewCamping1.DG_ReservedSpots.Rows)
                                {
                                    if (r.Cells[0].Value.ToString() == p.getActId.ToString())
                                    {
                                        r.Selected = true;
                                    }
                                }

                                viewCamping1.SelectionChecking();
                            }
                        
                       
                    }else if (sidepanelforBTNs.Top == lendBtn.Top)
                    {
                        if (dh.CheckInStatus(p.getActId))
                        {
                            viewLending1.accountFound = true;
                            viewLending1.userId = p.getUserId;
                            viewLending1.accountId = input;
                            viewLending1.btnLendItem.Enabled = true;
                            bool hasRecord = false;
                            int index = -1;
                            viewLending1.DG_LoanedArticels.Sort(viewLending1.DG_LoanedArticels.Columns[1], ListSortDirection.Ascending);

                            foreach (DataGridViewRow r in viewLending1.DG_LoanedArticels.Rows)
                            {
                                if (r.Cells[1].Value.ToString() == input.ToString() && !hasRecord)
                                {
                                    hasRecord = true;
                                    r.Selected = true;
                                    index = r.Index;
                                    continue;
                                }
                                r.Selected = false;

                            }

                            if (!hasRecord)
                            {
                                MessageBox.Show($"There is no lending record for this account.", "Notification");
                            }

                        }
                        else
                        {
                            viewLending1.btnLendItem.Enabled = false;
                        }
                    }
                    
                    
                }
                else
                {
                    viewStore1.Enabled = false;
                    lblbal.Text = "......";
                    lblname.Text = "......";
                    MessageBox.Show($"A Person with given user id of {tbBarcode.Text} does not exist");                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void enterClick(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
        }
    }
}