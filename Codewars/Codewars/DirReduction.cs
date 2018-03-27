using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class DirReduction
    {
        public static string[] dirReduc(String[] arr)
        {
            int x = 1;
            List<string> reducedDirections = new List<string>();
            while (x != 0)
            {
                x = 0;
                reducedDirections.Clear();
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if ((arr[i] == "NORTH" && arr[i + 1] == "SOUTH")
                        || (arr[i] == "WEST" && arr[i + 1] == "EAST")
                        || (arr[i] == "SOUTH" && arr[i + 1] == "NORTH")
                        || (arr[i] == "EAST" && arr[i + 1] == "WEST"))
                    {
                        arr[i] = null;
                        arr[i + 1] = null;
                    }
                }

                foreach (string s in arr)
                {
                    if (s != null)
                    {
                        reducedDirections.Add(s);
                    }
                    else if (s == null)
                    {
                        x = 1;
                    }
                }                
                Array.Resize(ref arr, reducedDirections.Count);
                arr = reducedDirections.ToArray();
            }
            return arr;
        }

        /* Better: Stack
         * public static String[] dirReduc(String[] arr) {
        Stack<String> stack = new Stack<String>();
 
        foreach (String direction in arr) {
            String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;
 
            switch(direction) {
                case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "EAST":  if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "WEST":  if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
            }
        }
        String[] result = stack.ToArray();        
        Array.Reverse(result);
       
        return result;              
        }
        */

        public static void Main()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            dirReduc(a);
            Console.ReadKey();
        }
    }
}
