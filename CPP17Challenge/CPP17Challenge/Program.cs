/*
 * https://www.fluentcpp.com/2017/09/25/expressive-cpp17-coding-challenge/
 * */

using System;
using System.IO;

namespace CPP17Challenge
{
    class Program
    {
        static void ReplaceColumn(String[] s, int column, String replaceString)
        {
            s[column] = replaceString;
        }

        static void Main(string[] args)
        {
            int columnNumber = 0;
            char delimiter = ',';
            String fileName = args[0];
            String column = args[1];
            String replace = args[2];
            bool header = false;

            try
            {  
                using (StreamReader sr = new StreamReader("../../" + fileName))
                {
                    while (sr.Peek() >= 0)
                    {
                        
                        // Header file first

                        String line = sr.ReadLine();
                        String[] substrings = line.Split(delimiter);

                        if (header == false)
                        {
                            if (line.Contains(column))
                            {
                                header = true;
                                Console.WriteLine(line);

                                // Determine the column Number
                                for (int i = 0; i < substrings.Length; i++)
                                {
                                    if (substrings[i] == column)
                                    {
                                        columnNumber = i;
                                    }
                                }

                                continue;
                            }
                            else if (line.Contains(column))
                            {
                                Console.WriteLine("Not a valid file");
                                System.Environment.Exit(0);
                            }
                        }

                        ReplaceColumn(substrings, columnNumber, replace);

                        for (int i = 0; i < substrings.Length; i++)
                        {
                            Console.Write(substrings[i]);
                            if (i != substrings.Length-1)
                            {
                                Console.Write(delimiter);
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
