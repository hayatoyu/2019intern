using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        /*
         * 計算出1到100的總和
         */
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 0;i < 101;i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
