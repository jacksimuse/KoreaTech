using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    internal class Worker : Person
    {
        public bool isWork;
        public Worker(string name, int age, bool iswork) : base (name, age)
        {
            isWork = iswork;
        }

        public void ShowWorkplace(bool isWork)
        {
            if (isWork)
            {
                MessageBox.Show("근무지는 한기대입니다");
            }
            else
            {
                MessageBox.Show("쉬는 중입니다");
            }
        }

        public override void Run(double meter)
        {
            MessageBox.Show($"회사까지 앞으로 {meter}km 남았습니다");
        }
    }
}
