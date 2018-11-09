using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace HHF_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanelforBTNs.Height = AdminBtn.Height;
            sidepanelforBTNs.Top = AdminBtn.Top;
           viewAdminDashboard1.BringToFront();
            //SoundPlayer my_sound = new SoundPlayer("F:/xxxxxx.wave"); //put your own .wave file path
            //my_sound.Play();
            //my_sound.Stop();

        }

      

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = ticketsBtn.Height;
            sidepanelforBTNs.Top = ticketsBtn.Top;
            viewTickets1.BringToFront();
            panel3.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = checkinBTn.Height;
            sidepanelforBTNs.Top = checkinBTn.Top;
            panel3.Visible = false;
             viewCheckInOut1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = storeBtn.Height;
            sidepanelforBTNs.Top = storeBtn.Top;
            panel3.Visible = true;
            //  viewStore1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = campBtn.Height;
            sidepanelforBTNs.Top = campBtn.Top;
            panel3.Visible = true;
            //  viewCamping1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = lendBtn.Height;
            sidepanelforBTNs.Top = lendBtn.Top;
            panel3.Visible = true;
            //  viewLending1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanelforBTNs.Height = AdminBtn.Height;
            sidepanelforBTNs.Top = AdminBtn.Top;
            viewAdminDashboard1.BringToFront();
            panel3.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.DarkRed;
        }

       
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void viewCheckInOut1_Load(object sender, EventArgs e)
        {

        }

        private void viewTickets1_Load(object sender, EventArgs e)
        {

        }
    }
}
