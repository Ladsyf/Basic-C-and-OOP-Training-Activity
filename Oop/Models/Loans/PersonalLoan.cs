namespace Oop.Main.Models.Loans
{
    public class PersonalLoan : Loan
    {
        private readonly string _purpose;

        public PersonalLoan(decimal amount, int duration, string purpose) : base(amount, 0.03, duration)
        {
            _purpose = purpose;
        }

        public override string Type => "Personal Loan";

        public override void DisplayLoanDetails()
        {
            Console.WriteLine($"Type of Loan: {Type}");
            Console.WriteLine($"Purpose of Loan: {_purpose}");
            Console.WriteLine($"{Type} Details:");
            Console.WriteLine($"\t Total Loan: {CalculateTotalPayment():n}");
        }
    }
}
