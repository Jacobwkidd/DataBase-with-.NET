public class Computer{
    public string Brand{get;set;}
    public string OS{get;set;}
    // has to be virtual because it's the first we see it
    public virtual string Boot(string mode){
        return $"Booting in {mode}.";
    }
}