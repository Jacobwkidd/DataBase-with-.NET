public class Comparator{
    public bool Compare<T>(T itemA, T itemB){
        if(itemA.Equals(itemB)){
            return true;
        }
        else{
            return false;
        }
    }
}