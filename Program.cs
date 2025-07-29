using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
class Program
{
    static void Main()
    {
        // Acá empieza el programa
        Console.WriteLine("Hola mundo!");
        Port mc = new Port("Maracaibo");
        mc.PrintInfo();
    }
}

