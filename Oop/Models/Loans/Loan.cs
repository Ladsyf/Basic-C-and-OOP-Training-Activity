namespace Oop.Main.Models.Loans
{
    public class Loan
    {
        protected decimal _amount;
        protected double _interestRate;
        protected int _duration;
        public Loan() : this(0, 0, 0)
        { }
        public Loan(decimal amount, double interestRate, int duration)
        {
            _amount = amount;
            _interestRate = interestRate;
            _duration = duration;
        }

        public decimal CalculateTotalPayment()
        {
            return _amount * (decimal)Math.Pow(1 + _interestRate, _duration);
        }

        public void DisplayLoanDetails()
        {
            Console.WriteLine("Loan amount: " + _amount);
            Console.WriteLine("Interest rate is " + _interestRate);
            Console.WriteLine("Duration is: " + _duration + "months");
        }

    }
}
