
namespace HHF_APP
{
    partial class viewCamping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCamping));
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbCampingHeader = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCCheckIn = new System.Windows.Forms.Button();
            this.btnCCheckOut = new System.Windows.Forms.Button();
            this.btnCPay = new System.Windows.Forms.Button();
            this.tbCBarcode = new System.Windows.Forms.TextBox();
            this.lblCampingBarcode = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.panel14);
            this.panel9.Controls.Add(this.lbCampingHeader);
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(313, 303);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(160, 66);
            this.panel9.TabIndex = 15;
            // 
            // panel14
            // 
            this.panel14.AutoSize = true;
            this.panel14.BackColor = System.Drawing.Color.LimeGreen;
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(3, 10);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(40, 37);
            this.panel14.TabIndex = 1;
            // 
            // lbCampingHeader
            // 
            this.lbCampingHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCampingHeader.AutoSize = true;
            this.lbCampingHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampingHeader.Location = new System.Drawing.Point(49, 7);
            this.lbCampingHeader.Name = "lbCampingHeader";
            this.lbCampingHeader.Size = new System.Drawing.Size(105, 19);
            this.lbCampingHeader.TabIndex = 0;
            this.lbCampingHeader.Text = "Payment Status";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.lblPaymentStatus);
            this.panel15.Controls.Add(this.label20);
            this.panel15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.Location = new System.Drawing.Point(3, 28);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(155, 33);
            this.panel15.TabIndex = 0;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(87, 7);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(39, 19);
            this.lblPaymentStatus.TabIndex = 2;
            this.lblPaymentStatus.Text = "-----";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(132, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 19);
            this.label20.TabIndex = 1;
            this.label20.Text = "xxxxx";
            // 
            // btnCCheckIn
            // 
            this.btnCCheckIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCheckIn.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCCheckIn.Location = new System.Drawing.Point(258, 220);
            this.btnCCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCCheckIn.Name = "btnCCheckIn";
            this.btnCCheckIn.Size = new System.Drawing.Size(147, 78);
            this.btnCCheckIn.TabIndex = 11;
            this.btnCCheckIn.Text = "Check In";
            this.btnCCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCCheckOut
            // 
            this.btnCCheckOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCheckOut.ForeColor = System.Drawing.Color.Red;
            this.btnCCheckOut.Location = new System.Drawing.Point(410, 220);
            this.btnCCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCCheckOut.Name = "btnCCheckOut";
            this.btnCCheckOut.Size = new System.Drawing.Size(147, 78);
            this.btnCCheckOut.TabIndex = 17;
            this.btnCCheckOut.Text = "Check Out";
            this.btnCCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnCPay
            // 
            this.btnCPay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPay.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCPay.Location = new System.Drawing.Point(478, 309);
            this.btnCPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCPay.Name = "btnCPay";
            this.btnCPay.Size = new System.Drawing.Size(46, 56);
            this.btnCPay.TabIndex = 18;
            this.btnCPay.Text = "Pay";
            this.btnCPay.UseVisualStyleBackColor = false;
            // 
            // tbCBarcode
            // 
            this.tbCBarcode.Location = new System.Drawing.Point(300, 196);
            this.tbCBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCBarcode.Name = "tbCBarcode";
            this.tbCBarcode.Size = new System.Drawing.Size(235, 20);
            this.tbCBarcode.TabIndex = 19;
            // 
            // lblCampingBarcode
            // 
            this.lblCampingBarcode.AutoSize = true;
            this.lblCampingBarcode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampingBarcode.Location = new System.Drawing.Point(195, 189);
            this.lblCampingBarcode.Name = "lblCampingBarcode";
            this.lblCampingBarcode.Size = new System.Drawing.Size(90, 25);
            this.lblCampingBarcode.TabIndex = 20;
            this.lblCampingBarcode.Text = "Barcode:";
            // 
            // viewCamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.lblCampingBarcode);
            this.Controls.Add(this.tbCBarcode);
            this.Controls.Add(this.btnCPay);
            this.Controls.Add(this.btnCCheckOut);
            this.Controls.Add(this.btnCCheckIn);
            this.Controls.Add(this.panel9);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewCamping";
            this.Size = new System.Drawing.Size(834, 570);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lbCampingHeader;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCCheckIn;
        private System.Windows.Forms.Button btnCCheckOut;
        private System.Windows.Forms.Button btnCPay;
        private System.Windows.Forms.TextBox tbCBarcode;
        private System.Windows.Forms.Label lblCampingBarcode;
    }
}
