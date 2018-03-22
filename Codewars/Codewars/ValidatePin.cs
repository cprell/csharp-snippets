using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    class ValidatePin
    {
        public static bool ValidatePinString(string pin)
        {
            string pattern = "";
            if (pin.Length.Equals(4))
            {
                pattern = @"\d{4}";
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                Match m = r.Match(pin);
                while (m.Success) return true;
            }
            else if (pin.Length.Equals(6))
            {
                pattern = @"\d{6}";
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                Match m = r.Match(pin);
                while (m.Success) return true;
            }
            return false;
        }

        /*
         * return new Regex(@"^(\d{4}|\d{6})$").IsMatch(pin);
         * */

        public static void Main()
        {
            Console.WriteLine(ValidatePinString("1234"));
            Console.WriteLine(ValidatePinString("493"));
            Console.WriteLine(ValidatePinString("95453"));
            Console.WriteLine(ValidatePinString("654321"));
            Console.WriteLine(ValidatePinString("-1234"));
            Console.WriteLine(ValidatePinString("-1-1-1-1"));
            Console.ReadKey();
        }
    }
}
