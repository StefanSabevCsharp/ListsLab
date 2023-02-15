using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.Where(x => x > 0).Reverse();
            List<int> Sorted = numbers.Where(x => x > 0).Reverse().ToList();

            if (Sorted.Count > 1)
            {
                Console.WriteLine(string.Join(" ",Sorted));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
