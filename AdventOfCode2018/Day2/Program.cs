using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var allLines = File.ReadAllLines("input.txt");
            var numberOf2 = 0;
            var numberOf3 = 0;
            var has2 = false;
            var has3 = false;

            foreach (var id in allLines)
            {
                Check(id, out has2, out has3);
                if (has2)
                {
                    numberOf2++;
                }
                if (has3)
                {
                    numberOf3++;
                }
            }

            Console.WriteLine(numberOf2 * numberOf3);
            Console.ReadLine();
        }

        public static void Check(string id, out bool has2, out bool has3)
        {
            has2 = false;
            has3 = false;

            var chars = new Dictionary<char, int>();
            foreach (var c in id)
            {
                if (chars.ContainsKey(c))
                {
                    chars[c]++;
                }
                else
                {
                    chars.Add(c, 1);
                }
            }

            foreach (var value in chars.Values)
            {
                if (value == 2)
                {
                    has2 = true;
                }
                if (value == 3)
                {
                    has3 = true;
                }
                if (has2 && has3)
                {
                    return;
                }
            }
        }
    }
}
