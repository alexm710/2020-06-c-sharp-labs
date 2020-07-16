using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CollectionsExercisesLib
{
        public class CollectionsExercises
        {
            /* removes and returns the next num entries in the queue, as a comma separated string */
            public static string NextInQueue(int num, Queue<string> queue)
            {
                string output = "";
                if (num > 0) output += queue.Dequeue();
                for (int i = 1; i < num; i++)
                {
                    if (queue.Count == 0) break;
                    output += ", ";
                    output += queue.Dequeue();
                }
                return output;
            }

            /* uses a Stack to create and return array of ints in reverse order to the one supplied */
            public static int[] Reverse(int[] original)
            {
                var reverser = new Stack<int>();
                foreach (int num in original)
                {
                    reverser.Push(num);
                }

                int[] reverse = new int[original.Length];
                for (int i = 0; i < reverse.Length; i++)
                {
                    reverse[i] = reverser.Pop();
                }
                return reverse;
            }
            // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
            public static string CountDigits(string input)
            {
                var occurences = new Dictionary<char, int>();
                foreach (char c in input)
                {
                    Regex rg = new Regex(@"[0-9]");
                    if (rg.IsMatch(c.ToString()))
                    {
                        if (!occurences.ContainsKey(c)) occurences.Add(c, 1);
                        else occurences[c]++;
                    }
                }
                string output = "";
                foreach (var keyValuePair in occurences)
                {
                    output += keyValuePair;
                }
                return output;
            }
        }
    }