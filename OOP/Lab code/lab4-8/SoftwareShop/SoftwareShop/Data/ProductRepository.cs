
using Microsoft.Data.SqlClient;
using SoftwareShop.Models;

namespace SoftwareShop.Repositories
{
    public class ProductRepository
    {
        //-----Fields and properties-----//
        private string _connectionString;

        //-----End of Fields and Properties-----//

        public ProductRepository(string conntectionString)
        {
            this._connectionString = conntectionString;
        }


        //-----Methods-----//

        public List<Product> GetAllProducts()

        {

            var products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())

                {

                    products.Add(new Product

                    {

                        Id = reader.GetInt32(0),

                        Name = reader.GetString(1),

                        Description = reader.GetString(2),

                        Price = reader.GetDecimal(3),

                        ImagePath = reader.GetString(4),

                        DetailedDescription = reader.GetString(5)

                    });

                }

            }

            return products;

        }
        public void AddProduct(Product product)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("INSERT INTO Products (Name, Description, Price, ImagePath, DetailedDescription) VALUES (@name, @description, @price, @imagePath, @detailedDescription)", connection, transaction);

                    command.Parameters.AddWithValue("@name", product.Name);

                    command.Parameters.AddWithValue("@description", product.Description);

                    command.Parameters.AddWithValue("@price", product.Price);

                    command.Parameters.AddWithValue("@imagePath", product.ImagePath);

                    command.Parameters.AddWithValue("@detailedDescription", product.DetailedDescription);

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
        public void UpdateProduct(Product product)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("UPDATE Products SET Name=@name, Description=@description, Price=@price, ImagePath=@imagePath, DetailedDescription=@detailedDescription WHERE Id=@id", connection, transaction);

                    command.Parameters.AddWithValue("@id", product.Id);

                    command.Parameters.AddWithValue("@name", product.Name);

                    command.Parameters.AddWithValue("@description", product.Description);

                    command.Parameters.AddWithValue("@price", product.Price);

                    command.Parameters.AddWithValue("@imagePath", product.ImagePath);

                    command.Parameters.AddWithValue("@detailedDescription", product.DetailedDescription);

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

        public void DeleteProduct(int id)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try

                {

                    SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id=@id", connection, transaction);

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
