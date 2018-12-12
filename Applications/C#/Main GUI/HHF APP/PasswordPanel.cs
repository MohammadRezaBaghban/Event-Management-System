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
    public partial class PasswordPanel : UserControl
    {
        private DataHelper dh;
        char index;
        
        


        public PasswordPanel()
        {
            InitializeComponent();
            dh = new DataHelper();
            
       
        }

        private void btnSubmitPsw_Click(object sender, EventArgs e)
        {
            try
            {
                String psw = tbNewPassw.Text;
                int nrChanged = dh.ChangePassword(index.ToString(), psw);
                if (nrChanged > 0)
                {
                    MessageBox.Show("Successfully changed the password");
                    tbNewPassw.Clear();
                    Panel myParent = (Panel) this.Parent;
                    myParent.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SetSelectedUser(string v)
        {
            index = v[0];
            
        }
    }
}
