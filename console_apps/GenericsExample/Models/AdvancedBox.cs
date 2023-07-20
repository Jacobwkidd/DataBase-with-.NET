public class AdvancedBox<T, U>{
    public T ItemA{get;set;}
    public T ItemB{get;set;}
    public AdvancedBox(T itemA, U itemB){
        this.ItemA = itemA;
        this.ItemB = itemB;
    }

    public U Test(T key){
        return this.ItemB;
    }
}