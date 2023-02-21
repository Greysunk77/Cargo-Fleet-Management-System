using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cargofleetSystem
{
    class Memory
    {
            //declarations  for the varibles in Time Management  
        public string mechanicID;
        public DateTime dob;
        public int Mechours;
        public string driverhours;
        public string driverID;


        //this is the Constructor for the Memory class .
        public Memory(string mechanicID, DateTime dob, int Mechours, string driverhours, string driverID, int hourperWeek)
        {
            this.mechanicID = mechanicID;
            this.dob = dob;
            this.Mechours = Mechours;
            this.driverhours = driverhours;
            this.driverID = driverID;
          

        }

        public Memory()
        {
        }
        // getters and return methods for the stored variables
        public string getmechanicID()
        {
            return mechanicID;
        }
        public DateTime getdob()
        {
            return dob;
        }
        public int getMechours()
        {
            return Mechours;
        }

        public string getdriverhours()
        {
            return driverhours;
        }
        public string getdriverID()
        {
            return driverID;
        }

        

    }
}
