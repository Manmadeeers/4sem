

using Microsoft.Data.SqlClient;
using SoftwareShop.Models;

namespace SoftwareShop.Repositories
{
    public class OrderRepository
    {

        //-----Fields and Properties-----//
        private string _connectionString;

        //-----End of Fields and Properties-----//


        public OrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        //-----Methods-----//

        public List<Order> GetAllOrders()

        {

            var orders = new List<Order>();

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Orders", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())

                {

                    orders.Add(new Order

                    {

                        Id = reader.GetInt32(0),

                        UserId = reader.GetInt32(1),

                        ProductId = reader.GetInt32(2),

                        TotalPrice = reader.GetDecimal(3)

                    });

                }

            }

            return orders;

        }

        public void AddOrder(Order order)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("INSERT INTO Orders (UserId, ProductId, TotalPrice) VALUES (@userId, @productId, @totalPrice)", connection, transaction);

                    command.Parameters.AddWithValue("@userId", order.UserId);

                    command.Parameters.AddWithValue("@productId", order.ProductId);

                    command.Parameters.AddWithValue("@totalPrice", order.TotalPrice);

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

        public void UpdateOrder(Order order)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("UPDATE Orders SET UserId=@userId, ProductId=@productId, TotalPrice=@totalPrice WHERE Id=@id", connection, transaction);

                    command.Parameters.AddWithValue("@id", order.Id);

                    command.Parameters.AddWithValue("@userId", order.UserId);

                    command.Parameters.AddWithValue("@productId", order.ProductId);

                    command.Parameters.AddWithValue("@totalPrice", order.TotalPrice);

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

        public void DeleteOrder(int id)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE Id=@id", connection, transaction);

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
