﻿namespace HHF_APP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.sidepanelforBTNs = new System.Windows.Forms.Panel();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.lendBtn = new System.Windows.Forms.Button();
            this.campBtn = new System.Windows.Forms.Button();
            this.checkinBTn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.ticketsBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.viewLending1 = new HHF_APP.viewLending();
            this.viewStore1 = new HHF_APP.viewStore();
            this.viewCamping1 = new HHF_APP.viewCamping();
            this.viewAdminDashboard1 = new HHF_APP.viewAdminDashboard();
            this.viewTickets1 = new HHF_APP.viewTickets();
            this.viewCheckInOut1 = new HHF_APP.viewCheckInOut();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(104)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 787);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(99, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER NAME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(314, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 787);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(939, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox3.Size = new System.Drawing.Size(26, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.panel5.Controls.Add(this.viewLending1);
            this.panel5.Controls.Add(this.viewStore1);
            this.panel5.Controls.Add(this.viewCamping1);
            this.panel5.Controls.Add(this.viewAdminDashboard1);
            this.panel5.Controls.Add(this.viewTickets1);
            this.panel5.Controls.Add(this.viewCheckInOut1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(968, 753);
            this.panel5.TabIndex = 0;
            // 
            // viewLending1
            // 
            this.viewLending1.BackColor = System.Drawing.Color.Linen;
            this.viewLending1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewLending1.BackgroundImage")));
            this.viewLending1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewLending1.Location = new System.Drawing.Point(0, 0);
            this.viewLending1.Name = "viewLending1";
            this.viewLending1.Size = new System.Drawing.Size(968, 753);
            this.viewLending1.TabIndex = 5;
            // 
            // viewStore1
            // 
            this.viewStore1.BackColor = System.Drawing.Color.Linen;
            this.viewStore1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewStore1.BackgroundImage")));
            this.viewStore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewStore1.Location = new System.Drawing.Point(0, 0);
            this.viewStore1.Name = "viewStore1";
            this.viewStore1.Size = new System.Drawing.Size(968, 753);
            this.viewStore1.TabIndex = 4;
            // 
            // viewCamping1
            // 
            this.viewCamping1.BackColor = System.Drawing.Color.Linen;
            this.viewCamping1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewCamping1.BackgroundImage")));
            this.viewCamping1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewCamping1.Location = new System.Drawing.Point(0, 0);
            this.viewCamping1.Name = "viewCamping1";
            this.viewCamping1.Size = new System.Drawing.Size(968, 753);
            this.viewCamping1.TabIndex = 3;
            // 
            // viewAdminDashboard1
            // 
            this.viewAdminDashboard1.BackColor = System.Drawing.Color.Linen;
            this.viewAdminDashboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewAdminDashboard1.BackgroundImage")));
            this.viewAdminDashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewAdminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.viewAdminDashboard1.Name = "viewAdminDashboard1";
            this.viewAdminDashboard1.Padding = new System.Windows.Forms.Padding(5);
            this.viewAdminDashboard1.Size = new System.Drawing.Size(968, 753);
            this.viewAdminDashboard1.TabIndex = 2;
            // 
            // viewTickets1
            // 
            this.viewTickets1.BackColor = System.Drawing.Color.Linen;
            this.viewTickets1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewTickets1.BackgroundImage")));
            this.viewTickets1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewTickets1.Location = new System.Drawing.Point(0, 0);
            this.viewTickets1.Name = "viewTickets1";
            this.viewTickets1.Padding = new System.Windows.Forms.Padding(5);
            this.viewTickets1.Size = new System.Drawing.Size(965, 753);
            this.viewTickets1.TabIndex = 1;
            this.viewTickets1.Load += new System.EventHandler(this.viewTickets1_Load);
            // 
            // viewCheckInOut1
            // 
            this.viewCheckInOut1.BackColor = System.Drawing.Color.Linen;
            this.viewCheckInOut1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewCheckInOut1.BackgroundImage")));
            this.viewCheckInOut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewCheckInOut1.Location = new System.Drawing.Point(0, 0);
            this.viewCheckInOut1.Name = "viewCheckInOut1";
            this.viewCheckInOut1.Padding = new System.Windows.Forms.Padding(5);
            this.viewCheckInOut1.Size = new System.Drawing.Size(968, 753);
            this.viewCheckInOut1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 787);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Button lendBtn;
        private System.Windows.Forms.Button campBtn;
        private System.Windows.Forms.Button checkinBTn;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Button ticketsBtn;
        private System.Windows.Forms.Panel sidepanelforBTNs;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private viewCheckInOut viewCheckInOut1;
        private viewTickets viewTickets1;
        private viewAdminDashboard viewAdminDashboard1;
        private viewLending viewLending1;
        private viewStore viewStore1;
        private viewCamping viewCamping1;
    }
}
