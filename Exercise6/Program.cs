using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        /*
         * 判斷一數是不是質數
         */
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一正整數");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if(num > 1)
            {
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(input + "不是質數");
                        return;
                    }
                }
                Console.WriteLine(input + "是質數");
            }
            else
            {
                Console.WriteLine("只有大於1的正整數才能討論質數");
            }
            
        }
    }
}
