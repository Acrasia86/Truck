using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{
    class Customer
    {
        public Customer(string customers, string destination, string cargo, DateTime deliveryDate, string truck)
        {
            Customers = customers;
            Destination = destination;
            Cargo = cargo;
            DeliveryDate = deliveryDate;
            Truck = truck;
        }

        public string Customers { get; }
        public string Destination { get; }
        public string Cargo { get; }
        public DateTime DeliveryDate { get; }
        public string Truck { get; }
    }
}
