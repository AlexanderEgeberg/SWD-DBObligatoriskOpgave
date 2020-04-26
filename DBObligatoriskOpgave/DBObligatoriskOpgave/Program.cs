using DBObligatoriskOpgaveWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBObligatoriskOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Create
            ManageFacility.CreateFacility(new Facility() {Facility_No = 7, Facility_Name = "Biograf" });

            /// Read
            ManageFacility.ReadFacilities();

            /// Update
            ManageFacility.UpdateFacility(7, new Facility() { Facility_No = 7, Facility_Name = "3D Biograf" });


            ManageFacility.ReadFacilities();

            /// Delete

            ManageFacility.DeleteFacility(7);

            ManageFacility.ReadFacilities();

            Console.ReadKey();

        }
    }
}
