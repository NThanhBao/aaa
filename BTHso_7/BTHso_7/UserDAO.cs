using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTHso_7
{
    public class UserDAO
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public bool CheckUser(String username)
        {
            string sql = @"SELECT COUNT(*) FROM UserInfo WHERE UserName = @usn";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@usn", username);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return (count >= 1);
            }
        }
        public bool Insert(User user)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO UserInfo (UserName,PassWord,FirstName,LastName,Email,Gender,Address) 
                                        VALUES(@username,@password,@firstname,@lastname,@email,@gender,@address) ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.PassWord);
                cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                cmd.Parameters.AddWithValue("@lastname", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@address", user.Address);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool Delete(string username)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM UserInfo WHERE UserName = @username";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return (result >= 1);
            }   
        }
            public DataTable GetAllUsers()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM UserInfo";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                return dt;
            }
    }
}