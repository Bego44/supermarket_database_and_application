using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace supermarketproject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT top 1 Product_name FROM Product INNER JOIN Orders ON Product.Product_ID = orders.Product_Id GROUP BY Product_name ORDER BY sum(Orders.Quantity) desc ";
            SqlCommand cmd = new SqlCommand(Query, con);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select Product_name from Product where Product.Product_ID = ( select Product_IDfrom orders  where datepart(MONTH, orders.Order_date) != (select top 1 datepart(MONTH, product_never_bought_for_month.specific_month) from product_never_bought_for_month)";
						
            SqlCommand cmd = new SqlCommand(Query, con);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select Customer_name from Customer where datepart(YEAR, GETDATE()) - datepart(YEAR, Customer.last_purchase_date) >= 1";
            SqlCommand cmd = new SqlCommand(Query, con);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT top 1 Customer_name FROM Customer INNER JOIN Orders ON Customer.Customer_name = orders.Customer_ID GROUP BY Customer_name ORDER BY sum(Orders.Total_price) desc; ";
            SqlCommand cmd = new SqlCommand(Query, con);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT TOP 1 Department FROM Product INNER JOIN orders on Product.Product_ID = orders.Product_Id GROUP BY Department ORDER BY sum(Orders.Quantity * Orders.Total_Price) DESC ; ";
            SqlCommand cmd = new SqlCommand(Query, con);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select * ,count(orders.Customer_ID) FROM Product INNER JOIN orders on Product.Product_ID = orders.Product_Id group by orders.Product_ID ";
            SqlCommand cmd = new SqlCommand(Query, con);
        }
    }
}
