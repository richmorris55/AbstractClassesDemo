using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Drives rough.");
        }


        public bool HasTrunk { get; set; }


    }
}

