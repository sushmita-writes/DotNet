using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Vehicle
    {
        public int noOfWheels;
        public string plateName;

        public Vehicle(int noOfWheels, string plateName)
        {
            Console.WriteLine("\n   BASE CLASS CONSTRUCTOR   ");
            this.noOfWheels = noOfWheels;
            this.plateName = plateName;
        }

        public virtual void DisplayWheels()
        {
            Console.WriteLine($"No. of wheels: {noOfWheels} ");
        }
        public void DisplayPlate()
        {
            Console.WriteLine($"Plate Name: {plateName}");
        }

        public void Horn()
        {
            Console.WriteLine("Horn: Unknown");
        }
    }

    public class Car : Vehicle
    {
        public string model;

        public Car(string model, string plateName) : base(4, plateName)
        {   
            Console.WriteLine("   DERIVED CLASS CONSTRUCTOR   ");
            this.model = model;
        }

        public override void DisplayWheels()
        {
            Console.Write("This is a Car. ");
            base.DisplayWheels();
            Console.Write("Car Model: " + model + ", ");
            base.DisplayPlate();
        }
        public new void Horn()
        {
            Console.WriteLine("Horn: Beep Beep");
        }
    }

    public class Cycle : Vehicle
    {
        public string size;
        public Cycle(string size, string plateName) : base(2, plateName)
        {
            Console.WriteLine("   DERIVED CLASS CONSTRUCTOR   ");
            this.size = size;
        }
        public override void DisplayWheels()
        {
            Console.Write("This is a Cycle. ");
            base.DisplayWheels();
            Console.Write("Cycle Size: " + size + ", ");
            base.DisplayPlate();
        }

        public new void Horn()
        {
            Console.WriteLine("Horn: Ring Ring");
        }
    }
}
