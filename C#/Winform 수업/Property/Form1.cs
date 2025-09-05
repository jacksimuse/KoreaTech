using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property
{
    public partial class Form1 : Form
    {
        myClass mc = new myClass();
        myClass mc2;

        myStruct ms;
        myStruct ms2;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc.Id = "악성코드";
            mc.Pw = "1234";

            button1.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = $"mc Id : {mc.Id}, mc Pw : {mc.Pw}";
            MessageBox.Show(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mc.Id = "원본 데이터";
            ms.id = "원본 데이터";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mc2 = mc;   // 참조 / 주소를 공유
            ms2 = ms;   // 복사

            mc.Id = "수정된 데이터";
            ms.id = "수정된 데이터";

            MessageBox.Show($"mc id : {mc.Id}, ms : {ms.id}");
            MessageBox.Show($"mc2 id : {mc2.Id}, ms2 : {ms2.id}");

        }
    }
}
