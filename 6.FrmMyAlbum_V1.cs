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
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            photo f = new photo();
            f.Show();
        }

        private void FrmMyAlbum_V1_Load(object sender, EventArgs e)

        {
           
            this.myTableTableAdapter1.Fill(myPhotoDataSet11.myTable);
            for(int i =0;i<=myPhotoDataSet11.myTable.Rows.Count-1;i++)
            {
                LinkLabel x = new LinkLabel();
                x.Text = $"{myPhotoDataSet11.myTable.Rows[i][1]}";
                x.Left = 30;
                x.Top = 30 * i;
                x.Tag = i;//ID

                x.Click += X_Click;
                this.splitContainer2.Panel1.Controls.Add(x);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
           
        }
    }
}
