using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum PastryType { Cupcake, Cake, Croissant, PetiteFleu}
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
                case 22:
                    Console.WriteLine("You skipped a few options");
                    break;
                default:
                    Console.WriteLine("You didn't pick any of my numbers");
                    break;
            }

            PastryType pastry = PastryType.Cake;

            switch (pastry)
            {
                case PastryType.Cupcake:
                    Console.WriteLine("That is $4.");
                    break;
                case PastryType.Cake:
                    Console.WriteLine("That is $30.");
                    break;
                case PastryType.Croissant:
                    Console.WriteLine("That is $3.50");
                    break;
                case PastryType.PetiteFleu:
                    Console.WriteLine("That is $4.50");
                    break;
                default:
                    break;
            }
        }
    }
}
