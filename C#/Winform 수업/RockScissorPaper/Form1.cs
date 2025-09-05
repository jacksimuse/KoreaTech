using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorPaper
{
    public partial class Form1 : Form
    {
        int computer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            //computer++;

            //if (computer > 2)
            //    computer = 0;

            int user = int.Parse(comboBox1.SelectedItem.ToString());

            int result = (user - 1 + 3) % 3;

            switch (result)
            {
                case 0:
                    MessageBox.Show("비겼습니다");
                    //return;

                    for (int i = 0;   i < 5; i++)
                    {
                        if (i == 3) continue;   // continue 반복문에서 주로 사용, 조건에 따라 한 단계 넘어감
                        user += i;
                    }
                    break;  // break는 현재 진행되고 있는 구문만 탈출, return 호출한 곳 전체를 탈출
                case 1:
                    MessageBox.Show("이겼습니다");
                    break;
                case 2:
                    MessageBox.Show("졌습니다");
                    break;
            }

           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            computer++;

            if (computer > 2)
                computer = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }
    }
}
