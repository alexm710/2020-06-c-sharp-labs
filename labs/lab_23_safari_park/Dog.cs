using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_safari_park

{
    public class Dog : Animal
    {

        public int Age;
        public int Height;
        private int v1;
        private string v2;

        // This is a Constructor with 3 parameters.
        // Using :base(name) to call constructor of parent: Animal(string).
        // The fields of superclass will be assigned values.
        // Then the fields of this class is assigned values.
        public Dog(string name, int Age, int Height)
            : base(name)
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(string,int,int)");
        }

        // This constructor call to default constructor of superclass.
        public Dog(int Age, int Height)
            : base()
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(int,int)");
        }

        public Dog(string Name, int v1, string v2) : base(Name)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void Say()
        {
            Console.WriteLine("Meo");
        }

        // Override method in parent class.
        // Rewrite this method,
        // to accurately describe the behaviour of the dog.
        public override void Move()
        {
            Console.WriteLine("Cat Move ...");
        }
    }
}