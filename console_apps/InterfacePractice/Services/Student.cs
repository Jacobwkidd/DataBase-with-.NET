using InterfacePractice.Interfaces;
namespace InterfacePractice.Services;
public class Student : IPrintable{
    public string Name{get; set;}
    public int Age{get; set;}
    public string Major{get; set;}
    public string PrintDetails(){
        return @$"Student: {Name}
Age: {Age}
Major: {Major}";
    }
}