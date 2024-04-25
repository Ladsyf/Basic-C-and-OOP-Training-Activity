namespace Oop.Main.Models.Loans
{
    public class HousingLoan : Loan
    {
        public override string Type => "Housing Loan";

        public HousingLoan(decimal amount, int duration) : base(amount, 0.07, duration)
        {
        }
    }
}
