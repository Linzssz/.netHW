using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmDataSet結構 : Form
    {
        public FrmDataSet結構()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwData1.Products);
            this.categoriesTableAdapter1.Fill(this.nwData1.Categories);
            this.customersTableAdapter1.Fill(this.nwData1.Customers);


            this.dataGridView4.DataSource = this.nwData1.Products;
            this.dataGridView5.DataSource = this.nwData1.Categories;
            this.dataGridView6.DataSource = this.nwData1.Customers;
            //=======================================================

            this.listBox2.Items.Clear();

            for (int i = 0; i <= this.nwData1.Tables.Count - 1; i++)
            {
                DataTable table = this.nwData1.Tables[i];
                this.listBox2.Items.Add(table.TableName);

                //table.column

                string s = "";
                for (int column = 0; column <= table.Columns.Count - 1; column++)
                {
                    s += $"{ table.Columns[column].ColumnName,-40 }";


                }

                this.listBox2.Items.Add(s);
                //===========================
                //table.rows

                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    // Datarow dr=  table.Rows[row];
                    //this.listBox2.Items.Add(table.Rows[row][0]);

                    string A = "";

                    for (int line = 0; line <= table.Columns.Count - 1; line++)
                    {
                        A += $"{table.Rows[row][line],-40}";

                    }
                    this.listBox2.Items.Add(A);
                }


                this.listBox2.Items.Add("=======================================================================================================================");



            }
        }
    }
}
