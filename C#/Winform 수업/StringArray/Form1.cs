using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "1000.001";
           // int i = 0;
           //// i = int.Parse(s);


            //button1.Text = i.ToString();

            int inum;
            bool bl = int.TryParse(s, out inum);

            button1.Text = bl.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int num = 12345;
            //double num2 = 123.45;

            //string str1 = num.ToString();

            //MessageBox.Show(str1);

            //string str2 = num2.ToString("C2");
            //// 변수.ToString("C")를 입력하면 그 나라의 통화대로 나오고, 문자 뒤 숫자를 입력하면 소수점 관리가 가능

            //MessageBox.Show(str2);

            string str3 = "abCDe";
            //MessageBox.Show(str3.ToLower());

            string str4 = "삼성디스플레이 c# 수업";
            string[] strArr = str4.Split(' ');
            //MessageBox.Show(strArr[0]);
            //MessageBox.Show(strArr[1]);
            //MessageBox.Show(strArr[2]);

            //            string fruits = "바나나 포도 사과 딸기";
            //string[] strFru = fruits.Split(' ');
            //MessageBox.Show(strFru[0]);
            //MessageBox.Show(strFru[1]);
            //MessageBox.Show(strFru[2]);
            //MessageBox.Show(strFru[3]);

            //            01 01 01 01 01 / 전원 빨간색 노란색 파란색 초록색
            //             1010010101 / 전원이 켜져있고 빨간색이 켜져있고 노, 파, 초는 off

            //            string str5 = str3 + str4; // + 기호를 통해 문자열을 합칠 수 있음
            //            string str6 = $"{str3} + {str4}";

            //            string apple = "사과";
            //            int num = 2;

            //            C# 4.7 이전버전
                       // string str7 = string.Format("지금 천안에 {0}가 {1}개 있습니다.", apple, num);
            //            C# 4.7 이후버전
                  //      string str8 = $@"지금은 천안에 {apple}가 



            //{num}개 있습니다";
            //            MessageBox.Show(str8);

            //            삼성 디스플레이 c# 수업;
                        string str9 = str4.Substring(2, 5);
            //            MessageBox.Show(str9);

            //            object obj = "문자";
            //            string st = (string)obj;
            //            MessageBox.Show(st);


            StringBuilder sb = new StringBuilder();
            // Reference Type인 클래스를 사용할 때는 new 라는 키워드와 함께 인스턴스를 생성해서 사용한다.
            sb.Append("안녕하세요"); // 단순 문장 뒤에 문장 추가
            sb.AppendLine("딸기"); // 문장 줄바꿈 추가
            sb.Append("바나나");

            sb.Insert(3, "삼성"); // 해당 위치에 글자 삽입
            sb.Replace("딸기", "포도"); // 기존에 있던 문장을 새로운 문장으로 교체
            sb.Remove(0, 2);


            MessageBox.Show(sb.ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * 같은 자료형을 여러 데이터로 묶어서 저장하는 자료구조
             * 메모리에 연속적으로 저장되어 있어 접근 속도가 빠름
             */

            int[] numbers = new int[5]; // 정수형(int)배열 선언

            int[] num = { 1, 2, 3, 4, 5 }; // 정수형(int)배열 초기화

            // 배열에 접근

            MessageBox.Show(num[0].ToString());
            MessageBox.Show(num[1].ToString());
            MessageBox.Show(num[2].ToString());
            MessageBox.Show(num[3].ToString());
            MessageBox.Show(num[4].ToString());
            ////  MessageBox.Show(num[5].ToString()); // 배열의 인덱스를 넘었을 때 오류 발생

             num[0] = 100;

            //  MessageBox.Show(num[0].ToString());

            MessageBox.Show(num.Length.ToString());

            for (int i = 0; i < num.Length; i++)
            {
                MessageBox.Show(num[i].ToString());
            }

            string[] str = new string[5]; // 문자열 배열 선언
            string[] strings = { "삼성", "디스", "플레이" }; // 문자열 배열 초기화


        }
    }
}
