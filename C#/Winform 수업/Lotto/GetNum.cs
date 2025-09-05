using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class GetNum
    {
        const int min = 1;
        const int max = 45;
        const int lottoball = 6;
        int[] nums = new int[lottoball];
        Random rd = new Random();


        void NumInit()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        bool IsOverLap(int num)
        {
            bool check = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (num == nums[i])
                {
                    check = true;
                }
            }
            return check;
        }

        public void Gen()
        {
            int cnt = 0;
            NumInit();
            while (cnt < lottoball)
            {
                int num = rd.Next(min, max + 1);
                if (!IsOverLap(num))
                {
                    nums[cnt] = num;
                    cnt++;
                }
            }

            Array.Reverse(nums);
            Array.Sort(nums);
           
        }


        public string GetStr()
        {
            string str = string.Empty;
            for (int i = 0; i < nums.Length; i++)
            {
                str += nums[i].ToString() + " ";
            }
            return str;
        }
    }
}
