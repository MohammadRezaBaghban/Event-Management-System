using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


        public int AddEmployee(String fName, String lName, String email, String password, String phoneNr,
            String position, String street, String postcode)
        {
            String query =
                "INSERT INTO employees(emp_id, fname, lname, email, password, phone_nr, position, street, postcode) VALUES (@empID, @fName, @lName, @email, @password, @phoneNr, @position, @street, @postcode)";
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
            String query =
                "DELETE FROM employees WHERE emp_id IN (SELECT MAX(emp_id) FROM employees) AND fname = @fName AND lname = @lName";
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
                else
                {
                    return false;
                }
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



        public Person checkTicket1(int user_id)
        {
            string query =
                "SELECT usr.fname , usr.lname , usr.account_id ,t.ticket_id, ac.currentbal FROM users AS usr JOIN tickets AS t on usr.user_id=t.user_id,accounts ac  where usr.user_id=@user_id and usr.account_id= ac.account_id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                Person temp = null;
                while (reader.Read())
                {
                    temp = new Person(user_id, Convert.ToString(reader["fname"]), Convert.ToString(reader["lname"]),
                        Convert.ToInt32(reader["account_id"]), Convert.ToInt32(reader["ticket_id"]),
                        Convert.ToDecimal(reader["currentbal"]));
                }

                if (temp != null)
                {
                    return temp;
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                return null;
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

        //Function for checking if users are already checked in
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
        public string ticketStatus, ticketType;

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
                    temp = true;
                }

                if (temp == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
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





        public int addTransaction(int userid, decimal amount, string type)
        {
            int act_id = -1;
            decimal balance = 0.0m;

            using (connection)
            {
                connection.Open();
                MySqlTransaction tran = connection.BeginTransaction();

                try
                {
                    //get act id of that person
                    String query = "SELECT account_id FROM users WHERE user_id = @idNr and status = @status";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idNr", userid);
                    command.Parameters.AddWithValue("@status", "checked_in");

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        act_id = Convert.ToInt32(reader["account_id"]);
                    }

                    if (act_id == -1)
                    {
                        throw new System.Exception("Either the person is not checked or User does not exists");
                    }

                    reader.Close();
                    //get the balance of the account
                    query = "SELECT currentbal FROM accounts WHERE account_id = @idNr";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idNr", act_id);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        balance = Convert.ToDecimal(reader["currentbal"]);
                    }

                    reader.Close();
                    //validate whether the balance is sufficent
                    if (balance - amount < 0 && amount > 0)
                    {
                        throw new Exception("Balance is insufficient");
                    }

                    //create new transaction
                    query =
                        "INSERT INTO transactions (`date`, `time`, `account_id`, `amount`, `current_balance`, `type`) VALUES (@date, @time, @account_id, @amount, @current_balance, @type)";
                    command = new MySqlCommand(query, connection);
                    string s = DateTime.Now.ToString("yyyy-MM-dd");
                    command.Parameters.AddWithValue("@date", s);
                    s = DateTime.Now.ToString("HH:mm:ss");
                    command.Parameters.AddWithValue("@time", s);

                    command.Parameters.AddWithValue("@account_id", act_id);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@current_balance", balance - amount);
                    command.Parameters.AddWithValue("@type", type);


                    int nrOfRecordsChanged = command.ExecuteNonQuery();
                    reader.Close();
                    //if the compiler reachs here that means every thing went fine and now we have to update the current balance

                    query = "UPDATE accounts SET currentbal = @bal WHERE account_id = @id";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bal", balance - amount);
                    command.Parameters.AddWithValue("@id", act_id);


                    command.ExecuteNonQuery();
                    if (Convert.ToInt32(command.ExecuteNonQuery()) <= 0)
                    {
                        throw new Exception("Error While Updating the balance");
                    }

                    tran.Commit();
                    return 1;

                }
                catch (Exception ex)
                {
                    try
                    {
                        tran.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        MessageBox.Show(exRollback.Message);
                    }

                    MessageBox.Show(ex.Message);
                    return -1;


                }
            }
        }
    }
}
