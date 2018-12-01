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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
