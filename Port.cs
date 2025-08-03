using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Port
    {
        public string Name { get; set; }
        public int PortNumber { get; set; }
        public List<Ship> Ships { get; set; }

        public Port(string name)
        {
            Name = name;
            Ships = new List<Ship>();
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Port name: {Name}");
            Console.WriteLine($"Port number: {PortNumber}");
            Console.WriteLine("Ships in the port: " + Ships.Count);
            Console.WriteLine("Total load capacity: " + GetTotalLoadCapacity() + " tons");

        }

        public void AddShip(Ship ship)
        {
            Ships.Add(ship);
        }
        public int GetTotalLoadCapacity()
        {
            return Ships.Sum(s => s.GetLoadCapacity());
        }
    }

    public abstract class Ship
    {
        public string Name { get; set; }

        public int YearBuilt { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        // public int Capacity { get; set; }
        public abstract int GetLoadCapacity();

        // public List<Port> Ports { get; set; }
    }


    public class CargoShip : Ship
    {
        public int MaxTons { get; set; }

        public override int GetLoadCapacity()
        {
            return MaxTons;
        }
    }
    
    public class PassengerShip : Ship
    {
        public int MaxPassengers { get; set; }

        public override int GetLoadCapacity()
        {
            return MaxPassengers * 100;
        }
    }
    
}

