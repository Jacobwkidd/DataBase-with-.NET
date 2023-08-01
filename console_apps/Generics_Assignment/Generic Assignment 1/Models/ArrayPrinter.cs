public class ArrayPrinter{
    public void PrintArray<T>(T[] array){
        foreach(T item in array){
            System.Console.WriteLine($"Item {item}");
        }
    }
}