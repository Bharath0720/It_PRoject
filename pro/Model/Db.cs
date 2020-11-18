using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DbDemo.Models
{
    public class Db
    {
        public static string connectionString = "data source=localhost; Initial Catalog = DBProject ;Integrated Security = true";

        public static int signUpStd(String Id, String name, String fname,Char gender,String password,String cnic,String city,int disc,String birthday,String mobile)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command;
            int data = 0;

            try
            {
                command = new SqlCommand("spStdSignup", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 20).Value = name;
                command.Parameters.Add("@cnic", SqlDbType.NVarChar, 19).Value = cnic;
                command.Parameters.Add("@stdId", SqlDbType.Int ).Value = Id;
                command.Parameters.Add("fatherName", SqlDbType.NVarChar, 25).Value = fname;
                command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = birthday;
                command.Parameters.Add("@discipline", SqlDbType.Int).Value = disc;
                command.Parameters.Add("@gender", SqlDbType.Char).Value = gender;
                command.Parameters.Add("@mobile", SqlDbType.NVarChar, 12).Value = mobile;
                command.Parameters.Add("@city", SqlDbType.NVarChar, 10).Value = city;
                command.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password;
                
                command.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                
                command.ExecuteNonQuery();

                data = Convert.ToInt32(command.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                data = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                connection.Close();
            }
            return data;

        }

        public static int signUpTeach(String courseId, int Id, String name, String fname, Char gender, String password, String cnic, String city, int disc, String birthday, String mobile, String email)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command;
            int data = 0;

            try
            {
                command = new SqlCommand("spTeacherSignup", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@courseId", SqlDbType.NVarChar, 20).Value = courseId;
                command.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = name;
                command.Parameters.Add("@cnic", SqlDbType.NVarChar, 19).Value = cnic;
                command.Parameters.Add("@teacherId", SqlDbType.Int).Value = Id;
                command.Parameters.Add("fatherName", SqlDbType.NVarChar, 25).Value = fname;
                command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = birthday;
                command.Parameters.Add("@discipline", SqlDbType.Int).Value = disc;
                command.Parameters.Add("@gender", SqlDbType.Char).Value = gender;
                command.Parameters.Add("@mobile", SqlDbType.NVarChar, 12).Value = mobile;
                command.Parameters.Add("@city", SqlDbType.NVarChar, 10).Value = city;
                command.Parameters.Add("@password", SqlDbType.NVarChar, 20).Value = password;
                command.Parameters.Add("@email", SqlDbType.NVarChar, 25).Value = email;
                command.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;


                command.ExecuteNonQuery();

                data = Convert.ToInt32(command.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                data = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                connection.Close();
            }
            return data;

        }

        public static int userLogin(int userId,String password)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command;
            int data = 0;

            try
            {
                command = new SqlCommand("spUserLogin", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@password", SqlDbType.NVarChar, 20).Value = password;
                
                command.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;


                command.ExecuteNonQuery();

                data = Convert.ToInt32(command.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                data = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                connection.Close();
            }
            return data;

        }
    }
}