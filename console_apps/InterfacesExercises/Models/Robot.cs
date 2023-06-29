using InterfaceExercises.Interfaces;
namespace InterfaceExercises.Models;
public class Robot : IMovable
{
    public int Position{get;set;}
    public int Direction{get;set;}

       public int MoveForward(int distance)
    {
        return (this.Position += distance);
    }
    public int MoveBackward(int distance)
    {
        return (this.Position -= distance);
    }

    public int TurnAngle(int angle)
    {
        return (this.Direction = (this.Direction + angle) % 360);
    }
}