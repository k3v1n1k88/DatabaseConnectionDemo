using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class DatabaseMSSQLConnection: DatabaseConnection
    {
        private SqlConnection createConnection() {
            SqlConnection cnn;
            string connetionString = @"Data Source=AKWOJQZOBE2VFUU\SQLEXPRESS;Initial Catalog=SimpleDatabase;User ID=sa;Password=sa";
            try
            {
                cnn = new SqlConnection(connetionString);
            }
            catch (Exception ex) {
                return null;
            }
            return cnn;
        }
        public SqlDataReader readData()
        {
            SqlConnection cnn = null;
            SqlCommand cmd;
            SqlDataReader reader;
            String sql;
            try
            {
                sql = "Select * from  Student";
                cnn = this.createConnection();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    Student s = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                //    Console.WriteLine("{0} - {1} - {2}", s.Id, s.Name, s.GPA);
                //}
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally{
                if(cnn!=null)
                    cnn.Close();
            }
            //Console.ReadLine();
            return reader;
        }

        public int addMore(Object obj)
        {
            SqlConnection cnn = null;
            SqlCommand cmd;
            try
            {
                if (obj is Student)
                {
                    Student s = (Student)obj;

                    cnn = this.createConnection();
                    cnn.Open();
                    cmd = cnn.CreateCommand();

                    cmd.CommandText = "INSERT INTO Student(id,name,gpa) VALUES(@param1,@param2,@param3)";
                    cmd.Parameters.AddWithValue("@param1", s.Id);  
                    cmd.Parameters.AddWithValue("@param2", s.Name);  
                    cmd.Parameters.AddWithValue("@param3", s.GPA);  

                    return cmd.ExecuteNonQuery();
                }
                else
                    //throw new NotImplementedException();
                    return 0;
            }
            catch (Exception ex) {
                return 0;
            }
        }

        public int update(Object obj)
        {
            SqlConnection cnn = null;
            SqlCommand cmd;
            string sql;
            try
            {
                if (obj is Student)
                {
                    Student s = (Student)obj;
                    //cnn = this.createConnection();
                    //cnn.Open();
                    //sql = "update Student set name = " + s.Name + ", gpa = " + s.GPA + " where id = " + s.Id;
                    //cmd = new SqlCommand(sql, cnn);
                    //return cmd.ExecuteNonQuery();

                    cnn = this.createConnection();
                    cnn.Open();
                    cmd = cnn.CreateCommand();

                    cmd.CommandText = "update Student set name = @name, gpa = @gpa where id = @id;";
                    cmd.Parameters.AddWithValue("@id", s.Id);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@gpa", s.GPA);  

                    return cmd.ExecuteNonQuery();
                }
                else
                    //throw new NotImplementedException();
                    return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int delete(Object obj)
        {
            SqlConnection cnn = null;
            SqlCommand cmd;
            try
            {
                if (obj is Student)
                {
                    Student s = (Student)obj;

                    cnn = this.createConnection();
                    cnn.Open();
                    cmd = cnn.CreateCommand();

                    cmd.CommandText = "delete from Student where id = @id";
                    cmd.Parameters.AddWithValue("@id", s.Id);

                    return cmd.ExecuteNonQuery();
                }
                else
                    //throw new NotImplementedException();
                    return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public List<string> getField()
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
