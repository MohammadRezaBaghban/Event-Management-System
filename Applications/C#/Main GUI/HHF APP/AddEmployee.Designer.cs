namespace HHF_APP
{
    partial class AddEmployee
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
            this.tbEmpLname = new System.Windows.Forms.TextBox();
            this.tbEmpPassword = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpLName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbEmpFname = new System.Windows.Forms.TextBox();
            this.btnSubmitEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmpLname
            // 
            this.tbEmpLname.Location = new System.Drawing.Point(122, 52);
            this.tbEmpLname.Name = "tbEmpLname";
            this.tbEmpLname.Size = new System.Drawing.Size(100, 20);
            this.tbEmpLname.TabIndex = 0;
            // 
            // tbEmpPassword
            // 
            this.tbEmpPassword.Location = new System.Drawing.Point(122, 87);
            this.tbEmpPassword.Name = "tbEmpPassword";
            this.tbEmpPassword.Size = new System.Drawing.Size(100, 20);
            this.tbEmpPassword.TabIndex = 1;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(31, 23);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(55, 13);
            this.lblEmpName.TabIndex = 2;
            this.lblEmpName.Text = "First name";
            // 
            // lblEmpLName
            // 
            this.lblEmpLName.AutoSize = true;
            this.lblEmpLName.Location = new System.Drawing.Point(30, 52);
            this.lblEmpLName.Name = "lblEmpLName";
            this.lblEmpLName.Size = new System.Drawing.Size(56, 13);
            this.lblEmpLName.TabIndex = 3;
            this.lblEmpLName.Text = "Last name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // tbEmpFname
            // 
            this.tbEmpFname.Location = new System.Drawing.Point(122, 23);
            this.tbEmpFname.Name = "tbEmpFname";
            this.tbEmpFname.Size = new System.Drawing.Size(100, 20);
            this.tbEmpFname.TabIndex = 5;
            // 
            // btnSubmitEmp
            // 
            this.btnSubmitEmp.Location = new System.Drawing.Point(122, 130);
            this.btnSubmitEmp.Name = "btnSubmitEmp";
            this.btnSubmitEmp.Size = new System.Drawing.Size(91, 35);
            this.btnSubmitEmp.TabIndex = 6;
            this.btnSubmitEmp.Text = "Enter";
            this.btnSubmitEmp.UseVisualStyleBackColor = true;
            this.btnSubmitEmp.Click += new System.EventHandler(this.btnSubmitEmp_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmitEmp);
            this.Controls.Add(this.tbEmpFname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmpLName);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.tbEmpPassword);
            this.Controls.Add(this.tbEmpLname);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(266, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmpLname;
        private System.Windows.Forms.TextBox tbEmpPassword;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpLName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbEmpFname;
        private System.Windows.Forms.Button btnSubmitEmp;
    }
}
