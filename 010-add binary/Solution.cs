using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_add_binary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var aNum = Convert.ToInt32(a, 2);
            var bNum = Convert.ToInt32(b, 2);

            var sum = aNum + bNum;
            if (sum == 0) return "0";
            int kalan;
            string ret = "";
            while (sum != 0)
            {
                kalan = sum % 2;
                sum /= 2;
                ret = kalan.ToString() + ret;
            }

            return ret;
        }
    }
}