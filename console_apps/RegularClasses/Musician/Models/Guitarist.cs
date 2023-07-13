public class Guitarist : Musician {
    public override Play(string song){
        song = "G C Am D7";
        System.Console.WriteLine("Playing this Guitar " + song);
    }
}