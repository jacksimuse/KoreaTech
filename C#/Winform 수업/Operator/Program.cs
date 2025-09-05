using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 산술연산자
            int a = 1;
            int b = 2;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            // 2. 증가/감소 연산자
            Console.WriteLine(++a); // a = a + 1  / a++ -> 후위 연산자 / ++a -> 전위 연산자
            Console.WriteLine(--b); // b = b - 1 

            // 3. 관계연산자
            Console.WriteLine(a > b); // 초과
            Console.WriteLine(a < b); // 미만
            Console.WriteLine(a >= b); // 이상 
            Console.WriteLine(a <= b); // 이하
            Console.WriteLine(a == b); // 같음?
            Console.WriteLine(a != b); // 다름?

            // 4. 논리연산자
            bool c = true;
            bool d = false;

            Console.WriteLine(c && d); // false
            Console.WriteLine(c || d); // true
            Console.WriteLine(!c); // false
            Console.WriteLine(!d); //  true

            // 5. 비트연산자
            int e = 3; // 011 
            int f = 4; // 100

            Console.WriteLine(e & f);
            Console.WriteLine(e | f);
            Console.WriteLine(e ^ f);
            Console.WriteLine(~e);
            Console.WriteLine(~f);
            Console.WriteLine(e << f);
            Console.WriteLine(e >> f);

            // 6. 할당연산자
            e = 10;
            Console.WriteLine(e);
            e += 20;
            Console.WriteLine(e);
            e -= 5;
            Console.WriteLine(e);
            e *= 2;
            Console.WriteLine(e);
            e /= 3;
            Console.WriteLine(e);
            e %= 4;
            Console.WriteLine(e);
            e &= 5; // e = e & 5
            Console.WriteLine(e);
            e |= 6;  // e = e | 6
            Console.WriteLine(e);

            e ^= 6;  // e = e ^ 6
            Console.WriteLine(e);
            e <<= 6;  // e = e << 6
            Console.WriteLine(e);
            e >>= 6;  // e = e >> 6
            Console.WriteLine(e);

            Console.WriteLine(e >= 0 ? "크다" : "작다");


        }
    }
}
