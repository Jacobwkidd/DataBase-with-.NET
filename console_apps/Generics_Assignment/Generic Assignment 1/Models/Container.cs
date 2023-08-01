public class Container<T>{
    private List<T> items;
    public Container(){ // if you dont create an constructor, it will be like int = null;
        items = new List<T>(); 
    }
    public void AddItem(T item){
        items.Add(item);
    }
    public bool RemoveItem(T item){
        return items.Remove(item);
    }
    public void PrintItem(){
        foreach(T item in items){
            System.Console.WriteLine($"items {item}");
        }
    }
}