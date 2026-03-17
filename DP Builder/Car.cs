using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Car
    {
        private int _seats;
        private int _power;

        public void SetSeats(int seats)
        {
            _seats = seats;
        }
        public void SetEngine(int power)
        {
            _power = power;
        }
        public override string ToString()
        {
            return $"Car seats: {_seats}\tCar engine power : {_power}";
        }
    }
}
