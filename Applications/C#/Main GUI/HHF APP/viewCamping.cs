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
        public viewCamping()
        {
            InitializeComponent();
            cs = DataHelper.connectionInfo;
        }

        private void viewCamping_Load(object sender, EventArgs e)
        {
           
        }

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
                dt2 = OccupiedCampingSpots();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

            DG_AvailableSpots.DataSource = dt1;
            DG_AvailableSpots.DataMember = dt1.TableName;
            DG_ReservedSpots.DataSource = dt2;
            DG_ReservedSpots.DataMember = dt2.TableName;
            LAvailableSpot.Text = $"{dt1.Rows.Count}";

        }

        //Retrieve the data of Available camping spot
        public DataTable AvailableCampingSpots()
        {
            string query = "Select spot_nr as 'Spot Number',if(is_vip='no','Regular','Vip') as 'Camp Type'" +
                           " From camp_spots" +
                           $" Where is_reserved = 'no'";
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

        public DataTable OccupiedCampingSpots()
        {
            string query =
                "Select r.account_id as 'Account ID', s.spot_nr as 'Spot Number',if (s.is_vip = 'no','Regular','Vip') as 'Camp Type',is_reserved,"
                + " if (r.is_paid = 'yes',' + Already Paid',' - Has Not Paid') as 'Payment Status', if (r.status = 'checked_in', 'Checked In', IF(r.status = 'checked_out', 'Checked Out', '-----') ) as 'Check-in Status'"
                + "From camp_spots s join camp_reservation r On(s.spot_nr = r.spot_nr)"
                + "Where is_reserved = 'yes';";

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

        /*public string NumberOfSpots(string reserved)
        {
            string query = 
            using (MySqlConnection con = new MySqlConnection(DataHelper.connectionInfo))
            {
                using
            }
        }*/


    }
}
