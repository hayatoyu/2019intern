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
            interns.Add("陳○陞");
            interns.Add("吳○筑");
            interns.Add("王○慈");
            interns.Add("林○宏");
            interns.Add("王○瑄");
            interns.Add("陳○妤");
            interns.Add("曾○彤");
            interns.Add("魏○淳");
            interns.Add("吳○仙");
            interns.Add("李○臻");
            interns.Add("黃○瑄");
            interns.Add("莊○軒");
            interns.Sort();
            Console.WriteLine("目前實習生人數 " + interns.Count);
            string target = "陳○妤";

            #region 開始搜尋
            int index = BinarySearch(interns, target);
            if (index > -1)
                Console.WriteLine($"{target} 同學的索引值為 {index}，在第 {index + 1} 位");
            
            else
                Console.WriteLine($"找不到 {target} 同學");
            #endregion
        }

        #region 搜尋方法
        static int BinarySearch(List<string> interns, string name)
        {
            int left = 0, right = interns.Count;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (interns[mid].Equals(name))
                    return mid;
                else if (interns[mid].CompareTo(name) > 0)
                    right = mid - 1;
                else if (interns[mid].CompareTo(name) < 0)
                    left = mid + 1;
            }
            return -1;
        }
        #endregion
    }
}
