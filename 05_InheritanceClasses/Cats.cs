using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_InheritanceClasses
{
    //cat is the derived class
    public class Cat : Animal  //Animal is the base class and is inheriting from Animal
    {
        public Cat()
        {
            Console.WriteLine("This Made a Cat");
        }

        public Cat(bool isMammal) : base(isMammal)
        {
            
        }

        public double ClawLength { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Meow.");//wheen using shortcuts- it is called scaffolding
        }

        public override void Move() //overriding the Animal override..had to add virtual to Animal
        {
            base.Move();//invoking the parent method
            Console.WriteLine("They move quickly!");
        }
    }

    public class RagdollCat : Cat
    {
        public override void MakeSound()//change cat to virtual and override for this one
        {
            Console.WriteLine("Purrrr.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} meanders across the floor.");
        }//commenting out ctrl + shift + /

    }

    public class Calico : Cat
    {
        //Constructor
        public Calico()
        {
            Console.WriteLine("This Constructor Made a Calico.");
        }
    }
}
