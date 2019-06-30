using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        /*
         * Excel 的行(Column)有兩種表示法：
         * 1. 可以 A,B,C,....,Z,AA,AB,AC......
         * 2. 數字表示
         * 其中
         *  A -> 1
         *  B -> 2
         *  .......
         *  Z -> 26
         *  AA -> 27
         *  AB -> 28
         *  ........
         *  ZY -> 701
         *  
         *  請寫出一個轉換方式，輸入數字，轉換為標題表示
         *  不限使用迴圈或遞迴
         *  
         *  提示：
         *      可能需要使用 ASCII 轉換字元及數字做計算
         */
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入 Excel 行索引值");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToTitle(num));
        }

        static string ConvertToTitle(int num)
        {
            return num < 1 ? string.Empty : ConvertToTitle((num - 1) / 26) + (char)((num - 1) % 26 + 'A');
        }
    }
}
