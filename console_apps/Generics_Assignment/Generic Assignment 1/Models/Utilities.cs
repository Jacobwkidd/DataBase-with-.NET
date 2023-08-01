public class Utilities{
    public T Max<T>(T value1, T value2) where T : IComparable<T>{
		// TODO: implement.
        if(value1.CompareTo(value2) >= 0){
            return value1;
        } // ask why do I need a >= 0
        else{
            return value2;
        }
    }

}