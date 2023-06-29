using InterfaceExercises.Interfaces;
namespace InterfaceExercises.Models;
public class Employee : IPayable
{
    public double CurrentSalary{get;set;}
    public double IncreaseSalary(double increment){
        return (this.CurrentSalary + increment);
    }
    public double DeductTax(double rate){
        double tax = this.CurrentSalary * (rate / 100);
        double TaxedSalary = CurrentSalary - tax;
        return TaxedSalary * (rate / 100);
    }
    public double PayBonus(double amount){
        return (this.CurrentSalary + amount);
    }
}