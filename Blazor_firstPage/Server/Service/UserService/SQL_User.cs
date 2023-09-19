using Blazor_firstPage.Server.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Blazor_firstPage.Server.Service.UserService
{
    public class SQL_User
    {
        static string connectionString = "Server=localhost;Database=cleanenergy;User=root;Password=Pimo12345;";

        public static List<User> GetUsers()
        {
            string query = "SELECT * FROM User";

            List<User> users = new List<User>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        // Id is int
                        user.Id = Convert.ToInt32(reader[0]);
                        user.Name = Convert.ToString(reader[1]);
                        user.Email = Convert.ToString(reader[2]);
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public static void AddUser(User user)
        {
            string query = "INSERT INTO Customer (Name, Email) VALUES (@Name, @Email)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@Name", user.Name);
                    sqlCommand.Parameters.AddWithValue("@Email", user.Email);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
