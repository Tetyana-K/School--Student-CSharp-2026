using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CarBuilder : IBuilder
    {
        private Car car;
        public void Reset()
        {
            car = new Car();
        }
        public void MakeEngine(int power)
        {
            car.SetEngine(power);
        }

        public void MakeSeats(int seats)
        {
            car.SetSeats(seats);
        }

        public Car GetResult()
        {
            return car;
        }
    }
}
