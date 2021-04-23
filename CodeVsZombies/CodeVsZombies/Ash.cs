using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeVsZombies
{
    class Ash
    {
        private Coordinates Coordinates;
        private int MovementSpeed => 1000;
        private int Range => 2000;

        public Ash(Coordinates coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
