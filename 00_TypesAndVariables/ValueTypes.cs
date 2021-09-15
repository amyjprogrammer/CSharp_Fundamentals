using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared; //declaring a variable
            isDeclared = true; //initializing

            bool isDeclaredandInitialized = true;  //declaring and initializing on the same line
        }

        [TestMethod]
        public void Characters()
        {
            //use single quotes for characters
            char character = 'a';
            char symbol = '?';
            char number = '1'; //can't do math with it
            char space = ' ';
            char specialCharacter = '\n';
            char singlequote = '\'';//is looking for a single '
        }

        [TestMethod]
        public void WholeNumbers()
        {
            //int short byte long int16 int32 int64
            byte byteExample = 3; //8 bits or 00000003, no negatives
            sbyte sByteExample = -128;//127 positive and -128
            short shortExample = 16;//can go negative, up to 32767
            Int16 anotherShortExample = -32768;//shows short

            //2^32
            int intMax = 2147483647;
            Int32 intMin = -2147483648;
            uint unSignedInt = 2147483648;

            //2^64
            long longExample = 9223372036854775807;
            
        }

        [TestMethod]
        public void Decimals()
        {
            //decimal double float
            //store a set number
            float floatExample = 3.14f;//must have the f
            double doubleExample = 3.14;
            decimal decimalExample = 3.14m; //must have the m

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        //Enum
        enum PastryTypes { Eclair, Croissant, Petitfour, Cake, Cupcake}
        [TestMethod]
        public void Enums()
        {
            PastryTypes myPastry = PastryTypes.Croissant;
            PastryTypes anotherOne = PastryTypes.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Today;

            DateTime specificDate = new DateTime(2021, 03, 24);
            DateTime todayTwo = today;

            //takes it type from the right side of assignment operator
            var variable = today;
            //variable = 'a';
            //to comment a line out is ctrl k + c
        }
    }
}
