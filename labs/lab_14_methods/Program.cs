//using System;

//namespace lab_14_methods
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
            //Console.WriteLine("Hello World!");
            //var output = DoThis();
            //    SquareNumber(x: 2, y: "Hello");
            //}

            //public static string DoThis()
            //{
            //    return "THIS IS SPARTA!";
            //}

            //public static int SquareNumber(int x, string y)
            //{
            //    Console.WriteLine(y);
            //    return x * x;
            //OrderPizza(false, true, false);
            //var results = DoThisPartTwo(10, "Leo", out bool isLarge);
            //Console.WriteLine(isLarge);
            //Console.WriteLine(results);

            //var myTuple = (fname:"nish", lname: "Mandal", Age: 18);
            ////var myTuple = ("nish", "Mandal", 18); -- Can use fname lname etc or not
            //Console.WriteLine(myTuple.Item2);

            // Tuples are used to retrieve TWO calls from a method instead of having to do it twice. use brackets
            //var result = DoThat(10, "Hey Bruno");
            //Console.WriteLine(result);
            //Console.WriteLine(result.xsquared);
            //var (square, greaterThan10) = DoThat(5, "hello");

            // Overloading
            //Console.WriteLine(Add(6, 4, 2));
            //Console.WriteLine(Add(6, 5));

        //    // Declare a static method called TripleCalc which has four parameters:
        //    Console.WriteLine(TripleCalc(6, 4, 2));
        //    Console.WriteLine(TripleCalc(6, 5, 9, out sum));
        //}
        // Declare a static method called TripleCalc which has four parameters: An integer out parameter sum
        // The method should return the product of a, b and c
        // And sum should contain their sum.
 


        //public static int TripleCalc(int a, int b, int c, out int sum)
        //{
        //    sum = a + b + c;
        //    return a * b * c;
        //}
        //// Now write an overload of the TripleCalc method that has three parameters three integers a, b and c And returns a tuple(int sum, int product
        //public static (int sum, int product) TripleCalc(int a, int b, int c)
        //{
        //    return (a + b + c, a * b * c);
        //}

        // OVERLOADING

        //public static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}


        //public static (int xsquared, bool y_gt_10) DoThat(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x * x, z);
        //}
        ////public static int DoThisPartTwo(int x, string y, out bool z)
        //{
        //    Console.WriteLine(y);
        //    z = (x > 9);
        //    return x * x;
        //}

        //public static void OrderPizza(bool pepperoni, bool pineapple, bool banana = false)
        //{
        //    if (pepperoni == true && pineapple == true && banana == true)
        //        Console.WriteLine("Delicious!!");
        //    if (pepperoni == true && pineapple == false && banana == true)
        //            Console.WriteLine("Where's the pineapple!!");
        //    if (pepperoni == false && pineapple == false && banana == false)
        //        Console.WriteLine("Where's my toppings!!!");
        //    if (pepperoni == true && pineapple == true && banana == false)
        //        Console.WriteLine("Where's my banana!");
        //    else
        //        Console.WriteLine(":(");
        //}
//    }
//}
