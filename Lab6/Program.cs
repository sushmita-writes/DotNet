using System.Xml.Linq;

string myXml = @"<students>
                    <student>Sushmita Shrestha</student>
                    <student>Sushma Lama</student>
                    <student>sushil Karki</student>
                    <student>Ram KC</student>
                    <student>Sushila Rai</student>
                    <student>Hari Sherpa</student>
                </students>";

XDocument myXmlDoc = new XDocument();
myXmlDoc = XDocument.Parse(myXml);

Console.WriteLine("LINQ and Lambda expression:\n-------------------------\nList of students:");
var students = myXmlDoc.Element("students").Descendants().Select(s => s.Value).ToList();
foreach (var student in students)
{
    Console.WriteLine("    " + student);
}

Console.WriteLine("Names starting with 'S':");
var startWithS = students.Where(x => x.StartsWith('S')).ToList();
foreach (var student in startWithS)
{
    Console.WriteLine("    " + student);
}

//-------WITHOUT USING LINQ AND LAMBDA-------
//var students = myXmlDoc.Element("students").Descendants();
//Console.WriteLine("List of students:");
//foreach (var student in students)
//{
//    Console.WriteLine(student.Value);
//}


List<int> ages = new List<int> { 11, 3, 6, 89, 19, 10, 8, 7, 29, 34 };
ages.Add(56);
ages.Add(17);
var agesGT20 = ages.Where(x => x > 20).ToList();
Console.WriteLine("Ages greater than 20:");
foreach (var age in agesGT20)
{
    Console.Write("    " + age);
}

// ******** TRY STATEMENTS AND EXCEPTIONS ********
Console.WriteLine("\n\nTry statements and exceptions:");
Console.WriteLine("-------------------------");
int n1 = 0, n2 = 0, result = 0;
Console.WriteLine("Enter two numbers");
try
{
    n1 = Convert.ToInt32(Console.ReadLine());
    n2 = Convert.ToInt32(Console.ReadLine());

}
catch (FormatException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}


try
{
    result = n1 / n2;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Result: " + result);
}

try
{
    throw new Exception("thrown a custom exception message");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
