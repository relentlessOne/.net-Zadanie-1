using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Toys
{
    class Plane : IAccelerate, IRise
    {

        public String name;

        public int rise
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

        public void Rise(int change)
        {
            rise = change;
        }

        public Plane(int speed, int rise, String name)
        {
            this.speed = speed;
            this.rise = rise;
            this.name = name;
        }
    }
}
