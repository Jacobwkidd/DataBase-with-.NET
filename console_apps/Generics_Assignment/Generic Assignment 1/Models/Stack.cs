public class Stack<T>{
    private List<T> items;

    public Stack(){
        items = new List<T>();
    }

    public void Push(T item){
        items.Add(item);
    }
    public T Pop(){
        int lastIndex = items.Count - 1;
        T lastItem = items[lastIndex];
        items.RemoveAt(lastIndex);
        return lastItem;
    }
    public bool IsEmpty(){
        return items.Count == 0;
    }

}