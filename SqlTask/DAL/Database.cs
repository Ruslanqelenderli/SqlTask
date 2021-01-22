using SqlTask.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask.DAL
{
    class Database : IDisposable
    {
        private SqlConnection _SqlConnection;


        private string _GetConnectionString(string connectionStringName)
        {
            return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }
        public Database(string connectionStringName)
        {
            string connectionString = _GetConnectionString(connectionStringName);
            _SqlConnection = new SqlConnection(connectionString);
        }
        private void SqlChecking()
        {
            if (_SqlConnection.State == ConnectionState.Closed)
            {
                _SqlConnection.Open();
            }
        }
        public void Delete(int id)
        {
            SqlChecking();
            string query = "DELETE FROM Products WHERE Id=@id";
            using (SqlCommand sql = new SqlCommand(query, _SqlConnection))
            {
                sql.Parameters.AddWithValue("@id", id);
            }

        }
        public void Update(Product product)
        {
            try
            {
                SqlChecking();
                string query = "UPDATE Products Set Name=@name,Price=@price WHERE Id=@id";
                using (SqlCommand sqlCommand = new SqlCommand(query, _SqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", product.Name);
                    sqlCommand.Parameters.AddWithValue("@price", product.Price);
                    sqlCommand.Parameters.AddWithValue("@Id", product.Id);

                    sqlCommand.ExecuteNonQuery();
                }

            }
            catch (SqlException exp)
            {

                throw exp;
            }

        }
        public void CreateProduct(Product product)
        {
            try
            {
                SqlChecking();
                string query = "INSERT INTO Products VALUES(@name,@price)";
                using (SqlCommand sqlCommand = new SqlCommand(query, _SqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", product.Name);
                    sqlCommand.Parameters.AddWithValue("@price", product.Price);

                    sqlCommand.ExecuteNonQuery();
                }

            }
            catch (SqlException exp)
            {

                throw exp;
            }


        }


        public List<ProductGridModel> GetGrid()
        {
            
            List<ProductGridModel> products = new List<ProductGridModel>();
            try
            {
                //open edirik emeliyyati icra etmek ucun
                SqlChecking();
                //queryni seliqelilik olsun deye bele yaziriq
                string query = @"SELECT product.Id as ProductId,product.Name as ProductName," +
                                 "product.Price as ProductPrice,category.Id as CategoryId," +
                                 "category.Name as CategoryName FROM Products as product" +
                                 "INNER JOIN Categories category ON product.CategoryId = category.Id"; 
                //command ile emri veririk
                using (SqlCommand sqlCommand = new SqlCommand(query, _SqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ProductGridModel product = new ProductGridModel()
                            {
                                ProductId = Convert.ToInt32(sqlDataReader["ProductId"].ToString()),
                                ProductName = sqlDataReader["ProductName"].ToString(),
                                ProductPrice = Convert.ToInt32(sqlDataReader["ProductPrice"].ToString()),
                                CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"].ToString()),
                                CategoryName = sqlDataReader["CategoryName"].ToString()
                            };
                            products.Add(product);
                        }
                    }
                }

            }
            catch (SqlException exception)
            {

                throw exception;
            }
            return products;
        }




        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                //open edirik emeliyyati icra etmek ucun
                SqlChecking();
                //queryni seliqelilik olsun deye bele yaziriq
                string query = "SELECT Id,Name,Price FROM Products";
                //command ile emri veririk
                using (SqlCommand sqlCommand = new SqlCommand(query, _SqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Product product = new Product()
                            {
                                Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                                Name = sqlDataReader["Name"].ToString(),
                                Price = Convert.ToInt32(sqlDataReader["Price"].ToString())
                            };
                            products.Add(product);
                        }
                    }
                }
                
            }
            catch (SqlException exception)
            {

                throw exception;
            }
            return products;

        }


        public void Dispose()
        {
            _SqlConnection.Dispose();
        }
    }
}
