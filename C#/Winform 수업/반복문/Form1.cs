using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 반복문
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int sum = 0;

            for (int i = 1; i <= a; i = i + 2)
            {
                if (i == 3) continue;
                sum += i;    // sum = sum + i;
            }

            MessageBox.Show(sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] str = { "딸기", "사과", "포도", "바나나" };

            foreach (string item in str)
            {
                MessageBox.Show(item);
            }

            //foreach (var item in str)
            //{

            //}

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
                else
                {
                    item.Checked = true;
                }
                
               // (item as CheckBox).Checked = true;
               // MessageBox.Show(item.ToString());

            }

            foreach (var item in groupBox1.Controls)
            {
                if ((item as CheckBox).Checked)
                {
                    (item as CheckBox).Checked = false;
                }
                else
                {
                    (item as CheckBox).Checked = true;
                }
            }

            foreach (Control item in groupBox1.Controls)
            {
                if ((item as CheckBox).Checked)
                {
                    (item as CheckBox).Checked = false;
                }
                else
                {
                    (item as CheckBox).Checked = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //while (isRun)
            //{
            //    isRun = false;
            //}

            bool isRun = true;

            int a = 0;

            do {
                a++;
                if (a == 10)
                {
                    isRun = false;
                    MessageBox.Show(a.ToString());
                }
            }
            while (isRun);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //isRun = false;
        }
    }
}
