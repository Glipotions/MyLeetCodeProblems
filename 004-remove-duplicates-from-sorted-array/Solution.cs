﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_remove_duplicates_from_sorted_array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var dsc= nums.Distinct().ToArray();

            for (int i = 0; i < dsc.Length; i++)
            {
                nums[i] = dsc[i];
            }

            return dsc.Length;
        }
    }
}
