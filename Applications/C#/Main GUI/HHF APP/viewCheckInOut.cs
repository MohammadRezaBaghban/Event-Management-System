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
        public viewCheckInOut()
        {
            InitializeComponent();
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
                barsetting.Type = BarCodeType.EAN128;

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

    }
}
