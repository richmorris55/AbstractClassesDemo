using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		

        public override void DriveAbstract()
        {
            Console.WriteLine("Drives rough."); 
        }


        public bool HasSideCar { get; set; }


    }
}

