using Oop.Main.Models;
using Oop.Main.Models.Accounts;
using Oop.Main.Models.Loans;

namespace Oop.Main;

internal class Program
{
    static void Main(string[] args)
    {
        var accountHolder = new AccountHolder("Juan Dela Cruz", new CheckingAccount());

        var newCarLoan = new CarLoan(100000, 3, "Toyota Fortuner");

        accountHolder.Loans.Add(newCarLoan);

        var newPersonalLoan = new PersonalLoan(10000, 1, "Renovation");

        accountHolder.Loans.Add(newPersonalLoan);

        accountHolder.DisplayAllLoanDetails();
    }
}
