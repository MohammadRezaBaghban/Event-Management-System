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
        private List<string> FirstName;
        List<string> LastName;
        List<string> Email;
        private DataHelper dh=new DataHelper();

       
        List<Member> members = new List<Member>();
        private int NrMembers = 0;

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
                this.GbCamping.Visible = false;
                this.GbGroupMembers.Visible = false;
            }
            ChangeColor();
            
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

        class Member
        {
            public static int Number = 0;

            public string Fn;

            public string Ln;

            public string Email;
            public Member(string fn,string ln, string email)
            {
                this.Email = email;
                this.Fn = fn;
                this.Ln = ln;
                Number++;
            }
        }
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.TbMemberFN.Text))
            {
                MessageBox.Show("Please fill in First name field");
                this.TbMemberLN.Focus();
            }else if (String.IsNullOrWhiteSpace(this.TbMemberLN.Text))
            {
                MessageBox.Show("Please fill in Last name field");
                this.TbMemberLN.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.TbMemberEmail.Text))
            {
                MessageBox.Show("Please fill in Email field");
                this.TbMemberEmail.Focus();
            }
            else
            {
                if (Member.Number < 5)
                {
                    if (this.members.Exists(
                        delegate (Member member)
                            {
                                if (member.Email == this.TbMemberEmail.Text)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }))
                    {
                        MessageBox.Show("There is another member in the list with given email!");
                    }
                    else
                    {
                        Member m = new Member(this.TbMemberFN.Text, this.TbMemberLN.Text, this.TbMemberEmail.Text);
                        this.members.Add(m);
                        this.UpdateListOfMember();
                        TbMemberFN.Text = "";
                        TbMemberLN.Text = "";
                        TbMemberEmail.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("A group can only has maximum six members");
                }
                
            }
        }

        private void UpdateListOfMember()
        {
            this.ToolStripMemberList.DropDownItems.Clear();
            this.FirstName = new List<string>();
            this.LastName = new List<string>();
            this.Email = new List<string>();
                     
            int i = 0;
            foreach (var m in this.members)
            {
                this.FirstName.Add(m.Fn);
                this.LastName.Add(m.Ln);
                this.Email.Add(m.Email);
                this.ToolStripMemberList.DropDownItems.Add($"{i+1} - {m.Fn}");
                this.ToolStripMemberList.DropDownItems[i].Tag = m;
                this.ToolStripMemberList.DropDownItems[i].Click += new EventHandler(this.ShowMemberInforMation);
                var temp = this.ToolStripMemberList.DropDownItems[i].Tag;
               
                i++;
            }
        }

        public void ShowMemberInforMation(object o, EventArgs e)
        {
            
            var temp = ((ToolStripItem)o);
            Member m = (Member)temp.Tag;
            this.TbMemberFN.Text = m.Fn;
            this.TbMemberLN.Text = m.Ln;
            this.TbMemberEmail.Text = m.Email;
            this.lblCurrentMember.Text = m.Fn;
            this.lblCurrentMember.Tag = m;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (lblCurrentMember.Tag == null)
            {
                MessageBox.Show("No member has been selected");
            }
            else
            {

                this.members.Remove((Member)this.lblCurrentMember.Tag);
                Member.Number--;
                this.lblCurrentMember.Tag = null;
                this.lblCurrentMember.Text = "";
                TbMemberFN.Text = "";
                TbMemberLN.Text = "";
                TbMemberEmail.Text = "";
                this.UpdateListOfMember();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbEmail.Text == TbRepeatEmail.Text && TbPassword.Text == TbConfirmPassword.Text && TbFirstName.Text!=""&& TbIBAN.Text!="" && TbLastName.Text!=""&& TbPassword.Text!=""&& TbEmail.Text!=""&& TbLastName.Text!=""&& TbPassword.Text!=""&& NrTopUp.Text!="")
                {
                    if (RbIndividual.Checked)
                    {
                        if (dh.SellTicketIndividual(new TicketPurchase(TbFirstName.Text,
                            TbLastName.Text, TbEmail.Text, TbPassword.Text,
                            TbPhone.Text, TbIBAN.Text, Convert.ToDecimal(NrTopUp.Value))))
                        {
                            MessageBox.Show("Successfully purchased.");
           
                        }
                    }
                    else if (RbGroup.Checked)
                    {
                        if (dh.SellTicketGroup(new TicketGroup
                        (TbFirstName.Text,
                            TbLastName.Text, TbEmail.Text, TbPassword.Text,
                            TbPhone.Text, TbIBAN.Text, Convert.ToDecimal(NrTopUp.Value),
                            FirstName,
                            LastName, Email, CbAdvancedPayment.Checked)))
                        {
                            MessageBox.Show("Successfully purchased.");

                        }
                    }
                    else if (RbVIP.Checked)
                    {
                        if (dh.SellTicketGroup(new TicketGroup
                        (TbFirstName.Text,
                            TbLastName.Text, TbEmail.Text, TbPassword.Text,
                            TbPhone.Text, TbIBAN.Text, Convert.ToDecimal(NrTopUp.Value), true)))
                        {
                            MessageBox.Show("Successfully purchased.");
                        }

                    }
                }
                else if(TbEmail.Text != TbRepeatEmail.Text)
                {
                    MessageBox.Show("Emails Dont Match");
                }
                else if (TbPassword.Text != TbConfirmPassword.Text)
                {
                    MessageBox.Show("Password Dont Match");
                }
                else {
                    MessageBox.Show("Not Fields are filled");}
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void RbGroup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
