using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of given length and false in any other case.
    (In this case, all triangles must have surface greater than 0 to be accepted).
*/

namespace Codewars
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c) => a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;

        public static void Main()
        {
            Console.WriteLine("Run Unit Tests");
            Console.ReadKey();
        }
    }
}
