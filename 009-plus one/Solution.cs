using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _009_plus_one
{
    public class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;

        }
    }
}
