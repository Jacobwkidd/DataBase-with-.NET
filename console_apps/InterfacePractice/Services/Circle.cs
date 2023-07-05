using InterfacePractice.Interfaces;
namespace InterfacePractice.Services;

public class Circle : IMeasurable{
    public double Radius{get; set;}
    public Circle(double radius){
        this.Radius = radius;
    }
    public double CalculateArea(){
        return (3.14 * this.Radius * this.Radius);
    }

    public double CalculatePerimeter(){
        return (2 * 3.14 * this.Radius);
    }
}