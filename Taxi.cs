using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass {
    class Taxi 
    {

        //properties 
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; } 

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            Console.WriteLine("OnDuty: {0}", OnDuty ? "yes" : "no");
            Console.WriteLine("NumPassenger: {0}\n", NumPassenger); 
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Jono sedang menjeput penumpang ", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Jono sedang mengantar penumpang \n", DriverName);
        }
    }
}
