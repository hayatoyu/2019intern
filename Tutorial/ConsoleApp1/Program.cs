using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 在宣告字典物件的同時，也要宣告其鍵值與值的資料型態。此範例中均為字串類型。
            Dictionary<string, string> election2020 = new Dictionary<string, string>();
            election2020.Add("宋楚瑜", "親民黨");
            election2020.Add("韓國瑜", "國民黨");
            election2020.Add("蔡英文", "民進黨");
            election2020.Add("宋楚瑜", "過去曾是國民黨");  // 現在好好的管人家過去幹嘛？

            foreach(var election in election2020)
            {
                Console.WriteLine($"{election.Key} 屬於 {election.Value}");
            }
            Console.ReadLine();
        }
    }
}
