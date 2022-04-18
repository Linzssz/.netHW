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
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
            UsernameTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builderUser();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelTXT();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Logon();
        }

        private void KeyO(object sender, KeyEventArgs e)
        {
            if (e.Alt ==true&&e.KeyCode==Keys.O)
            {
                Logon();
            }
        }
        private void KeyC(object sender, KeyEventArgs e)
        {
            if (e.Alt  == true && e. KeyCode == Keys.C)
            {
                CancelTXT();
            }
        }

        private void KeyUP(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.U)
            {
                UsernameTextBox.Focus();
            }
            if(e.Alt == true && e.KeyCode == Keys.P)
            {
                PasswordTextBox.Focus();
            }
        }
        private void Logon()
        {
            string UserName = UsernameTextBox.Text;
            string Password = PasswordTextBox.Text;
            try
            {

                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select *from MyMember where UserName='{UserName}' and Password='{Password}'";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("登入成功");
                        FrmCustomers f = new FrmCustomers();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("登入失敗");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void builderUser()
        {
            try
            {
                string UserName = UsernameTextBox.Text;
                string Password = PasswordTextBox.Text;
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"insert into MyMember(UserName,Password) Values (@UserName,@Password)";
                    command.Connection = conn;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;

                    conn.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("帳號建立成功");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void CancelTXT()
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            UsernameTextBox.Focus();
        }

    }
}
