public class Robot{
    public string Name{get;set;}
    public static string Company{get;set;} = "Async";
    public int BatteryPower{get;set;} = 100;
    public Robot(string name){
        this.Name = name;
    }
    public void SuperCharge(int charge){
        var result = Robot.Add(this.BatteryPower, charge);
        System.Console.WriteLine(result);
        this.BatteryPower += charge;
    }
    public static int Add(int a, int b){
        return a + b;
    }
   
    public static void ChangeName(Robot bot, string newName){
        bot.Name = newName;
    }
}