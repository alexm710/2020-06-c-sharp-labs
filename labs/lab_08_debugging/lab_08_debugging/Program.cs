using System;
using System.Diagnostics;

namespace lab_08_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output to console");
            Debug.WriteLine("Outpuuting debug output");
            Trace.WriteLine("Outputting trace output");
            Console.ReadLine();
        }
    }
}
