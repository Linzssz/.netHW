using MyHW.Properties;
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
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();
            LoadToCombobox();
            this.cityTableAdapter1.Fill(AlumbDataSet.City);

            
            for (int i = 0; i < this.AlumbDataSet.City.Rows.Count; i++)
            {
                LinkLabel x = new LinkLabel();
                x.Text = $"{AlumbDataSet.City.Rows[i][1]}";
                x.Left = 50;
                x.Top =35* i;
                x.Tag = AlumbDataSet.City[i].CityID;

                x.Click += X_Click;
                this.flowLayoutPanel2.Controls.Add(x);



            }
        }

        private void LoadToCombobox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.AlbumConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct CityName from City", conn);

                    SqlDataReader dataReader = command.ExecuteReader();

                    this.comboBox1.Items.Clear();//清除listbox

                    while (dataReader.Read())
                    {
                        this.comboBox1.Items.Add(dataReader["CityName"]);
                    }
                    this.comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)//回報錯誤
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((LinkLabel)sender).Text+ " - " + ((LinkLabel)sender).Tag);
            // LinkLabel x = (LinkLabel)sender;轉型
            LinkLabel x = sender as LinkLabel;
            ShowImage((int)x.Tag);
            
        }

        private void ShowImage(int x)
        {
            flowLayoutPanel1.Controls.Clear();

            try
            { using (SqlConnection conn=new SqlConnection(Settings.Default.AlbumConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from city as c join photo as p on c.cityid=p.cityid where P.CityID='{x}'";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader reader= command.ExecuteReader();

                    while(reader.Read())
                    {
                        byte[] bytes = (byte[])reader["picture"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        PictureBox p = new PictureBox();
                        p.Image = Image.FromStream(ms);
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.flowLayoutPanel1.Controls.Add(p);
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.Filter = "(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            //if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //this.flowLayoutPanel3.Controls.Image = Image.FromFile(this.openFileDialog1.FileName);

            //    try
            //    {

            //        using (SqlConnection conn = new SqlConnection(Settings.Default.AlbumConnectionString))
            //        {


            //            SqlCommand command = new SqlCommand();
            //            command.CommandText = $"insert into Photo (Image) values (@Image)";
            //            command.Connection = conn;

            //            //===============================
            //            byte[] bytes;
            //            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //            PictureBox p = new PictureBox();
            //            Bitmap o = new Bitmap();
            //            p=Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg));
            //            bytes = ms.GetBuffer();




            //            command.Parameters.Add("@Desc", SqlDbType.Text).Value = textBox4.Text;
            //            command.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;



            //            conn.Open();
            //            command.ExecuteNonQuery();//insert使用此語法

            //            MessageBox.Show("INSERT   Image Successfully");

            //        }
            //    }
            //    catch (Exception ex)//回報錯誤
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.AlumbDataSet);

        }

        private void photoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.AlumbDataSet);

        }

        private void photoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.photoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.AlumbDataSet);

        }

        private void cityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.AlumbDataSet);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMyAlbum_V1_Load(object sender, EventArgs e)
        {
             this.bindingNavigator1city.BindingSource = this.cityBindingSource;
            this.photobindingNavigator1.BindingSource = this.photoBindingSource;
            this.photoTableAdapter1.Fill(AlumbDataSet.Photo);
            this.photoBindingSource.DataSource = AlumbDataSet.Photo;
            this.photoDataGridView.DataSource = photoBindingSource;
        }

        private void photoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void photoIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cityIDTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void photoNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void photoNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureLabel_Click(object sender, EventArgs e)
        {

        }

        private void photoIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picturePictureBox_Click(object sender, EventArgs e)
        {

        }
    }



}
