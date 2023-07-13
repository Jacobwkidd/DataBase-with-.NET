public abstract class CheckingAccount : BankAccount{
    public string Hello(){
        return "Hello World";
    }
    public override double ApplyInterestRate(double interestRate){
        return 10;
    }
}