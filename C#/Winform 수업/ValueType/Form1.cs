using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 100;
            int num2 = 200;
            int result = num1 + num2;

            string str = "결과는" + result.ToString() + "입니다";
            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = 3.14;
            double num2 = 1.23;

            string str = "num1 : " + num1.ToString() + "입니다\r\nnum2 : " + num2.ToString();
            MessageBox.Show(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int int_size = sizeof(int);
            int char_size = sizeof(char);
            int long_size = sizeof(long);
            int double_size = sizeof(double);
            int bool_size = sizeof(bool);
           

            MessageBox.Show(int_size.ToString());
            MessageBox.Show(char_size.ToString());
            MessageBox.Show(long_size.ToString());
            MessageBox.Show(double_size.ToString());
            MessageBox.Show(bool_size.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myEnum rainbow;
            rainbow = myEnum.남;

            string str = string.Empty;
            switch (rainbow)
            {
                case myEnum.빨:
                    str = "빨간색";
                    break;
                case myEnum.주:
                    str = "주황색";
                    break;
                case myEnum.노:
                    str = "노란색";
                    break;
                case myEnum.초:
                    str = "초록색";
                    break;
                case myEnum.파:
                    str = "파란색";
                    break;
                case myEnum.남:
                    str = "남색";
                    break;
                case myEnum.보:
                    str = "보라색";
                    break;
            }

            MessageBox.Show(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myStruct info;

            info.name = "최재훈";
            info.age = 0;
            info.pnum = "010-7569-9066";

            string str = $"이름 : {info.name}\r\n" +
                            $"나이 : {info.age}\r\n" +
                            $"연락처 : {info.pnum}";

            MessageBox.Show(str);
        }
    }
}
