using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuPandBot
{
    class Panda : IPet
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        private bool IsAsleep { get; set; }
        public string OwnersName { get; set; }

        public Panda(string name)
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
            Console.WriteLine($"{this} panda is munching {food}");
        }

        public void SayHello()
        {
            Console.WriteLine($"{this} panda says hello.");
        }
    }
}
