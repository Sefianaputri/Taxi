using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method

        public void TaxiInfo()
        {
            Console.WriteLine("DriverName : {0}, DriverName");
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sudah menjemput penumpang ", DriverName);

        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sudah selesai mengantar penumpang", DriverName);
        }
    }
}
