public class Boat : IVehicle
{
    public string Name{get;set;}
    public Boat(string Name){
        this.Name = Name;
    }
    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void StartEngine()
    {
        System.Console.WriteLine("Boat StartEngine()");
    }

    public void StopEngine()
    {
        throw new NotImplementedException();
    }
}