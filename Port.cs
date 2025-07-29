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
    }
}

public class Ship
{
    public string Name { get; set; }

    public int YearBuilt { get; set; }

    public string Brand { get; set; }

    public string Type { get; set; }

    public int Capacity { get; set; }
    
    // public List<Port> Ports { get; set; }
}

    
}

