using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrSt
{
    internal class StClass
    {
        static StClass()
        {
            // 최초 1회 초기화용
            MessageBox.Show("StClass가 처음으로 초기화 되었습니다");
        }

        public static void Start(int num)
        {
            MessageBox.Show($"{num}번째 호출 중입니다");
        }
    }
}
