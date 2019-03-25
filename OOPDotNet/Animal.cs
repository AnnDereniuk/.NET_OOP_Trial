using System;


namespace OOPDotNet
{
    class Animal
    {
        private int weight;
        private int age;

        public int getAge()
        {
            return age;
        }

        public int getWeight()
        {
            return weight;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public virtual void doing()
        {
            Console.WriteLine("I can say smth");
        }

        public virtual void eat()
        {
            weight++;
            Console.WriteLine("I'm eating");
        }

        public void toString()
        {
            Console.WriteLine("My current age is "+age+" years and my current weight is "+weight); 
        }

        public Animal()
        {

        }
        public Animal(int weight, int age)
        {
            this.age = age;
            this.weight = weight;
        }
    }
}
