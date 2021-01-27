using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Family p = new Family();
            Console.Write(p.Kids);
            foreach (var i in p.Kids)
            {
                Console.WriteLine(i);
            }
        }
        public class LivingBeing
        {
            public virtual string Speak()
            {
                return " The Living Being Speaks";
            }
        }

        public class Human : LivingBeing
        {

            public string Name { get; set; }
            public string Thoughts = "I Think";
            
            public override string Speak()
            {
                return $"My name is {this.Name}";
            }
            public string Lie()
            {
                return Thoughts + base.Speak();
            }
            public Deceased Die()
            {
                return (Deceased)this;
            }
        }
        public class Man : Human
        {
           
        }
        public class Boy : Man
        {
            public override string Speak()
            {
                return "Hi! " + base.Speak();
            }
        }
        public class Woman : Human
        {
            
        }
        public class Girl : Woman
        {
            public override string Speak()
            {
                return "Hi! " + base.Speak();
            }
            
        }
        public class Family
        {
            readonly public Human[] Kids = new Human[2] { new Boy(), new Girl() };
        }
        public class Deceased : Human
        {
           
        }
        public class Dog : LivingBeing
        {
            public override string Speak()
            {
                 return "Woof!";
            }
        }

        public class Cat : LivingBeing
        {
            public override string Speak()
            {
                return "Meow!";
            }
        }

        public class Tree : LivingBeing
        {

        }
    }
}
