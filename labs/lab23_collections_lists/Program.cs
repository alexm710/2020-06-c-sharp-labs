using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace lab23_collections_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<string>();

            myQueue.Enqueue("First item");
            myQueue.Enqueue("Second item");
            myQueue.Enqueue("Third item");
            myQueue.Enqueue("Fourth item");

            Console.WriteLine(myQueue.Peek());

            myQueue.Dequeue();
            Console.WriteLine(myQueue.Peek());

            Console.WriteLine(myQueue.Contains("Third item"));

            var myStack = new Stack<string>();
            myStack.Push("item1");
            myStack.Push("item2");
            myStack.Push("item3");
            myStack.Pop();

            foreach (var item in myStack)
                Console.WriteLine(item);

            var personDict = new Dictionary<int, string>();

            personDict.Add(1, "Alex");
            personDict.Add(2, "Phil");
            personDict.Add(3, "Nish");

            var personDictNew = new Dictionary<int, string>()
            {
                {1, "Alex" },
                {2, "Phil" },
                {3, "Nish" }
            };
            foreach (var item in personDictNew.Keys)
            {
                Console.WriteLine($"Index/key is {item.key} and value is {personDictNew[key]}");
            }

            string input = "We are SPARTA";
            input = input.Trim().ToLower();

            var countD = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (countD.ContainsKey(c))
                {
                    countD[c]++;
                }

                else
                {
                    countD.Add(c, 1);
                }
            }
            foreach (var entry in countD)
                Console.WriteLine(entry);
        }
    }
}
