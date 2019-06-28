using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= i =======");
            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);

            Console.WriteLine("======= j =======");
            int j = 5;
            Console.WriteLine(j);
            Console.WriteLine(++j);
            Console.WriteLine(j);

            Console.WriteLine("======= a + b =======");
            int a = 10, b = 8;
            Console.WriteLine(a + b);

            Console.WriteLine("======= c * d =======");
            double c = 2.5, d = 0.5;
            Console.WriteLine(c * d);

            Console.WriteLine("======= a / b =======");
            Console.WriteLine(a / b);

            Console.WriteLine("======= c / d =======");
            Console.WriteLine(c / d);

            Console.WriteLine("======= j % i =======");
            Console.WriteLine(j % i);

            Console.WriteLine("======= i % j =======");
            Console.WriteLine(i % j);
        }
    }
}
