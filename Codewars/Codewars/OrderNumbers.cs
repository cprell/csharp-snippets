using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class OrderNumbers
    {
        public static int DescendingOrder(int num)
        {
            String s = num.ToString();
            int[] a = new int[s.Length];
            

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (s.ElementAt(i));
                a[i] = a[i] - 48;
            }

            Array.Sort(a);
            Array.Reverse(a);

            s = string.Join(string.Empty, a);
            Int32.TryParse(s, out num);
            return num;
        }

        /*
         * return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
         * 
         * --------------
         * 
         * char[] arr = num.ToString().ToCharArray();
         * Array.Sort(arr);
         * Array.Reverse(arr);
         * return Convert.ToInt32(new string(arr));
         * 
         * */

        public static void Main()
        {
            DescendingOrder(395);
            Console.ReadKey();
        }
    }
}
