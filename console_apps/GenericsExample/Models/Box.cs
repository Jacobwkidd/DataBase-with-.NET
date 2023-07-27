public class Box<T>{
    private T item;
    
    public T Thing{get;set;}

    public Box(T item){
        this.item = item;
    }
    public Box(T item, T thing){
        this.item = item;
        this.Thing = thing;
    }

    public T GetItem(){
        return this.item;
    }
      public T SetItem(T item){
        return this.item = item;
    }

    public string DisplayType(){
        return "Item is of type: " + typeof(T);
    }
}