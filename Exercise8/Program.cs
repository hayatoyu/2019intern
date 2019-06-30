using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        /*
         * 輾轉相除法
         */
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個正整數");
            string input1 = Console.ReadLine();
            Console.WriteLine("請輸入第二個正整數");
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            while((num1 % num2 > 0) && (num2 % num1 > 0))
            {
                if (num1 > num2)
                    num1 %= num2;
                else
                    num2 %= num1;
            }
            Console.WriteLine(input1 + " 與 " + input2 + "之最大公因數為 " + Math.Min(num1, num2));
        }
    }
}
