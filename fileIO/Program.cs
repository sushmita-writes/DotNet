FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
for (int i = 0; i < 10; i++)
{
    F.WriteByte((byte)i);
}

Console.WriteLine("Data in test.dat:");
F.Position = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write(F.ReadByte());
}
F.Close();
Console.ReadKey();

