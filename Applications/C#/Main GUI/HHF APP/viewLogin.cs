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

            if (dh.appLogin(email, passWord) == true)
            {
                this.SendToBack();
            }
            else { MessageBox.Show("Incorrect Username or Password"); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
