namespace Assignment3.CalculatorClasses
{
    internal class SavingsCalculator
    {
        private double initialDeposit;
        private double monthlyDeposit;
        private int period;
        private double growthRate;
        private double fees;
        private double totalInterest;
        private double totalFees;

        public void SetInitialDeposit(double deposit)
        {
            initialDeposit = deposit;
        }

        public void SetMonthlyDeposit(double deposit)
        {
            monthlyDeposit = deposit;
        }

        public void SetPeriod(int periodInYears)
        {
            period = periodInYears * 12; // convert years to months
        }

        public void SetGrowthRate(double rate)
        {
            growthRate = rate / 100.0 / 12; // convert annual rate to monthly rate
        }

        public void SetFees(double feeRate)
        {
            fees = feeRate / 100.0 / 12; // convert annual fee rate to monthly fee rate
        }

        public double GetTotalInterest()
        {
            return totalInterest;
        }

        public double GetTotalFees()
        {
            return totalFees;
        }

        public double PerformCalculation()
        {
            return CalculateFutureValue();
        }

        public double GetTotalAmountPaid()
        {
            return initialDeposit + (period * monthlyDeposit);
        }

        private double CalculateFutureValue()
        {
            double balance = initialDeposit;
            totalInterest = 0;
            totalFees = 0;

            for (int month = 1; month <= period; month++)
            {
                double interest = CalculateInterest(balance);
                double fee = CalculateFees(balance);
                balance = UpdateBalance(balance, interest, fee);
            }

            return balance;
        }

        private double CalculateInterest(double balance)
        {
            double interest = growthRate * balance;
            totalInterest += interest;
            return interest;
        }

        private double CalculateFees(double balance)
        {
            double fee = fees * balance;
            totalFees += fee;
            return fee;
        }

        private double UpdateBalance(double balance, double interest, double fee)
        {
            return balance + interest - fee + monthlyDeposit;
        }
    }
}