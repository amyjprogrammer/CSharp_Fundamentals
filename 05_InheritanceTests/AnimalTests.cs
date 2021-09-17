using _05_InheritanceClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_InheritanceTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void MovementTest_ShouldWriteToConsoleContainingAnimalTypeName()
        {
            Animal animalOne = new Animal();//newing up
            animalOne.Move();
        }

        [TestMethod]
        public void CatMovementTest_ShouldWriteToConsoleContainingCatTypeNamePlusSecondLineSpecificToCatType() 
        {
            
            Cat catOne = new Cat(true);
            catOne.Move();

            catOne.ClawLength = 3.7;
        }

        [TestMethod]
        public void RagdollMethodsTest_ShouldOutputToConsoleRagdollCatSpecificWriteLines()
        {
            RagdollCat whiskers = new RagdollCat();
            Cat snickers = new RagdollCat();//object ragdoll of type cat

            whiskers.Move();
            snickers.MakeSound();//shows purrrr. 
            //if MakeSound was not in Cat snickers wouldn't be able to access it
        }

        [TestMethod]
        public void CalicoConstructorTest_ShouldOutputToConsoleProperWriteLines()
        {
            Cat fluffy = new Calico();

            fluffy.IsMammal = true;
            fluffy.ClawLength = 1.1;
            fluffy.Move();
            fluffy.MakeSound();
        }

        [TestMethod]
        public void CheckingTypes()
        {
            Calico catOne = new Calico();
            Animal animalOne = new Calico();

            List<Animal> animals = new List<Animal>();

            animals.Add(catOne);
            animals.Add(new RagdollCat());
            animals.Add(new Animal());
            
        }
    }
}
