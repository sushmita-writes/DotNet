using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    // Sealed class cannot be inherited.
    public sealed class Student 
    {
        private int id;
        private char grade;

        public Student(int id, char grade)
        {
            this.id = id;
            this.grade = grade;
        }

        public void display()
        {
            Console.WriteLine("\nSealed class: " + typeof(Student));
            Console.WriteLine($"ID: {id}, Grade: {grade}");
        }
    }
}
