using InterfacePractice.Interfaces;
namespace InterfacePractice.Services;

public class Rectangle : IMeasurable{

    public double Length{get; set;}
    public double Width{get; set;}
     public Rectangle(double length, double width){
        this.Length = length;
        this.Width = width;
    }
    public double CalculateArea(){
        return (this.Length * this.Width);
    }
    public double CalculatePerimeter(){
        return (2 * (this.Length + this.Width));
    }
}