using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5,18,37,0,121,73,3};
            for(int i = 0;i < nums.Length;i++)
            {
                if (IsPrime(nums[i]))
                    Console.WriteLine(nums[i] + " 是質數");
                else
                    Console.WriteLine(nums[i] + " 不是質數");
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            for(int i = 2;i * i <= num;i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
