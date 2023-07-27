Box<double> boxA = new Box<double>(8);
Box<string> boxB = new Box<string>("Hello World!");
AdvancedBox<string, int> boxC = new AdvancedBox<string, int>("Hello", 8);


System.Console.WriteLine($"BoxA: {boxA.GetItem()} +  boxA of type:   {boxA.DisplayType()}");
System.Console.WriteLine($"BoxB: {boxB.GetItem()} boxB of type: {boxB.DisplayType()}");

System.Console.WriteLine("boxC.ItemA: " + boxC.ItemA);
System.Console.WriteLine("boxC.ItemB: " + boxC.ItemB);


//////////========------------
Box<int> testBox = new Box<int>(8);
System.Console.WriteLine(testBox.GetItem());
testBox.SetItem(12);
System.Console.WriteLine(testBox.GetItem());

Box<Double> testBox2 = new Box<Double>(80, 120);
System.Console.WriteLine(testBox2.Thing);
testBox2.Thing = 160;
System.Console.WriteLine(testBox2.Thing);


string firstWord = "Hello";
string secondWord = " World!";

int firstNum = 8;
int secondNum = 12;

// System.Console.WriteLine(firstWord.CompareTo(secondWord));
// System.Console.WriteLine(firstNum.CompareTo(secondNum));

