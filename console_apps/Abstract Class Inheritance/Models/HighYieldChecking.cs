public class HighYieldCheckingAccount : BankAccount{
    public override double ApplyInterestRate(double interestRate)
    {   
        this.Balance += this.Balance * interestRate;
        throw this.Balance;
    }
}