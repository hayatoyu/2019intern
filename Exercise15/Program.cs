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
            Sort.BubbleSort(array1);
            Sort.BubbleSort(array2);
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
        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            T temp;
            bool swap;
            for(int i = 0;i < array.Length;i++)
            {
                swap = false;
                for(int j = 0;j < array.Length - i - 1;j++)
                {
                    if(array[j].CompareTo(array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        if (!swap)
                            swap = true;
                    }
                }
                if (!swap)
                    return;
            }
        }
    }
}
