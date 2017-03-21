using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    interface IAccelerate
    {
        int speed
        {
            set;
            get;
        }

        void Accelerate(int change);
    }

    interface IDive
    {

        int dive
        {
            set;
            get;
        }

        void Dive(int change);
    }

    interface IRise
    {
        int rise
        {
            set;
            get;
        }

        void Rise(int change);
    }
}