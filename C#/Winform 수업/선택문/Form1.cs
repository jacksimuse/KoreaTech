using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 선택문
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 조건 생성
            bool a = true;
            int color = 0; // 0 = 빨강, 1 = 노랑, 2 = 초록
           
            color = int.Parse(textBox1.Text);

            if (color >= 3) return;

            if (color == 0)
            {
                button1.BackColor = Color.Red;
            }
            else if (color == 1)
            {
                button1.BackColor= Color.Yellow;
            }
            else
            {
                button1.BackColor= Color.Green;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = int.Parse(textBox1.Text);

            switch (a)
            {
                case 0:
                    button2.BackColor = Color.Red;
                    goto case 2;
                    //break;
                case 1:
                    button2.BackColor = Color.Yellow;
                    break;
                case 2:
                    button2.BackColor = Color.Green;
                    break;
            }

            switch (a)
            {
                case 0:
                case 1:
                    button2.BackColor = Color.Red;
                    break;
                case 2:
                    button2.BackColor = Color.Green;
                    break;
            }
        }
    }
}
