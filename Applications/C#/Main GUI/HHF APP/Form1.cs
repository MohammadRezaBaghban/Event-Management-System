using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HHF_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanelforBTNs.Height = AdminBtn.Height;
            sidepanelforBTNs.Top = AdminBtn.Top;
            viewLogin1.SendToBack();
            //SoundPlayer my_sound = new SoundPlayer("F:/xxxxxx.wave"); //put your own .4wave file path
            //my_sound.Play();
            //my_sound.Stop();
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
            Close();
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
            var resources =
                new ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            LogoutBtn = new Button();
            sidepanelforBTNs = new Panel();
            AdminBtn = new Button();
            lendBtn = new Button();
            campBtn = new Button();
            checkinBTn = new Button();
            storeBtn = new Button();
            ticketsBtn = new Button();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            label4 = new Label();
            tbBarcode = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            viewTickets1 = new viewTickets();
            viewStore1 = new viewStore();
            viewLending1 = new viewLending();
            viewCheckInOut1 = new viewCheckInOut();
            viewCamping1 = new viewCamping();
            viewAdminDashboard1 = new viewAdminDashboard();
            viewLogin1 = new viewLogin();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((ISupportInitialize) pictureBox1).BeginInit();
            ((ISupportInitialize) pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((ISupportInitialize) pictureBox3).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 104,
                28);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 786);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(19, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(86, 110);
            panel6.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage =
                (Image) resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 102);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
            pictureBox2.Image = (Image) resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(260, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.Location = new Point(149, 74);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 2;
            label1.Text = "USER NAME";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 104,
                28);
            panel2.Controls.Add(LogoutBtn);
            panel2.Controls.Add(sidepanelforBTNs);
            panel2.Controls.Add(AdminBtn);
            panel2.Controls.Add(lendBtn);
            panel2.Controls.Add(campBtn);
            panel2.Controls.Add(checkinBTn);
            panel2.Controls.Add(storeBtn);
            panel2.Controls.Add(ticketsBtn);
            panel2.Location = new Point(3, 107);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 677);
            panel2.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Black;
            LogoutBtn.BackgroundImageLayout = ImageLayout.Zoom;
            LogoutBtn.FlatAppearance.BorderColor = Color.White;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Century Gothic", 13.2F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Image = (Image) resources.GetObject("LogoutBtn.Image");
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(73, 628);
            LogoutBtn.Margin = new Padding(3, 2, 3, 2);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(148, 46);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.Text = "Log out";
            LogoutBtn.TextAlign = ContentAlignment.MiddleRight;
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // sidepanelforBTNs
            // 
            sidepanelforBTNs.BackColor = Color.Black;
            sidepanelforBTNs.Location = new Point(3, 18);
            sidepanelforBTNs.Margin = new Padding(3, 2, 3, 2);
            sidepanelforBTNs.Name = "sidepanelforBTNs";
            sidepanelforBTNs.Size = new Size(10, 59);
            sidepanelforBTNs.TabIndex = 0;
            // 
            // AdminBtn
            // 
            AdminBtn.BackColor = Color.Transparent;
            AdminBtn.DialogResult = DialogResult.Cancel;
            AdminBtn.FlatAppearance.BorderColor = Color.White;
            AdminBtn.FlatAppearance.BorderSize = 0;
            AdminBtn.FlatStyle = FlatStyle.Flat;
            AdminBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            AdminBtn.Image = (Image) resources.GetObject("AdminBtn.Image");
            AdminBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AdminBtn.Location = new Point(16, 2);
            AdminBtn.Margin = new Padding(3, 2, 3, 2);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(289, 92);
            AdminBtn.TabIndex = 4;
            AdminBtn.Text = "              Admin Dashboard";
            AdminBtn.TextAlign = ContentAlignment.MiddleLeft;
            AdminBtn.UseVisualStyleBackColor = false;
            AdminBtn.Click += button4_Click;
            // 
            // lendBtn
            // 
            lendBtn.BackColor = Color.Transparent;
            lendBtn.FlatAppearance.BorderColor = Color.White;
            lendBtn.FlatAppearance.BorderSize = 0;
            lendBtn.FlatStyle = FlatStyle.Flat;
            lendBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            lendBtn.Image = (Image) resources.GetObject("lendBtn.Image");
            lendBtn.ImageAlign = ContentAlignment.MiddleLeft;
            lendBtn.Location = new Point(16, 473);
            lendBtn.Margin = new Padding(3, 2, 3, 2);
            lendBtn.Name = "lendBtn";
            lendBtn.Size = new Size(289, 92);
            lendBtn.TabIndex = 3;
            lendBtn.Text = "              Material Lend";
            lendBtn.TextAlign = ContentAlignment.MiddleLeft;
            lendBtn.UseVisualStyleBackColor = false;
            lendBtn.Click += button5_Click;
            // 
            // campBtn
            // 
            campBtn.BackColor = Color.Transparent;
            campBtn.FlatAppearance.BorderColor = Color.White;
            campBtn.FlatAppearance.BorderSize = 0;
            campBtn.FlatStyle = FlatStyle.Flat;
            campBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            campBtn.Image = (Image) resources.GetObject("campBtn.Image");
            campBtn.ImageAlign = ContentAlignment.MiddleLeft;
            campBtn.Location = new Point(16, 379);
            campBtn.Margin = new Padding(3, 2, 3, 2);
            campBtn.Name = "campBtn";
            campBtn.Size = new Size(295, 92);
            campBtn.TabIndex = 2;
            campBtn.Text = "              Camping Check                             in/out";
            campBtn.TextAlign = ContentAlignment.MiddleLeft;
            campBtn.UseVisualStyleBackColor = false;
            campBtn.Click += button6_Click;
            // 
            // checkinBTn
            // 
            checkinBTn.BackColor = Color.Transparent;
            checkinBTn.DialogResult = DialogResult.Cancel;
            checkinBTn.FlatAppearance.BorderColor = Color.White;
            checkinBTn.FlatAppearance.BorderSize = 0;
            checkinBTn.FlatStyle = FlatStyle.Flat;
            checkinBTn.Font = new Font("Century Gothic", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            checkinBTn.Image = (Image) resources.GetObject("checkinBTn.Image");
            checkinBTn.ImageAlign = ContentAlignment.MiddleLeft;
            checkinBTn.Location = new Point(16, 191);
            checkinBTn.Margin = new Padding(3, 2, 3, 2);
            checkinBTn.Name = "checkinBTn";
            checkinBTn.Size = new Size(289, 92);
            checkinBTn.TabIndex = 1;
            checkinBTn.Text = "               Check in/out";
            checkinBTn.TextAlign = ContentAlignment.MiddleLeft;
            checkinBTn.UseVisualStyleBackColor = false;
            checkinBTn.Click += button3_Click;
            // 
            // storeBtn
            // 
            storeBtn.BackColor = Color.Transparent;
            storeBtn.DialogResult = DialogResult.Cancel;
            storeBtn.FlatAppearance.BorderColor = Color.White;
            storeBtn.FlatAppearance.BorderSize = 0;
            storeBtn.FlatStyle = FlatStyle.Flat;
            storeBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            storeBtn.Image = (Image) resources.GetObject("storeBtn.Image");
            storeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            storeBtn.Location = new Point(16, 286);
            storeBtn.Margin = new Padding(3, 2, 3, 2);
            storeBtn.Name = "storeBtn";
            storeBtn.Size = new Size(289, 92);
            storeBtn.TabIndex = 1;
            storeBtn.Text = "              Store";
            storeBtn.TextAlign = ContentAlignment.MiddleLeft;
            storeBtn.UseVisualStyleBackColor = false;
            storeBtn.Click += button2_Click;
            // 
            // ticketsBtn
            // 
            ticketsBtn.BackColor = Color.Transparent;
            ticketsBtn.DialogResult = DialogResult.Cancel;
            ticketsBtn.FlatAppearance.BorderColor = Color.Black;
            ticketsBtn.FlatAppearance.BorderSize = 0;
            ticketsBtn.FlatStyle = FlatStyle.Flat;
            ticketsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            ticketsBtn.Image = (Image) resources.GetObject("ticketsBtn.Image");
            ticketsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ticketsBtn.Location = new Point(16, 97);
            ticketsBtn.Margin = new Padding(0, 0, 0, 2);
            ticketsBtn.Name = "ticketsBtn";
            ticketsBtn.Size = new Size(289, 92);
            ticketsBtn.TabIndex = 0;
            ticketsBtn.Text = "              Tickets";
            ticketsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ticketsBtn.UseVisualStyleBackColor = false;
            ticketsBtn.Click += ticketsBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image) resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(936, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(3, 2, 3, 2);
            pictureBox3.Size = new Size(31, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Chocolate;
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(314, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(968, 86);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224,
                224);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbBarcode);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 31);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 48);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255,
                192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Myriad Hebrew", 7.8F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            button2.Location = new Point(292, 14);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(71, 25);
            button2.TabIndex = 5;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 9);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 4;
            label4.Text = "Ticket ID:";
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(117, 14);
            tbBarcode.Margin = new Padding(3, 2, 3, 2);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(170, 24);
            tbBarcode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            label3.Location = new Point(602, 9);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 2;
            label3.Text = "Balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            label2.Location = new Point(377, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold,
                GraphicsUnit.Point, 0);
            button1.Location = new Point(791, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(174, 43);
            button1.TabIndex = 0;
            button1.Text = "Scan Barcode";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // viewTickets1
            // 
            viewTickets1.BackColor = Color.Linen;
            viewTickets1.BackgroundImageLayout = ImageLayout.Zoom;
            viewTickets1.Location = new Point(318, 79);
            viewTickets1.Margin = new Padding(3, 2, 3, 2);
            viewTickets1.Name = "viewTickets1";
            viewTickets1.Padding = new Padding(5, 5, 5, 5);
            viewTickets1.Size = new Size(964, 727);
            viewTickets1.TabIndex = 8;
            // 
            // viewStore1
            // 
            viewStore1.BackColor = Color.Linen;
            viewStore1.BackgroundImageLayout = ImageLayout.Zoom;
            viewStore1.Location = new Point(314, 78);
            viewStore1.Margin = new Padding(3, 2, 3, 2);
            viewStore1.Name = "viewStore1";
            viewStore1.Size = new Size(973, 702);
            viewStore1.TabIndex = 7;
            // 
            // viewLending1
            // 
            viewLending1.BackColor = Color.Linen;
            viewLending1.BackgroundImageLayout = ImageLayout.Zoom;
            viewLending1.Location = new Point(314, 78);
            viewLending1.Margin = new Padding(3, 2, 3, 2);
            viewLending1.Name = "viewLending1";
            viewLending1.Size = new Size(965, 702);
            viewLending1.TabIndex = 6;
            // 
            // viewCheckInOut1
            // 
            viewCheckInOut1.BackColor = Color.Linen;
            viewCheckInOut1.BackgroundImageLayout = ImageLayout.Zoom;
            viewCheckInOut1.Location = new Point(314, 78);
            viewCheckInOut1.Margin = new Padding(3, 2, 3, 2);
            viewCheckInOut1.Name = "viewCheckInOut1";
            viewCheckInOut1.Padding = new Padding(5);
            viewCheckInOut1.Size = new Size(973, 702);
            viewCheckInOut1.TabIndex = 5;
            // 
            // viewCamping1
            // 
            viewCamping1.BackColor = Color.Linen;
            viewCamping1.BackgroundImageLayout = ImageLayout.Zoom;
            viewCamping1.Location = new Point(314, 85);
            viewCamping1.Margin = new Padding(3, 2, 3, 2);
            viewCamping1.Name = "viewCamping1";
            viewCamping1.Size = new Size(973, 702);
            viewCamping1.TabIndex = 4;
            // 
            // viewAdminDashboard1
            // 
            viewAdminDashboard1.BackColor = Color.Linen;
            viewAdminDashboard1.BackgroundImageLayout = ImageLayout.Zoom;
            viewAdminDashboard1.Location = new Point(314, 85);
            viewAdminDashboard1.Margin = new Padding(3, 2, 3, 2);
            viewAdminDashboard1.Name = "viewAdminDashboard1";
            viewAdminDashboard1.Padding = new Padding(5, 5, 5, 5);
            viewAdminDashboard1.Size = new Size(968, 702);
            viewAdminDashboard1.TabIndex = 3;
            // 
            // viewLogin1
            // 
            viewLogin1.Location = new Point(0, 0);
            viewLogin1.Margin = new Padding(2);
            viewLogin1.Name = "viewLogin1";
            viewLogin1.Size = new Size(1282, 806);
            viewLogin1.TabIndex = 4;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1282, 786);
            Controls.Add(viewTickets1);
            Controls.Add(viewStore1);
            Controls.Add(viewLending1);
            Controls.Add(viewCheckInOut1);
            Controls.Add(viewCamping1);
            Controls.Add(viewAdminDashboard1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(viewLogin1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon) resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "4";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            ((ISupportInitialize) pictureBox1).EndInit();
            ((ISupportInitialize) pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((ISupportInitialize) pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            viewLogin1.BringToFront();
        }
    }
}