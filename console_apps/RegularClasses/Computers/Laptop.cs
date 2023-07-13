public class Laptop : Computer{
    public override string Boot(string mode)
    {
        return $"Laptop is booting {mode}";
        // when its a base level it will inheritance one level up
    }
}