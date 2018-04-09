using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuPandBot
{
    class Human 
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        private bool IsAsleep { get; set; }
        public List<IPet> PetList = new List<IPet>();

        public Human(string name)
        {
            Name = name;
            Birthday = DateTime.Now;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }

        public void FallAsleep()
        {
            IsAsleep = true;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{this} human is eating {food}");
        }

        public void SayHello()
        {
            Console.WriteLine($"{this} human says: Hey there!");
        }

        public void AdoptPet (IPet pet)
        {
            pet.OwnersName = this.Name;
            this.PetList.Add(pet);
        }
    }
}
