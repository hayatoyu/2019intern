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
            MultipleTable(1, 1);
        }

        
        static void MultipleTable(int i,int j)
        {
            #region 解答
            if (j > 9)
            {
                j -= 9;
                i++;
                Console.WriteLine("\n");
            }
            if (i > 9)
                return;
            //Console.Write(i + " * " + j + " = " + (i * j) + "\t");
            Console.Write($"{i} * {j} = {i * j} \t");
            MultipleTable(i, ++j);
            #endregion
        }



    }
}
