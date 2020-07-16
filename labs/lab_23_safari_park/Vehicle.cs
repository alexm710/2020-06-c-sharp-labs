using System;
using System.Collections.Generic;
using System.Text;

namespace lab_23_safari_park
{
    public class Vehicle : IMovable
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set //setting the value in setter
            {
                if (value >= 0 && value <= _capacity)
                { _numPassengers = value; }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
            }
        }
        public int Position { get; private set; }

        public Vehicle(int capacity = 6, int speed = 10)
        {
            _speed = speed;
            _capacity = capacity;
        }

        public virtual string Move(int times) // virtual is essentially the opposite of override
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }

        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";

        }

        public override string ToString()
        {
            return $"{base.ToString()} capacity {_capacity} speed {_speed} passengers {_numPassengers} position{ Position}";
        }
    }
}