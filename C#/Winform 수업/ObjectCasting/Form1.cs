using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectCasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object o = 123;
            int i = 0;
            string s = "";

            o = i; // 암시적(묵시적)형변환, 작은 단위 -> 큰 단위
            i = (int)o; // 명시적 형변환, 큰 단위 -> 작은 단위
            o = s;
            s = o.ToString();

            o = textBox1.Text;

            var v = 123;
            v = 0;

            o.Equals(i); // 괄호안에 값이 현재 오브젝트 변수와 같으면 true, false
            // o = i ?
            MessageBox.Show(o.Equals(s).ToString());
            MessageBox.Show(o.ToString());

            // 컨트롤 + k +  c / u
            MessageBox.Show(i.GetType().ToString());
            MessageBox.Show(o.GetHashCode().ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (numericUpDown1.Value is decimal) // textbox의 text는 string으로 구성되어있어서 is string = true / is int = false
            //{
            //    textBox1.Text = "글자를 바꿨습니다";
            //}
            //else
            //{
            //    textBox1.Text = "글자입니다";
            //}

            object o = 123;
            string str = "안녕하세요";

            str = o as string;

            MessageBox.Show(str);

        }
    }
}
