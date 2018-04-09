using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuPandBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var Steve = new Human("Steve");
            Console.WriteLine($"Welcome to life {Steve.Name}");

            var PanPan = new Panda("PanPan");
            Console.WriteLine($"{PanPan.Name} is a good panda.");

            var Rosie = new Robot("Rosie");
            Console.WriteLine($"{Rosie.Name} is here to clean your house.");

            Console.ReadLine();
        }
    }
}
