using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Subscriber
    public class Player
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }

        public Player()
        {
            Number = 10;
            Name = "Magdy";
            Team = "Ettihad";
        }

        public override string ToString()
        {
            return $"{Name} from team {Team}";
        }

        //callback function
        public void Run()
        {
            Console.WriteLine($"Player {Name} from tem {Team} is running into ball");
        }

        //callback function
        public void Run(Location loc)
        {
            Console.WriteLine($"Player {Name} from team {Team} is running into ball {loc}");
        }
    }
}
