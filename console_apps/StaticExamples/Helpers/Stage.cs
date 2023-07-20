public static class Stage{
    //Can't have a constructor without a static

    public static string Name{get;set;} = "Spider";


    public static int Multiply(int a, int b){
        return a * b;
    }
    public static void ChangeName(Robot bot, string newName){
        bot.Name = newName;
    }

}