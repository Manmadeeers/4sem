using Microsoft.Data.SqlClient;
using SoftwareShop.Models;


namespace SoftwareShop.Repositories
{
    public class UserRepository
    {
        //-----Fields and Properties-----//
        private string _connectionString;


        //-----End of Fields and Properties-----//


        public UserRepository(string connString)
        {
            _connectionString = connString;
        }



        //-----Methods-----//
        public List<User> GetAllUsers()

        {

            var users = new List<User>();

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())

                {

                    users.Add(new User

                    {

                        Id = reader.GetInt32(0),

                        Name = reader.GetString(1),

                        Email = reader.GetString(2),

                        Password = reader.GetString(3),

                        IsAdmin = reader.GetBoolean(4),

                        Role = reader.GetString(5)

                    });

                }

            }

            return users;

        }
        public void AddUser(User user)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("INSERT INTO Users (Name, Email, Password, IsAdmin, Role) VALUES (@name, @email, @password, @isAdmin, @role)", connection, transaction);

                    command.Parameters.AddWithValue("@name", user.Name);

                    command.Parameters.AddWithValue("@email", user.Email);

                    command.Parameters.AddWithValue("@password", user.Password);

                    command.Parameters.AddWithValue("@isAdmin", user.IsAdmin);

                    command.Parameters.AddWithValue("@role", user.Role);

                    command.ExecuteNonQuery();

                    transaction.Commit();

                }

                catch

                {

                    transaction.Rollback();

                    throw;

                }

            }

        }

        public void UpdateUser(User user)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("UPDATE Users SET Name=@name, Email=@email, Password=@password, IsAdmin=@isAdmin, Role=@role WHERE Id=@id", connection, transaction);

                    command.Parameters.AddWithValue("@id", user.Id);

                    command.Parameters.AddWithValue("@name", user.Name);

                    command.Parameters.AddWithValue("@email", user.Email);

                    command.Parameters.AddWithValue("@password", user.Password);

                    command.Parameters.AddWithValue("@isAdmin", user.IsAdmin);

                    command.Parameters.AddWithValue("@role", user.Role);

                    command.ExecuteNonQuery();

                    transaction.Commit();

                }

                catch

                {

                    transaction.Rollback();

                    throw;

                }

            }

        }
        public void DeleteUser(int id)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("DELETE FROM Users WHERE Id=@id", connection, transaction);

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    transaction.Commit();

                }

                catch

                {

                    transaction.Rollback();

                    throw;

                }

            }

        }

        //-----End of Methods-----//


    }
}
