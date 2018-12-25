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
            //webBrowser1.Visible = false;
            this.btnCloseBrowser.Visible = false;
            
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
            //webBrowser1.Navigate("http://hhf.hera.fhict.nl/php/index.php?page=booking&type=individual&ref=y");
            //webBrowser1.Visible = true;
            this.btnCloseBrowser.Visible = true;
           // webBrowser1.BringToFront();
            btnCloseBrowser.BringToFront();


        }

        private void btnBuyGroup_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("http://hhf.hera.fhict.nl/php/index.php?page=booking&type=group&ref=y");
            //webBrowser1.Visible = true;
            this.btnCloseBrowser.Visible = true;
            //webBrowser1.BringToFront();
            btnCloseBrowser.BringToFront();
        }

        private void btnBuyVIP_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("http://hhf.hera.fhict.nl/php/index.php?page=booking&type=vip&ref=y");
            //webBrowser1.Visible = true;
            this.btnCloseBrowser.Visible = true;
            //webBrowser1.BringToFront();
            btnCloseBrowser.BringToFront();
        }

        private void btnCloseBrowser_Click(object sender, EventArgs e)
        {

            //this.webBrowser1.Visible = false;
            this.btnCloseBrowser.Visible = false;
        }
    }
}
