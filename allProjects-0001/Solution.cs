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
            List<int> nums1L = nums1.Take(m).ToList();
            List<int> nums2L = nums2.Take(n).ToList();

            nums1 = nums1L.Concat(nums2L).OrderBy(x => x).ToArray();

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
