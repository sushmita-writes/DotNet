using Lab4;

Vehicle v = new Vehicle(2, "ABC123");
v.DisplayWheels();
v.DisplayPlate();
v.Horn();

Car c = new Car("Toyota", "XYZ789");
c.DisplayWheels();
c.Horn(); 

Vehicle cy = new Cycle("XS", "CYCLE456");
cy.DisplayWheels();
cy.Horn();

/*
    Difference between virtual-override and new methods is that
    for new, base class method is called when object is type base class,
    and child class method is called when object is type child class.
    but for override, child class method is called even when object is type base class.
*/

Student s = new Student(62, 'A');
s.display();

Document doc = new Document();
Console.WriteLine("\nAbstract Class");
doc.Display();
doc.Greet();
doc.Sign();

Vulture v1 = new Vulture();
Console.WriteLine("\nInterface");
v1.Sound();
v1.Fly();