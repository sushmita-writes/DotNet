using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public interface Animal
    {
        void Sound();
    }
    public interface Bird
    {
        void Fly();
    }

    // MULTIPLE INHERITANCE USING INTERFACES
    // not allowed in Class in C#, but allowed in Interfaces
    public class Vulture : Animal, Bird
    {
        public void Sound()
        {
            Console.WriteLine("Vulture Sound: Screech");
        }
        public void Fly()
        {
            Console.WriteLine("Vulture is flying.");
        }
    }
}
