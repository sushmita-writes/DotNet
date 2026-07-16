using Lab3;
Console.WriteLine("Lab3: Partial Class, Indexor");

Marksheet sushmita  = new Marksheet();
sushmita[0] = "CS259";
sushmita[1] = "CS260";
sushmita[2] = "CS261";
sushmita[0, "CS259"] = 'A';
sushmita[1, "CS260"] = 'B';
sushmita[2, "CS261"] = 'C';

Console.WriteLine("Using get and set accessors...");

Console.WriteLine("\nCourse\tGrade");
for (int i = 0; i < 3; i++)
{
    string code = sushmita[i];
    Console.WriteLine($"{code}\t{sushmita[i, code]}");
}
