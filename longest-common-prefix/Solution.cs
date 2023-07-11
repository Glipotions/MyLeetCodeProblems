using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_common_prefix
{
    public class Solution
    {
        /// <summary>
        /// shortest ile listedeki en kısa yazı alınarak onun uzunluğu referans alınır
        /// strs.Select(x => x[i]) ile strs listesindeki tüm elemanların i. indexini alır
        /// Örneğin {"flower", "flow", "flight"} listesinde i=0 için hepsinin ilk değeri olan "f" yi 3 kere alır
        /// i=1 için hepsinin 2. değeri olan "l" yi 3 kere alır i=2 için ise "o" ve "i" yi alır çünkü flight'ın 2. indexi "i" dir
        /// Distinct ile aynı olanlardan tek sayıda olacak şekilde liste yapar ve 1 den fazla ise bu demek oluyor ki farklı bir karakter karşılaştırılmış
        /// 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {

            string shortest = strs.OrderBy(x => x.Length).First();

            for (int i = 0; i < shortest.Length; i++)
            {
                if (strs.Select(x => x[i]).Distinct().Count() > 1) return shortest[..i];
            }
            return shortest;
        }
    }
}