#define RUNNINGTEST01
using System;
using System.Diagnostics;

namespace lab_03_dot_net_core_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArray = { 1, 2, 3, 4, 5 };
            foreach (var item in myArray)
            {
                System.Console.WriteLine(item);
            }
            Console.WriteLine();
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                total += i;
            }
            // compile if the build is debug build
#if DEBUG
            Console.WriteLine("This code is only compiled in debug mode");
#endif

#if RUNNINGTEST01
            Console.WriteLine("Runninng Test01");
#endif

            // Debugging
            // Logging
            // Console

            Console.WriteLine("Output to console");
            Debug.WriteLine("Outpuuting debug output");
            Trace.WriteLine("Outputting trace output");
            Console.ReadLine();


        }
    }
}
