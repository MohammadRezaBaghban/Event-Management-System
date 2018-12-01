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
                                "database=dbi378474;" +
                                "user id=dbi378474;" +
                                "Pwd=123456789;" +
                                "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            }


            public int AddEmployee(String fName, String lName, String password)
            {
                String query = "INSERT INTO employees VALUES (@fName, @lName, @password)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fName", fName);
                command.Parameters.AddWithValue("@lName", lName);
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
    }
}
