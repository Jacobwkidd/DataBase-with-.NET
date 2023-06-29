using InterfaceExercises.Interfaces;
using InterfaceExercises.Models;

GameCharacter dolphin = new GameCharacter();
int depthResult = dolphin.Dive(100);
dolphin.Dive(80);
System.Console.WriteLine("Depth result: " + depthResult);
System.Console.WriteLine("Dolphin Current Depth: " + dolphin.CurrentDepth);

Robot walle = new Robot();
int angleResult = walle.TurnAngle(400);


System.Console.WriteLine("Angle Result: " + angleResult);
System.Console.WriteLine("walle direction: " + walle.Direction);


