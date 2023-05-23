using System;

namespace BMICalculator
{
    internal class SavingsCalculator
    {

        //initialization of varaibles. 
        private double monthlyDeposit;
        private double interestRate = 0.10;
        private double period;
        private double interestEarned;

        /// <summary>
        /// Calculates the final balance value while including the inputs and values from monthly deposits and the period of time(years). The .10% rate is also included here. 
        /// </summary>
        /// <returns>Value of balance which in this case is final balance</returns>
        public double CalculateFutureVal()
        {
            double numOfMonths = period * 12;

            double balance = 0.0; //future value

            //The calculation for future value in a for loop that loops until i value is less or equals to numofmonths which is the the period amount * 12. 
            for (int i = 1; i <= numOfMonths; i++)
            {
                interestEarned = (interestRate / 12) * balance;
                balance += interestEarned + monthlyDeposit;
            }

            return balance;
        }

        #region getters & setters
        public void setMonthlyDeposit(double monthlyDeposit)
        {
            this.monthlyDeposit = monthlyDeposit;
        }

        public double getMonthlyDeposit(double monthlyDeposit)
        {
            return monthlyDeposit;
        }

        public void setInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public double getInterestRate(double interestRate)
        {
            return interestRate;
        }

        public void setPeriod(double period)
        {
            this.period = period;
        }

        public double getPeriod(double period)
        {
            return period;
        }

        #endregion

    }



}
