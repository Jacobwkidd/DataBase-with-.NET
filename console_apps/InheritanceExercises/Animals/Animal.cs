public class Animal{
    public string Name {get; set;}
    public virtual void MakeSound(){
        System.Console.WriteLine("The animal makes a sound");
    }
}