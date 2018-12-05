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

            if (tbFname.Text != "" && tbLname.Text != "" && tbPhoneNr.Text != "" && tbPosition.Text != "" && tbAddress.Text != "" && tbPostcode.Text != "" && tbEmail.Text != "" && tbPassword.Text != "")
            {
                fName = Convert.ToString(tbFname.Text);
                lName = Convert.ToString(tbLname.Text);
                phoneNr = Convert.ToString(tbPhoneNr.Text);
                position = Convert.ToString(tbPosition.Text);
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
                    int nrAdded = dh.AddEmployee(fName, lName, phoneNr, position, address, postcode);
                    int nrAdded2 = dh.AddEmployeeCred(fName, lName, email, password);
                    if (nrAdded2 + nrAdded > 1)
                    {
                        MessageBox.Show("Succesfully added to database");

                        tbFname.Clear();
                        tbLname.Clear();
                        tbPhoneNr.Clear();
                        tbPosition.Clear();
                        tbAddress.Clear();
                        tbPostcode.Clear();
                        tbEmail.Clear();
                        tbPassword.Clear();
                        
                    }
                    else
                    {
                       // dh.RemoveEmployee1(fName, lName);
                        MessageBox.Show("Error when adding to database");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Some info provided is incorrect");
                }
            }
       
           
            
        } 
    }
}
