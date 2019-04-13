using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object
            Taxi Taxi = new Taxi();

            //Properties
            Taxi.DriverName = "Jono";
            Taxi.OnDuty = true;
            Taxi.NumPassenger = 10;

            //methode
            Taxi.TaxiInfo();
            Taxi.PickUpPassenger();
            Taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
