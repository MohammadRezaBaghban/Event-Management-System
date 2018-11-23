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

namespace HHF_APP
{
    public partial class viewCheckInOut : UserControl
    {
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
                
                barcodeimage.Save("../../../"+tbUserId.Text+".png");
                
                System.Diagnostics.Process.Start("../../../" + tbUserId.Text + ".png");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
