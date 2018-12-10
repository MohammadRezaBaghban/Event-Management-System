using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Barcode;
using Spire.Barcode.Implementation;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;

namespace HHF_APP
{
    public partial class viewCheckInOut : UserControl
    {
        string filename;
        private Font verdana10Font;
        private StreamReader reader;
        private DataHelper dh;
        public viewCheckInOut()
        {
            InitializeComponent();
            dh = new DataHelper();
        }

        private void viewCheckInOut_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputRFID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTicketPrint_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeSettings barsetting = new BarcodeSettings();

                //set the x dimension
                barsetting.X = 0.8f;
                barsetting.Unit = GraphicsUnit.Millimeter;

                barsetting.HasBorder = true;
                barsetting.BorderWidth = 0.5F;

                //set the data
                barsetting.Data = tbUserId.Text;
                barsetting.Data2D = tbUserId.Text;

                //generate EAN128 barcode
                barsetting.Type = BarCodeType.Codabar;

                BarCodeGenerator bargenerator = new BarCodeGenerator(barsetting);
                Image barcodeimage = bargenerator.GenerateImage();
                filename = "C:/xampp/htdocs/ProP_Sems2/Applications/C#/Main GUI/HHF APP/bin/Debug/barcodes" + tbUserId.Text + ".png";
                barcodeimage.Save(filename);
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += PrintPage;
                pd.Print();
                Process.Start(filename);
                // Process.Start(@filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(filename);
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);
        }

        private void btnTicketFind_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(tbUserId.Text);
            if (dh.checkTicket(user_id)==true && dh.checkInOutInfo(user_id)==true)
            {
                lblHolderName.Text = dh.holderName;
                lblAccountID.Text = Convert.ToString(dh.actId);
                lblTicketID.Text = Convert.ToString(dh.ticketId);
                lblTicketType.Text = Convert.ToString(dh.ticketType);
                lblTicketStatus.Text = Convert.ToString(dh.ticketStatus);
                lblBalance.Text = Convert.ToString(dh.ticketBalance);
                lblRefundAmount.Text = Convert.ToString(dh.ticketRefund);
            }
            else { MessageBox.Show("User with user id : "+user_id+" Not Found"); }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(tbUserId.Text);
            if (dh.checkIn(user_id) == 1)
            {
                if (dh.checkedIn(user_id) == 1)
                {
                    MessageBox.Show("Person Already Checked In");
                }
                else { MessageBox.Show("Check In successfull"); }

            }
            else { MessageBox.Show("Could not check in user"); }
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
