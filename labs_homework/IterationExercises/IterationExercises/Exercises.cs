﻿using System.Collections.Generic;
using System.Linq;

namespace IterationLib
{

    public class Program
    {

        public static void Main(string[] args)
        {
            //ignore
        }
    }


    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            if (nums.Length == 0)
                return int.MaxValue;
            else
                return nums.Min();
        }

        // return lowest num in a list, max int if list is empty
        public static int FindLowest(List<int> nums)
        {
            if (nums.Count == 0) return int.MaxValue;
            nums.Sort();
            return nums[0];
        }

        // return lowest num in a list, max int if list is empty method #2
        public static int FindLowest1(List<int> nums)
        {
            int lowest = int.MaxValue;
            if (nums.Count == 0)
                return int.MaxValue;
            foreach (int i in nums)
                if (i < lowest)
                {
                    lowest = i;
                }
            return lowest;
}


        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                if (i % 5 == 0 || i % 2 == 0)
                    sum += i;
            }
            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            input = input.Trim().ToLower();
            int As = 0, Bs = 0, Cs = 0, Ds = 0;
            foreach (char character in input)
            {
                switch (character)
                {
                    case 'a':
                        As++;
                        break;
                    case 'b':
                        Bs++;
                        break;
                    case 'c':
                        Cs++;
                        break;
                    case 'd':
                        Ds++;
                        break;
                }
            }
            return $"A:{As} B:{Bs} C:{Cs} D:{Ds}";
        }
    }
}