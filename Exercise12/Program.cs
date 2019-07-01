using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        /*
         * 九九乘法表
         */
        static void Main(string[] args)
        {
            MultipleTable(1, 1, 9, 9);
        }

        #region 解答
        static void MultipleTable(int i,int j,int x,int y)
        {
            if(j > y)
            {
                j -= y;
                i++;
                Console.WriteLine("\n");
            }
            if (i > x)
                return;
            Console.Write(i + " * " + j + " = " + (i * j) + "\t");
            MultipleTable(i, ++j, x, y);
        }
        #endregion


    }
}
