using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeVsZombies
{
    class Human
    {
        private Coordinates Coordinates { get; set; }
        private bool Alive;

        public Human(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Alive = true;
        }
    }

}
