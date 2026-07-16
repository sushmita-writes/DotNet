using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    // cannot create an object of an abstract class
    public abstract class Contract
    {
        public abstract void Greet();
        public abstract void Sign();
        public void Display()
        {
            Console.WriteLine("Non-abstract method");
        }

    }

    public class Document : Contract
    {
        public override void Greet()
        {
            Console.WriteLine("Abstract method: Hello, World!");
        }
        public override void Sign()
        {
            Console.WriteLine("Abstract method: Document signed.");
        }
    }
}
