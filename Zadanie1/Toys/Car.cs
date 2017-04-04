using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Toys
{
    class Car : IAccelerate
    {
        public String name;

        public int speed
        {
            set;
            get;
        }

        public void Accelerate(int change)
        {
            speed = change;
        }

        public Car(int speed, String name)
        {
            this.speed = speed;
            this.name = name;
        }

        public Car()
        {
            
        }

    }
}
