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
            interns.Add("班主任");
            Console.WriteLine("目前實習生人數 " + interns.Count);
            string target = "狄處長";

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
