using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHF_APP
{
    public partial class viewLogin : UserControl 
    {
        private DataHelper dh;
        public viewLogin()
        {
            InitializeComponent();
            dh = new DataHelper();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string passWord = tbPassword.Text;
            if (!string.IsNullOrWhiteSpace(email) || !string.IsNullOrWhiteSpace(passWord))
            {
                if (dh.appLogin(email, passWord) == 1)
                {
                    var myparent = (Form1)this.Parent;
                    myparent.AdminBtn.Enabled = true;
                    myparent.viewAdminDashboard1.Visible = true;
                    this.SendToBack();


                }
                else if(dh.appLogin(email, passWord) == 0)
                {
                    var myparent = (Form1)this.Parent;
                    myparent.AdminBtn.Enabled = false;
                    myparent.viewAdminDashboard1.Visible = false;
                    this.SendToBack();
                   
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }

                tbEmail.Clear();
                tbPassword.Clear();
            }
            else
            {
                MessageBox.Show("Fill in everything!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void viewLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
