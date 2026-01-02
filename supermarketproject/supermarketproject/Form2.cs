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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        public string conString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
            conection.Open();
            SqlCommand cmd = new SqlCommand("select username,password from Account where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", conection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage");
                Form3     f1 = new Form3();
                this.Visible = false;
                f1.Show();


            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            conection.Close();
        }
    }
}
