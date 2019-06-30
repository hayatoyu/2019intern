using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        /*
         * 計算 1 ~ 100 的和
         */

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(100));
        }

        static int Sum(int n)
        {
            if (n == 1)
                return n;
            else
                return n + Sum(n - 1);
        }
    }
}
