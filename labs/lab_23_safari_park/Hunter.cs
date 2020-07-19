using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.SymbolStore;

namespace lab_23_safari_park
{
    public class Hunter : Person, IShootable // Derived Class
    {
        public IShootable Shooter { get; set; } // Autoimplemented property called shooter of Ishootable type

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName) // Inherits first name/last name from parent class.                 Takes Base represents Parent or Superclass. // 
        {
            Shooter = shooter; // don't need to call anything else as it implements from Person class

        }

        // Cannot have an argument-less in the constructor once it's inherited, unless the Parent Child already exists
        public Hunter()
        {

        }
        public string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }



        public override string ToString()
        {
            return $"{base.ToString()} {Shooter}";
        }
    }

    //public class MonsterHunter : Hunter : IShootable
    //{
    //    private string _weapon;
    //    public MonsterHunter(string fName, string lName, string camera, string weapon) : base(fName, lName, shooter)
    //    {
    //        _weapon = weapon;
    //    }

    //    public sealed override string ToString()//Sealed: it can't intherit from it
    //    {
    //        return $"{base.ToString()} Weapon: {_weapon}";
    //    }
    //}
}