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
            Hanoi(1,n,n, 'A', 'B', 'C');
        }

        
        static int Hanoi(int step,int n,int no,char source,char temp,char destination)
        {
            #region 解答
            if (n == 1)
            {
                Console.WriteLine("步驟{0}：將 {1} 號盤從 {2} 移至 {3}",step, no, source, destination);
            }
            else
            {
                step = Hanoi(step,n - 1,n - 1, source, destination, temp);
                step = Hanoi(step,1, n, source, temp, destination);
                step = Hanoi(step,n - 1,n - 1, temp, source, destination);
            }
            
            return n == 1 ? ++step : step;
            #endregion
        }        

    }
}
