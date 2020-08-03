using System;

namespace lab_22_exceptions
{
    class Program
    {
        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };

        public static void AddBeatle(int pos, string name)
        {
            if (pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException($"The beatles do have a position {pos}");
            }
            _theBeatles[pos] = name;
            //    try
            //    {

            //        _theBeatles[pos] = name;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Sorry, no 5th Beatle allowed");
            //        Console.WriteLine($"2. {e.ToString()}");
            //        Console.WriteLine("Sorry, no 5th Beatle allowed");
            //        Console.WriteLine("Sorry, no 5th Beatle allowed");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Here comes the sun!");
            //    }
            //}

            static void Main(string[] args)
            {
                AddBeatle(4, "Brian");

                int three = 3;
                int sum = int.MaxValue + three;
                Console.WriteLine(sum);
            }


                //int x = 10;
                //int y = 0;

                //try
                //{
                //    int output = x / y;
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine("An exception has occured");
                //    finally
                //{
                //    Console.WriteLine("But Life goes on...");
                //}
            
        }
    }
}


