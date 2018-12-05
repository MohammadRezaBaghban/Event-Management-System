using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                catch
                {
              
                    return -1;
               
                }
            
                finally
                {
                    connection.Close();
                }

            }
        public int AddEmployeeCred(String email, String password)
        {
            String idea1 = "(SELECT MAX(emp_id) FROM employees)";
            String query ="INSERT INTO emp_cred VALUES (@empID, @email, @password)";
   
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@empID", idea1);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

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
    }
            
}
