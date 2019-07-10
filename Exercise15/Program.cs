using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {3,8,10,2,7,5,9,6,78,56,34 };
            string[] array2 = new string[] {"Alex","Mike","Eric","Bob","Tina","David","Leo","Judy" };

            // ========== 排序兩個陣列 ==========
            array1 = Sort.QuickSort(array1);
            array2 = Sort.QuickSort(array2);
            // ==================================


            Console.WriteLine("Array1 的元素經過排序後依序為 ：");
            for(int i = 0;i < array1.Length;i++)
            {
                Console.Write(array1[i] + "\t");
            }
            Console.WriteLine("\n\nArray2 的元素經過排序後依序為 ：");
            for(int i = 0;i < array2.Length;i++)
            {
                Console.Write(array2[i] + "\t");
            }
        }
    }
    class Sort
    {
        #region 快速排序法
        public static int[] QuickSort(int[] array)
        {
            if (array.Length < 2)
                return array;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> result = new List<int>();
            int idx = array.Length / 2;
            int pivot = array[idx];
            for(int i = 0;i < array.Length;i++)
            {
                if (i == idx)
                    continue;
                if (array[i] >= pivot)
                    right.Add(array[i]);
                else
                    left.Add(array[i]);
            }
            result.AddRange(QuickSort(left.ToArray()));
            result.Add(pivot);
            result.AddRange(QuickSort(right.ToArray()));
            return result.ToArray();
        }
        #endregion

        #region 快速排序法(泛型)
        public static T[] QuickSort<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length < 2)
                return array;
            List<T> left = new List<T>();
            List<T> right = new List<T>();
            List<T> result = new List<T>();

            int idx = array.Length / 2;
            T pivot = array[idx];

            for(int i = 0;i < array.Length;i++)
            {
                if (i == idx)
                    continue;
                if (pivot.CompareTo(array[i]) > 0)
                    left.Add(array[i]);
                else
                    right.Add(array[i]);
            }

            result.AddRange(QuickSort(left.ToArray()));
            result.Add(pivot);
            result.AddRange(QuickSort(right.ToArray()));
            return result.ToArray();
        }
        #endregion
    }
}
