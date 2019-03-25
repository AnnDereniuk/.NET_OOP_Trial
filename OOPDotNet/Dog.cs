using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDotNet
{
    class Dog : Animal
    {
        private int weight;
        private int age;
        public Dog()
        {

        }
        public override void doing()
        {
            Console.WriteLine("Woof");
        }

        public override void eat()
        {
            setWeight(getWeight() + 4);
            Console.WriteLine("I like eating meat");
        }
    }
}
