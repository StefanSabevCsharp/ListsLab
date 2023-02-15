using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Add")
                {
                    int currentNum = int.Parse(input[1]);
                    numbers.Add(currentNum);
                }
                else if (input[0] == "Remove")
                {
                    int numToRemove = int.Parse(input[1]);
                    numbers.Remove(numToRemove);
                }
                else if (input[0] == "RemoveAt")
                {
                    int indeToRemove = int.Parse(input[1]);
                    numbers.RemoveAt(indeToRemove);
                }
                else if (input[0] == "Insert")
                {
                    int numberToInsert = int.Parse(input[1]);
                    int indexToInsert = int.Parse(input[2]);
                    numbers.Insert(indexToInsert, numberToInsert);

                }



            }
            Console.WriteLine(string.Join(" ",numbers) );
        }
    }
}
