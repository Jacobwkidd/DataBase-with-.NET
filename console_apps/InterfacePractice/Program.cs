using InterfacePractice.Interfaces;
using InterfacePractice.Services;


System.Console.WriteLine("-------------------- Book Start ---------------------");
Book HP = new Book();
HP.Title = "Harry Potter";
HP.Author = "JK Rowling";
HP.Genre = "Fantasy";
System.Console.WriteLine(HP.PrintDetails());

System.Console.WriteLine("------------------- Book End ------------------------");
System.Console.WriteLine("------------------- Student Start -------------------");

Student Jake = new Student();
Jake.Name = "Jake";
Jake.Age = 25;
Jake.Major = "Web and Software Development";
System.Console.WriteLine(Jake.PrintDetails());
System.Console.WriteLine("------------------- Student Ends ---------------------");
System.Console.WriteLine("------------------- BasicCalculations Starts ---------------------");
BasicCalculations basicAdd = new BasicCalculations();

System.Console.WriteLine("Add: " + basicAdd.Add(5, 5));

BasicCalculations Subtract = new BasicCalculations();
System.Console.WriteLine("Subtract: " + Subtract.Subtract(5, 5));

System.Console.WriteLine("------------------- BasicCalculations Ends ---------------------");
System.Console.WriteLine("------------------- IMeasurable Starts ---------------------");
Circle circle1 = new Circle(10);

double area = circle1.CalculateArea();
double peri = circle1.CalculatePerimeter();

System.Console.WriteLine("Circle: " + area);
System.Console.WriteLine("Circle: " + peri);

Rectangle rect = new Rectangle(10, 10);
System.Console.WriteLine("Rectangle Area: " + rect.CalculateArea());
System.Console.WriteLine("Rectangle Parimeter: " + rect.CalculatePerimeter());


System.Console.WriteLine("------------------- IMeasurable Ends ---------------------");