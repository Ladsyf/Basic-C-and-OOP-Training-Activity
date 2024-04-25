using Oop.Main.Models.Accounts;

namespace Oop.Main.Models;
public class AccountHolder
{
    public AccountHolder(string name, Account account)
    {
        AccountName = name;
        Account = account;
        Loans = [];
    }

    public string AccountName { get; }

    public Account Account { get; }

    public List<Loan> Loans { get; }

    public void DisplayAllLoanDetails()
    {
        foreach (Loan loan in Loans)
        {
            loan.DisplayLoanDetails();
            Console.WriteLine("\n\n");
        }
    }
}
