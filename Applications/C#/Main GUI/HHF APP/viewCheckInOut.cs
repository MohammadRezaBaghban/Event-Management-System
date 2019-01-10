using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Spire.Barcode;
//using Spire.Barcode.Implementation;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;
using Spire.Barcode;

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
                barsetting.Type = BarCodeType.Code128;

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
            if(tbUserId.Text == "")
            {
                MessageBox.Show("User id field Empty");
            }
            try
            {
                Person temp = dh.checkTicket(Convert.ToInt32(tbUserId.Text));
                if (temp != null && dh.checkInOutInfo(temp.getUserId) == true && dh.getGroupMembers(temp.getUserId) != null && dh.getAllTransactions(temp.getUserId) != null)
                {
                    lblHolderName.Text = temp.getName;
                    lblAccountID.Text = Convert.ToString(temp.getActId);
                    lblTicketID.Text = Convert.ToString(temp.getTicketId);
                    lblTicketType.Text = Convert.ToString(temp.getTicketType);
                    lblTicketStatus.Text = Convert.ToString(temp.getTicketvalidity);
                    lblBalance.Text = Convert.ToString(temp.getBalance);
                    lblVisitorStatus.Text = Convert.ToString(temp.getVisitorStatus);

                    List<Person> getListGroupMembers = dh.getGroupMembers(temp.getUserId);
                    List<ReturnLoaned> getListLoanedArticles = dh.getLoanedArticles(temp.getUserId);
                    List<Transactions> getListTransactions = dh.getAllTransactions(temp.getUserId);
                    this.lbGroupMembers.Items.Clear();
                    this.lbLoanedItems.Items.Clear();
                    this.lblTransations.Items.Clear();
                    this.lbLoanedItems.Items.Clear();


                    foreach (Person p in getListGroupMembers)
                    {
                        lbGroupMembers.Items.Add(p.ToString());
                    }

                    foreach (ReturnLoaned A in getListLoanedArticles)
                    {
                        lbLoanedItems.Items.Add(A);
                    }

                    foreach (Transactions tr in getListTransactions)
                    {
                        lblTransations.Items.Add(tr.ToString());
                    }
                }
                else { MessageBox.Show("User with user id : " + tbUserId.Text + " Not Found"); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Input fields");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text == "")
            {
                MessageBox.Show("User id field empty");
            }
            try
            {
                int user_id = Convert.ToInt32(tbUserId.Text);
                string check = dh.checkedIn(user_id);
                if (check=="checked_in" || check=="check_out")
                {
                    MessageBox.Show("Person Already Checked In/Out");
                }
                else if (check =="" && dh.checkIn(user_id) == 1)
                {
                    MessageBox.Show("Check in successfull");
                }
                else { MessageBox.Show("Check In unsuccessfull "); }
                btnTicketFind.PerformClick();
            }
            catch (FormatException)
            {
                MessageBox.Show("Check input fields");
            }
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnArticles_Click(object sender, EventArgs e)
        {
            
            if(tbUserId.Text =="" && tbArticleNr.Text =="")
            {
                MessageBox.Show("Article Nr Field Empty!!");
            }
            try
            {
                int user_id = Convert.ToInt32(tbUserId.Text);
                int article_nr = Convert.ToInt32(tbArticleNr.Text);
                Person temp = dh.checkTicket(Convert.ToInt32(tbUserId.Text));
                if (((ReturnLoaned)lbLoanedItems.SelectedItem).getArticleStatus == "returned") { MessageBox.Show("Already Returned"); }
                else if (dh.ReturnLoanedMaterials((ReturnLoaned)lbLoanedItems.SelectedItem) >= 1 && dh.ReturnLoanedMaterials((ReturnLoaned)lbLoanedItems.SelectedItem) != 0)
                {
                    MessageBox.Show("Item" +
                                    " with article nr" + article_nr + " returned");
                    lbLoanedItems.Items.Clear();
                    List<ReturnLoaned> getListLoanedArticles = dh.getLoanedArticles(temp.getUserId);
                    foreach (ReturnLoaned A in getListLoanedArticles)
                    {
                        lbLoanedItems.Items.Add(A);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect article nr or connection time out");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input fields empty");
            }
        }

        private void lblTransations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblTransations.SelectedItem == null) { MessageBox.Show("No Transaction Selected !"); }
            try
            {
                string value = lblTransations.SelectedItem.ToString();
                string[] result = value.Split(new[] { ',' });

                lblTransactionID.Text = result[0];
                lblTransactionType.Text = result[1];
                lblTransactionAmount.Text = result[2];
                lblTransactionDate.Text = result[3];
                lblTransactionTime.Text = result[4];
            }
            catch (NullReferenceException){}
        }

        private void btnTransactionFile_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text File (*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfd.FileName;
                    FileStream fs = null;
            StreamWriter sw = null;
            fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(fs);
            if (tbUserId.Text == "") { MessageBox.Show("No User Id specified!!"); }
            try
            {
                sw.WriteLine("\t\t\t\t\t List Of Transactions");
                sw.WriteLine("");
                sw.WriteLine($"\t Account Number: {this.lblAccountID.Text}  \t\t\t Account Holder Name : {this.lblHolderName.Text} \t \t ");
                sw.WriteLine("--------------------------------------------------------------------------------------------------");
                sw.WriteLine("");
                string header = String.Format("\t {0,-10}{1,-12}{2,-14}{3,-12}{4,-14}{5,-14}\n",
                    "# Nr","ID", "Type", "Amount", "Date", "Time");
                sw.WriteLine(header);
                sw.WriteLine();
                int user_id = Convert.ToInt32(tbUserId.Text);

                Person temp = dh.checkTicket(user_id);
                int totalAmount = 0;
                if (temp != null && dh.getAllTransactions(temp.getUserId) != null)
                {

                    int i = 1;
                    foreach (Transactions tr1 in dh.getAllTransactions(temp.getUserId))
                    {
                        Tuple<int, string, int, string, string>[] transactions =
                        {
                        Tuple.Create(tr1.getTransactionId,tr1.getTransactionType,tr1.getTransactionAmount,tr1.getTransactionDate,tr1.getTransactionTime)
                        };
                        
                        if (tr1.getTransactionType.Equals("refund"))
                        {
                            totalAmount -= tr1.getTransactionAmount;
                        }
                        else
                        {
                            totalAmount += tr1.getTransactionAmount;
                        }

                        

                        
                        StringBuilder sb = new StringBuilder();
                        
                        foreach (var city in transactions)
                        {
                            sw.Write("\t {0,-10}{1,-12}{2,-14}{3,-12}{4,-14}{5,-14}",
                                                i ,city.Item1, city.Item2, city.Item3, city.Item4, city.Item5, Environment.NewLine);
                            sw.WriteLine();
                            i++;
                        }
                    }

                    sw.WriteLine("");
                    sw.WriteLine("--------------------------------------------------------------------------------------------------");
                    sw.Write($"\t Total Amount of Spent Money = {totalAmount}  \t\t Bank Account Number: {this.dh.BankAccountNr(Convert.ToInt32(this.lblAccountID.Text))} \t ");                    
                }
                MessageBox.Show("File Created Successfully");
            }
            catch (IOException) { throw new IOException("Error Writing to File"); }
            catch (FormatException) { }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                }
            }

            
        }

        private void btnRefundAndCheckOut_Click(object sender, EventArgs e)
        {
            
            if (tbUserId.Text == "")
            {
                MessageBox.Show("User id Field Empty!!");
            }
            try
            {

                int userId = Convert.ToInt32(tbUserId.Text);
                if (dh.RefundCloseAccount(userId) >= 1)
                {
                    MessageBox.Show("Successfully Closed Account");
                    btnTicketFind.PerformClick();
                }
                else MessageBox.Show("Person Already Checked Out");
            }
            catch (FormatException) { }
            catch (Exception ex) { MessageBox.Show(ex.Message
                ); }
        }

        private void lbLoanedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLoanedItems.SelectedItem == null) { MessageBox.Show("No Article Selected !"); }
            try
            {
                string value = lbLoanedItems.SelectedItem.ToString();
                string[] result = value.Split(new[] { ',' });

                tbArticleNr.Text = result[2];
            }
            catch (NullReferenceException) { }
        }
    }
}
