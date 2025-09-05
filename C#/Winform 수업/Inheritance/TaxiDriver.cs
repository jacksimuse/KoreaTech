using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    internal class TaxiDriver : Person
    {
        public string CarNum;

        public TaxiDriver(string name, int age, string carnum) : base (name, age)
        {
            CarNum = carnum;
        }

        public void CarInfo(string carnum, string car)
        {
            if (carnum !=string.Empty)
            {
                MessageBox.Show($"{Name}이 소유한 차량은 {car} 입니다");
            }
        }

        public override void Run(double meter)
        {
           base.Run(meter);
            MessageBox.Show($"택시 운전사는 {meter}km 더 갑니다");
        }

    }
}
