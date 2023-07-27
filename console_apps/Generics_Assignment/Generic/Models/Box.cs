public class Box<T>{
    private T item;
    public void SetValue(T item){
        this.item = item;
    }
    public T GetValue(){
        return this.item;
    }
    public void print(T item1, T item2){
        System.Console.WriteLine(item1);
    }
}