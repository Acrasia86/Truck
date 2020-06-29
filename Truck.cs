using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoTruck
{
    class Truck
    {
        

        Dictionary<string, Customer> orderDictionary = new Dictionary<string, Customer>();
        Dictionary<string, Vehicle> truckDictionary = new Dictionary<string, Vehicle>();

        List<Customer> orderList = new List<Customer>();
        List<Vehicle> truckList = new List<Vehicle>();

        public void PrintOrder()
        {
            Console.Clear();
            
            Console.WriteLine("Kund          Last            Lastbil         Leveransdatum");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var order in orderList)
            {
                foreach (var truck in truckDictionary)
                {
                    Console.WriteLine($"{order.Customers}           {order.Cargo}            {truck.Value.RegistrationNumber}           {order.DeliveryDate}");
                }
                
            }
            Console.ReadLine();
        }

        public void RegisterOrder()
        {
            Console.Clear();

            string userInput;
            Console.Write("Kund: ");

            string customers = Console.ReadLine();

            Console.Write("Destination: ");

            string destination = Console.ReadLine();

            Console.Write("Last: ");

            string cargo = Console.ReadLine();

            Console.Write("Leveransdatum (yyyy-mm-dd hh:mm): ");

            DateTime shippingDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Lastbil (Registreringsnummer): ");

            string truck = Console.ReadLine();

                Console.WriteLine("\n\nÄr det korrekt? (J)a   (N)ej");
                userInput = Console.ReadLine();

            Console.Clear();

            if (userInput == "J" && truckDictionary.ContainsKey(truck))

                {
                    Customer order = new Customer(customers, destination, cargo, shippingDate, truck);
                    orderList.Add(order);

                    Console.WriteLine("Leverans skapad");

                    Thread.Sleep(2000);

                }

            else if(userInput == "N")
            {
                RegisterOrder();
            }
            else
            {
                Console.WriteLine("Lastbil hittades ej");
                Thread.Sleep(2000);
            }

        }

        public void RegisterTruck()
        {
            Console.Clear();
            string userInput;
            Console.Write("Registreringsnummer: ");

            string registrationNumber = Console.ReadLine();

            Console.Write("Märke: ");

            string typeOfTruck = Console.ReadLine();

            Console.Write("Model: ");

            string model = Console.ReadLine();

            Console.Write("Lastkapacitet (kubik): ");

            int loadingCapacity = int.Parse(Console.ReadLine());


                Console.WriteLine("\n\nÄr det korrekt? (J)a    (N)ej");
                userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "J")
            {
                Vehicle truck = new Vehicle(registrationNumber, typeOfTruck, model, loadingCapacity);
                truckDictionary.Add(registrationNumber, truck);

                Console.WriteLine("Lastbil registrerad");

                Thread.Sleep(2000);

            }
            else if (userInput == "N")
            {
                RegisterTruck();
            }
            

        }
    }
}
