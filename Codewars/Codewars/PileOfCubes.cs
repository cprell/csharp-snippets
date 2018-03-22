using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class PileOfCubes
    {
        public static long FindNb(long m)
        {
            int n = PileUp(m);
            return n;
        }

        public static int PileUp(long m)
        {
            int n = 0;
            if (m == 1) return 1;

            while (m > 0)
            {
                n++;
                long number = n;
                m = m - (number* number * number);
                Console.WriteLine("m = {0} \t n = {1}", m, n);
                if (m < 0) return -1;
            }
            return n;
        }

        public static void Main()
        {
            // FindNb(1071225);
            // FindNb(4183059834009);
            // FindNb(24723578342962);
            // FindNb(135440716410000);
            // Console.ReadKey();
        }
    }
}
