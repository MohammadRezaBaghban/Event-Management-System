using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HHF_APP
{
    class DataHelper
    {
      
            public MySqlConnection connection;
            public DataHelper()
            {
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                "database=dbi400320;" +
                                "user id=dbi400320;" +
                                "Pwd=12345678;" +
                                "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            }


            public int AddEmployee(String fName, String lName, String phoneNr, String position, String street, String postcode)
            {
                String query = "INSERT INTO employees(emp_id, fname, lname, phone_nr, position, street, postcode) VALUES (@empID, @fName, @lName, @phoneNr, @position, @street, @postcode)";
                MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@empID", null);
            command.Parameters.AddWithValue("@fName", fName);
            command.Parameters.AddWithValue("@lName", lName);
            command.Parameters.AddWithValue("@phoneNr", phoneNr);
            command.Parameters.AddWithValue("@position", position);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@postcode", postcode);

                try
                {
                    connection.Open();
                    int nrOfRecordsChanged = command.ExecuteNonQuery();
                    return nrOfRecordsChanged;
                }
                catch(Exception ex)
                {

                    return -1;

                }
            
                finally
                {
                    connection.Close();
                }

            }

        public int RemoveEmployee1(String fName, String lName) /* Not Working ATM */
        {
            String query = "DELETE FROM employees WHERE emp_id IN (SELECT MAX(emp_id) FROM employees) AND fname = @fName AND lname = @lName";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@fName", fName);  
            command.Parameters.AddWithValue("@lName", lName);
 

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {

                return -1;

            }

            finally
            {
                connection.Close();
            }

        }

        public int AddEmployeeCred(String fname, String lname, String email, String password)
        {
            String query = "INSERT INTO emp_cred(emp_id, email, password) VALUES ((SELECT emp_id FROM employees WHERE fname = @fname AND lname = @lname), @email, @password)";
   
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@lname", lname);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
            
            public int CountVisitors()
            {
                String query = "SELECT COUNT(*) FROM users WHERE status = 'checked_in'";
                MySqlCommand command = new MySqlCommand(query, connection);
                int number;
                 try
                 {
                    connection.Open();
                    number = Convert.ToInt32(command.ExecuteScalar());
                    return number;
                 }
                 catch
                 {
                     return -1;
                 }
                 finally
                 {
                     connection.Close();
                 }
            }

        public int CountTickts()
        {
            String query = "SELECT COUNT(*) FROM tickets";
            MySqlCommand command = new MySqlCommand(query, connection);
            int number;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int TotalSpent()
        {
            String query = "SELECT SUM(amount) FROM transactions";
            MySqlCommand command = new MySqlCommand(query, connection);
            int number;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int TotalBalance()
        {
            String query = "SELECT SUM(initial_balance) FROM accounts";
            MySqlCommand command = new MySqlCommand(query, connection);
            int number;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int TotalVisitors()
        {
            String query = "SELECT COUNT(*) FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            int number;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int CampSpotsBooked()
        {
            String query = "SELECT COUNT(*) FROM camp_spots WHERE is_reserved = 1";
            MySqlCommand command = new MySqlCommand(query, connection);
            int number;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        //Function for login 
        public bool appLogin(string email, string password)
        {
            //Count because the number of records for succesfull login should be q as there is only one user with such records
            string joinQuery = "SELECT COUNT(*) as cnt FROM employees WHERE email=@email AND password =@password";

            MySqlCommand command = new MySqlCommand(joinQuery, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            try
            {
                connection.Open();

                if (command.ExecuteScalar().ToString() == "1")
                {
                    return true;
                }
                else { return false; }
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //Function for finding the User and his Tickets

        public string holderName; public int actId,ticketId;
        public bool checkTicket(int user_id)
        {
            string query = "SELECT usr.fname , usr.lname , usr.account_id ,t.ticket_id FROM users AS usr JOIN tickets AS t on usr.user_id=t.user_id  where usr.user_id=@user_id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                bool temp=false;
                while (reader.Read())
                {
                    this.holderName = Convert.ToString(reader["fname"]);
                    this.holderName += " " + reader["lname"].ToString();
                    this.actId = Convert.ToInt32(reader["account_id"]);
                    this.ticketId = Convert.ToInt32(reader["ticket_id"]);
                    temp = true;
                }

                if (temp==false)
                {
                    return false;
                }
                else { return true; }

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //Function for checking in users
        public int checkIn(int user_id)
        {
            string check_in_query = "UPDATE users SET status='checked_in'  where user_id=@user_id";
            MySqlCommand command = new MySqlCommand(check_in_query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);
            
            try
            {
                connection.Open();
                int checkedRecords = command.ExecuteNonQuery();
                return checkedRecords;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        //Function for checking if users are already checkd in
        public int checkedIn(int user_id)
        {
            string check_in_query = "SELECT status FROM users WHERE user_id=@user_id and status='checked_in'";
            MySqlCommand command = new MySqlCommand(check_in_query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                int checkedRecords = command.ExecuteNonQuery();
                return checkedRecords;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }


        public int ticketBalance, ticketRefund;
        public string ticketStatus,ticketType;
        public bool checkInOutInfo(int user_id)
        {
            string query =
                "SELECT tr.type,a.is_valid,tr.current_balance FROM accounts AS a  JOIN users AS usr ON a.account_id=usr.account_id JOIN transactions AS tr ON tr.account_id=a.account_id where usr.user_id =@user_id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                bool temp = false;
                while (reader.Read())
                {
                    this.ticketType = Convert.ToString(reader["type"]);
                    this.ticketStatus = Convert.ToString(reader["is_valid"]);
                    this.ticketBalance = Convert.ToInt32(reader["current_balance"]);
                    this.ticketRefund = Convert.ToInt32(reader["current_balance"]);
                    temp= true;
                }

                if (temp == false)
                {
                    return false;
                }
                else { return true; }

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

    }

}
