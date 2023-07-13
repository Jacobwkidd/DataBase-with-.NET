public abstract class BankAccount{
    public string AccountHolder{get;set;}
    public double Balance{get;set;}
    public double Deposit(double amount){
        this.Balance += amount;
        return this.Balance;
    }
    public double Withdraw(double amount){
        this.Balance -= amount;
        return this.Balance;
    }
    public abstract double ApplyInterestRate(double interestRate);
}