public class Car : IVehicle{
    public string Name{get;set;}
    public Car(string Name){
        this.Name = Name;
    }
    public void StartEngine(){
        System.Console.WriteLine("car StartEngine()");
    }
     public void StopEngine(){
        
    }
     public void Drive(){
        
    }

}