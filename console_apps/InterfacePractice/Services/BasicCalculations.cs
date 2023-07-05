using InterfacePractice.Interfaces;
namespace InterfacePractice.Services;

public class BasicCalculations : ICalculations{
    public int Add(int param1, int param2){
        return (param1 + param2);
    }
    public int Subtract(int param1, int param2){
        return (param1 - param2);
    }
}