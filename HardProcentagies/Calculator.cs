using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace HardProcentagies
{
    public class Calculator
    {
        public static (double, double, double) CountPercentage(double rate, double money,  int periodMonth)
        {
            double totalMoney = money * Math.Pow((1 + (rate / 1200)), periodMonth);
            double income = totalMoney - money;
            double incomePercentage = income / money * 100;

            return (Math.Round(totalMoney, 2), Math.Round(incomePercentage, 2), Math.Round(income, 2));
        }
    }
}

