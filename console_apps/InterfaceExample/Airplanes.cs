public class Airplane : IVehicle
{
    public string Name {get; set;}
    public Airplane(string Name){
        this.Name = Name;
    }
    public void Test(){
        System.Console.WriteLine("Airplane Test");
    }
    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void StartEngine()
    {
        System.Console.WriteLine("Airplane StartEngine()");
    }

    public void StopEngine()
    {
        throw new NotImplementedException();
    }
}