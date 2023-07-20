Box<double> boxA = new Box<double>(8);
Box<string> boxB = new Box<string>("Hello World!");
AdvancedBox<string, int> boxC = new AdvancedBox<string, int>("Hello", 8);


System.Console.WriteLine("BoxA: " + boxA.getItem() + " boxA of type: " + boxA.DisplayType());
System.Console.WriteLine("BoxB: " + boxB.getItem() + " boxB of type: " + boxB.DisplayType());

System.Console.WriteLine("boxC.ItemA: " + boxC.itemA);
System.Console.WriteLine("boxC.ItemB: " + boxC.itemB);