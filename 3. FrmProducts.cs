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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(nwDataSet1.Products);
            this.bindingSource1.DataSource = nwDataSet1.Products;
            this.dataGridView1.DataSource = bindingSource1;
            this.bindingNavigator1.BindingSource  = bindingSource1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label2.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
            lblResult.Text = $"共{this.bindingSource1.Count}則結果";
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);
            this.productsTableAdapter1.UnitPriceFillBy(this.nwDataSet1.Products, A, B);
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            String A = textBox3.Text;
            this.productsTableAdapter1.FillByPN (this.nwDataSet1.Products,A);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
