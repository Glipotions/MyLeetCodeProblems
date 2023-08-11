using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    return (int)Math.Floor(i - 1);
            }

            return 0;
        }

        public int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (n == 2) return 2;

            int a = 1, b = 2, c = 0;
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;

        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode? temp = head;

            while (temp != null)
            {
                if (temp.val == temp.next?.val)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
            }
            return head;
        }


        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //List<int> nums1L = nums1.Take(m).ToList();
            //List<int> nums2L = nums2.Take(n).ToList();

            //var merge = nums1L.Concat(nums2L).OrderBy(x => x).ToArray();
            //nums1 = merge;
            //return merge;

            var lngt = nums1.Length;
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];

            }
            for (int i = 0; i < m + n; i++)
            {
                if (i - 1 < lngt && i - 1 >= 0)
                {
                    if (nums1[i] < nums1[i - 1])
                    {
                        int sayi1 = nums1[i - 1];
                        nums1[i - 1] = nums1[i];
                        nums1[i] = sayi1;
                    }
                }
            }
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var yazi = x.ToString();
            for (int i = 0; i < yazi.Length - 1; i++)
            {
                if (yazi[i] != yazi[(yazi.Length - 1) - i]) return false;
            }
            return true;
        }

        public bool IsMatch(string s, string p)
        {
            if (s.Length != p.Length) return false;
            var sArr = s.ToArray();
            var pArr = p.ToArray();
            if (p.Contains("."))
            {
                var ch = p.IndexOf(".");
                pArr[ch] = s[ch];
            }
            if (p.Contains("*"))
            {
                var ch = p.IndexOf("*");
                if (sArr[ch - 1] <= sArr[ch])
                {
                    pArr[ch] = sArr[ch];
                }
                else
                {
                    return false;
                }
            }

            var sStr = new string(sArr);
            var pStr = new string(pArr);
            if (sStr == pStr) return true;

            return false;
        }

        public int MaxArea(int[] height)
        {
            var length = height.Length - 1;

            int t = 0;
            int maxArea = 0;


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (height[i] > height[j])
                    {
                        if (height[j] * (j - i) > maxArea)
                            maxArea = height[j] * (j - i);
                    }
                    else
                    {
                        if (height[i] * (i - j) > maxArea)
                            maxArea = height[i] * (i - j);
                    }
                }
            }

            return maxArea;

        }

        public IList<IList<int>> PascalsTriangleGenerate(int numRows)
        {
            IList<int> pascalRows = new List<int>();
            IList<IList<int>> pascals = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                pascalRows = new List<int>();
                if (i == 0)
                {
                    pascalRows = new List<int>() { 1 };
                }
                else
                {
                    var prevPascalRow = pascals[i - 1];
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0)
                        {
                            pascalRows.Add(1);
                        }
                        else if (j == i)
                        {
                            pascalRows.Add(1);
                        }
                        else
                        {
                            pascalRows.Add(prevPascalRow[j - 1] + prevPascalRow[j]);
                        }
                    }
                }

                pascals.Add(pascalRows);
            }
            return pascals;
        }
        public IList<int> PascalsTriangleGetRow(int numRows)
        {
            IList<int> pascalRows = new List<int>();
            IList<IList<int>> pascals = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                pascalRows = new List<int>();
                if (i == 0)
                {
                    pascalRows = new List<int>() { 1 };
                }
                else
                {
                    var prevPascalRow = pascals[i - 1];
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0)
                        {
                            pascalRows.Add(1);
                        }
                        else if (j == i)
                        {
                            pascalRows.Add(1);
                        }
                        else
                        {
                            pascalRows.Add(prevPascalRow[j - 1] + prevPascalRow[j]);
                        }
                    }
                }

                pascals.Add(pascalRows);
            }
            return pascalRows;
        }

        public int MaxProfit(int[] prices)
        {


            var min = prices[0];
            var profit = 0;
            foreach (var item in prices)
            {
                profit = Math.Max(profit, item - min);
                min = Math.Min(item, min);
            }

            return profit;
        }


        public bool IsPalindrome(string s)
        {
            s = s.Replace(" ", "").ToLower();
            s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
            var t = string.Empty;
            //var reverse = s.Reverse().Select(x => t += x).LastOrDefault("");
            foreach (var item in s)
            {
                t = item+t;
            }
            var ret = t == s;

            return ret;
        }

        public int SingleNumber(int[] nums)
        {

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
