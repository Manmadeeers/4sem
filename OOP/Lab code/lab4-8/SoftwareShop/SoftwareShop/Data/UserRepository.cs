using Microsoft.Data.SqlClient;
using SoftwareShop.Models;


namespace SoftwareShop.Data
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
        private void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using(SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(
                            "INSERT INTO Users (Name, Email, Password, IsAdmin, Role) VALUES " +
                            "(@Name, @Email, @Password, @IsAdmin, @Role)", 
                            connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Name", user.Name);

                            command.Parameters.AddWithValue("@Email", user.Email);

                            command.Parameters.AddWithValue("@Password", user.Password);

                            command.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);

                            command.Parameters.AddWithValue("@Role", user.Role);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }   
        }


        //-----End of Methods-----//


    }
}
