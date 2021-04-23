using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeVsZombies
{
    class Zombie
    {
        private Coordinates Coordinates;
        private bool Alive;
        public int MovementSpeed => 400;

        public Zombie(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Alive = true;
        }
    }
}
