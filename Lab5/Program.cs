using System.Collections.Generic;
using System.Collections;
using System.Security.Authentication;

Console.WriteLine("Generic Collections");
Console.WriteLine("-------------------");

Console.Write("List:");
List<string> fruits = new List<string>();
fruits.Add("Apple");
fruits.Add("Jackfruit");
fruits.Add("Mango");
foreach (string fruit in fruits)
{
    Console.Write("  " + fruit);
}

Console.Write("\nDictionary:");
Dictionary<int, string> myDict = new Dictionary<int, string>();
myDict.Add(1, "Sushmita");
myDict.Add(2, "Sushma");
myDict.Add(3, "Luna");
foreach (KeyValuePair<int, string> kvp in myDict)
{
    Console.Write(" " + kvp.Key + "->" + kvp.Value);
}

Console.Write("\nSortedList:");
SortedList<int, string> mySortedList = new SortedList<int, string>();
mySortedList.Add(3, "Three");
mySortedList.Add(12, "Twelve");
mySortedList.Add(1, "One");
foreach (KeyValuePair<int, string> kvp in mySortedList)
{
    Console.Write(" " + kvp.Key + "->" + kvp.Value);
}

Console.Write("\nStack:");
Stack<string> myStack = new Stack<string>();
myStack.Push("s1");
myStack.Push("ss");
myStack.Pop();
myStack.Push("s2");
myStack.Push("s3");
foreach (string s in myStack)
{
    Console.Write("    " + s);
}

Console.WriteLine("\n\nNon-Generic Collections");
Console.WriteLine("-----------------------");

Console.WriteLine("ArrayList:");
ArrayList myArrayList = new ArrayList();
myArrayList.Add("string data tpe");
myArrayList.Add(80010355);
myArrayList.Add(DateTime.Now);
foreach (var item in myArrayList)
{
    Console.WriteLine("    " + item);
}

Console.Write("SortedList:");
SortedList slist  = new SortedList();
slist.Add(3, 99);
slist.Add(12, "Hello");
slist.Add(1, 56.5);
foreach (DictionaryEntry de in slist)
{
    Console.Write(" " + de.Key + "->" + de.Value);
}

Console.Write("\nQueue:");
Queue myQueue = new Queue();
myQueue.Enqueue("trash");
myQueue.Enqueue("Q-100");
myQueue.Enqueue(200);
myQueue.Enqueue(300.004);
myQueue.Dequeue();
foreach (var item in myQueue)
{
    Console.Write("    " + item);
}
Console.WriteLine("\n\n");
//  *************** FILE IO  ****************

string folderPath = "C:\\Users\\shres\\DotNet\\Lab5\\Documents";
Directory.CreateDirectory(folderPath); // if folder already exists, this will do nothing
string filepath = Path.Combine(folderPath, "myfile.txt");

//File.WriteAllText(filepath, "Written to myfile.txt\n    -> WriteAllText. ");
//File.AppendAllText(filepath, "\nAppended to myfile.txt\n   -> AppendAllText. ");
//File.AppendAllLines(filepath, ["line1", "line2"]);

bool fileExists = File.Exists(filepath);
if (fileExists)
{
    string content = File.ReadAllText(filepath);
    Console.WriteLine("File Content:");
    Console.WriteLine(content);
}

string copiedfilePath = Path.Combine(folderPath, "myfile_copy.txt");
File.Delete(copiedfilePath); 
if (!File.Exists(copiedfilePath))
{
    File.Copy(filepath, copiedfilePath);
    Console.WriteLine($"File copied to {copiedfilePath}");

}
else
{
    Console.WriteLine($"File already exists at {copiedfilePath}");
}
