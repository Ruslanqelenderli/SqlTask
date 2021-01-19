using SqlTask.DAL;
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

            #region simple
           string connectionString = ConfigurationManager.ConnectionStrings["myTask"].ConnectionString;
            string query = "INSERT INTO SqlTask(Name,Price) VALUES ('" + txb_Name.Text + "', " + txb_Price.Text + ")";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
            sqlConnection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
             {
            int affectedRows = sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Sisteme elave olundu");
            }
            }
           
            #endregion

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            #region simple
            string connectionString = ConfigurationManager.ConnectionStrings["myTask"].ConnectionString;
            string query = "UPDATE SqlTask SET Name='" + txb_Name.Text + "'  WHERE Id=" + txb_Id.Text + "";



            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
            sqlConnection.Open();

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
            int affectedRows1 = sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Ada duzelis edildi.");
            }

            }
            #endregion
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myTask"].ConnectionString;
            string query = "DELETE FROM SqlTask WHERE Id="+txb_Id.Text+"";



            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    int affectedRows1 = sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Qeyd etdiyiniz id silindi");
                }

            }
        }
    }
}