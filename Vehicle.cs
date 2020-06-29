using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{
    class Vehicle
    {
        public Vehicle(string registrationNumber, string typeOfTruck, string model, int loadingCapacity)
        {
            RegistrationNumber = registrationNumber;
            TypeOfTruck = typeOfTruck;
            Model = model;
            LoadingCapacity = loadingCapacity;
        }

        public string RegistrationNumber { get; }
        public string TypeOfTruck { get; }
        public string Model { get; }
        public int LoadingCapacity { get; }
    }
}
