using SqlTask.DAL;
using SqlTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlTask
{
    public partial class SqlTaskForm : Form
    {
        public SqlTaskForm()
        {
            InitializeComponent();
            GetAllProductsGrid();
        }
        private void GetAllProducts()
        {
            using (Database db = new Database("myTask"))
            {
                var products = db.GetAllProducts();
                dgv_Products.DataSource = products;
            }
        }

        private void GetAllProductsGrid()
        {
            using (Database db = new Database("myTask"))
            {
                var gridModels = db.GetGrid();
                dgv_Products.DataSource = gridModels;
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            using(Database database=new Database("myTask"))
            {
                var products = database.GetAllProducts();
                foreach(var pr in products)
                {
                    rtxb_Task.AppendText("Id= " + pr.Id.ToString() + " Name = " + pr.Name.ToString() + " Price = " + pr.Price.ToString());
                    rtxb_Task.AppendText("\n");
                }
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using(Database database=new Database("myTask"))
            {
                database.CreateProduct( new Product
                {
                    Name = txb_Name.Text,
                    Price=Convert.ToInt32(txb_Price.Text),
                   
                    
                });
            }
            MessageBox.Show("Product added.");
            GetAllProducts();
            #region simple
           /*string connectionString = ConfigurationManager.ConnectionStrings["myTask"].ConnectionString;
            string query = "INSERT INTO SqlTask(Name,Price) VALUES ('" + txb_Name.Text + "', " + txb_Price.Text + ")";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
            sqlConnection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
             {
            int affectedRows = sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Sisteme elave olundu");
            }
            }*/
           
            #endregion

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using(Database database=new Database("myTask"))
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgv_Products.CurrentRow.Cells[0].Value),

                    Name = txb_NameUpdate.Text,
                    Price = Convert.ToInt32(txb_PriceUpdate.Text)
                };
                database.Update(product);
            }
            GetAllProducts();
            #region simple
           /* string connectionString = ConfigurationManager.ConnectionStrings["myTask"].ConnectionString;
            string query = "UPDATE SqlTask SET Name='" + txb_Name.Text + "'  WHERE Id=" + txb_Id.Text + "";



            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
            sqlConnection.Open();

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
            int affectedRows1 = sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Ada duzelis edildi.");
            }

            }*/
            #endregion
        }

        private void dgv_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_NameUpdate.Text = dgv_Products.CurrentRow.Cells[1].Value.ToString();
            txb_PriceUpdate.Text = dgv_Products.CurrentRow.Cells[2].Value.ToString();


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_Products.CurrentRow.Cells[0].Value);
            using(Database database=new Database("myTask"))
            {
                
                database.Delete(id);
                GetAllProducts();
            }
           
        }
    }
}