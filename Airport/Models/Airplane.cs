using System.Collections.Generic;

namespace Airport.Object
{
    public class Airplane
    {
        public int AirplaneId { get; set; }

        public string Model { get; set; }

        public int ValueMest { get; set; }

        public string NameCapitan { get; set; }

        public string LastNameCapitan { get; set; }

        public virtual ICollection<Reise> Reises { get; set; }
    }
}
