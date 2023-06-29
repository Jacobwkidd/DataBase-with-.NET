using InterfaceExercises.Interfaces;
namespace InterfaceExercises.Models;
public interface IMovable{
    public int MoveForward(int distance);
    public int MoveBackward(int distance);
    public int TurnAngle(int angle);
    
}