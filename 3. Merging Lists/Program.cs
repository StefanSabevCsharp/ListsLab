﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            int min = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < min; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if (firstList.Count > secondList.Count)
            {
                for (int i = min; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else if (secondList.Count > firstList.Count)
            {
                for (int i = min; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
