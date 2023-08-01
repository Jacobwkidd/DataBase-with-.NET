Box<int> intBox = new Box<int>();
intBox.SetValue(10);
Console.WriteLine(intBox.GetValue());  // Should output: 10

Box<string> stringBox = new Box<string>();
stringBox.SetValue("Hello, world!");
Console.WriteLine(stringBox.GetValue());  // Should output: Hello, world!

System.Console.WriteLine("================== Problem 2 Starts ============================");
// compare two things and see if we have the same type 

Printer printer = new Printer();
printer.Print<int>(5, 10);  // Should output: Value 1: 5, Value 2: 10
printer.Print<string>("Hello", "World");  // Should output: Value 1: Hello, Value 2: World

System.Console.WriteLine("================== Problem 2 Ends ============================");
System.Console.WriteLine("================== Problem 3 Starts ============================");
Pair<int, string> pair = new Pair<int, string> { First = 1, Second = "one" };
Console.WriteLine($"First: {pair.First}, Second: {pair.Second}");  // Should output: First: 1, Second: one
System.Console.WriteLine("================== Problem 3 Ends ============================");
System.Console.WriteLine("================== Problem 4 Starts ============================");
Comparator comparator = new Comparator();
Console.WriteLine(comparator.Compare<int>(5, 10));  // Should output: False
Console.WriteLine(comparator.Compare<string>("Hello", "Hello"));  // Should output: True

System.Console.WriteLine("================== Problem 4 Ends ============================");
System.Console.WriteLine("================== Problem 5 Starts ============================");
Triple<int, string, bool> triple = new Triple<int, string, bool> { First = 1, Second = "one", Third = true };
Console.WriteLine($"First: {triple.First}, Second: {triple.Second}, Third: {triple.Third}");  // Should output: First: 1, Second: one, Third: True

System.Console.WriteLine("================== Problem 5 Ends ============================");
System.Console.WriteLine("================== Problem 6 Starts ============================");
ArrayPrinter arrayPrinter = new ArrayPrinter();
arrayPrinter.PrintArray<int>(new int[] { 1, 2, 3, 4, 5 });  // Should output: 1 2 3 4 5 (on separate lines)
arrayPrinter.PrintArray<string>(new string[] { "Hello", "World" });  // Should output: Hello World (on separate lines)

System.Console.WriteLine("================== Problem 6 Ends ============================");
System.Console.WriteLine("================== Problem 7 Starts ============================");
Container<int> container = new Container<int>();
container.AddItem(10);
container.AddItem(20);
container.RemoveItem(10);
container.PrintItem();

System.Console.WriteLine("================== Problem 7 Ends ============================");
System.Console.WriteLine("================== Problem 8 Starts ============================");
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
Console.WriteLine(stack.Pop());  // Should output: 2
Console.WriteLine(stack.IsEmpty());  // Should output: False

System.Console.WriteLine("================== Problem 8 Ends ============================");
System.Console.WriteLine("================== Problem 9 Starts ============================");
Box<int> box1 = new Box<int>();
box1.SetValue(10);
Box<int> box2 = new Box<int>();
box2.SetValue(20);
box1.Swap(box2);
Console.WriteLine($"Box1 Value: {box1.GetValue()}, Box2 Value: {box2.GetValue()}");  // Should output: Box1 Value: 20, Box2 Value: 10

System.Console.WriteLine("================== Problem 9 Ends ============================");
System.Console.WriteLine("================== Problem 10 Starts ============================");
Utilities utilities = new Utilities();
Console.WriteLine(utilities.Max<int>(5, 10));  // Should output: 10
Console.WriteLine(utilities.Max<string>("Hello", "World"));  // Should output: World

System.Console.WriteLine("================== Problem 10 Ends ============================");