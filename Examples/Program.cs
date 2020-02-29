using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 計算 97 是不是質數
            // 質數定義：僅能被 1 和自己本身整除的正整數
            // 質數找法：如果一個正整數在小於等於自己正平方根的範圍內找不到能整除它的數，那它就是質數
            int target = 97;
            int div = 2;
            bool isPrime = true;

            while(div * div <= target)
            {
                if(target % div == 0)
                {
                    isPrime = false;
                    break;
                }
                div++;
            }

            if (isPrime)
                Console.WriteLine($"{target} 是 質數");
            else
                Console.WriteLine($"{target} 不是 質數");
            Console.ReadLine();
        }
    }
}
