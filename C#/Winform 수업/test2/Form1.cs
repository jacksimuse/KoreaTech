using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1번 문제
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);

            double res = num1 * num2;

            MessageBox.Show(res.ToString());


            // 2번 문제
            // 오류 해결하기(hint : 값, 자료형 바꾸기 가능, 형 변환 가능) // 틀린 이유는 주석으로
            // int a = 7.3;     
            // int는 정수형이라 오류남 -> 자료형을 double로 수정 or 값을 7로 수정
            double da = 7.3;
            int ia = 7;
            // float b = 3.14; 
            // float은 접미사 f가 들어가야함 -> 접미사 f를 넣기 or 자료형을 double로 수정
            float fb = 3.14f;
            double db = 3.14;
            // double c = a * b;
            // a와 b를 수정하고 double로 형 변환해야 연산이 가능
            double dc = da * db;
            // char d = 'abc';
            // char는 문자 1개만 담을 수 있는 value Type이며 작은 따옴표로 감싼다. 값을 'a'로 수정 or  자료형을 string으로 수정
            char cd = 'a';
            string sd = "abc";
            // string e = '한';
            // string은 문자들의 배열로 reference Type이며 큰 따옴표로 문장을 감싼다. 값을 "한글자"로 수정 or 자료형을 char로 수정
            string se = "한글자";
            char ce = '한';

            //5번 문제
            var va = 200; // -> int
            var vs = "자료형";  //-> string

        }
    }
}
