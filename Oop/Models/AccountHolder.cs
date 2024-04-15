using Oop.Main.Models.Accounts;
using Oop.Main.Models.Loans;

namespace Oop.Main.Models
{
    public class AccountHolder
    {
        public AccountHolder(string name, Account account)
        {
            Name = name;
            Account = account;
        }
        public Account Account { get; }
        public string Name { get; }
        public IReadOnlyList<Loan> Loans { get; }
    }
}
