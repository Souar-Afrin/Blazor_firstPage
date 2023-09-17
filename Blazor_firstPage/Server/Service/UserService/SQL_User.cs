using Blazor_firstPage.Server.Model;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Blazor_firstPage.Server.Service.UserService
{
    public class SQL_User
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TESTSS;";

        public static List<User> GetUsers()
        {
            string query = "SELECT * FROM Customer";

            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        //Id is int 
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

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {
                    sqlcommand.Parameters.AddWithValue("@Name", user.Name);
                    sqlcommand.Parameters.AddWithValue("@Email", user.Email);
                    sqlcommand.ExecuteNonQuery();
                }
            }

        }
    }
}
