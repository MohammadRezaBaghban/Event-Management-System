using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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


        public int AddEmployee(String fName, String lName, String email, String password, String phoneNr, String position, String street, String postcode)
        {
            String query = "INSERT INTO employees(emp_id, fname, lname, email, password, phone_nr, position, street, postcode) VALUES (@empID, @fName, @lName, @email, @password, @phoneNr, @position, @street, @postcode)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@empID", null);
            command.Parameters.AddWithValue("@fName", fName);
            command.Parameters.AddWithValue("@lName", lName);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public List<Employee> GetEmployees()
        {
            String query = "SELECT emp_id, fname, lname, position FROM employees";
            MySqlCommand command = new MySqlCommand(query, connection);

            List<Employee> temp = new List<Employee>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int idNr;
                String fName;
                String lName;
                String role;
                while (reader.Read())
                {
                    idNr = Convert.ToInt32(reader["emp_id"]);
                    fName = Convert.ToString(reader["fname"]);
                    lName = Convert.ToString(reader["lname"]);
                    role = Convert.ToString(reader["position"]);
                    temp.Add(new Employee(idNr, fName, lName, role));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public List<Employee> GetEmployees(String fname)
        {
            String query = "SELECT emp_id, fname, lname, position FROM employees WHERE fname LIKE @fname";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@fname", fname + "%");

            List<Employee> temp = new List<Employee>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int idNr;
                String fName;
                String lName;
                String role;
                while (reader.Read())
                {
                    idNr = Convert.ToInt32(reader["emp_id"]);
                    fName = Convert.ToString(reader["fname"]);
                    lName = Convert.ToString(reader["lname"]);
                    role = Convert.ToString(reader["position"]);
                    temp.Add(new Employee(idNr, fName, lName, role));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public List<Employee> GetEmployees(int idnr)
        {
            String query = "SELECT emp_id, fname, lname, position FROM employees WHERE emp_id = @idNr";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@idNr", idnr);

            List<Employee> temp = new List<Employee>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int idNr;
                String fName;
                String lName;
                String role;
                while (reader.Read())
                {
                    idNr = Convert.ToInt32(reader["emp_id"]);
                    fName = Convert.ToString(reader["fname"]);
                    lName = Convert.ToString(reader["lname"]);
                    role = Convert.ToString(reader["position"]);
                    temp.Add(new Employee(idNr, fName, lName, role));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public void ChangePassword(String empId, String password)
        {
            String query = "UPDATE employees SET password = @password WHERE emp_id = @emp_id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@emp_id", empId);
        }
    }
            
}
