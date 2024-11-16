using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Subscriber
    public class Referee
    {
        public string Name { get; set; }
        public string RefereeType { get; set; }
        public Referee()
        {
            Name = "Ahmed";
            RefereeType = "Main Referee";
        }

        //callback method
        public void Observe()
        {
            Console.WriteLine($"Referee {Name} is observing ball...");
        }

        public void Observe(Location loc)
        {
            Console.WriteLine($"Referee {Name} is observing ball...{loc}");
        }
    }
}
