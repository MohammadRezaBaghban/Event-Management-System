using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HHF_APP
{
    class DataHelper
    {

        public MySqlConnection connection;
        public static String connectionInfo;
        private Article art;
        public DataHelper()
        {
           
            connectionInfo = ConfigurationManager.ConnectionStrings["myPhpAdmin"].ConnectionString;

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

        public int ChangePassword(String index, String password)
        {
          

            String query = "UPDATE employees SET password = @password WHERE emp_id = @emp_id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@emp_id", index);

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

        public int DeleteEmployee(String id)
        {
            String query = "DELETE FROM employees WHERE emp_id = @emp_id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@emp_id", id);

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

        //Function for login 

        public bool appLogin(string email, string password)
        {
            //Count because the number of records for succesfull login should be q as there is only one user with such records
            //string joinQuery = "SELECT COUNT(*) as cnt , position FROM employees WHERE email=@email AND password =@password";
            string joinQuery = $"SELECT COUNT(*) as cnt FROM employees WHERE email='{email}' AND password ='{password}'";
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



        public Person checkTicket(int user_id)
        {
            string query = "SELECT usr.group_id,usr.fname , usr.lname , usr.account_id ,t.ticket_id,ac.is_valid,usr.is_vip, usr.status, ac.currentbal FROM users AS usr JOIN tickets AS t on usr.user_id = t.user_id JOIN accounts AS ac ON usr.account_id = ac.account_id where usr.user_id = @user_id and usr.account_id = ac.account_id";
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
                    temp =
                        new Person(
                            user_id, Convert.ToString(reader["group_id"]), Convert.ToString(reader["fname"]),
                            Convert.ToString(reader["lname"]), Convert.ToInt32(reader["account_id"]),
                            Convert.ToInt32(reader["ticket_id"]), Convert.ToDecimal(reader["currentbal"]),
                            Convert.ToString(reader["status"]),Convert.ToString(reader["is_valid"]),
                            Convert.ToString(reader["is_vip"]));
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
        private string status="";
        public string checkedIn(int user_id)
        {
            string check_in_query = "SELECT status FROM users WHERE user_id=@user_id";
            MySqlCommand command = new MySqlCommand(check_in_query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    status = Convert.ToString(reader["status"]);
                }
                return status;
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
        /// </summary>

        public decimal ticketBalance; public string visitorStatus;
        public bool checkInOutInfo(int user_id)
        {
            string query =
                "SELECT a.currentbal, usr.status FROM accounts AS a  JOIN users AS usr ON a.account_id=usr.account_id JOIN transactions AS tr ON tr.account_id=a.account_id where usr.user_id =@user_id";
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
                    this.ticketBalance = Convert.ToDecimal(reader["currentbal"]);
                    this.visitorStatus = Convert.ToString(reader["status"]);
                    temp = true;
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





        public int addTransaction(int userid, decimal amount, string type)
        {
            int act_id = -1;
            decimal balance = 0.0m;

            using (connection)
            {
                if (connection.State.ToString() != "Open")
                {
                connection.Open();
                }
                
               
                MySqlTransaction tran = connection.BeginTransaction();

                try
                {
                    String query;
                    MySqlCommand command;
                    MySqlDataReader reader;
                    if (type == "deposit")
                    {
                        //get act id of that person
                        query = "SELECT account_id FROM users WHERE user_id = @idNr";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idNr", userid);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            act_id = Convert.ToInt32(reader["account_id"]);
                        }
                        reader.Close();
                        if (act_id == -1)
                        {
                            throw new System.Exception("the User does not exists");
                        }
                        
                    }
                    else
                    {
                        //get act id of that person
                    
                        query = "SELECT users.account_id FROM users, accounts WHERE users.account_id = accounts.account_id and users.user_id = @idNr and users.status= @status and accounts.is_valid='yes'";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idNr", userid);
                        command.Parameters.AddWithValue("@status", "checked_in");
                         reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            act_id = Convert.ToInt32(reader["account_id"]);
                        }
                        reader.Close();
                        if (act_id == -1)
                        {
                            throw new System.Exception("Either the person is not checked in  or the account is no longer valid");
                        }
                        
                    }


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

                    if (type == "deposit")
                    {
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
                        command.Parameters.AddWithValue("@current_balance", balance + amount);
                        command.Parameters.AddWithValue("@type", type);


                        int nrOfRecordsChanged = command.ExecuteNonQuery();
                        reader.Close();
                        //if the compiler reachs here that means every thing went fine and now we have to update the current balance

                        query = "UPDATE accounts SET currentbal = @bal WHERE account_id = @id";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@bal", balance + amount);
                        command.Parameters.AddWithValue("@id", act_id);


                        
                        if (Convert.ToInt32(command.ExecuteNonQuery()) <= 0)
                        {
                            reader.Close();
                            throw new Exception("Error While Updating the balance");
                        }
                        reader.Close();
                    }
                    else
                    {
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
                        reader.Close();
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
                       throw new Exception(exRollback.Message);
                    }

                    throw new Exception(ex.Message);
                }
            }
        }
        public List<Person> getGroupMembers(int user_id)
        {
            string sql = "Select * FROM users where group_id = (SELECT group_id from users where user_id=@user_id)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Person> tempList = new List<Person>();
                while (reader.Read())
                {
                    tempList.Add(new Person(Convert.ToString(reader["fname"]),
                        Convert.ToString(reader["lname"]), Convert.ToString(reader["group_id"])));
                }
                if (tempList != null)
                {
                    return tempList;
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

        public int RefundCloseAccount(int user_id)
        {
            int checkedRecords=0;
            string query = "Select is_admin from users where user_id=@user_id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {

                    if (reader["is_admin"].ToString() == "yes")
                    {
                        checkedRecords = 1;
                    }
                    else if(reader["is_admin"].ToString() == "no")
                    {
                        checkedRecords = 0;
                    }
                }
                connection.Close();
              
            }
            catch
            {
               
            }

            if (checkedRecords==1) {
                addTransaction(user_id, ticketBalance, "refund");
                query = "UPDATE users, accounts  SET users.status ='check_out', accounts.is_valid ='no'  WHERE users.account_id = accounts.account_id AND users.user_id=@user_id AND users.status='checked_in'";
                command = new MySqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@user_id", user_id);

                try
                {
                    connection.Open();
                    checkedRecords = command.ExecuteNonQuery();
                   
                    return checkedRecords;
                }
                catch(Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                query = "UPDATE users SET users.status ='check_out' WHERE users.user_id=@user_id AND users.status='checked_in'";
                command = new MySqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@user_id", user_id);

                try
                {
                    connection.Open();
                    checkedRecords = command.ExecuteNonQuery();
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


        }

        public List<ReturnLoaned> getLoanedArticles(int user_id)
        {
            string sql = "Select art.type,lo.article_status,lo.article_nr,lo.transaction_id,lo.loaned_id FROM articles AS art JOIN loaned AS lo on art.article_nr=lo.article_nr JOIN transactions as tr on tr.transaction_id = lo.transaction_id JOIN accounts as a on tr.account_id=a.account_id JOIN users as usr on a.account_id=usr.account_id where usr.user_id=@user_id AND tr.type='loan'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<ReturnLoaned> tempList = new List<ReturnLoaned>();
                while (reader.Read())
                {

                    tempList.Add(new ReturnLoaned(Convert.ToInt32(reader["loaned_id"])
                        , Convert.ToInt32(reader["transaction_id"]) , Convert.ToInt32(reader["article_nr"])
                        , Convert.ToString(reader["article_status"]), Convert.ToString(reader["type"])
                        ));
                }
                return tempList;
                
               
              
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

        public int ReturnLoanedMaterials(ReturnLoaned rl)
        {
            string query = "UPDATE loaned SET loaned.article_status='returned' WHERE loaned.loaned_id = @rl";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@rl", rl.getLoanedId);

            try
            {
                connection.Open();
                int checkedRecords = command.ExecuteNonQuery();
                return checkedRecords;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        
       
        public List<Transactions> getAllTransactions(int user_id)
        {
            string sql = "SELECT tr.transaction_id,tr.amount,tr.type,tr.date,tr.time FROM transactions as tr JOIN accounts as a on tr.account_id=a.account_id JOIN users as usr on a.account_id=usr.account_id where usr.user_id=@user_id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Transactions> tempList = new List<Transactions>();
                while (reader.Read())
                {

                    tempList.Add(new Transactions(
                        Convert.ToInt32(reader["transaction_id"]), 
                        Convert.ToInt32(reader["amount"]),
                        Convert.ToString(reader["type"]),
                        Convert.ToString(reader["date"]),
                        Convert.ToString(reader["time"])));
                }
                if (tempList != null)
                {
                    return tempList;
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

            return null;
        }

        public decimal CurrentBalance(int accountId)
        {
            decimal temp;
            using (MySqlConnection con = new MySqlConnection(connectionInfo))
            {
                string query = $"Select currentbal " +
                               $"From accounts " +
                               $"Where account_id = {accountId};";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    temp = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            return temp;
        }
        public bool CheckCampReservation(int accountId)
        {
            string query = $"Select Count(*) " +
                           $"From camp_reservation " +
                           $"Where account_id = '{accountId}';";
            int temp = -100000000;
            using (MySqlConnection con = new MySqlConnection(DataHelper.connectionInfo))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    temp = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            if (temp==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int NrOfMembersInAGroup(int accountid)
        {
            int result = -1;
            using (MySqlConnection con = new MySqlConnection(connectionInfo))
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

        public string BankAccountNr(int i)
        {
            string result = "";
            using (MySqlConnection con = new MySqlConnection(connectionInfo))
            {
                string query = "Select bank_act_nr " +
                               "From accounts " +
                               $"Where account_id={i};";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    result = cmd.ExecuteScalar().ToString();
                }
            }

            return result;
        }
        public bool CheckInStatus(int account_id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionInfo))
            {
                string result = " ";               
                con.Open();
                string query = $"Select status From users where account_id = {account_id} ";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                   
                    result = cmd.ExecuteScalar().ToString();
                    
                }
                if (result == "checked_in")
                {
                    return true;
                }
                else
                {
                    if (result == "check_out")
                    {
                        MessageBox.Show($"This account has already checked-out from the event!\nYou can not perform any tasks related to this account", "Check Out Done");
                    }
                    else
                    {
                        MessageBox.Show($"This account has not been checked-in in the event!\nPlease Check In in \"Check In\\Out Section\"", "Check In Needed");
                    }
                    return false;
                }
            }
        }

               //Graph part methods start
        public int GenArt1()
        {
            String query = "SELECT COUNT(*) FROM loaned WHERE article_nr = 1";
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
        public int GenArt2()
        {
            String query = "SELECT COUNT(*) FROM loaned WHERE article_nr = 2";
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
        public int GenArt3()
        {
            String query = "SELECT COUNT(*) FROM loaned WHERE article_nr = 3";
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

        public int GetCampNormal()
        {
            String query = "SELECT COUNT(*) FROM camp_spots WHERE is_vip = 'no'";
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

        public int GetCampVIP()
        {
            String query = "SELECT COUNT(*) FROM camp_spots WHERE is_vip = 'yes'";
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

        public int GetReservedNormal()
        {
            String query = "SELECT COUNT(*) FROM camp_spots WHERE is_vip = 'no' AND is_reserved = 'yes'";
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

        public int GetReservedVIP()
        {
            String query = "SELECT COUNT(*) FROM camp_spots WHERE is_vip = 'yes' AND is_reserved = 'yes'";
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

        public int GetSpentAmount1()
        {
            String query = "SELECT SUM(amount) FROM transactions WHERE type = 'food'";
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

        public int GetSpentAmount2()
        {
            String query = "SELECT SUM(amount) FROM transactions WHERE type = 'registration'";
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

        public int GetSpentAmount3()
        {
            String query = "SELECT SUM(amount) FROM transactions WHERE type = 'deposit'";
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
        public int GetSpentAmount4()
        {
            String query = "SELECT SUM(amount) FROM transactions WHERE type = 'items'";
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

        public int GetSpentAmount5()
        {
            String query = "SELECT SUM(amount) FROM transactions WHERE type = 'loan'";
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
        public int GetSpentAmount6()
        {
            String query = "SELECT SUM(amount) FROM transactions WHERE type = 'camp'";
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
        }//Graph part methods finish


    }
}
