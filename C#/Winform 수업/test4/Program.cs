using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 별찍기
            /* 
             *  1번 문제
             * *
             * **
             * ***
             * ****
             * *****
             */

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            /* 2번 문제
             * *****
             * ****
             * ***
             * **
             * *
             */

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // 3번 문제 1,2번을 for -> do while로 바꾸기
            int a = 1;
            while (a <= 5)
            {
                int j = 0;
                while (j < a)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                a++;
            }

            a = 1;
            while (a <= 5)
            {
                int j = 5;
                while (j > a)
                {
                    Console.Write("*");
                    j--;
                }
                Console.WriteLine();
                a++;
            }


            // 4번 문제 
            // 입력 받은 횟수 만큼 별을 반복 출력하는 프로그램
            // 입력 받은 함수 Console.ReadLine();


            // 4번 문제 템플릿
            int count = 10;
            while (count >= 0)
            {
                Console.WriteLine("반복 횟수를 입력하세요 : ");
                string str = Console.ReadLine();
                int b = int.Parse(str);
                if (b <= 0)
                {
                    Console.WriteLine("0보다 같거나 작은 수는 사용할 수 없습니다.");
                }
                // 별찍는 for문
                for (int i = 1; i <= b; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                count--;
            }


            //for (int i = 2; i <= 9; i++)
            //{
            //    for(int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i*j}");
            //    }
            //}
        }
    }
}
