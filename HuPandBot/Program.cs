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
            Console.WriteLine($"Welcome to life {Steve.Name}. You were born on {Steve.Birthday}");
            Console.WriteLine(Steve);

            var PanPan = new Panda("PanPan");
            Console.WriteLine($"{PanPan.Name} is a good panda.");
            Console.WriteLine(PanPan);

            var Rosie = new Robot("Rosie");
            Console.WriteLine($"{Rosie.Name} is here to clean your house.");
            Console.WriteLine(Rosie);

            Steve.AdoptPet(PanPan);
            Steve.AdoptPet(Rosie);

            foreach (IPet pet in Steve.PetList)
            {
                Console.WriteLine($"{pet} is in Steve's PetList");
            }

            Console.WriteLine($"PanPan's owner is: {PanPan.OwnersName}");
            Console.WriteLine($"Rosie's owner is: {Rosie.OwnersName}");

            Rosie.StartUp();
            Rosie.GetState();
            Rosie.ShutDown();
            Rosie.GetState();



            Console.ReadLine();
        }
    }
}
