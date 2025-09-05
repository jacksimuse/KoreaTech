using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Info()
        {
            MessageBox.Show($"이름 : {Name} 나이 : {Age}");
        }

        public void Info(string school)
        {
            MessageBox.Show($@"안녕하세요 {school}을 다니고 있는
이름 : {Name} 나이 : {Age} 입니다");
        }

        public void Info(double height, double weight)
        {
            MessageBox.Show($@"이름 : {Name}, 나이 : {Age}
키 : {height}, 몸무게 : {weight}");
        }

        public virtual void Run(double meter)
        {
            MessageBox.Show($@"사람은 하루에 {meter}m를 달릴 수 있습니다");
        }
    }
}
