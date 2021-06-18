using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Basic Inheritance");
            //make a car
            Car myCar = new Car(80);
            Console.WriteLine($"My car is going {myCar.Speed} MPH");

            //set the current speed andprint
            myCar.Speed = 60;
            Console.WriteLine($"My car is going {myCar.Speed} MPH");
            Console.ReadLine();

        }
    }
}
