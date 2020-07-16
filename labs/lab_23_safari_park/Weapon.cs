﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_23_safari_park
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"Shooting with a {_brand}";
        }


        public override string ToString()
        {
            return $"Shooting with  a {base.ToString()} {_brand}";
        }
    }

    class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }
    }

    class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Water!! {base.Shoot()}";
        }
    }
}
