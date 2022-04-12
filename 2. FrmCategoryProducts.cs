using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyHomeWork
{
    
    
  //1.sqlconnetion
 //2.sqlcommand
 //3.sqldatareader
 //4.ui control
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            SqlConnection conn = null;
            
                conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
                conn.Open();
                SqlCommand command = new SqlCommand("select CategoryName From Categories", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.comboBox1.Items.Add(reader["CategoryName"]);
                }
                conn.Close();
            
}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string a = (comboBox1.SelectedIndex + 1).ToString();
            conn=new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
            conn.Open();
            SqlCommand command = new SqlCommand("Select*from Products where CategoryID="+a,conn);
            SqlDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while(reader.Read())
            {
                this.listBox1.Items.Add(reader["ProductName"]);
            }
            conn.Close();
        }
    }
}
