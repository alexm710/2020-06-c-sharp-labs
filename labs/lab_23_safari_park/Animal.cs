using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace lab_23_safari_park
{
    public abstract class Animal
    {
        // This is Name field.
        // for example, Tom cat, Jerry mouse.
        public string Name;
 
        // Default constructor.
        public Animal()
        {
            Console.WriteLine("- Animal()");
        }
 
        public Animal(string Name)
        {
            // Assign a value to the Name field.
            this.Name = Name;
            Console.WriteLine("- Animal(string)");
        }
 
        // Move(): Animal Move.
        // Virtual: Allows the subclass to override this method.
        public virtual void Move()
        {
            Console.WriteLine("Animal Move");
        }
 
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
 
    }
}