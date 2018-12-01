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
            String password;

            if (tbEmpFname.Text != "" && tbEmpLname.Text != "" && tbEmpPassword.Text != "")
            {
                fName = Convert.ToString(tbEmpFname.Text);
                lName = Convert.ToString(tbEmpLname.Text);
                password = Convert.ToString(tbEmpPassword.Text);
                int nrAdded = dh.AddEmployee(fName, lName, password);
                if (nrAdded > 0)
                {
                    MessageBox.Show("Succesfully added to database");
                    tbEmpFname.Clear();
                    tbEmpLname.Clear();
                    tbEmpPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Error when adding to database");
                }
            }
       
           
            
        }
    }
}
