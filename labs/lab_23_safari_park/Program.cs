using System;
using System.Collections.Generic;

namespace lab_23_safari_park
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera pentax = new Camera("Pentax"); // instantiate object
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);

            Console.WriteLine(nish.Shoot()); // calls the Shoot method in hunter class to get full name and s
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;



















            // Having overload constructor we can instantiate 3 differents objects with 3 differents attributes
            // We can set attributes by using the properties if we have a default constructor Eg: Person leo = new Person(){Leo, Xia};
            //Person cathy = new Person("Cathy", "French") { Age = 14 }; //{Age= 14} => Object initialiser
            //Person nish = new Person();
            //Person phil = new Person("Phil", "Idk", 35);


            //Console.WriteLine(bryn.GetType()); //returns the runtime type of the current instance.
            //Person leo = new Person("Leo", "Xia"); //With abstract cannot be instatiated/ With Sealed cannot be used for intheritance
            //Person nish = new Person("Nish", "Mandal");
            //Hunter cathy = new Hunter("Cathy", "French");
            //MonsterHunter phil = new MonsterHunter("Phil", "Anderson", "Nikon", "Love");
            //var safariList = new List<Person>();
            //safariList.Add(nish);
            //safariList.Add(cathy);
            //safariList.Add(phil);

            //foreach (var item in safariList)
            //{
            //    Console.WriteLine(item);
            //}

            //var v = new Airplane();
            //Console.WriteLine(v.ToString());

            //var moveObjs = new List<IMovable>()
            //{
            //    new Person("Chen", "Shan"),
            //    new Airplane(400, 200, "BrynAir"),
            //    new Vehicle(6, 10),
            //    new Hunter("Dog", "Dundee", "Nikon")
            //};

            //Console.WriteLine();
            //Console.WriteLine("Moving the objects");
            //foreach (var item in moveObjs)
            //{
            //    Console.WriteLine(item.Move(3));
        }
        }
    }
