using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5,18,37,0,121,73,3};
            BubbleSort(nums);
            for(int i = 0; i < nums.Length;i++)
            {
                Console.Write($"{nums[i]} \t");
            }
        }


        #region 氣泡排序法
        static void BubbleSort(int[] nums)
        {
            bool swap;
            for(int i = 0;i < nums.Length;i++)
            {
                swap = false;
                for(int j = 0;j < nums.Length - i - 1;j++)
                {
                    if(nums[j] > nums[j + 1])
                    {
                        swap = true;
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
                if (!swap)
                    return;
            }
        }
        #endregion
    }
}
