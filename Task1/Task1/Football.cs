using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Publisher
    public class Football
    {
        public int Id { get; set; }
        public string FootballName { get; set; }

        Location location;
        public Location Location
        {
            set
            {
                if (value != location)
                {
                    BallLocationChanged?.Invoke(value);
                }
                location = value;
            }
            get
            {
                return location;
            }
        }

        public override string ToString()
        {
            return $"football in location {this.location}";
        }

        public event Action<Location> BallLocationChanged;
    }
}
