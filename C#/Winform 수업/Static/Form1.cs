using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        myClass mc1 = new myClass();
        myClass mc2 = new myClass();
        myClass mc3 = new myClass();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc1.instanceNum++;
            myClass.staticNum++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mc2.instanceNum++;
           // myClass.staticNum++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mc3.instanceNum++;
            //myClass.staticNum++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = $@"mc1 숫자 :  {mc1.instanceNum} 
mc2 숫자 : {mc2.instanceNum}
mc3 숫자 : {mc3.instanceNum}
static 숫자 : {myClass.staticNum}";

            MessageBox.Show(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Math.PI; // 3.14***********
         //   a = Math.Cos(a);
            a = Math.Pow(a, 2);

            double[] b = new double[10];
            b[0] = a;

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a;
            }

            //foreach (var item in b)
            //{
            //    item = a;
            //}

            MessageBox.Show(b[5].ToString());

            
        }
    }
}
