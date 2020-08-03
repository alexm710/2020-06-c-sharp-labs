using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace lab_17_selection
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random randomNG = new Random();
            int num1 = randomNG.Next(1, 11);
            int num2 = randomNG.Next(1, 11);

            Console.WriteLine("What is " + num1 + "times " + num2 + "?");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num1 * num2)
            {

                int responseIndex = randomNG.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("well done king");
                        break;
                    case 2:
                        Console.WriteLine("smart lad u are eh");
                        break;
                    default:
                        Console.WriteLine("mans got his KS2 maths down");
                        break;
                }
            }

            else
            {
                int diff = Math.Abs(answer - (num1 * num2));
                if (diff == 1) {
                    Console.WriteLine("not bad g try again");
                }
                else if (diff <= 5)
                {
                    Console.WriteLine("get back to the books, nearly there");
                    }
                else
                    Console.WriteLine("no hope mate");
                }
            
            Console.ReadKey();
        }
    }
}

            // if (conidition is true) then do this otherwise do this
            //// if  (condition) :? do this if true  : do this if false
            //int x = 5;
            //    int y = 10;

            //var result = x > y ? "x is greater than y" : "x is less than y";
            //Console.WriteLine(result);


    //public class Selection
    //{ // showing an if statement
    //    public static string PassFail(int mark)
    //    {

    //        if (mark >= 40)
    //        {
    //            return "Pass";
    //        }
    //        else if (mark >= 60)
    //        {
    //            return "Merit";
    //        }
    //        else if (mark >= 75)
    //        {
    //            return "Distinction";
    //        }

    //        else return "fail";
    //    }
    //        // Showing a Switch Break Statement
    //        public static string AlertLevel(int level)
    //        {
    //            string priority = "Code";
    //            switch (level)
    //            {
    //                case 3:
    //                    priority = priority + "Red";
    //                    break;
    //                case 2:
    //                case 1:
    //                    priority = priority + "Amber";
    //                    break;
    //                case 0:
    //                    priority = priority + "Green";
    //                    break;
    //                default:
    //                    priority = "error";
    //                    break;
    //            }
    //            return priority;
    //        }
    //    // Showing a Ternary if statement
    //    public static string PassFailAgain(int mark)
    //    {
    //        return mark >= 40 ? "pass" : "fail";
    //    }
    //    }      
    
