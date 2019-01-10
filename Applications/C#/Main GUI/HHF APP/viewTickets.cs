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
    public partial class viewTickets : UserControl
    {
        public viewTickets()
        {
            InitializeComponent();
            
            
        }

        public void ManagingUI(int a)
        {
            //Function of this method, since Radio Buttons are being in different panels
            //They can all be checked, to link them in a way that only one can be selected 
            //This method can be used.

            void ChangeColor()
            {
                this.pnlIndividual.BackColor = Color.LavenderBlush;
                this.pnlGroup.BackColor = Color.LavenderBlush;
                this.pnlVIP.BackColor = Color.LavenderBlush;
                if (a == 1)
                {
                    this.pnlIndividual.BackColor = Color.NavajoWhite;
                }
                else if (a == 2)
                {
                    this.pnlGroup.BackColor = Color.NavajoWhite;
                }
                else if (a == 3)
                {
                    this.pnlVIP.BackColor = Color.NavajoWhite;
                }
            }

            if (a==1)
            {            
                this.RbGroup.Checked = false;
                this.RbVIP.Checked = false;
                this.RbIndividual.Checked = true;
                this.GbCamping.Visible = false;
                this.GbGroupMembers.Visible = false;
                
            }else if (a==2)
            {                
                this.RbVIP.Checked = false;
                this.RbIndividual.Checked = false;
                this.RbGroup.Checked = true;
                this.GbCamping.Visible = true;
                this.GbGroupMembers.Visible = true;
            }
            else if (a==3)
            {                 
                this.RbIndividual.Checked = false;
                this.RbGroup.Checked = false;
                this.RbVIP.Checked = true;
                this.GbCamping.Visible = true;
                this.GbGroupMembers.Visible = false;
            }
            ChangeColor();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyIndiv_Click(object sender, EventArgs e)
        {
            


        }

        private void btnBuyGroup_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuyVIP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCloseBrowser_Click(object sender, EventArgs e)
        {

            
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbRepeatEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRepeatEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click_1(object sender, EventArgs e)
        {

        }

        private void TbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbIBAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIBAN_Click(object sender, EventArgs e)
        {

        }

        private void NrTopUp_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RbIndividual_Click(object sender, EventArgs e)
        {
            this.ManagingUI(1);
        }

        private void RbGroup_Click(object sender, EventArgs e)
        {
            this.ManagingUI(2);
        }

        private void RbVIP_Click(object sender, EventArgs e)
        {
            this.ManagingUI(3);
        }

        private void pnlIndividual_Click(object sender, EventArgs e)
        {
            this.ManagingUI(1);
        }

        private void pnlGroup_Click(object sender, EventArgs e)
        {
            this.ManagingUI(2);
        }

        private void pnlVIP_Click(object sender, EventArgs e)
        {
            this.ManagingUI(3);
        }
    }
}
