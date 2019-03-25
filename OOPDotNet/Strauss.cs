using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDotNet
{
    class Strauss: Animal
    {
        public override void eat()
        {
            setWeight(getWeight()+2);
            Console.WriteLine("I'm eating smth");
        }

    }
}
