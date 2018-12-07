using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace HHF_APP
{
    
    public partial class viewAdminDashboard : UserControl
    {
        private DataHelper dh;
        int i = -1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        public viewAdminDashboard()
        {
            InitializeComponent();
            dh = new DataHelper();
            
        }
        

        private void viewAdminDashboard_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void buttonModified1_Click(object sender, EventArgs e)
        {

        }
        
        private void modifiedpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VisitCount_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                panelAddEmp.Visible = true;
            }
            else
                panelAddEmp.Visible = false;

        }

        private void addEmployee1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblVisitors.Text = Convert.ToString(dh.CountVisitors());
            lblTicketsSold.Text = Convert.ToString(dh.CountTickts());
            lblTotalSpent.Text = Convert.ToString(dh.TotalSpent());
            lblTotalBalance.Text = Convert.ToString(dh.TotalBalance());
            lblTotalVisitors.Text = Convert.ToString(dh.TotalVisitors());
            lblBookedSpots.Text = Convert.ToString(dh.CampSpotsBooked());
            lblFreeSpots.Text = Convert.ToString(10000 - Convert.ToInt32(lblBookedSpots.Text));
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            lbEmployees.Items.Clear();
            String input = tbSearchEmployee.Text;
            bool isText = input.All(char.IsLetter);
            bool isNum = input.All(char.IsDigit);
            String isEmpty = "";

            try
            {

                if (input == isEmpty)
                {
                    List<Employee> empList = dh.GetEmployees();
                    foreach (Employee emp in empList)
                    {
                        lbEmployees.Items.Add(emp.ToAString());
                    }
                }
                else if (isText == true)
                {
                    List<Employee> empList = dh.GetEmployees(input);
                    foreach(Employee emp in empList)
                    {
                        lbEmployees.Items.Add(emp.ToAString());
                    }
                }
                else if (isNum == true)
                {
                    List<Employee> empList = dh.GetEmployees(Convert.ToInt32(input));
                    foreach (Employee emp in empList)
                    {
                        lbEmployees.Items.Add(emp.ToAString());
                    }
                }
                else if(input == isEmpty)
                {
                    List<Employee> empList = dh.GetEmployees();
                    foreach (Employee emp in empList)
                    {
                        lbEmployees.Items.Add(emp.ToAString());
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                String user = lbEmployees.SelectedItem.ToString();
                char idNr = user[0];
                MessageBox.Show(idNr.ToString());
            }
            catch
            {
                MessageBox.Show("Select an employee before proceeding");
            }
        }
    }
}
