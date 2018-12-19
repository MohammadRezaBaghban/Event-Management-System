﻿using System;
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
            string joinQuery = "SELECT COUNT(*) as cnt FROM employees WHERE email=@email AND password =@password";
            //string join1Query = $"SELECT COUNT(*) as cnt FROM employees WHERE email='{email}' AND password ='{password}'";
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
            string query =
                "SELECT usr.group_id,usr.fname , usr.lname , usr.account_id ,t.ticket_id,ac.is_valid,usr.is_vip, ac.currentbal FROM users AS usr JOIN tickets AS t on usr.user_id=t.user_id,accounts ac  where usr.user_id=@user_id and usr.account_id= ac.account_id";
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
                            Convert.ToString(reader["is_valid"]), Convert.ToString(reader["is_vip"]));
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
        public bool checkInOutInfo(int user_id)
        {
            string query =
                "SELECT tr.current_balance FROM accounts AS a  JOIN users AS usr ON a.account_id=usr.account_id JOIN transactions AS tr ON tr.account_id=a.account_id where usr.user_id =@user_id";
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
                    this.ticketBalance = Convert.ToInt32(reader["current_balance"]);
                    this.ticketRefund = Convert.ToInt32(reader["current_balance"]);
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
                connection.Open();
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
                        if (act_id == -1)
                        {
                            throw new System.Exception("Either the person is not checked or User does not exists");
                        }
                        reader.Close();
                    }
                    else
                    {
                        //get act id of that person
                    
                        query = "SELECT account_id FROM users WHERE user_id = @idNr and status= @status";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idNr", userid);
                        command.Parameters.AddWithValue("@status", "checked_in");
                         reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            act_id = Convert.ToInt32(reader["account_id"]);
                        }
                        if (act_id == -1)
                        {
                            throw new System.Exception("Either the person is not checked or User does not exists");
                        }
                        reader.Close();
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


                        command.ExecuteNonQuery();
                        if (Convert.ToInt32(command.ExecuteNonQuery()) <= 0)
                        {
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

        public List<Article> getLoanedArticles(int user_id)
        {
            string sql = "Select art.type,lo.article_status,lo.article_nr FROM articles AS art JOIN loaned AS lo on art.article_nr=lo.article_nr JOIN transactions as tr on tr.transaction_id = lo.transaction_id JOIN accounts as a on tr.account_id=a.account_id JOIN users as usr on a.account_id=usr.account_id where usr.user_id=@user_id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Article> tempList = new List<Article>();
                while (reader.Read())
                {

                    tempList.Add(new Article(Convert.ToString(reader["type"])
                        , Convert.ToString(reader["article_status"]) , Convert.ToInt32(reader["article_nr"])));
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

        public int ReturnLoanedMaterials(int user_id, int articled_nr)
        {
            string query = "UPDATE loaned SET loaned.article_status='returned' WHERE loaned.transaction_id = (SELECT tr.transaction_id FROM transactions as tr JOIN accounts as a on tr.account_id=a.account_id JOIN users as usr ON a.account_id=usr.account_id WHERE usr.user_id=@user_id) AND loaned.article_nr=@article_nr";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@article_nr", articled_nr);

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
        public List<Transactions> getAllTransactions(int user_id)
        {
            string sql = "SELECT tr.transaction_id,tr.type,tr.amount,tr.date,tr.time FROM transactions as tr JOIN accounts as a on tr.account_id=a.account_id JOIN users as usr on a.account_id=usr.account_id where usr.user_id=@user_id";
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

                    tempList.Add(new Transactions(Convert.ToInt32(reader["transaction_id"]), 
                        Convert.ToInt32(reader["amount"]), Convert.ToString(reader["type"]),
                        Convert.ToString(reader["date"]),Convert.ToString(reader["time"])));
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
    }
}
