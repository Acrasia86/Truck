using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{
    class Menu
    {
        Truck start = new Truck();
        public void Menus()
        {


            bool shouldNotExit = true;

            Console.Clear();

            while (shouldNotExit)
            {
                Console.WriteLine("1. Skapa leverans");
                Console.WriteLine("2. Lista leveranser");
                Console.WriteLine("3. Registrera lastbil");
                Console.WriteLine("4. Avsluta");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        start.RegisterOrder();
                        break;
                    case 2:
                        start.PrintOrder();
                        break;
                    case 3:
                        start.RegisterTruck();
                        break;
                    case 4:
                        shouldNotExit = false;
                        break;



                }

                Console.Clear();
            }
        }
    }
}
