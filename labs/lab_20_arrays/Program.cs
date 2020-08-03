using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace lab_20_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //    char[] nish = new char[4];
            //    // long method
            //    nish[0] = 'n';
            //    nish[1] = 'i';
            //    nish[2] = 's';
            //    // quicker method
            //    char[] sparta = { 's', 'p', 'a', 'r', 't', 'a' };
            //int[] newArray = { 2, 3, 4, 5, 6, };
            //var result = Array.ArraySum(newArray);
            //Console.WriteLine(result);

            // MULTI DIMENSIONAL ARRAYS

            //int[,] grid = new int[2, 4];
            //int[,,,,] grid4d = new int [3, 4, 20, 30];
            int[,] grid2d = { { 4, 7, 8, 9 }, { 6, 1, 7, 10 } };

            // 4 6 
            // 7 1 
            // 8 7 
            // 9 10
            int val = grid2d[0, 1]; // returns 7, (0 refers to column, 1 is going down the column)
            Console.WriteLine(val); // if it was [2, 1] it would return an error (out of bounds, only 2 columns)

            int[,,] grid3d = { {{ 4, 7, 8, 9 }, { 6, 1, 7, 10 }, { 4, 4, 4, 4 } } };

            // JAGGED ARRAYS

            string[][] animalGrid = new string[2][];
            animalGrid[0] = new string[4];
            animalGrid[1] = new string[2];

            animalGrid[0][0] = "Turkey"; // adding to first array and beginning of array

            string[][] animalGrid2 = new string[][]
            {
                new string[] {"llama", "puma", "horse", "kitten" },
                new string[] {"haddock", "tuna"}
            };
            var animal = animalGrid2[0][1]; // taking index 0 array and 2nd row, result is puma
            Console.WriteLine(animal); // if it was [2][1] it would be out of bounds

            // LISTS 

            List<string> namesOld = new List<string>(); // new is collecting from the object class
            //var names = new List<string>(); // this is the same way of writing 1 line above

            //names.Add("Nish");  // this is a long way of doing it
            //names.Add("Bruno"); // quicker way below, but this is also useful
            var names= new List<string> { "Nish", "alex" };
            foreach (string name in names)
            Console.WriteLine(names);

            // STRINGS

            // Strings are immutable, can only get a read only like the example below
            string namex = "phil";
            Console.WriteLine(namex[1]); // produces h

            var allChars = namex.ToCharArray();
            var initials = namex.ToCharArray(1, 3);
            Console.WriteLine(initials);

            string firstName = "Harry";
            string lastName = "Derybshire";
            double score = 90.4454334;

            // concatenating harry's details
            var string1 = firstName + " " + lastName + " Score:" + score;
            var string2 = $"{firstName} {lastName} Score: {score:p2}"; //p2 for % sign
            Console.WriteLine(string1);
            Console.WriteLine(string2);

            // casting for primitive types, parsing for changing a complete different type
            string input = "33";
            int input2 = Int32.Parse(input);
            int sum = 1 + input2;

            // STRING BUILDER
            // create a string that says hello 66 (especially nish)
            StringBuilder sb = new StringBuilder("hello");
            sb.Append(" engineering 66\n especially nish");
            Console.WriteLine(sb);

            
        }
    }

    public class Array
    {
        public static int ArraySum(int[] practiceArray)
        {
            int arraySum = practiceArray[0] + practiceArray[1] + practiceArray[2];
            return arraySum;
        }
    }
}
