using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class LabTitle
    {
        public LabTitle()
        {
            Console.WriteLine("Default constructor");
        }

        public LabTitle(Char c)
        {
            Console.WriteLine($"1 parameter constructor, c = {c}");
        }

        public LabTitle(Char c, int i)
        {
            Console.WriteLine($"2 parameter constructor, c = {c}, i = {i}");
        }
        public static void Out()
        {
            Console.WriteLine("Lab title?: ");
            string title = Console.ReadLine() ?? "**";
            Console.WriteLine($"Lab1: {title}");
        }
    }
}
