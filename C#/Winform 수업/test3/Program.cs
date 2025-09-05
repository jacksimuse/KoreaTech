using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 사칙연산 a = 10 / b =20
            // 2. 관계연산 a와 b 관계 연산 >, <, >= 
            // 3. 비트 &, |, ~,       <<, >>  3칸 씩 옮기기
            // 4. 삼항연산 a와 b 비교하고 "정답" : "오답"

            int a = 10;
            int b = 20;
            // 1. 5개 
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // 2. 6개
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            // 3. 5개
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(~a);
            Console.WriteLine(a << 3);
            Console.WriteLine(b >> 3);
            
            // 4. 1개
            Console.WriteLine(a > b ? "정답" : "오답");

            // 설정 값 토글하기 
            // 설정 초기값은 21, 4번째 비트에 신호를 확인하여 신호가 있으면 끄는 코드 작성
            int init = 21; // 00010101 
            int check = 8; // 00001000
            init = init ^ check; 
            Console.WriteLine(init);

        }
    }
}
