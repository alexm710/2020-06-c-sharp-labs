using ClassesApp;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SafariPark
{
    public class Program
    {
        public static void Main()
        {
            var cathy = new Person("Cathy", "French");
            var boeing = new Airplane(400, 200, "Boeing");
            var v1 = new Vehicle(12, 20);
            var phil = new Hunter("Phil", "Anderson", "Pentax");

            var gameObject = new List<Object>()
                {
                    cathy,
                    boeing,
                    v1,
                    phil
            };

            foreach (var item in gameObject)
            {
                Console.WriteLine(item.ToString());
            }

            SpartaWrite(phil);
            SpartaWrite(cathy);
        }
        public static void SpartaWrite(Object obj)
        {
            Console.WriteLine(obj);
            if (obj is Hunter)
            {
                var HunterObj = (Hunter)obj;
                Console.WriteLine(HunterObj.Shoot());
            }
        }
    }
}