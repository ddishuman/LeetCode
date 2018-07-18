using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp_LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int k = 100;
            int target = 0;
            //int result = 0;
            int[] nums = new int[] { 2,3,1,1,4 };
            int[] nums1 = new int[] { 1, 3, 5 };
            int[] nums2 = new int[] { 1, 3, 5 };
            bool[] used = new bool[nums.Length];

            //int maxlength = 0;
            //int Count = nums[0];
            //bool check = false;

            var hs = new HashSet<int>();
            int index = 0;
            int step = 0;

            CheckStep(step, index, nums[0], nums, hs);
            return hs.Min();

            //Array.Reverse(nums);

            //Console.WriteLine(string.Join(",", result));

        }

        private static void CheckStep(int step, int index, int count, int[] nums, HashSet<int> hs)
        {
            if (index + count >= nums.Length - 1)
            {
                step++;
                if (!hs.Add(step))
                    return;
            } 
            else
            {
                step++;
                for (;  count >0; count--)
                {
                    CheckStep(step, index, nums[index + count], nums, list);
                }
            }
        }


    }

    
    
}
