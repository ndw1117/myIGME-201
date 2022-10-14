using System;
using Vehicles;

namespace Traffic
{
    //Class: Traffic
    //Author: Nick Will
    //Purpose: Demonstrates a class which uses the Vehicles library
    //Restrictions: None
    class Traffic
    {
        static void Main(string[] args)
        {
            Compact compact = new Compact();
            AddPassenger(compact);

            /*
             * This does not work because freightTrain is not a passenger carrier
             * FreightTrain freightTrain = new FreightTrain();
             * AddPassenger(freightTrain);
            */
        }

        public static void AddPassenger(IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger();
            Console.WriteLine(vehicleObject.ToString());
            Console.WriteLine("");
        }
    }
}