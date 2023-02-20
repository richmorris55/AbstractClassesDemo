using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles


            List<Vehicle> vehicleList = new List<Vehicle>();




            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * 
             * 
             * 
             * Set the properties with object initializer syntax
             */


            Car car1 = new Car()
            {
                Year = "1968",

                Make = "Chevrolet",

                Model = "Camaro",

                HasTrunk = true
            };



            Motorcycle moto1 = new Motorcycle()
            {

                Year = "1931",

                Make = "Indian",

                Model = "101 Scout",

                HasSideCar = false

            };


            Vehicle car2 = new Car()
            {
                Year = "1967",

                Make = "Ford Shelby",

                Model = "Gt 500"
            };


            Vehicle moto2 = new Motorcycle()
            {

                Year = "1936",

                Make = "Harley Davidson",

                Model = "Knucklehead"

            };




            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicleList.Add(car1);

            vehicleList.Add(car2);

            vehicleList.Add(moto1);

            vehicleList.Add(moto2);


            foreach (var vehicle in vehicleList)
            {

                Console.WriteLine($"Year: {vehicle.Year}");

                Console.WriteLine($"Make: {vehicle.Make}");

                Console.WriteLine($"Model: {vehicle.Model}");

                vehicle.DriveAbstract();

                vehicle.DriveVirtual();


                Console.WriteLine();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle


            #endregion            
            Console.ReadLine();
        }
    }
}
