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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conection = new SqlConnection("Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True");

            conection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conection;
            sqlCommand.CommandText = "insert into Product values('" + t1.Text + "', '" + t2.Text + "', '" + t3.Text + "', '" + t4.Text + "','" + t5.Text + "','" + t6.Text + "')";


            conection.Close();

           // productBindingSource5.EndEdit();

          //  productTableAdapter.Update(supermarketDataSet.Product);
            //SqlConnection conection = new SqlConnection();
            //conection.ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            //conection.Open();
            //SqlCommand cmd = new SqlCommand("insert into Product values('" + t1.Text + "', '" + t2.Text + "', '" + t3.Text + "', '" + t4.Text + "','" + t5.Text + "','" + t6.Text + "')", conection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //conection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.supermarketDataSet.Orders);
            // TODO: This line of code loads data into the 'supermarketDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.supermarketDataSet.Product);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            productBindingSource5.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
