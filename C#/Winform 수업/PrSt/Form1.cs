using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrSt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // f9 브레이크 포인트 / f10번 한줄씩 디버깅 / 함수를 만났을때 f11번

            //  PrClass.GetObject() == instance -> pc /  pc == instance
            PrClass pc = PrClass.GetObject(); // 일반 클래스 객체 생성
                                              // private 클래스 

            pc.color = "빨간색";
            MessageBox.Show(pc.color);

            PrClass pc2 = PrClass.GetObject(); // 일반 클래스 객체 생성
                                              // private 클래스 

            pc2.color = "파란색";
            MessageBox.Show(pc2.color);


            MessageBox.Show(pc.color);
        }

        int i = 0;

        private void button2_Click(object sender, EventArgs e)
        {
       
            StClass.Start(i);
            i++;
        }
    }
}
