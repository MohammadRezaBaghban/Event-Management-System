using System;
using System.Windows.Forms;

namespace HHF_APP
{
    public partial class viewLogin : UserControl 
    {
        private new const string Text = "Incorrect Username or Password";
        private const string Text1 = "Fill in everything!";
        private readonly DataHelper dh;
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
                if (dh.appLogin(email, passWord))
                {
                    SendToBack();


                }
                else
                {
                    MessageBox.Show(Text);
                }

                tbEmail.Clear();
                tbPassword.Clear();
            }
            else
            {
                MessageBox.Show(Text1);
            }
        }
    }
}
