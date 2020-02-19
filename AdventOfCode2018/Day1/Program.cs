using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var allLines = File.ReadAllLines("input.txt");
            var currentFreq = new List<int>();

            var current = 0;
            while(true)
            {
                foreach (var item in allLines)
                {
                    var num = int.Parse(item);
                    current += num;

                    if (!currentFreq.Contains(current))
                    {
                        currentFreq.Add(current);
                    }
                    else
                    {
                        Console.WriteLine($"Founded: {current}, size {currentFreq.Count}");
                        return;
                    }
                };
            }            
        }


        static private void Part1()
        {
            Console.WriteLine("Hello World!");
            var allLines = File.ReadAllLines("input.txt");
            var sum = 0;
            foreach (var item in allLines)
            {
                var num = int.Parse(item);
                sum += num;
            };
            Console.WriteLine($"number of lines {allLines.Length}");

            Console.WriteLine(sum);
        }
    }
}
