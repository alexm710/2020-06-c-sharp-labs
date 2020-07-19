using System;
using System.Collections.Generic;
using System.Text;

namespace lab_23_safari_park
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed) // constructor does not return anything - just instantiates object 
        {
            _airline = airline;
        }

        public Airplane(int capacity) : base(capacity)
        { // constructor to only focus on the specific field. constructor where only capacity is known. if speed or airline isn't known this would be useful. CALL CONSTRUCTOR AND THEN parse then arguements to the super class).

        }
        public void Ascend(int distance) // void means we do not need a return type.
        {
            _altitude += distance;  // altitude will equal the distance
            // same with space
            
        }

        public void Descend(int distance)
        {
            if (_altitude > distance)
                _altitude -= distance;
            else _altitude = 0;

            // if statement to not get to negative altitude
        }

        public override string Move() // run the move method from vehicle
        {
            return $"{base.Move()} at an altitude of {_altitude} metres"; // also concatenating the both strings from vehicle and airplane 
        }

        public override string Move(int times)  // calling same method but has variation of times (how many times it moves etc.)
        {
            return $"{base.Move(times)} at an altitude of {_altitude} metres"; // base runs the parent class function 
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude {_altitude}";
        }


    }
}
