using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        /*
         * 河內塔
         * 將 n 層盤子從 A 移動至 C，一次只能移動一個盤子
         * 且較大的盤子不能放在較小的盤子上
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入 n 層河內塔");
            int n = int.Parse(Console.ReadLine());
            Hanoi(n,n, 'A', 'B', 'C');
        }

        static void Hanoi(int n,int no,char source,char temp,char destination)
        {
            if(n == 1)
            {
                Console.WriteLine("將 {0} 號盤從 {1} 移至 {2}", no, source, destination);
            }
            else
            {
                Hanoi(n - 1,n - 1, source, destination, temp);
                Hanoi(1, n, source, temp, destination);
                Hanoi(n - 1,n - 1, temp, source, destination);
            }
        }
    }
}
