using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPcastingDowncasting.Models
{
    internal class Car:Vehichle
    {

        public override void Drive()
        {
            Console.WriteLine("Drive Car");
        }
        public static bool operator >(Car car1, Car car3)
        {
            return car1.Price > car3.Price;
        }

        public static bool operator <(Car car1, Car car3)
        {
            return car1.Price < car3.Price;
        }

    }
}
