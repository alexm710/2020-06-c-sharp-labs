using System;
using System.Collections.Generic;

namespace lab_10_data_types
{
    class Program
    {
        static void Main(string[] args)
        {

            //float sum = 0;

            //for (int i = 0; i < 1000; i++)
            //{
            //    sum += 1 / 3.0f;
            //}
            //Console.WriteLine("1/3 added 1000 times: " + sum);
            //Console.WriteLine("1/3  multiplied by 1000: " + 1 / 3.0f * 1000);

            /* checked
             { 
             int a = Int32.MaxValue;
             int b = a + 1;
             Console.WriteLine(a);
             Console.WriteLine(b);
             }
         } */
            //char firstLetter = 'n';
            //int firstLetterAsNumber = firstLetter;
            //Console.WriteLine(firstLetterAsNumber);

            ////  Explict Conversion (can get data loss )
            //  double x = 3.14f;
            //  float y = (float)x;
            //  Console.WriteLine(y);

            //  // Impicit Conversion (preferred if possible)
            //  int i = 100;
            //  double d = i;
            //  Console.WriteLine(d);

            //  // explicit conversion
            //  bool likeApples = true;
            //  Console.WriteLine(likeApples);
            //  double likeApplesAsDouble = System.Convert.ToInt32(likeApples);
            //  Console.WriteLine(likeApplesAsDouble);

            //  // impicit conversion
            //  int a = 1;
            //  double b = a;

            //char initial = 'M';
            //int mCode = inital;
            //Console.WriteLine(mCode);
            //Console.WriteLine(char)mCode);

            //Use round function to change how many decimal places you want
            //double pi = 3.141592;
            //pi = Math.Round(pi, 3); // 3 dp
            //Console.WriteLine(pi);

            double xy = 4.0d / 3.0d;
            double xyz = Math.Round(xy, 2); // 2 dp
            Console.WriteLine(xyz);

            //int num = -5;
            //ulong longNum = (ulong)num;
            //Console.WriteLine(longNum);//

            // Work out how to convert the chatacter '4' to the integer 4
            //
            char character1 = '4';
            int integer1 = character1 - '0';
            Console.WriteLine(character1);

            //int four = Convert.ToInt32(new String, four, 4);x
            var myList = new List<int>();
            
        }
    }
}
