using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(awDataSet1.ProductPhoto);
            this.bindingSource1.DataSource = awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = bindingSource1;
            this.bindingNavigator1.BindingSource = bindingSource1;

           SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand("select distinct year(ModifiedDate) as 'ModifiedDate' From Production.ProductPhoto group by ModifiedDate ", conn);
            SqlDataReader reader = command.ExecuteReader();     
            while (reader.Read())
            {
                string A = $"{reader["ModifiedDate"]}";
                this.comboBox1.Items.Add(A);
            }
            conn.Close();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            decimal d = Convert.ToDecimal(comboBox1.SelectedItem);
            this.productPhotoTableAdapter1.FillByyear(awDataSet1.ProductPhoto, d);
          
         
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            DateTime B = dateTimePicker1.Value;
            DateTime O = dateTimePicker2.Value;
            this.productPhotoTableAdapter1.FillBydatetime(awDataSet1.ProductPhoto, B, O);
                
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime B = dateTimePicker1.Value;
            DateTime O = dateTimePicker2.Value;
            this.productPhotoTableAdapter1.FillByDTOB (awDataSet1.ProductPhoto, B, O);
        }

        
    }
}
