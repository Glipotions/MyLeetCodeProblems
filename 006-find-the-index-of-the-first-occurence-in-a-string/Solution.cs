using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_find_the_index_of_the_first_occurence_in_a_string
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                var t=haystack.Replace(needle, "#");
                return t.IndexOf("#");
            }
            else
                return -1;
        }
    }
}
