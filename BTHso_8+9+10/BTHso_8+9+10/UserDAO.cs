using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTHso_8_9_10
{
    public class UserDAO
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        public User GetUserByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT * FROM ursInfo WHERE UserName = @usn";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@usn", username);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User user = new User
                    {
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        Email = (string)reader["Email"],
                        Gender = (Boolean)reader["Gender"],
                        Address = (string)reader["Address"],
                        UserName = (string)reader["UserName"],
                        PassWord = (string)reader["PassWord"]
                    };
                    reader.Close(); // đóng SqlDataReader
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }
        public bool UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE ursInfo
                            SET FirstName = @firstname,
                                LastName = @lastname,
                                Email = @email,
                                Gender = @gender,
                                Address = @address,
                                Password = @password,
                                Avatar = @avatar
                            WHERE UserName = @username";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.PassWord);
                cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                cmd.Parameters.AddWithValue("@lastname", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@avatar", user.AvatarFileName);

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckUser(String username)
        {
            string sql = @"SELECT COUNT(*) FROM ursInfo WHERE UserName = @usn";
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
                string sql = @"INSERT INTO ursInfo (UserName,PassWord,FirstName,LastName,Email,Gender,Address,Avatar) 
                                        VALUES(@username,@password,@firstname,@lastname,@email,@gender,@address,@avatar) ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.PassWord);
                cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                cmd.Parameters.AddWithValue("@lastname", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@avatar", user.AvatarFileName);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Delete(string username)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM ursInfo WHERE UserName = @username";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM ursInfo";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

    }

}