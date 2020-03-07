using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();
            employees.Add("Employee1");
            employees.Add("Employee2");
            employees.Add("Employee3");
            Console.WriteLine($"公司的員工個數：{employees.Count}");

            Console.WriteLine("公司新進了一個員工...");
            employees.Add("Employee4");
            Console.WriteLine($"公司目前的員工個數：{employees.Count}");

            Console.WriteLine("Employee2離職了...");
            employees.RemoveAt(1);
            Console.WriteLine($"公司目前的員工個數：{employees.Count}");

            Console.WriteLine("目前的員工依序為：");
            for(int i = 0;i < employees.Count;i++)
            {
                Console.Write($"{employees[i]}\t");
            }
            Console.ReadLine();
        }
    }
}
