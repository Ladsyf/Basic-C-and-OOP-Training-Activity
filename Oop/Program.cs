using Oop.Main.Models;
using Oop.Main.Models.Accounts;

namespace Oop.Main

{
    public class Program
    {
        static void Main(string[] args)
        {
            var accountHolder = new AccountHolder("Juan Dela Cruz", new CheckingAccount());

            var checkingAccount = (ICheckingAccount) accountHolder.Account;
            
            if(checkingAccount != null)
                checkingAccount.Deposit("asdsad",100000);


            //var account = new Account();

            //account.Deposit(50000);
            //account.Withdraw(20000);

            //Console.WriteLine($"My balance is {account.GetBalance():n}");

            //var loan = new Loan(100000, .05, 12);

            //var loanAmount = loan.CalculateTotalPayment();

            //loan.DisplayLoanDetails();

            //Console.WriteLine($"Total payment should be: {loanAmount:n}");

            Console.Read();
        }
    }
}
