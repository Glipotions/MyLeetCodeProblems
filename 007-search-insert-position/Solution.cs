using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_search_insert_position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Any(x => x == target))
                return nums.ToList().IndexOf(target);
            else if (nums.Min() > target)
                return 0;
            else if (nums.Max() < target)
                return nums.Length;
            foreach (int num in nums)
            {
                if (num > target)
                    return nums.ToList().IndexOf(num);
            }
            
            // buraya asla gelmez
            return 0;
        }
    }
}
