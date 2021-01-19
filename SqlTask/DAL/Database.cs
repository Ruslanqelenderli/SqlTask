using SqlTask.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask.DAL
{
    class Database:IDisposable
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
        public  void CreateProduct()
        {
            
            //_SqlConnection.Open();
            //string query = "INSERT INTO SqlTask(Name,Price) VALUES ('" + txb_Name.Text + "', " + txb_Price.Text + ")";

        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                //open edirik emeliyyati icra etmek ucun
                _SqlConnection.Open();
                //queryni seliqelilik olsun deye bele yaziriq
                string query = "SELECT Id,Name,Price FROM SqlTask";
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
