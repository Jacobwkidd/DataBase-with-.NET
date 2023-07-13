public class Desktop : Computer{
    public override string Boot(string mode){
        return $"Booting in {mode} with faster speed";
    }
}