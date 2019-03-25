using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDotNet
{
    class Cat : Animal
    {
        public override void doing()
        {
            Console.WriteLine("Meow");
        }

        public override void eat()
        {
            setWeight(getWeight() + 3);
            Console.WriteLine("I like eating fish");
        }
    }
}
