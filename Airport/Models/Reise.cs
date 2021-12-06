using System.Collections.Generic;

namespace Airport.Object
{
    public class Reise
    {
        public int ReiseId { get; set; }

        public int AirplaneId { get; set; }

        public virtual Airplane airplane { get; set; }

        public ICollection<Passenger> passengers { get; set; }

        public string ACity { get; set; }

        public string BCity { get; set; }

        public string DateRaise { get; set; }

        public string TimeFlight { get; set; }


    }
}
