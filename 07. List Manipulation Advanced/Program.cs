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
            bool flag = false;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Add")
                {
                    int currentNum = int.Parse(input[1]);
                    numbers.Add(currentNum);
                    flag = true;
                }
                else if (input[0] == "Remove")
                {
                    int numToRemove = int.Parse(input[1]);
                    numbers.Remove(numToRemove);
                    flag = true;

                }
                else if (input[0] == "RemoveAt")
                {
                    int indeToRemove = int.Parse(input[1]);
                    numbers.RemoveAt(indeToRemove);
                    flag = true;

                }
                else if (input[0] == "Insert")
                {
                    int numberToInsert = int.Parse(input[1]);
                    int indexToInsert = int.Parse(input[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    flag = true;

                }
                else if (input[0] == "Contains")
                {
                    int currentNum = int.Parse(input[1]);
                    bool isContains = numbers.Contains(currentNum);
                    if (isContains)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (input[0] == "PrintEven")
                {
                    List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (input[0] == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.Where(x => x % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (input[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (input[0] == "Filter")
                {
                    int conditionNum = int.Parse(input[2]);

                    if (input[1] == "<")
                    {
                        List<int> conditionList = numbers.Where(x => x < conditionNum).ToList();
                        Console.WriteLine(string.Join(" ", conditionList));
                    }
                    else if (input[1] == ">")
                    {
                        List<int> conditionList = numbers.Where(x => x > conditionNum).ToList();
                        Console.WriteLine(string.Join(" ", conditionList));
                    }
                    else if (input[1] == ">=")
                    {
                        List<int> conditionList = numbers.Where(x => x >= conditionNum).ToList();
                        Console.WriteLine(string.Join(" ", conditionList));
                    }
                    else if (input[1] == "<=")
                    {
                        List<int> conditionList = numbers.Where(x => x <= conditionNum).ToList();
                        Console.WriteLine(string.Join(" ", conditionList));
                    }

                }



            }
            if (flag)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                return;
            }
        }
    }
}
