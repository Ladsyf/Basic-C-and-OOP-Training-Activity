namespace Oop.Main.Models.Loans
{
    public class CarLoan : Loan
    {
        private readonly string _carModel;

        public CarLoan(decimal amount, int duration, string carModel) : base(amount, 0.05, duration)
        {
            _carModel = carModel;
        }

        public override string Type => "Car Loan";

        public override void DisplayLoanDetails()
        {
            Console.WriteLine($"Type of Loan: {Type}");
            Console.WriteLine($"{Type} Details:");
            Console.WriteLine($"\t Car Model: {_carModel}");
            Console.WriteLine($"\t Total Loan: {CalculateTotalPayment():n}");
        }
    }
}
