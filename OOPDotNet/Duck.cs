using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDotNet
{
    class Duck : Animal
    {
        private int weight;
        private int age;
        public override void doing()
        {
            Console.WriteLine("I can fly");
        }

        public override void eat()
        {
            setWeight(getWeight() + 2);
            Console.WriteLine("I'm eating smth");
        }
    }
}
