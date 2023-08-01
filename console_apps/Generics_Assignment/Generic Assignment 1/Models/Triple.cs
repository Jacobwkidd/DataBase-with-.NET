public class Triple<T, U, V>{
    public T First;
    public U Second;
    public V Third;
    public void SetValeuA(T First){
        this.First = First;
    }
    public T GetValueA(){
        return this.First;
    }
    public void SetValueB(U Second){
        this.Second = Second;
    }
    public U GetValueB(){
        return this.Second;
    }
    public void SetValueC(V Third){
        this.Third = Third;
    }
    public V GetValueC(){
        return this.Third;
    }
}