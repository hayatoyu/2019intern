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
            interns.Add("陳易陞");
            interns.Add("吳筱筑");
            interns.Add("王欣慈");
            interns.Add("林冠宏");
            interns.Add("王妤瑄");
            interns.Add("陳俐妤");
            interns.Add("曾友彤");
            interns.Add("魏雅淳");
            interns.Add("吳玉仙");
            interns.Add("李旻臻");
            interns.Add("黃昱瑄");
            interns.Add("莊惠軒");
            interns.Sort();
            Console.WriteLine("目前實習生人數 " + interns.Count);
            string target = "大象愛將";

            #region 開始搜尋
            int index = BinarySearch(interns, target);
            if (index > -1)
                Console.WriteLine($"{target} 同學在第 {index + 1} 位");
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
