namespace Oop.Main.Models.Accounts
{
    public class CheckingAccount : Account, ICheckingAccount
    {
        public void Deposit(string checkNumber, decimal amount)
        {
            Deposit(amount);
            Console.WriteLine($"Check Number {checkNumber}");
        }
    }
}
