
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        public FrmHomeWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = { 100, 66, 77 };
            int Max = num[0];

            for (int i = 0; i < 3; i++)
            {

                if (Max < num[i])
                { Max = num[i]; }

                labResult.Text = Max.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int a = 0;
            int b = 0;


            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] % 2 == 0)
                { a++; }
                else
                { b++; }
            }
            labResult.Text = "偶數有" + a + "個," + "奇數有" + b + "個";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsd","sdfdfsdfsdfdfgsdf"};
            string result = "";
            int a = 0;
            for (int i = 0; i < names.Length; i++)

            {
                if (a < names[i].Length)

                {
                    a = names[i].Length;
                    result = names[i];
                }

            }
            labResult.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox4.Text);

            if (N % 2 == 0)
            { labResult.Text = N + "此數為偶數"; }

            else { labResult.Text = N + "此數為奇數"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

            int max = scores.Max();
            int min = scores.Min();
            labResult.Text = ("Max = " + max + ",Min=" + min);

            


        }

        

        private void button16_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int sum = 0;
            for (int i = a; i <= b; i += c)
            {
                sum += i;

            }
            labResult.Text = sum.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int sum = 0;
            while (a <= b)
            {
                sum += a;
                a += c;

            }
            labResult.Text = sum.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int sum = 0;
            do
            {
                sum += a;
                a += c;


            }
            while (a <= b);
            labResult.Text = sum.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            labResult.Text = "";

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    labResult.Text = (i + "*" + j + "=" + (i * j).ToString("00") + " ");
                }

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            labResult.Text = Convert.ToString(100, 2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string result = "";
            int sum = 0;
            String[] names = { "aaa", "cbb", "ccc", "Mary", "Tom", "caacc", "Mary", "Tcm" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Contains("C") || names[i].Contains("c"))

                { sum++; }
            }
            labResult.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Params(10, 20, 30, 66, 55, 48, 95);
        }

        private void Params(params int[] nums)
        {
            labResult.Text = $"最大值{nums.Max()}";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<int> randomlist = new List<int>();

            Random rnd = new Random();

            while (randomlist.Count < 6)
            {
                int r = rnd.Next(1, 49);
                while (randomlist.Contains(r))
                {
                    r = rnd.Next(1, 49);
                }
                randomlist.Add(r);

                labResult.Text = string.Join(" ", randomlist.OrderBy(x => x));

            }
        }
    }
}
