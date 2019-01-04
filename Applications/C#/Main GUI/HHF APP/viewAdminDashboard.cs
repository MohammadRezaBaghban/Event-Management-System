using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace HHF_APP
{
    public partial class viewAdminDashboard : UserControl
    {
        private DataHelper dh;
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
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
            btnRefresh_Click( sender, e);
            btnSearchEmployee_Click(sender,e);
            rbArticle_Click(sender, e);
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

        public void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (panelAddEmp.Visible == true)
            {
                panelAddEmp.Visible = false;
            }
            else
            {
                panelAddEmp.Visible = true;
            }
        }

        private void addEmployee1_Load(object sender, EventArgs e)
        {
        }

        public void btnRefresh_Click(object sender, EventArgs e)
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
                    foreach (Employee emp in empList)
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
                else if (input == isEmpty)
                {
                    List<Employee> empList = dh.GetEmployees();
                    foreach (Employee emp in empList)
                    {
                        lbEmployees.Items.Add(emp.ToAString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (pnlPassword.Visible == true)
            {
                pnlPassword.Visible = false;
            }
            else pnlPassword.Visible = true;
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                passwordPanel1.SetSelectedUser(lbEmployees.SelectedItem.ToString());
            }
            catch
            {
            }
        }


        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                String emp = lbEmployees.SelectedItem.ToString();
                char index = emp[0];

                int nrDeleted = dh.DeleteEmployee(index.ToString());

                if (nrDeleted > 0)
                {
                    MessageBox.Show("Employee removed successfully");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select an employee that you want to delete before pressing the delete button");
            }
        }

        private void btnSelectLogFile_Click(object sender, EventArgs e)
        { List<string> temp= new List<string>();
            ofdATMLog.Filter = "Text Files (*.txt)|*.txt";
            ofdATMLog.DefaultExt = "txt";
            ofdATMLog.AddExtension = true;
            ofdATMLog.Title = "Select ATM Log";
            if (ofdATMLog.ShowDialog() == DialogResult.OK)
            {
                tbAtmLogPath.Text = ofdATMLog.FileName;
                FileStream fs = null;
                StreamReader sw = null;
                try
                {
                    fs = new FileStream(ofdATMLog.FileName, FileMode.Open, FileAccess.Read);
                    sw = new StreamReader(fs);

                    for(int i=0; i<4;i++)
                    {sw.ReadLine();}

                    string line = sw.ReadLine();
                    while (line != null)
                    {
                        temp.Add(line);

                        line = sw.ReadLine();
                    }

                    foreach (string record in temp)
                    {
                        var info = record.Split(' ');
                        
                        dh.addTransaction(Convert.ToInt32(info[0]), Convert.ToDecimal(info[1]), "deposit");
                    }



                }
                catch (IOException ex)
                {
                    lbATMLog.Items.Add("I/O Error");
                    lbATMLog.Items.Add(ex.Message);
                }
                catch (Exception ex)
                {
                    lbATMLog.Items.Add("Error");
                    lbATMLog.Items.Add(ex.Message);
                }

                finally
                {
                    sw?.Close();

                    if (fs != null)
                    {
                        fs.Close();
                        lbATMLog.Items.Add("*******************");
                        lbATMLog.Items.Add("Process Complete");
                        lbATMLog.Items.Add("*******************");
                        
                    }
                }
            }
        }

        private void rbArticle_Click(object sender, EventArgs e)
        {
            cbReserve.Visible = false;
            cbReserve.Checked = false;
            chartComplex.Series["Reserved"].IsVisibleInLegend = false;

            if (rbArticle.Checked == true && rbAmount.Checked == true)
            {

                chartComplex.Series["Amount"].Points.Clear();
                chartComplex.Series["Reserved"].Points.Clear();
                chartComplex.Series["Amount"].Points.AddXY("USB", dh.GenArt1());
                chartComplex.Series["Amount"].Points.AddXY("Torch", dh.GenArt2());
                chartComplex.Series["Amount"].Points.AddXY("Powerbank", dh.GenArt3());
            }
        }

        private void rbMoney_CheckedChanged(object sender, EventArgs e)
        {
            cbReserve.Visible = false;
            cbReserve.Checked = false;
            chartComplex.Series["Reserved"].IsVisibleInLegend = false;

            if (rbMoney.Checked == true && rbAmount.Checked == true)
            {

                chartComplex.Series["Amount"].Points.Clear();
                chartComplex.Series["Reserved"].Points.Clear();
                chartComplex.Series["Amount"].Points.AddXY("Food", dh.GetSpentAmount1());
                chartComplex.Series["Amount"].Points.AddXY("Registration", dh.GetSpentAmount2());
                chartComplex.Series["Amount"].Points.AddXY("Deposit", dh.GetSpentAmount3());
                chartComplex.Series["Amount"].Points.AddXY("Items", dh.GetSpentAmount4());
            }
        }

        private void rbCamping_CheckedChanged(object sender, EventArgs e)
        {
            cbReserve.Visible = true;
            chartComplex.Series["Reserved"].IsVisibleInLegend = false;

            if (rbCamping.Checked == true && rbAmount.Checked == true)
            {

                chartComplex.Series["Amount"].Points.Clear();
                chartComplex.Series["Reserved"].Points.Clear();
                chartComplex.Series["Amount"].Points.AddXY("Normal", dh.GetCampNormal());
                chartComplex.Series["Amount"].Points.AddXY("VIP", dh.GetCampVIP());

            }
        }

        private void cbReserve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReserve.Checked == true)
            {
            
                chartComplex.Series["Reserved"].IsVisibleInLegend = true;
                chartComplex.Series["Reserved"].Points.AddXY("Normal", dh.GetReservedNormal());
                chartComplex.Series["Reserved"].Points.AddXY("VIP", dh.GetReservedVIP());
            }
            else
            {
                chartComplex.Series["Amount"].Points.Clear();
                chartComplex.Series["Reserved"].Points.Clear();
                chartComplex.Series["Amount"].Points.AddXY("Normal", dh.GetCampNormal());
                chartComplex.Series["Amount"].Points.AddXY("VIP", dh.GetCampVIP());
            }

        }
    }
}
