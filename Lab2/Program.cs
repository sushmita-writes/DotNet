Console.WriteLine("Lab2: Data types and Operators");

// value types
Console.WriteLine("\nValue types:");

int i1 = 80010355, i2 = -62;
Console.WriteLine($"{i1.GetType()} => i1 = {i1}, i2 = {i2}");

short s1 = 355, s2 = -62;
Console.WriteLine($"{s1.GetType()} => s1 = {s1}, s2 = {s2}");

byte b1 = 62, b2 = 255; // byte cannot be negative
Console.WriteLine($"{b1.GetType()} => b1 = {b1}, b2 = {b2}");

long l1 = 6280010355, l2 = -62;
Console.WriteLine($"{l1.GetType()} => l1 = {l1}, l2 = {l2}");

float f1 = 62.062f, f2 = -62.0f;
Console.WriteLine($"{f1.GetType()} => f1 = {f1}, f2 = {f2}");

double d1 = 62.062, d2 = -62.0;
Console.WriteLine($"{d1.GetType()} => d1 = {d1}, d2 = {d2}");

decimal m1 = 80010355.355m, m2 = -62.0m;
Console.WriteLine($"{m1.GetType()} => m1 = {m1}, m2 = {m2}");

char c1 = 'A', c2 = 'B';
Console.WriteLine($"{c1.GetType()} => c1 = {c1}, c2 = {c2}");

bool bool1 = true, bool2 = false;
Console.WriteLine($"{bool1.GetType()} => bool1 = {bool1}, bool2 = {bool2}");

Console.WriteLine("\nReference types:");

int[] arr = new int[5] { 11, 22, 33, 44, 55 };
Console.WriteLine($"{arr.GetType()} => arr = [{string.Join(", ", arr)}]");

string str = "Hello, World!";
Console.WriteLine($"{str.GetType()} => str = {str}");

MyStruct s = new MyStruct { X = 10, Y = 20 };
Console.WriteLine($"{s.GetType()} => s.X = {s.X}, s.Y = {s.Y}");

Console.WriteLine($"{Days.Mon.GetType()} => {Days.Sun}, ..., {Days.Fri}");

int Add(int x, int y)
{
    return x + y;
}

MyDelegate add = Add;
Console.WriteLine($"{add.GetType()} => add(578, 190) = {add(578, 190)}");

public delegate int MyDelegate(int x, int y);

struct MyStruct
{
    public int X;
    public int Y;
}

enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
