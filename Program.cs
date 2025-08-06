using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Ports;
using Models.Ships;
class Program
{
    static void Main()
    {
        // Acá empieza el programa
        Console.WriteLine("Name of the port:");
        string portName = "Puerto1";
        int PortNumber = 1234;

        Port mc = new Port(portName);
        mc.PortNumber = PortNumber;
        mc.AddShip(new CargoShip { Name = "Cargo1", YearBuilt = 2000, Brand = "BrandA", Type = "Cargo", MaxTons = 500 });
        mc.AddShip(new CargoShip { Name = "Cargo2", YearBuilt = 2005, Brand = "BrandB", Type = "Cargo", MaxTons = 1000 });
        Console.WriteLine("Name of the port:");
        string portName = "Puerto1";
        int PortNumber = 1234;

        Port mc = new Port(portName);
        mc.PortNumber = PortNumber;
        mc.AddShip(new CargoShip { Name = "Cargo1", YearBuilt = 2000, Brand = "BrandA", Type = "Cargo", MaxTons = 500 });
        mc.AddShip(new CargoShip { Name = "Cargo2", YearBuilt = 2005, Brand = "BrandB", Type = "Cargo", MaxTons = 1000 });
        mc.PrintInfo();
        string res = "0";
        Console.WriteLine("Welcome to the port management system!");
        while (res != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Print port information");
            Console.WriteLine("2. Add a ship to the port");
            Console.WriteLine("3. List all ships in the port");
            Console.WriteLine("4. Find a ship by name");
            Console.WriteLine("5. Exit");
            res = Console.ReadLine().ToString();

            if (res == "1")
            {
                mc.PrintInfo();
            }
            else if (res == "2")
            {
                Console.WriteLine("Type of ship to add:");
                Console.WriteLine("1. Cargo Ship");
                Console.WriteLine("2. Passenger Ship");
                string shipType = Console.ReadLine();
                Console.WriteLine("Enter ship name:");
                string shipName = Console.ReadLine();
                Console.WriteLine("Enter year built:");
                int yearBuilt = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter brand:");
                string brand = Console.ReadLine();
                // Console.WriteLine("Enter capacity:");
                // int capacity = int.Parse(Console.ReadLine());
                if (shipType == "1")
                {
                    Console.WriteLine("Enter max tons:");
                    int maxTons = int.Parse(Console.ReadLine());

                    CargoShip newShip = new CargoShip
                    {
                        Name = shipName,
                        YearBuilt = yearBuilt,
                        Brand = brand,
                        Type = "Cargo",
                        MaxTons = maxTons
                    };

                    mc.AddShip(newShip);
                    Console.WriteLine($"Cargo ship {shipName} added to the port.");
                }
                else if (shipType == "2")
                {
                    Console.WriteLine("Enter max passengers:");
                    int MaxPassengers = int.Parse(Console.ReadLine());
                    PassengerShip passengerShip = new PassengerShip

                    {
                        Name = shipName,
                        YearBuilt = yearBuilt,
                        Brand = brand,
                        Type = "Passenger",
                        MaxPassengers = MaxPassengers
                    };
                    mc.AddShip(passengerShip);
                    Console.WriteLine($"Passenger ship {shipName} added to the port."); 
                }
                else
                {
                    Console.WriteLine("Invalid ship type selected.");
                }
            }
            
            else if (res == "3") 
            {
                Console.WriteLine("Ordenar por: 1. Nombre (Asc) 2. Nombre (Desc)");
                string order = Console.ReadLine();
                if (order == "1")
                {
                    mc.OrderByNameAscending();
                }
                else if (order == "2")
                {
                    mc.OrderByNameDescending();
                }

                
            }
            else if (res == "4") 
            {
                Console.WriteLine("Enter the name of the ship to find:");
                string shipName = Console.ReadLine();
                mc.FindShipByName(shipName);
            }
            else if (res == "5")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
            Console.WriteLine("Press Enter to continue...");
            res = Console.ReadLine().ToString();
        }

    }
}

