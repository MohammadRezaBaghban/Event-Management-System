//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql;
//using MySql.Data.MySqlClient;
//using System.Windows.Forms;

//namespace Week_1
//{
//    class DataHelper
//    {
//        public MySqlConnection connection;
//        public DataHelper()
//        {
//            String connectionInfo = "Server = studmysql01.fhict.local; " + "user id = dbi400320; " + "database = dbi400320; " + "password = 12345678;" + "sslmode = none";


//            connection = new MySqlConnection(connectionInfo);
//        }

//        public int AddAStudent(int number, string name, int age, int school_yrs, int ecs, string country)
//        {   //Probably you expected a return-value of type bool:
//            //true if the query was executed succesfully and false otherwise.
//            //But what if you executed a delete-query? Or an update-query?
//            //The return-value is teh number of records affected.

//            String sql = "INSERT INTO student VALUES (@number, @name, @age ,@school_yrs,@ecs,@country )";
//            MySqlCommand command = new MySqlCommand(sql, connection);
//            command.Parameters.AddWithValue("@name", name);
//            command.Parameters.AddWithValue("@number", number);
//            command.Parameters.AddWithValue("@ecs", ecs);
//            command.Parameters.AddWithValue("@age", age);
//            command.Parameters.AddWithValue("@school_yrs", school_yrs);
//            command.Parameters.AddWithValue("@country", country);


//            //On internet you also see a solution like:
//            // String sql = "INSERT INTO StudentTable VALUES (" +
//            //     "'" + name + "'," + number  + "," + creditpoints + ")";
//            //Be aware of sql-injection!

//            try
//            {
//                connection.Open();
//                int nrOfRecordsChanged = command.ExecuteNonQuery();
//                return nrOfRecordsChanged;
//            }
//            catch
//            {
//                return -1; //which means the try-block was not executed succesfully, so  . . .
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }
//        public List<person> GetAllStudents()
//        {
//            String sql = "SELECT * FROM student";
//            MySqlCommand command = new MySqlCommand(sql, connection);

//            List<person> tempstudents;
//            tempstudents = new List<person>();

//            try
//            {
//                connection.Open();
//                MySqlDataReader reader = command.ExecuteReader();

//                String name, country;
//                int pcn, age, school_yrs, ecs;
//                while (reader.Read())
//                {
//                    name = Convert.ToString(reader["name"]); country = Convert.ToString(reader["country"]);
//                    pcn = Convert.ToInt32(reader["pcn"]);
//                    age = Convert.ToInt32(reader["age"]);
//                    school_yrs = Convert.ToInt32(reader["school_yrs"]);
//                    ecs = Convert.ToInt32(reader["ecs"]);

//                    tempstudents.Add(new Student(age, name, pcn, school_yrs, country, ecs));
//                }
//            }
//            catch
//            {
//                MessageBox.Show("error while loading the students");
//            }
//            finally
//            {
//                connection.Close();
//            }
//            return tempstudents;
//        }
//        public List<person> GetAllTeachers()
//        {
//            String sql = "SELECT * FROM teacher";
//            MySqlCommand command = new MySqlCommand(sql, connection);

//            List<person> tempteacher;
//            tempteacher = new List<person>();

//            try
//            {
//                connection.Open();
//                MySqlDataReader reader = command.ExecuteReader();

//                String name, Role;

//                int pcn, age, school_yrs;
//                double salary;
//                teacherRole role = teacherRole.junior_teacher;
//                while (reader.Read())
//                {
//                    name = Convert.ToString(reader["name"]);
//                    pcn = Convert.ToInt32(reader["pcn"]);
//                    age = Convert.ToInt32(reader["age"]);
//                    school_yrs = Convert.ToInt32(reader["school_yrs"]);
//                    salary = Convert.ToDouble(reader["salary"]);

//                    Role = (reader["teacher_role"]).ToString();


//                    if (Role == teacherRole.teacher1.ToString())
//                    {
//                        role = teacherRole.teacher1;
//                    }
//                    else if (Role == teacherRole.teacher2.ToString())
//                    { role = teacherRole.teacher2; }
//                    else if (Role == teacherRole.teacher3.ToString())
//                    {
//                        role = teacherRole.teacher3;
//                    }
//                    else if (Role == teacherRole.director.ToString())
//                    {
//                        role = teacherRole.director;
//                    }
//                    else if (Role == teacherRole.coordinator.ToString())
//                    {
//                        role = teacherRole.coordinator;
//                    }
//                    else if (Role == teacherRole.junior_teacher.ToString())
//                    {
//                        role = teacherRole.junior_teacher;
//                    }

//                    tempteacher.Add(new Teacher(age, name, pcn, school_yrs, role, salary));
//                }
//            }
//            catch
//            {
//                MessageBox.Show("error while loading the teachers");
//            }
//            finally
//            {
//                connection.Close();
//            }
//            return tempteacher;
//        }

//        public int AddAteacher(int number, string name, int age, int school_yrs, double salary, teacherRole role)
//        {
//            String sql = "INSERT INTO teacher VALUES (@number, @name, @age ,@school_yrs,@salary,@teacher_role )";
//            MySqlCommand command = new MySqlCommand(sql, connection);
//            command.Parameters.AddWithValue("@name", name);
//            command.Parameters.AddWithValue("@number", number);
//            command.Parameters.AddWithValue("@salary", salary);
//            command.Parameters.AddWithValue("@age", age);
//            command.Parameters.AddWithValue("@school_yrs", school_yrs);
//            command.Parameters.AddWithValue("@teacher_role", role.ToString());



//            try
//            {
//                connection.Open();
//                int nrOfRecordsChanged = command.ExecuteNonQuery();
//                return nrOfRecordsChanged;
//            }

//            catch
//            {
//                return -1;
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }

//        public bool ResetDb()
//        {
//            String sql1 = "DELETE FROM teacher";

//            MySqlCommand command1 = new MySqlCommand(sql1, connection);

//            try
//            {
//                connection.Open();
//                command1.ExecuteNonQuery();

//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//            finally
//            {
//                connection.Close();
//            }

//        }

//    }
//}
