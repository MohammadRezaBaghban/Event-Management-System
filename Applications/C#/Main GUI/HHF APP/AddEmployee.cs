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
    public partial class AddEmployee: UserControl
    {
        private DataHelper dh;
        public AddEmployee()
        {
            InitializeComponent();
            dh = new DataHelper();
        }

        
        private void btnSubmitEmp_Click(object sender, EventArgs e)
        {
            
            String fName;
            String lName;
            String phoneNr;
            String position;
            String address;
            String postcode;
            String email;
            String password;

            if (tbFname.Text != "" && tbLname.Text != "" && tbPhoneNr.Text != "" && cbRole.SelectedItem.ToString() != "" && tbAddress.Text != "" && tbPostcode.Text != "" && tbEmail.Text != "" && tbPassword.Text != "")
            {
                fName = Convert.ToString(tbFname.Text);
                lName = Convert.ToString(tbLname.Text);
                phoneNr = Convert.ToString(tbPhoneNr.Text);
                position = Convert.ToString(cbRole.SelectedItem.ToString());
                address = Convert.ToString(tbAddress.Text);
                postcode = Convert.ToString(tbPostcode.Text);
                email = Convert.ToString(tbEmail.Text);
                password = Convert.ToString(tbPassword.Text);

                bool fNameResult = fName.All(Char.IsLetter);
                bool lNameResult = lName.All(Char.IsLetter);
                bool phoneNrResult = phoneNr.All(Char.IsDigit);
                bool positionResult = position.All(Char.IsLetter);
                bool emailResult = email.Contains("@");




                if (fNameResult == true && lNameResult == true && phoneNrResult == true && positionResult == true && emailResult == true)
                {
                    int nrAdded = dh.AddEmployee(fName, lName, email, password, phoneNr, position, address, postcode);

                    try
                    {
                        if (nrAdded > 0)
                        {
                            MessageBox.Show("Succesfully added to database");

                            tbFname.Clear();
                            tbLname.Clear();
                            tbPhoneNr.Clear();
                            cbRole.Items.Clear();
                            tbAddress.Clear();
                            tbPostcode.Clear();
                            tbEmail.Clear();
                            tbPassword.Clear();
                            Panel myParent = (Panel)this.Parent;
                            myParent.Visible = false;


                            var myFormParent = myParent.Parent;
                            myFormParent = myFormParent.Parent;
                             myFormParent = myFormParent.Parent;
                            viewAdminDashboard secondparent =(viewAdminDashboard) myFormParent.Parent;



                            secondparent.btnSearchEmployee_Click(sender, e);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (fNameResult == false)
                {
                    MessageBox.Show("Enter a valid first name");
                }
                else if (lNameResult == false)
                {
                    MessageBox.Show("Enter a valid last name");
                }
                else if (phoneNrResult == false)
                {
                    MessageBox.Show("Enter a valid phone number");
                }
                else
                {
                    MessageBox.Show("Enter a valid email address");
                }
            }
            else
            {
                MessageBox.Show("Fill in all the fields!!");
            }
       
           
            
        }

       
    }
}
