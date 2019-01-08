using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace HHF_APP
{
    public partial class viewCamping : UserControl
    {
        private String cs;
        private string PaymentStatus;
        private string CheckInStatus;
        public int userId;
        private DataHelper dh;
        public viewCamping()
        {
            InitializeComponent();
            cs = DataHelper.connectionInfo;
            dh = new DataHelper();
            
        }

       
        #region SQL Queries

        public DataTable AvailableCampingSpots()
        {
            string query = "Select spot_nr as 'Spot Number',if(is_vip='no','Regular','Vip') as 'Camp Type'" +
                           " From camp_spots" +
                           $" Where is_reserved = 'no' ";
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cs))
            {

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable ReservedCampingSpots()
        {
            string query =
                "Select r.account_id as 'Account ID', s.spot_nr as 'Spot Number',if (s.is_vip = 'no','Regular','Vip') as 'Camp Type',is_reserved,"
                + " if (r.is_paid = 'yes',' + Already Paid',' - Has Not Paid') as 'Payment Status', if (r.status = 'checked_in', 'Checked In', IF(r.status = 'checked_out', 'Checked Out', '-----') ) as 'Check-in Status'"
                + " "
                + "From camp_reservation r join camp_spots s On (s.spot_nr = r.spot_nr) join accounts a on ( r.account_id = a.account_id )"
                + "Where is_reserved = 'yes' ;";

            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }


                }
            }
            
            dt.Columns.Remove("is_reserved");
            return dt;
        }

        public int NrOfSpots(string reserved)
        {
            string query = $"Select Count(*) " +
                           $"From camp_spots " +
                           $"Where is_reserved = '{reserved}';";
            int temp = -100000000;
            using (MySqlConnection con = new MySqlConnection(DataHelper.connectionInfo))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    temp = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return temp;
        }

        public int NrOfMembersInAGroup(int accountid)
        {
            int result = -1;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                string query = "Select Count(*) " +
                               "From users " +
                               $"Where account_id={accountid};";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return result;
        }

        
        public bool MakeCampingPayment(int accountId, decimal price)
        {
            int nreffectedrecords =-1;
            //Check if the account balance
            if (dh.CurrentBalance(accountId) - price < 0)
            {
                MessageBox.Show($"Account Id {accountId} does not have enough balance!\n" +
                                $"More {price - dh.CurrentBalance(accountId)} € is needed.");
            }
            else
            {
                //Show a brief balance and recipt info and then ask for confirmation
                var result = MessageBox.Show(
                    $"Current Account Balance {dh.CurrentBalance(accountId)} €.\n" +
                    $"The fee of camping is {price} € (including 10 € late service fee)\n" +
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
                        string date = DateTime.Now.ToString("yyyy-MM-dd");
                        string time = DateTime.Now.ToString("HH:mm:ss");
                        string query = $"Insert Into transactions (`date`, `time`,`account_id`, `amount`, `current_balance`, `type`) VALUES " +
                                       $"('{date}','{time}', {accountId}, {price}, {dh.CurrentBalance(accountId)-price}, 'camp')";
                        using (MySqlCommand cmd = new MySqlCommand(query, con,trans))
                        {
                            try
                            {
                                nreffectedrecords = cmd.ExecuteNonQuery();
                                if (nreffectedrecords > 0)
                                {
                                    //Update the reservation status of camp spot
                                    cmd.CommandText = $"Update camp_reservation set is_paid ='yes' where account_id = {accountId}";
                                    nreffectedrecords = cmd.ExecuteNonQuery();
                                    if (nreffectedrecords > 0)
                                    {
                                        cmd.CommandText =
                                            $"Update accounts set currentbal ='{dh.CurrentBalance(accountId) - price}' where account_id = {accountId}";
                                        nreffectedrecords = cmd.ExecuteNonQuery();
                                    }
                                    if (nreffectedrecords > 0)
                                    {
                                    trans.Commit();
                                        return true;
                                    }
                            }
                            }
                            catch (Exception ex)
                            {
                                trans.Rollback();
                                MessageBox.Show($"{ex.Message}");
                                return false;
                            }
                            
                        }
                    }
                    
                }

                
            }

            return false;
        }

        public bool CheckInCheckOut(int accountId, string status)
        {
            int result = -1;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                string query = $"Update camp_reservation set status='{status}' Where account_id={accountId}";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteNonQuery());
                }
            }

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        public void LoadAvailable()
        {
            DataTable dt1 = null;
            DataTable dt2 = null;

            try
            {
                dt1 = AvailableCampingSpots();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            try
            {
                dt2 = ReservedCampingSpots();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

            DG_AvailableSpots.DataSource = dt1;
            DG_AvailableSpots.DataMember = dt1.TableName;

            DG_ReservedSpots.DataSource = dt2;
            DG_ReservedSpots.DataMember = dt2.TableName;
            DG_ReservedSpots.Sort(DG_ReservedSpots.Columns[3], ListSortDirection.Ascending);

            LAvailableSpot.Text = $"{NrOfSpots("no")}/{NrOfSpots("yes") + NrOfSpots("no")}";
            LOccupiedSpot.Text = $"{NrOfSpots("yes")}";

        }

        public bool SelectionChecking()
        {
            lblCheckInSts.Text = "    ------";
            LblPaymentSts.Text = "    ------";
            if (DG_ReservedSpots.SelectedRows.Count != 0)
            {
                if (DG_ReservedSpots.SelectedRows.Count > 1)
                {

                    MessageBox.Show("Only 'One' record should be choosed");
                    return false;
                }
                else
                {
                    PaymentStatus = DG_ReservedSpots.SelectedRows[0].Cells[3].Value.ToString();
                    CheckInStatus = DG_ReservedSpots.SelectedRows[0].Cells[4].Value.ToString();

                    if (PaymentStatus == " - Has Not Paid")
                    {
                        LblPaymentSts.Text = "Not Paid";
                        LblPaymentSts.ForeColor = Color.Red;
                    }
                    else if (PaymentStatus == " + Already Paid")
                    {
                        LblPaymentSts.Text = "Already Paid";
                        LblPaymentSts.ForeColor = Color.LimeGreen;
                    }

                    if (CheckInStatus == "Checked In")
                    {
                        lblCheckInSts.Text = "Checked-In";
                        lblCheckInSts.ForeColor = Color.LimeGreen;
                    }
                    else if (CheckInStatus == "Checked Out")
                    {
                        lblCheckInSts.Text = "Checked-Out";
                        lblCheckInSts.ForeColor = Color.DimGray;
                    }
                    else if (CheckInStatus == "-----")
                    {
                        lblCheckInSts.Text = "Not Checked-In";
                        lblCheckInSts.ForeColor = Color.Red;
                    }

                    return true;
                }

            }
            else
            {
                MessageBox.Show("Please select 'Only One' record from Reserved Spot section");
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadAvailable();
            
        }

        private void BtnMakePayment_Click(object sender, EventArgs e)
        {
            if (SelectionChecking())
            {
                int accountId = Convert.ToInt32(DG_ReservedSpots.SelectedRows[0].Cells[0].Value);

                if (dh.CheckInStatus(accountId))
                {
                    if (PaymentStatus == " - Has Not Paid")
                    {
                        bool result = false;
                        int NrMembers = NrOfMembersInAGroup(accountId);
                        if (NrMembers > 1)
                        {
                            decimal price = 10 + NrMembers * 20 + 10 /*Late Payment*/;
                            result = MakeCampingPayment(accountId, price);
                        }
                        else
                        {
                            decimal price = 10 + 120 + 20 + 10;
                            result = MakeCampingPayment(accountId, price);
                        }

                        if (result)
                        {
                            DG_ReservedSpots.SelectedRows[0].Cells[3].Value = " + Already Paid";
                            LblPaymentSts.Text = "Already Paid";
                            LblPaymentSts.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            MessageBox.Show($"Something wrong happened!");
                        }

                    }
                    else if (PaymentStatus == " + Already Paid")
                    {
                        MessageBox.Show("This account has already paid!");
                    }
                }
                
            }
        }

        private void btnCCheckIn_Click(object sender, EventArgs e)
        {
            bool status;
            if (SelectionChecking())
            {
                int accountId = Convert.ToInt32(DG_ReservedSpots.SelectedRows[0].Cells[0].Value);
                if (dh.CheckInStatus(accountId))
                {
                    if (CheckInStatus == "Checked In")
                    {
                        MessageBox.Show("Tenant has has already checked in!");
                    }
                    else if (CheckInStatus == "Checked Out")
                    {
                        MessageBox.Show("Tenant has already checked out!");
                    }
                    else if (CheckInStatus == "-----")
                    {
                        if (PaymentStatus == " - Has Not Paid")
                        {
                            MessageBox.Show("You cannot check in until make the payment!");
                        }
                        else
                        {
                            status = CheckInCheckOut(accountId, "checked_in");
                            if (status)
                            {
                                DG_ReservedSpots.SelectedRows[0].Cells[4].Value = "Checked In";
                                lblCheckInSts.Text = "Checked-In";
                                lblCheckInSts.ForeColor = Color.LimeGreen;
                                
                            }
                            else
                            {
                                MessageBox.Show("Something wrong happened!");
                            }

                        }
                    }
                }
            }
        }

        private void btnCCheckOut_Click(object sender, EventArgs e)
        {
            bool status;
            if (SelectionChecking())
            {
                int accountId = Convert.ToInt32(DG_ReservedSpots.SelectedRows[0].Cells[0].Value);
                if (dh.CheckInStatus(accountId))
                {
                    if (CheckInStatus == "Checked In")
                    {
                        status = CheckInCheckOut(accountId, "checked_out");
                        if (status)
                        {
                            DG_ReservedSpots.SelectedRows[0].Cells[4].Value = "Checked Out";
                            lblCheckInSts.ForeColor = Color.DimGray;
                            lblCheckInSts.Text = "Checked-Out";
                            MessageBox.Show("Tenant checked out successfully!");
                           
                        }
                        else
                        {
                            MessageBox.Show("Something wrong happened!");
                        }

                    }
                    else if (CheckInStatus == "Checked Out")
                    {
                        MessageBox.Show("Tenant has has already checked out!");

                    }
                    else if (CheckInStatus == "-----")
                    {
                        MessageBox.Show("First you need to check-in!");
                    }
                }
            }
        }

        private void DG_ReservedSpots_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectionChecking();
        }
    }
}
