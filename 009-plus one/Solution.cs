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
            string numStr = "";
            foreach (int i in digits)
            {
                numStr += i;
            }
            var num = int.Parse(numStr);
            num++;


            List<int> retArr = new();
            foreach (var item in num.ToString())
            {
                retArr.Add(Convert.ToInt32(new string(item, 1)));
            }

            return retArr.ToArray();
        }
    }
}
