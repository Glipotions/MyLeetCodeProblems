using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allProjects_0001
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            //return (int)Math.Floor(Math.Sqrt(x));

            if (x == 1) return 1;

            for (double i = 0; i <= x; i++)
            {
                if (i * i > x)
                    return (int)Math.Floor(i-1);
            }

            return 0;
        }

        public int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (n == 2) return 2;

            int a = 1, b = 2, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;

        }
    }
}
