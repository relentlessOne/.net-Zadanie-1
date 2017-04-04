using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Toys
{
    class Submarine : IAccelerate, IDive
    {
        public String name;

        public int dive
        {
            get;

            set;
        }

        public int speed
        {
            get;

            set;
        }

        public void Accelerate(int change)
        {
            speed = change;
        }

        public void Dive(int change)
        {
            dive = change;
        }

        public Submarine(int speed, int dive, String name)
        {
            this.speed = speed;
            this.dive = dive;
            this.name = name;
        }

        public Submarine()
        {

        }
    }
}
