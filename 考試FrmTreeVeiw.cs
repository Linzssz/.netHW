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
using MyHW.Properties;

namespace MyHW
{
    public partial class FrmTreeVeiw : Form
    {
        public FrmTreeVeiw()
        {
            InitializeComponent();
            this.customersTableAdapter1.Fill(nwDataSet1.Customers);
            this.bindingSource1.DataSource = nwDataSet1.Customers;
            this.dataGridView1.DataSource = bindingSource1;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            this.customersTableAdapter1.FillBycity(nwDataSet1.Customers, e.Node.Text);
            this.bindingSource1.DataSource = nwDataSet1.Customers;
            this.dataGridView1.DataSource = bindingSource1;

            if(dataGridView1.Columns.Count==0)
            {
                label1.Text = "";
            }
            else
            {
                label1.Text = "共"+dataGridView1.Columns.Count+ "個" + e.Node.Text + "的客戶";
            }


            //SqlConnection conn = null;
            //string a = (e.Node.Text).ToString();
            //conn = new SqlConnection(Settings.Default.NorthwindConnectionString);
            //conn.Open();
            //SqlCommand command = new SqlCommand("Select*from Customers where City=" + a, conn);
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    this.dataGridView1.DataSource = reader;
            //}
            //conn.Close();
            //=================================================
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
            //    {
            //        string City = e.Node.Text;

            //        conn.Open();
            //        SqlCommand command = new SqlCommand();
            //        command.CommandText = $"Select*from Customers where City={City}";
            //        command.Connection = conn;
            //        SqlDataReader reader = command.ExecuteReader();

            //        this.dataGridView1.Rows.Clear();
            //            for (int i = 0; i <=reader.ro- 1; column++)
            //            {
            //                s += $"{ table.Columns[column].ColumnName,-40 }";


            //            }

            //            this.listBox2.Items.Add(s);
            //            //===========================
            //            //table.rows

            //            for (int row = 0; row <= table.Rows.Count - 1; row++)
            //            {
            //                // Datarow dr=  table.Rows[row];
            //                //this.listBox2.Items.Add(table.Rows[row][0]);

            //                string A = "";

            //                for (int line = 0; line <= table.Columns.Count - 1; line++)
            //                {
            //                    A += $"{table.Rows[row][line],-40}";

            //                }
            //                this.listBox2.Items.Add(A);


            //        }
            //    }

            //catch (Exception ex)//回報錯誤
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void FrmTreeVeiw_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    SqlCommand command = new SqlCommand(); //"select * from Customers where country ='USA' ", conn
                    command.CommandText = "select* from Customers ";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {

                        string Country = dataReader["Country"].ToString();
                        string City = dataReader["City"].ToString();
                        string Customer = dataReader["CustomerID"].ToString();
                        TreeNode tempNode;


                        if (treeView1.Nodes[Country] == null)
                        {
                            TreeNode newtreeNode = new TreeNode(Country);
                            newtreeNode.Name = Country;
                            treeView1.Nodes.Add(newtreeNode);
                            tempNode = newtreeNode;

                        }
                        else
                        {
                            tempNode = treeView1.Nodes[Country];
                        }
                        if (tempNode.Nodes[City] == null)
                        {
                            TreeNode newtreeNode = new TreeNode(City);
                            newtreeNode.Name = City;
                            tempNode.Nodes.Add(newtreeNode);
                            tempNode = newtreeNode;

                        }
                        else
                        {
                            tempNode = tempNode.Nodes[City];
                        }
                        if (tempNode.Nodes[Customer] == null)
                        {
                            TreeNode newtreeNode = new TreeNode(Customer);
                            newtreeNode.Name = Customer;
                            tempNode.Nodes.Add(newtreeNode);
                            tempNode = newtreeNode;
                        }
                        else
                        {
                            tempNode = tempNode.Nodes[Customer];
                        }
                    }
                }
            }
            catch (Exception ex)//回報錯誤
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
