using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void Properties()
        {
            //creating an instances or "newing" up
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Ford";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Focus";
            firstVehicle.Mileage = 1234;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine($"This is a {firstVehicle.Make} {firstVehicle.Model} it has {firstVehicle.Mileage} miles on it.");

            Vehicle secondVehicle = firstVehicle;
            secondVehicle.Mileage = 70000;

            Console.WriteLine(firstVehicle.Mileage);
        }

        [TestMethod]
        public void Constructors()
        {
            Vehicle car = new Vehicle();
            car.Make = "Honda";
            car.Model = "Accord";

            Console.WriteLine($"This is my {car.Make} {car.Model}");

            Vehicle rocket = new Vehicle("Nasa", "Shuttle", 400000, VehicleType.Spaceship);
            Console.WriteLine($"This is my {rocket.Make} { rocket.Model}");
        }
    }
}
