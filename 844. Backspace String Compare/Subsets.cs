using System;
using System.Collections.Generic;
using System.Linq;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input: nums = [1, 2, 3]
            //Output:[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
            //Input: s = "ab#c", t = "ad#c"
            //Int64 n = 1804289383;
            //Int64 x =(Int64)Math.Floor((Math.Sqrt(1 + 8 * n) - 1) / 2);
            int[] nums = new int[] {2,5};
            Solution solution = new Solution();
            solution.function("ad#c");
            //solution.Rotate(nums, 2);
            //IList<IList<int>> lists = solution.Subsets(nums);
            //for (int i = 0; i < lists.Count; i++)
            //{
            //    Console.Write("[");
            //    for (int j = 0; j < lists[i].Count; j++)
            //    {
            //        Console.Write(lists[i][j]);
            //    }
            //    Console.WriteLine("]");

            //}

        }

        public class Solution
        {
            public string function(string str)
            {
                char[] CharArray = str.ToCharArray();
                for (int i = 0; i < CharArray.Length; i++)
                {
                    if (CharArray[i] == '#')
                    {
                        str.Remove(i - 1, 2);
                    }
                }
                return str;
            }
            public IList<IList<int>> Subsets(int[] nums)
            {

                List<IList<int>> res = new List<IList<int>>();
                if (nums == null || nums.Length == 0)
                    return res;

                backtracking(nums, 0, new List<int>(), res);
                return res;
            }

            private void backtracking(int[] nums, int start, List<int> list, List<IList<int>> res)
            {
                res.Add(new List<int>(list));
                for (int i = start; i < nums.Length; i++)
                {
                    list.Add(nums[i]);
                    backtracking(nums, i + 1, list, res);
                    list.RemoveAt(list.Count - 1);

                }
            }



           
            public int Search(int[] nums, int target)
            {
                int start = 0; 
                int end = nums.Length-1;
                int mid = -1;
                while (start + 1 < end) 
                {
                    mid = (start + end) / 2;

                    if (target < nums[mid]) { end = mid; }
                    else if (target > nums[mid]) { start = mid; } 
                    else if (target == nums[mid]) { start = mid; }
                }
                if(nums[start] == target)
                    return start;
                if (nums[end] == target)
                    return end;

                return -1;
            }


        }



    }
}