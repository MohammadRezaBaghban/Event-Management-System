namespace HHF_APP
{
    partial class viewCheckInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCheckInOut));
            this.inputRFID = new System.Windows.Forms.TextBox();
            this.btnRDIF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.visitcountnr = new System.Windows.Forms.Label();
            this.VisitCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputRFID
            // 
            this.inputRFID.Location = new System.Drawing.Point(16, 44);
            this.inputRFID.Name = "inputRFID";
            this.inputRFID.Size = new System.Drawing.Size(551, 24);
            this.inputRFID.TabIndex = 2;
            this.inputRFID.Text = "Scan RFID";
            this.inputRFID.TextChanged += new System.EventHandler(this.inputRFID_TextChanged);
            // 
            // btnRDIF
            // 
            this.btnRDIF.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRDIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDIF.Location = new System.Drawing.Point(16, 74);
            this.btnRDIF.Name = "btnRDIF";
            this.btnRDIF.Size = new System.Drawing.Size(551, 66);
            this.btnRDIF.TabIndex = 1;
            this.btnRDIF.Text = "Scan RFID";
            this.btnRDIF.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnCheckin);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnRDIF);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.inputRFID);
            this.panel1.Location = new System.Drawing.Point(342, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 720);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(16, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 140);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.GreenYellow;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(17, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 65);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.visitcountnr);
            this.panel4.Controls.Add(this.VisitCount);
            this.panel4.Location = new System.Drawing.Point(2, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 87);
            this.panel4.TabIndex = 0;
            // 
            // visitcountnr
            // 
            this.visitcountnr.AutoSize = true;
            this.visitcountnr.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitcountnr.Location = new System.Drawing.Point(154, 54);
            this.visitcountnr.Name = "visitcountnr";
            this.visitcountnr.Size = new System.Drawing.Size(85, 24);
            this.visitcountnr.TabIndex = 1;
            this.visitcountnr.Text = "00000";
            // 
            // VisitCount
            // 
            this.VisitCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitCount.AutoSize = true;
            this.VisitCount.Font = new System.Drawing.Font("Hobo Std", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitCount.Location = new System.Drawing.Point(101, 8);
            this.VisitCount.Name = "VisitCount";
            this.VisitCount.Size = new System.Drawing.Size(73, 24);
            this.VisitCount.TabIndex = 0;
            this.VisitCount.Text = "Balance";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(305, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 140);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(17, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(65, 65);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(2, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 87);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "xxxxx";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ticket Type";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(8, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(304, 273);
            this.panel8.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIcket ID : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 24);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIcket Holder : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "XXXXXXXXXXXX";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(55, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 79);
            this.button2.TabIndex = 5;
            this.button2.Text = "Asign RFID";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "New Visitors";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Returning Visitors";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.LightGray;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Charlemagne Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(18, 292);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(543, 102);
            this.btnCheckin.TabIndex = 8;
            this.btnCheckin.Text = "Check In/Out";
            this.btnCheckin.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.radioButton4);
            this.panel9.Controls.Add(this.radioButton3);
            this.panel9.Controls.Add(this.radioButton2);
            this.panel9.Controls.Add(this.radioButton1);
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(18, 400);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(543, 166);
            this.panel9.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 14.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(241, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "TOP UP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LavenderBlush;
            this.label9.Font = new System.Drawing.Font("Poplar Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 34);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(4);
            this.label9.Size = new System.Drawing.Size(179, 47);
            this.label9.TabIndex = 9;
            this.label9.Text = "Select Amount:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(193, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 40);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "€25";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(278, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 40);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "€50";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(363, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 40);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "€75";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold);
            this.radioButton4.Location = new System.Drawing.Point(446, 38);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 40);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "€100";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Charlemagne Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(534, 70);
            this.button3.TabIndex = 10;
            this.button3.Text = "TOP UP";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 572);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Members";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(527, 116);
            this.listBox1.TabIndex = 0;
            // 
            // viewCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "viewCheckInOut";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(968, 753);
            this.Load += new System.EventHandler(this.viewCheckInOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputRFID;
        private System.Windows.Forms.Button btnRDIF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label visitcountnr;
        private System.Windows.Forms.Label VisitCount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
