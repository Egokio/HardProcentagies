using System;

namespace HardProcentagies
{
    public static class Calculator
    {
        public static bool Validate(double rate, double money, int periodMonth)
        {
            return rate > 0 &&
                   money > 0 &&
                   periodMonth > 0;
        }

        public static (double totalMoney, double incomePercentage, double income)
            CountPercentage(double rate, double money, int periodMonth)
        {
            double totalMoney = money * Math.Pow(1 + (rate / 1200), periodMonth);
            double income = totalMoney - money;
            double incomePercentage = income / money * 100;

            return (
                Math.Round(totalMoney, 2),
                Math.Round(incomePercentage, 2),
                Math.Round(income, 2)
            );
        }
    }
}