using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _005_remove_element
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            /// Seçenek 1
            var t = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    t.Add(nums[i]);
                }
            }
            for (int i = 0; i < t.Count(); i++)
            {
                nums[i] = t[i];
            }

            return t.Count();

            /// Seçenek 2
            
            //int j = 0;
            //foreach (int i in nums)
            //{
            //    if (i != val)
            //    {
            //        nums[j++] = i;
            //    }
            //}

            //return j;
        }


    }
}
