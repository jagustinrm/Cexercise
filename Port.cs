using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Ships;


namespace Models.Ports
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
        public void OrderByNameAscending()
        {
            var sortedShips = Ships.OrderBy(s => s.Name).ToList();
            for (int i = 0; i < sortedShips.Count; i++)
            {
                Console.WriteLine(sortedShips[i].Name);
            }
        }

        public void OrderByNameDescending()
        {
            var sortedShips = Ships.OrderByDescending(s => s.Name).ToList();
            for (int i = 0; i < sortedShips.Count; i++)
            {
                Console.WriteLine(sortedShips[i].Name);
            }
        }

        public void FindShipByName(string name) {
            var ship = Ships.FirstOrDefault(s => s.Name == name);
            if (ship != null)
            {
                Console.WriteLine("Ship found:");
                Console.WriteLine($"Name: {ship.Name}");
                Console.WriteLine($"Year built: {ship.YearBuilt}");
                Console.WriteLine($"Brand: {ship.Brand}");
                Console.WriteLine($"Type: {ship.Type}");
                Console.WriteLine($"Load capacity: {ship.GetLoadCapacity()} tons");
            }
            else
            {
                Console.WriteLine("Ship not found.");
            }
        }
    }
}

namespace Models.Ships {
    public interface ILoadable
    {
        int GetLoadCapacity();
    }
    public abstract class Ship : ILoadable
    {
        public string Name { get; set; }
        public int YearBuilt { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        public abstract int GetLoadCapacity();
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

