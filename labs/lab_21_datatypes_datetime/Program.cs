using System;
using System.Security.Cryptography.X509Certificates;

namespace lab_21_datatypes_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var tps = TimeSpan.TicksPerSecond;
            var nowInTicks = DateTime.Now.Ticks;

            Console.WriteLine(tps); // ticks per second
            Console.WriteLine(nowInTicks); // showing datetime now in ticks

            // new date object mapped to midnight, 1 January 0001
            var d = new DateTime();
            var d1 = DateTime.Today;
            // Now
            var d2 = DateTime.Now;

            var d3 = new DateTime(2020, 7, 13, 10, 5, 18);

            // add one day
            d.AddDays(1);
            // add month
            d = d.AddMonths(1);


            var alexBday = new DateTime(1996, 06, 04);
            var age = DateTime.Now - alexBday;
            // accurate method
            int age2 = (int)((age.Days) / 365.25);
            Console.WriteLine(age2);

            var date = DateTime.Now.ToString("dd-MM-yyyy");
            var date2 = alexBday.ToString("yy/MMM/dd");
            Console.WriteLine(date);
            Console.WriteLine(date2);

            // TIMESPAN OBJECTS
            // 1 hour time span
            // timespan used to find the difference between times
            var timespan = new TimeSpan(1, 0, 0);
            // add this time right now
            var dateT = DateTime.Now + timespan;
            // add one tick to our date!
            var tick = new TimeSpan(1);
            dateT = dateT + tick;
            Console.WriteLine(dateT);


            // ENUMS

            //Suit theSuit = Suit.HEARTS;
            //int suit = (int)theSuit;
            //Console.WriteLine(theSuit);
            Suit theSuit = Suit.DIAMONDS;
            theSuit = Suit.HEARTS;

            //Suit mySuit = (Suit)2;
            //Console.WriteLine(mySuit);

            //switch (theSuit)
            //{
            //    case (Suit.HEARTS):
            //        Console.WriteLine("Heart");
            //        break;
            //    case (Suit.SPADES):
            //        Console.WriteLine("Spade");
            //        break;
            //    case (Suit.CLUBS):
            //        Console.WriteLine("Clubs");
            //        break;
            //    case (Suit.DIAMONDS):
            //        Console.WriteLine("Diamonds");
            //        break;
            //}
            //Console.WriteLine($"Sunday as a number is {(int)DayOfWeek.Sunday}");

            //int x = 1;
            //int dog;
            //float cat;
            //bool thing;
            //char c;
            //DateTime aDate;
            //string aString;
            //int[] arr;

            //bool? hasPassed;
            //uint numberOfTrainees;

            //int totalCost = 0;

            //int? item = 3;
            //if (item.HasValue)
            //{
            //    totalCost = item.Value * 10;
            //}

            dynamic item = 100;
            Console.WriteLine($"adding 10 to {item} gives {item + 10}");

            var rng = new Random();
            var rngSeeded = new Random(42);
            // seeding isn't fully random (below)
            var between1And10 = rngSeeded.Next(1, 11);
            // use rng.next instead for fully random
            var between1And20 = rng.Next(1, 21);

            Console.WriteLine(between1And10);
            Console.WriteLine(between1And20);
          
        }

        public enum Suit
        {
            HEARTS, // 0
            CLUBS, // 1
            SPADES, // 2
            DIAMONDS // 3
        }
        public enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday = 8,
            Friday,
            Saturday,
            Sunday
        }
    }
}
