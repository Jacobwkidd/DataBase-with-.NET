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
    public void Swap(Box<T> anotherBox){
        T temp = this.item;
        this.item = anotherBox.GetValue();
        anotherBox.SetValue(temp);
    }
}