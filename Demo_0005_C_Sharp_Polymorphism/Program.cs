using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0005_C_Sharp_Polymorphism
{
    class Animal
    {
        private int Id;
        private string Name;

        public Animal(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public virtual void EatingFood()
        {
            Console.WriteLine("The Animal is eating food");
        }
        public virtual void Sleeping()
        {
            Console.WriteLine("The Animal is sleeping");
        }
        public virtual void Running()
        {
            Console.WriteLine("The Animal is running");
        }
    }
    class Dog : Animal
    {
        private string Breed;

        public Dog(int id, string name, string breed) : base(id, name)
        {
            this.Breed = breed;
        }
        public override void EatingFood()
        {
            base.EatingFood();                  //The base class method can be called from within the derived class using the base keyword
            Console.WriteLine("The Dog is eating food");
        }
        public override void Sleeping()
        {
            Console.WriteLine("The Dog is sleeping");
        }
        public new void Running()
        {
            Console.WriteLine("The Dog is running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal(2, "def");
            a1.EatingFood();
            a1.Sleeping();
            a1.Running();
            Console.WriteLine();

            Dog d1 = new Dog(1, "abc", "indian");
            d1.EatingFood();
            d1.Sleeping();
            d1.Running();
            Console.WriteLine();

            Animal a2 = new Dog(3, "ght", "indian");
            a2.EatingFood();
            a2.Sleeping();
            a2.Running();
            Console.WriteLine();
        }
    }
}
