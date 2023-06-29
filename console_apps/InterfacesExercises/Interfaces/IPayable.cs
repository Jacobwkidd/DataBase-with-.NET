using InterfaceExercises.Interfaces;
namespace InterfaceExercises.Models;
public interface IPayable{
    public double IncreaseSalary(double increment);
    public double DeductTax(double rate);
    public double PayBonus(double amount);
    
}