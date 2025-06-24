using Microsoft.Data.SqlClient;
using SoftwareShop.Repositories;
using System.Data;
using System.Windows;

namespace SoftwareShop.Data
{
    public static class Repository
    {
        static string connection;

        public static UserRepository userRepository;
        public static ProductRepository productRepository;
        public static OrderRepository orderRepository;

        public static void Init(string conn)
        {
            try
            {
                connection = conn;
                InitializeDatabase(connection);
                userRepository = new UserRepository(connection);
                productRepository = new ProductRepository(connection);
                orderRepository = new OrderRepository(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть базу данных:\n{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public static void InitializeDatabase(string connectionString)
        {
            // Разбираем строку подключения, чтобы получить имя БД и подключиться к master
            var builder = new SqlConnectionStringBuilder(connectionString);
            string databaseName = builder.InitialCatalog;
            builder.InitialCatalog = "master";
            string masterConnectionString = builder.ToString();

            // 1) Создаём БД, если её нет
            using (var masterConn = new SqlConnection(masterConnectionString))
            {
                masterConn.Open();
                using (var cmd = masterConn.CreateCommand())
                {
                    cmd.CommandText = @"
                    IF DB_ID(@db) IS NULL
                    BEGIN
                        PRINT 'Database not found. Creating database...';
                        EXEC('CREATE DATABASE [' + @db + ']');
                    END";
                    cmd.Parameters.Add(new SqlParameter("@db", SqlDbType.NVarChar, 128) { Value = databaseName });
                    cmd.ExecuteNonQuery();
                }
            }

            // 2) Теперь подключаемся уже к нашей БД и создаём таблицы, если их нет
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                    -- Users
                    IF OBJECT_ID('dbo.Users','U') IS NULL
                     BEGIN
                        CREATE TABLE dbo.Users(
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Name NVARCHAR(100) NOT NULL,
                        Email NVARCHAR(200) NOT NULL,
                        Password NVARCHAR(200) NOT NULL,
                        IsAdmin BIT NOT NULL DEFAULT 0,
                        Role NVARCHAR(50) NULL
                        );
                        END

                    -- Products
                    IF OBJECT_ID('dbo.Products','U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.Products(
                            Id INT IDENTITY(1,1) PRIMARY KEY,
                            Name NVARCHAR(200) NOT NULL,
                            Description NVARCHAR(500) NULL,
                            Price DECIMAL(18,2) NOT NULL,
                            ImagePath NVARCHAR(500) NULL,
                            DetailedDescription NVARCHAR(MAX) NULL
                            );
                        END

                    -- Orders
                    IF OBJECT_ID('dbo.Orders','U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.Orders(
                            Id INT IDENTITY(1,1) PRIMARY KEY,
                            UserId INT NOT NULL,
                            ProductId INT NOT NULL,
                            TotalPrice DECIMAL(18,2) NOT NULL,
                            CONSTRAINT FK_Orders_Users FOREIGN KEY(UserId) REFERENCES dbo.Users(Id),
                            CONSTRAINT FK_Orders_Products FOREIGN KEY(ProductId) REFERENCES dbo.Products(Id)
                        );
                        END
                    ";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

