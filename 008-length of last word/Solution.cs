using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_length_of_last_word
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var a = s.Trim().Split(" ");
            return a[^1].Length;
            //
            //var lastWord = splitList.Last();
            //return lastWord.Length;
        }
    }
}
