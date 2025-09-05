using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    internal class Program
    {

        static double Square(double arg)
        {
            return Math.Pow(arg,2);

            //return arg * arg;
        }
        static void Main(string[] args)
        {
            //1번 문제
            //Console.WriteLine("수를 입력하세요 : ");
            //string input = Console.ReadLine();
            //double arg = Convert.ToDouble(input);

            //Console.WriteLine("결과 : {0}", Square(arg));



            // 2번 문제
            // 방법1
            //double mean = 0;
            //mean = Mean(1, 2, 3, 4, 5, mean);
            //Console.WriteLine("평균 : {0}", mean);

            // 방법2
            //double mean = 0;
            //Mean(1, 2, 3, 4, 5, out mean);
            //Console.WriteLine("평균 : {0}", mean);

            //방법3
            //double mean = 0;
            //Mean(1, 2, 3, 4, 5, ref mean);
            //Console.WriteLine("평균 : {0}", mean);

            // 3번 문제
            int a = 3;
            int b = 4;
            int resultA = 0;

           // Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            //  Plus(x, y, out resultB);

            // 오버로드 = 같은 메서드 명을 사용하며 다른 인자를 받아와서 작동한다.
            Plus(5, 3.14, out resultB);

            Console.WriteLine("{0} +{1} = {2}", x, y, resultB);
        }

        private static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        private static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }

        private static void Plus(int a, double b, out double c)
        {
            c = a + b;
        }

        private static void Plus(int a, double b, int d,  out double c)
        {
            c = a + b;
        }


        //방법 1
        //private static double Mean(double a, double b, double c, double d, double e, double mean)
        //{
        //    // 2번문제 mean이 0의 값을 가지는 이유는?
        //    return mean = (a + b + c + d + e) / 5;
        //}

        // 방법2
        //private static void Mean(double a, double b, double c, double d, double e, out double mean)
        //{
        //    // 2번문제 mean이 0의 값을 가지는 이유는?
        //    mean = (a + b + c + d + e) / 5;
        //}

        // 방법3
        //private static void Mean(double a, double b, double c, double d, double e, ref double mean)
        //{
        //    // 2번문제 mean이 0의 값을 가지는 이유는?
        //    mean = (a + b + c + d + e) / 5;
        //}
    }
}
