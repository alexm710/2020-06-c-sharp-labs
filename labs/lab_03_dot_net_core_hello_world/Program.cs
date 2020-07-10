using System;

namespace lab_03_dot_net_core_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArray ={1,2,3,4,5};
            foreach(var item in myArray){
                System.Console.WriteLine(item);
            }
        }
    }
}
