

Car carA = new Car("carA");
Car carB = new Car("carB");
Car carC = new Car("carC");

Boat boatA = new Boat("boatA");
Boat boatB = new Boat("boatB");
Boat boatC = new Boat("boatC");

Airplane airplaneA = new Airplane("airplaneA");
Airplane airplaneB = new Airplane("airplaneB");
Airplane airplaneC = new Airplane("airplaneC");

Airplane[] planes = {airplaneA, airplaneB, airplaneC};

IVehicle[] vehicleArr = {airplaneA, boatA, carA};

foreach(IVehicle vehicle in vehicleArr){ // <= polymorphism
    vehicle.StartEngine();
}

System.Console.WriteLine("-----------------");

IVehicle airplaneZ = new Airplane("airplaneZ"); // its IVehicle because its the data type
System.Console.WriteLine("Airplane type: " + airplaneZ.GetType());

