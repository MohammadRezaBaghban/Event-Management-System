namespace HHF_APP
{
    partial class PasswordPanel
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
            this.tbNewPassw = new System.Windows.Forms.TextBox();
            this.lblwww = new System.Windows.Forms.Label();
            this.btnSubmitPsw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewPassw
            // 
            this.tbNewPassw.Location = new System.Drawing.Point(25, 44);
            this.tbNewPassw.Name = "tbNewPassw";
            this.tbNewPassw.Size = new System.Drawing.Size(96, 20);
            this.tbNewPassw.TabIndex = 0;
            // 
            // lblwww
            // 
            this.lblwww.AutoSize = true;
            this.lblwww.Location = new System.Drawing.Point(33, 15);
            this.lblwww.Name = "lblwww";
            this.lblwww.Size = new System.Drawing.Size(77, 13);
            this.lblwww.TabIndex = 1;
            this.lblwww.Text = "New password";
            // 
            // btnSubmitPsw
            // 
            this.btnSubmitPsw.Location = new System.Drawing.Point(41, 85);
            this.btnSubmitPsw.Name = "btnSubmitPsw";
            this.btnSubmitPsw.Size = new System.Drawing.Size(62, 50);
            this.btnSubmitPsw.TabIndex = 2;
            this.btnSubmitPsw.Text = "Change";
            this.btnSubmitPsw.UseVisualStyleBackColor = true;
            this.btnSubmitPsw.Click += new System.EventHandler(this.btnSubmitPsw_Click);
            // 
            // PasswordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmitPsw);
            this.Controls.Add(this.lblwww);
            this.Controls.Add(this.tbNewPassw);
            this.Name = "PasswordPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewPassw;
        private System.Windows.Forms.Label lblwww;
        private System.Windows.Forms.Button btnSubmitPsw;
    }
}
