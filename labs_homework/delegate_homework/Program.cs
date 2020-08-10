using System;

namespace delegate_homework
{

    class Program
    {
        // Multicast Delegates In C#
        // Another great feature of delegates is that you can combine them together. This is called multicasting. You can use the + or += operator to add another method to the invocation list of an existing delegate instance. 
        // Similarly, you can also remove a method from an invocation list by using the decrement assignment operator (- or -=). This feature forms the base for events in C#. Below is a multicast delegate example.
        static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}!", s);
        }

        static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}!", s);
        }

        delegate void Del(string s);

        static void Main()
        {
            Del a, b, c, d;

            // Create the delegate object a that references 
            // the method Hello:
            a = Hello;

            // Create the delegate object b that references 
            // the method Goodbye:
            b = Goodbye;

            // The two delegates, a and b, are composed to form c: 
            c = a + b;

            // Remove a from the composed delegate, leaving d, 
            // which calls only the method Goodbye:
            d = c - a;

            Console.WriteLine("Invoking delegate a:");
            a("A");
            Console.WriteLine("Invoking delegate b:");
            b("B");
            Console.WriteLine("Invoking delegate c:");
            c("C");
            Console.WriteLine("Invoking delegate d:");
            d("D");


            /* Output:
            Invoking delegate a:
              Hello, A!
            Invoking delegate b:
              Goodbye, B!
            Invoking delegate c:
              Hello, C!
              Goodbye, C!
            Invoking delegate d:
              Goodbye, D!
            */

            Console.ReadLine();

            //Initialize pub class object
            Pub p = new Pub();

            //register for OnChange event - Subscriber 1
            p.OnChange += () => Console.WriteLine("Subscriber 1!");
            //register for OnChange event - Subscriber 2
            p.OnChange += () => Console.WriteLine("Subscriber 2!");

            //raise the event
            p.Raise();

            //After this Raise() method is called
            //all subscribers callback methods will get invoked

            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();
        }
    }

    //Define publisher class as Pub
    public class Pub
    {
        //OnChange property containing all the 
        //list of subscribers callback methods
        public event Action OnChange = delegate { };

        public void Raise()
        {
            //Invoke OnChange Action
            OnChange();
        }
    }
}

