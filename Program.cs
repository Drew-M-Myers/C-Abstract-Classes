using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles
            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car foucs = new Car() { Make = "Ford", Model = "Focus", Year = "2010", HasTrunk = true, NumberOfWindowsThatRoleDown = 4 };
            Motorcycle spyder = new Motorcycle() { Make = "Spyder", Model = "Can-Am", Year = "2022", DoesItHavASideCar = false, NumberOfWheels = 3 };

            Vehicle sedan = new Car() { Make = "Toyota", Model = "Camry", Year = "1998", NumberOfWindowsThatRoleDown = 4 };
            Vehicle motorcycle = new Motorcycle() { Make = "Suzuki", Model = "TL 1000 R", Year = "2001" };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(foucs);
            vehicles.Add(spyder);
            vehicles.Add(sedan);
            vehicles.Add(motorcycle);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("----------------------------------------------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
