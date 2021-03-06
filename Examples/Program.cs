﻿using System;
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
            // 在宣告字典的同時，也必須宣告其鍵值與值的資料型態。此範例中都是字串類型
            Dictionary<string, string> election2020 = new Dictionary<string, string>();
            election2020.Add("宋楚瑜", "親民黨");
            election2020.Add("韓國瑜", "國民黨");
            election2020.Add("蔡英文", "民進黨");

            // output
            foreach(var election in election2020)
            {
                Console.WriteLine($"{election.Key} 屬於 {election.Value}");
            }
        }
    }
}
