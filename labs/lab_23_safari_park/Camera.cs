using System;
using System.Collections.Generic;
using System.Text;

namespace lab_23_safari_park
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot() // taking the method shoot from Ishootable interface
        {
            return $"Shooting a {base.ToString()} {_brand}";
        }


    }
}
