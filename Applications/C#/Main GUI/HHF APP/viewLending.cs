using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HHF_APP
{
    public partial class viewLending : UserControl
    {

        public enum ItemType
        {
            
            usb,
            torch,
            powerbank
        }

        private string ReturnStatus;
        private string cs = DataHelper.connectionInfo;
        public bool accountFound;
        public int accountId;
        public int userId;
        public int totalRevenue;
        private DataHelper  dh = new DataHelper();

        public viewLending()
        {
            InitializeComponent();
            GetListOfLoanedItems();
        }

        private void viewLending_Load(object sender, EventArgs e)
        {

        }

        #region SQL Quries
        private void Revenue()
        {
            DG_Revenue.Rows.Clear();
            DataSet ds = new DataSet();
            int[] Nr = new int[3];
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                for (int i = 0; i < 3; i++)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        string query1 = "Select Count(*)" +
                                        "From loaned l join articles a on (l.article_nr = a.article_nr) " +
                                        $"Where a.type = '{((ItemType)(i))}' ";
                        cmd.CommandText = query1;
                        Nr[i] = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }

            }

            
            totalRevenue = Nr[1] * 5 + Nr[0] * 5 + Nr[2] * 8;
            DG_Revenue.Rows.Add("Torch", Nr[0], Nr[0] * 5);
            DG_Revenue.Rows.Add("USB Cable", Nr[1], Nr[1] * 5);
            DG_Revenue.Rows.Add("PowerBank", Nr[2], Nr[2] * 8);
            LblRevenue.Text = totalRevenue.ToString() + " €";

        }
        private void GetListOfLoanedItems()
        {
            DataSet ds = new DataSet();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                string query = "Select loaned_id as 'Record ID', t.account_id as 'Account Id', " +
                               "if(a.type = 'usb', 'USB Cable', if(a.type = 'torch','Torch','Power Bank')) as 'Item Type', " +
                               "if(l.article_status='loaned', 'Not Returned','Returned') as 'Item Status' " +
                               "From articles a join loaned l On (a.article_nr = l.article_nr) Join transactions t on ( l.transaction_id = t.transaction_id ) " +
                               "ORDER By 1 ";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                {
                    da.FillSchema(ds, schemaType: SchemaType.Source);
                    da.Fill(ds);
                }
            }

            DG_LoanedArticels.DataSource = ds;
            DG_LoanedArticels.DataMember = ds.Tables[0].TableName;

            Revenue();
        }
        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            int result;
            if (SelectionChecking())
            {
                DataGridViewSelectedRowCollection dr = this.DG_LoanedArticels.SelectedRows;
                for (int i = 0; i < dr.Count; i++)
                {
                    int recordNr = Convert.ToInt32(DG_LoanedArticels.SelectedRows[i].Cells[0].Value);
                    using (MySqlConnection con = new MySqlConnection(cs))
                    {
                        con.Open();
                        string query = "Update loaned set article_status = 'returned' where loaned_id = @recordId";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@recordId", recordNr);
                            result = cmd.ExecuteNonQuery();
                        }
                    }

                    if (result == 1)
                    {
                        DG_LoanedArticels.SelectedRows[i].Cells[3].Value = "Returned";
                    }
                }                                
            }
        }
        private int[] NumberOfBorrowedItems(int id)
        {
            int[] Nr = new int[3];
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                for (int i = 0; i < 3; i++)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        string query1 = "Select Count(*)" +
                                        "From loaned l join articles a on (l.article_nr = a.article_nr) Join transactions t on ( l.transaction_id = t.transaction_id )" +
                                        $"Where a.article_nr = @type and account_id = {id} ";
                        cmd.CommandText = query1;
                        cmd.Parameters.AddWithValue("@type",i+1);
                        Nr[i] = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }

            }

            return Nr;
        }

        private int MakeNewLoanRecord(int accountId,int type)
        {
            int NrchangedRecord;
            decimal price;
            string Itemtype;
            price = (type == 0 || type == 1) ? 5 : 8;
            Itemtype = (type == 0) ? "USB Cable" : (type == 1) ? "Torch" : "Powerbank";

            if (dh.CurrentBalance(accountId) - price < 0)
            {
                MessageBox.Show($"Account Id {accountId} does not have enough balance!\n" +
                                $"More {price - dh.CurrentBalance(accountId)} € is needed.");
                return -1;
            }
            else
            {
                //Show a brief balance and recipt info and then ask for confirmation
                var result = MessageBox.Show(
                    $"Current Account Balance {dh.CurrentBalance(accountId)} €. " +
                    $"The fee of this item is {price}\n" +
                    $"After payment, the remianing balance would be {dh.CurrentBalance(accountId) - price} €\n" +
                    $"Do you want to proceed this payment?", $"Ask for permission", MessageBoxButtons.YesNo
                    );
                //Create a new record in transaction Table
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(cs))
                    {
                        con.Open();
                        MySqlTransaction trans = con.BeginTransaction();
                        int transactionId = -1;
                        string date = DateTime.Now.ToString("yyyy-MM-dd");
                        string time = DateTime.Now.ToString("HH:mm:ss");
                        string query = $"Insert Into transactions (`date`, `time`,`account_id`, `amount`, `current_balance`, `type`) VALUES " +
                                       $"('{date}','{time}', {accountId}, {price}, {dh.CurrentBalance(accountId) - price}, 'loan')";
                        using (MySqlCommand cmd = new MySqlCommand(query, con,trans))
                        {
                            try
                            {
                                NrchangedRecord = cmd.ExecuteNonQuery();
                                if (NrchangedRecord > 0)
                                {   
                                    
                                    //Retrieve the last transaction Id and Record It 
                                    cmd.CommandText = "Select Max(transaction_id) From transactions where time is not null";
                                    transactionId = Convert.ToInt32(cmd.ExecuteScalar());

                                    cmd.CommandText = "Select Max(loaned_id) From loaned";
                                    int recordId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                                    //Insert a new record in loaned entity upon new loaned Item
                                    cmd.CommandText =
                                        "INSERT INTO `loaned`(`loaned_id`, `article_nr`, `transaction_id`, `article_status`) " +
                                        "VALUES (@loanID, @articleNr, @transactionId, @articleStatus)";
                                    cmd.Parameters.AddWithValue("@loanID", recordId);
                                    cmd.Parameters.AddWithValue("@articleNr", type + 1);
                                    cmd.Parameters.AddWithValue("@transactionId",transactionId);
                                    cmd.Parameters.AddWithValue("@articleStatus", "loaned");
                                    NrchangedRecord = cmd.ExecuteNonQuery();

                                    if (NrchangedRecord > 0)
                                    {
                                        //Update the new Balance of account of following purchases.
                                        cmd.CommandText = $"Update accounts set currentbal ='{dh.CurrentBalance(accountId) - price}' where account_id = {accountId}";
                                        NrchangedRecord = cmd.ExecuteNonQuery();
                                        if (NrchangedRecord > 0)
                                        {
                                            trans.Commit();
                                            return recordId;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                trans.Rollback();
                                MessageBox.Show($"{ex.Message}");
                                return -1;
                            }
                            
                        }

                        
                    }
                }

                return -1;
            }
        }
        #endregion
        

        private void btnLendItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLendItem_Click_1(object sender, EventArgs e)
        {

        }

        

        private bool SelectionChecking()
        {
            if (DG_LoanedArticels.SelectedRows.Count == 1)
            {
                
                ReturnStatus = DG_LoanedArticels.SelectedRows[0].Cells[3].Value.ToString();

                    if (ReturnStatus == "Not Returned")
                    {
                        return true;
                    }
                    else if (ReturnStatus == "Returned")
                    {
                        MessageBox.Show("This Item has been already returned!");
                        return false;
                    }

                    return false;
                

            }else if (DG_LoanedArticels.SelectedRows.Count > 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select at least One record from Loaned Items section");
                return false;
            }
        }

        private void btnLendItem_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnLendItem.Enabled)
            {
                accountId = -1;
                btnLendItem.BackColor = Color.DimGray;
                btnLendItem.ForeColor = Color.White;
                Cb_powerbank.Enabled = false;
                Cb_cable.Enabled = false;
                Cb_torch.Enabled = false;
            }
            else
            {
                
                btnLendItem.BackColor = Color.Green;
                btnLendItem.ForeColor = Color.White;
                Cb_powerbank.Enabled = true;
                Cb_cable.Enabled = true;
                Cb_torch.Enabled = true;
            }
        }

        private void AddToDataGrid(int recordId, int accountid, string type)
        {
            DataRow dr = ((DataSet)DG_LoanedArticels.DataSource).Tables[0].NewRow();
            dr[0] = recordId;
            dr[1] = accountid;
            dr[2] = type;
            dr[3] = "Not Returned";
            ((DataSet)DG_LoanedArticels.DataSource).Tables[0].Rows.Add(dr);
            if (type == "USB Cable")
            {
                DG_Revenue.Rows[1].Cells[1].Value = ((int)DG_Revenue.Rows[1].Cells[1].Value) + 1;
                DG_Revenue.Rows[1].Cells[2].Value = ((int)DG_Revenue.Rows[1].Cells[2].Value) + 5;
                totalRevenue += 5;
            }
            else if (type == "Torch")
            {
                DG_Revenue.Rows[0].Cells[1].Value = ((int)DG_Revenue.Rows[0].Cells[1].Value)+1;
                DG_Revenue.Rows[0].Cells[2].Value = ((int)DG_Revenue.Rows[0].Cells[2].Value) + 5;
                totalRevenue += 5;
            }
            else
            {
                DG_Revenue.Rows[2].Cells[1].Value = ((int)DG_Revenue.Rows[2].Cells[1].Value) + 1;
                DG_Revenue.Rows[2].Cells[2].Value = ((int)DG_Revenue.Rows[2].Cells[2].Value) + 8;
                totalRevenue += 8;
            }
            LblRevenue.Text = totalRevenue.ToString() + " €";
        }
        private void btnLendItem_Click_2(object sender, EventArgs e)
        {
            int number = dh.NrOfMembersInAGroup(accountId);
            var NrborrowedItems = NumberOfBorrowedItems(accountId);
            if (dh.CheckInStatus(userId))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0 && Cb_cable.Checked)
                    {
                        if (NrborrowedItems[i] < number)
                        {
                            int r = MakeNewLoanRecord(accountId, 0);
                            if (r!=-1)
                            {
                                AddToDataGrid(r,accountId,"USB Cable");
                                Cb_cable.Checked = false;
                            }
                        }
                        else
                        {
                            Cb_cable.Checked = false;
                            MessageBox.Show($"You can not borrow more than {number} {((ItemType)(i))} cable(s)", "Threshold Alart");
                        }
                    }
                    else if (i == 1 && Cb_torch.Checked)
                    {
                        if (NrborrowedItems[i] < number)
                        {
                            int r = MakeNewLoanRecord(accountId, 1);
                            if (r != -1)
                            {
                                AddToDataGrid(r, accountId, "Torch");
                                Cb_torch.Checked = false;
                            }
                        }
                        else
                        {
                            Cb_torch.Checked = false;
                            MessageBox.Show($"You can not borrow more than {number} {((ItemType)(i))}(s)", "Threshold Alart");
                        }
                    }
                    else if (i == 2 && Cb_powerbank.Checked)
                    {
                        if (NrborrowedItems[i] < number)
                        {
                            int r = MakeNewLoanRecord(accountId, 2);
                            if (r != -1)
                            {
                                AddToDataGrid(r, accountId, "Power Bank");
                                Cb_powerbank.Checked = false;
                            }
                        }
                        else
                        {
                            Cb_powerbank.Checked = false;
                            MessageBox.Show($"You can not borrow more than {number} {((ItemType)(i))}(s)", "Threshold Alart");
                        }
                    }

                    this.Enabled = false;

                }
            }
        }

        private void DG_LoanedArticels_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            LNrRecords.Text =((DataSet)DG_LoanedArticels.DataSource).Tables[0].Rows.Count.ToString();
        }

        private void DG_Revenue_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.GetListOfLoanedItems();
        }
    }
}
