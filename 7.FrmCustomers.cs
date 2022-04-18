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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            listView1.View = View.Details;
            LodCombox();
            CreatListView();
        }
        
        private void CreatListView()
        {
            try
            {
                using (SqlConnection conn=new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select*from customers", conn);
                    SqlDataReader reader = command.ExecuteReader();

                   DataTable table = reader.GetSchemaTable();

                   for (int i = 0; i <= table.Rows.Count - 1; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LodCombox()
        {
          
            
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("select distinct country from customers", conn);
                    SqlDataReader reader = command.ExecuteReader();

                    this.comboBox1.Items.Clear();
                    this.comboBox1.Items.Add("--All Country--");


                    while (reader.Read())
                    {
                        this.comboBox1.Items.Add(reader["country"]);
                        
                    }
                    this.comboBox1.SelectedIndex = 0;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select*from customers where country='{comboBox1.Text}'";
                    command.Connection = conn;
                    SqlDataReader reader = command.ExecuteReader();

                    this.listView1.Items.Clear();
                    Random r = new Random();
                  

                    
                        while (reader.Read())
                        {

                            ListViewItem lvi = this.listView1.Items.Add(reader[0].ToString());

                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);

                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                lvi.BackColor = Color.LightGray;
                            }
                            for (int i = 1; i <= reader.FieldCount - 1; i++)
                            {
                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }
                            }
                        }

                    }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //==========================================
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select*from customers";
                    command.Connection = conn;
                    SqlDataReader reader = command.ExecuteReader();

                    this.listView1.Items.Clear();
                    Random r = new Random();

                    if (comboBox1.Text == "--All Country--")
                    {
                        while (reader.Read())
                        {

                            ListViewItem lvi = this.listView1.Items.Add(reader[0].ToString());

                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);

                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                lvi.BackColor = Color.LightGray;
                            }
                            for (int i = 1; i <= reader.FieldCount - 1; i++)
                            {
                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }


        //TODO HW

        //1. All Country


        //================================
        //2. ContextMenuStrip2
        //選擇性作業
        //Groups
        //USA (100) 
        //UK (20)

        //this.listview1.visible = false;
        //ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

        //if (this.listView1.Groups["USA"] == null)
        //{                       {
        //    ListViewGroup group = this.listView1.Groups.Add("USA", "USA"); //Add(string key, string headerText);
        //    group.Tag = 0;
        //    lvi.Group = group; 
        //}
        //else
        //{
        //    ListViewGroup group = this.listView1.Groups["USA"]; 
        //    lvi.Group = group;
        //}

        //this.listView1.Groups["USA"].Tag = 
        //this.listView1.Groups["USA"].Header = 


    }

}
