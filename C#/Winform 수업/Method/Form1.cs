using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 4 메서드 만들기

            // 1. 매개변수(인자) 없이 반환값 없는 함수(메서드)
            //PrintMessage();

            // 2. 매개변수(인자) 있고 반환값 없는 함수(메서드)
            //CallName(textBox1.Text);

            // 3. 매개변수(인자) 없고 반환값 있는 함수(메서드)
            //textBox1.Text =  NoParamReturn();

            // 4. 매개변수(인자) 있고 반환값 있는 함수(메서드)
          // textBox1.Text =  AddTo(v3 : 1, v1 : 2, v2 : 5).ToString();


            // 반환하고싶은게 여러개 있을때 out사용
            // ref / reference
           // int a = 0;
           // int b = 1;

           //AddTo(ref a, ref b);

            //MessageBox.Show($"{a}, {b}");
            //a = 0;
            //b = 1;
            //AddToo(a, b);

            
            //MessageBox.Show($"{a}, {b}");

           //bool b = int.TryParse(textBox1.Text, out a);




            // 사칙 연산을 하는 메서드 4개 만들기
            // Plus, Minus, Mul, Div
            // 결과는 MessageBox or textBox.Text에 보여주기
            //Plus();



            //int a = 10 << (int)comboBox1.SelectedItem;
            //Minus(a);
            //MessageBox.Show(Mul().ToString());
            //textBox1.Text = (Div(3,6)).ToString();


        }

        private double Div(double a, double b)
        {
            return a / b;
        }

        private int Mul()
        {
            return 2 * 3;
        }

        private void Minus(int a)
        {
            MessageBox.Show((a - 1).ToString());
        }

        private void Plus()
        {
            int a = 1;
            int b = 2;
            MessageBox.Show((a+b).ToString());
        }


        private int AddToo(int v1, int v2)
        {
            v1 = 10;
            v2 = 20;
            return v1 + v2;
        }

        private int AddTo(int v1,  int v2 ,int v3 = 3) 
            // ref는 주소를 참조하기 때문에 값을 공유하게 된다

            // 디폴트 값은 맨 뒤에서부터 채우면 됨
            // 디폴트 값, 호출할 때 값을 안보내면 디폴트 값을 사용
        {
            v1 = 10;
            v2 = 20;

            return v1 + v2;
        }

        private string NoParamReturn()
        {
            return "문자";
        }

        private void CallName(string v)
        {
            MessageBox.Show(v);
        }

        private void PrintMessage()
        {
            MessageBox.Show("메세지 출력");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(i);
            }
        }





        int Sum(params int[] nums)
        {
            int res = 0;
            foreach (int i in nums)
            {
                res += i;
            }
            return res;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;

            a = Sum(1);
            MessageBox.Show(a.ToString());
            a = Sum(1,2,3);
            MessageBox.Show(a.ToString());
            a = Sum(100,300,500,700,900);
            MessageBox.Show(a.ToString());
        }
    }
}
