using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace HHF_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanelforBTNs.Height = AdminBtn.Height;
            sidepanelforBTNs.Top = AdminBtn.Top;
           viewAdminDashboard1.BringToFront();
            //SoundPlayer my_sound = new SoundPlayer("F:/xxxxxx.wave"); //put your own .4wave file path
            //my_sound.Play();
            //my_sound.Stop();
            Spire.Barcode.BarcodeSettings barsetting = new Spire.Barcode.BarcodeSettings();

            //set the x dimension
            barsetting.X = 0.8f;
            barsetting.Unit = GraphicsUnit.Millimeter;

            barsetting.HasBorder = true;
            barsetting.BorderWidth = 0.5F;

            //set the data
            barsetting.Data = "58465157484";
            barsetting.Data2D = "58465157484";

            //generate UPCA barcode
            barsetting.Type = Spire.Barcode.BarCodeType.UPCA;

            Spire.Barcode.BarCodeGenerator bargenerator = new Spire.Barcode.BarCodeGenerator(barsetting);
            Image barcodeimage = bargenerator.GenerateImage();
            barcodeimage.Save("barcode.png");

            System.Diagnostics.Process.Start("barcode.png");

        }

      

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = ticketsBtn.Height;
            sidepanelforBTNs.Top = ticketsBtn.Top;
            viewTickets1.BringToFront();
            panel3.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = checkinBTn.Height;
            sidepanelforBTNs.Top = checkinBTn.Top;
            panel3.Visible = false;
             viewCheckInOut1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = storeBtn.Height;
            sidepanelforBTNs.Top = storeBtn.Top;
            panel3.Visible = true;
             viewStore1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = campBtn.Height;
            sidepanelforBTNs.Top = campBtn.Top;
            panel3.Visible = true;
             viewCamping1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = lendBtn.Height;
            sidepanelforBTNs.Top = lendBtn.Top;
            panel3.Visible = true;
              viewLending1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = AdminBtn.Height;
            sidepanelforBTNs.Top = AdminBtn.Top;
          viewAdminDashboard1.BringToFront();
            panel3.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.viewAdminDashboard1 = new HHF_APP.viewAdminDashboard();
            this.viewCamping1 = new HHF_APP.viewCamping();
            this.viewCheckInOut1 = new HHF_APP.viewCheckInOut();
            this.viewLending1 = new HHF_APP.viewLending();
            this.viewStore1 = new HHF_APP.viewStore();
            this.viewTickets1 = new HHF_APP.viewTickets();
            this.barCodeControl1 = new Spire.Barcode.Forms.BarCodeControl();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 787);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(19, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(86, 110);
            this.panel6.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
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
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
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
            this.panel2.Controls.Add(this.barCodeControl1);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Controls.Add(this.sidepanelforBTNs);
            this.panel2.Controls.Add(this.AdminBtn);
            this.panel2.Controls.Add(this.lendBtn);
            this.panel2.Controls.Add(this.campBtn);
            this.panel2.Controls.Add(this.checkinBTn);
            this.panel2.Controls.Add(this.storeBtn);
            this.panel2.Controls.Add(this.ticketsBtn);
            this.panel2.Location = new System.Drawing.Point(3, 107);
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
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(148, 46);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // sidepanelforBTNs
            // 
            this.sidepanelforBTNs.BackColor = System.Drawing.Color.Black;
            this.sidepanelforBTNs.Location = new System.Drawing.Point(3, 18);
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
            this.AdminBtn.Location = new System.Drawing.Point(16, 3);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(289, 92);
            this.AdminBtn.TabIndex = 4;
            this.AdminBtn.Text = "              Admin Dashboard";
            this.AdminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.button4_Click);
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
            this.lendBtn.Name = "lendBtn";
            this.lendBtn.Size = new System.Drawing.Size(289, 92);
            this.lendBtn.TabIndex = 3;
            this.lendBtn.Text = "              Material Lend";
            this.lendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lendBtn.UseVisualStyleBackColor = false;
            this.lendBtn.Click += new System.EventHandler(this.button5_Click);
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
            this.campBtn.Name = "campBtn";
            this.campBtn.Size = new System.Drawing.Size(295, 92);
            this.campBtn.TabIndex = 2;
            this.campBtn.Text = "              Camping Check                             in/out";
            this.campBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campBtn.UseVisualStyleBackColor = false;
            this.campBtn.Click += new System.EventHandler(this.button6_Click);
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
            this.checkinBTn.Name = "checkinBTn";
            this.checkinBTn.Size = new System.Drawing.Size(289, 92);
            this.checkinBTn.TabIndex = 1;
            this.checkinBTn.Text = "               Check in/out";
            this.checkinBTn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBTn.UseVisualStyleBackColor = false;
            this.checkinBTn.Click += new System.EventHandler(this.button3_Click);
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
            this.storeBtn.Location = new System.Drawing.Point(16, 285);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(289, 92);
            this.storeBtn.TabIndex = 1;
            this.storeBtn.Text = "              Store";
            this.storeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storeBtn.UseVisualStyleBackColor = false;
            this.storeBtn.Click += new System.EventHandler(this.button2_Click);
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
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox3.Size = new System.Drawing.Size(32, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chocolate;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(314, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 86);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbBarcode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 48);
            this.panel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Myriad Hebrew", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(292, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ticket ID:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(117, 13);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(170, 24);
            this.tbBarcode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(602, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(791, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scan Barcode";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // viewAdminDashboard1
            // 
            this.viewAdminDashboard1.BackColor = System.Drawing.Color.Linen;
            this.viewAdminDashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewAdminDashboard1.Location = new System.Drawing.Point(314, 85);
            this.viewAdminDashboard1.Name = "viewAdminDashboard1";
            this.viewAdminDashboard1.Padding = new System.Windows.Forms.Padding(5);
            this.viewAdminDashboard1.Size = new System.Drawing.Size(968, 702);
            this.viewAdminDashboard1.TabIndex = 3;
            // 
            // viewCamping1
            // 
            this.viewCamping1.BackColor = System.Drawing.Color.Linen;
            this.viewCamping1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewCamping1.Location = new System.Drawing.Point(314, 85);
            this.viewCamping1.Name = "viewCamping1";
            this.viewCamping1.Size = new System.Drawing.Size(973, 702);
            this.viewCamping1.TabIndex = 4;
            // 
            // viewCheckInOut1
            // 
            this.viewCheckInOut1.BackColor = System.Drawing.Color.Linen;
            this.viewCheckInOut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewCheckInOut1.Location = new System.Drawing.Point(314, 77);
            this.viewCheckInOut1.Name = "viewCheckInOut1";
            this.viewCheckInOut1.Padding = new System.Windows.Forms.Padding(5);
            this.viewCheckInOut1.Size = new System.Drawing.Size(973, 702);
            this.viewCheckInOut1.TabIndex = 5;
            // 
            // viewLending1
            // 
            this.viewLending1.BackColor = System.Drawing.Color.Linen;
            this.viewLending1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewLending1.Location = new System.Drawing.Point(314, 77);
            this.viewLending1.Name = "viewLending1";
            this.viewLending1.Size = new System.Drawing.Size(965, 701);
            this.viewLending1.TabIndex = 6;
            // 
            // viewStore1
            // 
            this.viewStore1.BackColor = System.Drawing.Color.Linen;
            this.viewStore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewStore1.Location = new System.Drawing.Point(314, 77);
            this.viewStore1.Name = "viewStore1";
            this.viewStore1.Size = new System.Drawing.Size(973, 702);
            this.viewStore1.TabIndex = 7;
            // 
            // viewTickets1
            // 
            this.viewTickets1.BackColor = System.Drawing.Color.Linen;
            this.viewTickets1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewTickets1.Location = new System.Drawing.Point(317, 79);
            this.viewTickets1.Name = "viewTickets1";
            this.viewTickets1.Padding = new System.Windows.Forms.Padding(5);
            this.viewTickets1.Size = new System.Drawing.Size(964, 727);
            this.viewTickets1.TabIndex = 8;
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.BarHeight = 20F;
            this.barCodeControl1.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.barCodeControl1.BorderWidth = 0.9F;
            this.barCodeControl1.Data = "005";
            this.barCodeControl1.Data2D = "005";
            this.barCodeControl1.DpiX = 96F;
            this.barCodeControl1.DpiY = 96F;
            this.barCodeControl1.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCodeControl1.ImageHeight = 30F;
            this.barCodeControl1.ImageWidth = 120F;
            this.barCodeControl1.LeftMargin = 10F;
            this.barCodeControl1.Location = new System.Drawing.Point(20, 84);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.RightMargin = 20F;
            this.barCodeControl1.Rotate = 0F;
            this.barCodeControl1.ShowTextOnBottom = true;
            this.barCodeControl1.ShowTopText = true;
            this.barCodeControl1.Size = new System.Drawing.Size(271, 125);
            this.barCodeControl1.SupSpace = 4F;
            this.barCodeControl1.TabIndex = 9;
            this.barCodeControl1.TextFont = new System.Drawing.Font("Arial", 8F);
            this.barCodeControl1.TopText = "Spire.BarCode Evaluation Version";
            this.barCodeControl1.TopTextFont = new System.Drawing.Font("Times New Roman", 9F);
            this.barCodeControl1.Type = ((Spire.Barcode.BarCodeType)((Spire.Barcode.BarCodeType.Interleaved25 | Spire.Barcode.BarCodeType.Code93Extended)));
            this.barCodeControl1.UseChecksum = Spire.Barcode.CheckSumMode.Auto;
            this.barCodeControl1.WideNarrowRatio = 3F;
            this.barCodeControl1.XYRatio = 0F;
            this.barCodeControl1.Y = 2F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1282, 787);
            this.Controls.Add(this.viewTickets1);
            this.Controls.Add(this.viewStore1);
            this.Controls.Add(this.viewLending1);
            this.Controls.Add(this.viewCheckInOut1);
            this.Controls.Add(this.viewCamping1);
            this.Controls.Add(this.viewAdminDashboard1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

