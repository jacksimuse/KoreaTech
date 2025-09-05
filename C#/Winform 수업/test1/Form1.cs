using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "여러분, 안녕하세요?";

            if (s.Equals(textBox1.Text))
            {
                MessageBox.Show("반갑습니다");
            }

            //MessageBox.Show("반갑습니다");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //double num1 = double.Parse(textBox2.Text);
            //double num2 = Convert.ToDouble(textBox3.Text);

            //double res = num1 + num2;

            //MessageBox.Show(res.ToString());


            people p1;
            p1.id = 0;
            p1.name = "이름";

            MessageBox.Show($"{p1.id} + {p1.name}");
        }
    }
}
