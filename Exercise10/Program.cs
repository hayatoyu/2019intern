using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> interns = new List<string>();
            interns.Add("不知名");
            Console.WriteLine("目前實習生人數 " + interns.Count);
            Console.WriteLine("實習生名單如下： ");
            for(int i = 0;i < interns.Count;i++)
            {
                Console.Write(interns[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
