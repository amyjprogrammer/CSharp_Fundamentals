using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes_Setters
{
    [TestClass]
    public class QuakerTests
    {
        Exception thrownException = null;//newing up as null
        [TestMethod]
        public void InvalidUserName_ShouldThrowFormatException()
        {
            Quacker donald = new Quacker();

            //Try Catch
            try
            {
                //Tries to run any code in here
                donald.UserName = "Bob";
                Console.WriteLine("This is after setting Username");//will not run if line above will throw an exception
                //int.Parse("nine");
            }
            catch (FormatException error)
            {
                //Catches exceptions and runs code in here
                Console.WriteLine(error.Message);
                thrownException = error;
            }
            finally
            {
                //This is code that always runs.
                Console.WriteLine("This code is unstoppable.");
            }
            Console.WriteLine("This code can be stopped");

            Assert.IsInstanceOfType(thrownException, typeof(FormatException));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]//tells the system to expect the exception
        public void InvalidAge_ShouldThrowArgumentException()
        {
            var louie = new Quacker();
            louie.Age = 10;
        }
    }
}
