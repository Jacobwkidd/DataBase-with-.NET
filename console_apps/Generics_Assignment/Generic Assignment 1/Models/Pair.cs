public class Pair<T, U>{
    public T First;
    public U Second;
    // public Pair(T First, U Second){
    //     this.First = First;
    //     this.Second = Second;
    // }
    
    
    public void SetFirst(T First){
        this.First = First;
    }
    public T GetFirst(){
        return this.First;
    }

    public void SetValueB(U Second){
        this.Second = Second;
    }
    public U GetValueB(U Second){
        return this.Second;
    }

}