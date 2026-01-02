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
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }
       
        public string conString = "Data Source=DESKTOP-O5N9OQ9;Initial Catalog=supermarket;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.supermarketDataSet.Account);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountBindingSource.EndEdit();
            accountTableAdapter.Update(supermarketDataSet.Account);



            Form2 f1 = new Form2();
             this.Visible = false;
             f1.Show();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            accountBindingSource.AddNew();
        }

       
    }
}
