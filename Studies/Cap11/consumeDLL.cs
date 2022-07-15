using static System.Console;
using System;
using CompDLL;

namespace csharpbook{

    public class ConsumeDLL{
        static void Main(string[] args){
            int incomeVal = 10000;
            int incomeDays = 50;
            GeneralCalculation incomeObj = new GeneralCalculation() { value = incomeVal, days = incomeDays };
            WriteLine($"Income:{incomeObj.value}, Days:{incomeObj.days}, Average:{incomeObj.AverageIncome()}");
            int insuranceValue = 10000;
            var greenColor = GeneralDiscount.Colors.green;
            var redColor = GeneralDiscount.Colors.red;
            var yellowColor = GeneralDiscount.Colors.yellow;
            WriteLine("---------- DISCOUNT BY COLORS ------------");
            WriteLine($"Insurance value: R${insuranceValue}");
            WriteLine($"Red Value: R${GeneralDiscount.DiscountByColor(insuranceValue, redColor):n0}");
            WriteLine($"Yellow Value: R${GeneralDiscount.DiscountByColor(insuranceValue, yellowColor):n0}");
            WriteLine($"Green Value: R${GeneralDiscount.DiscountByColor(insuranceValue, greenColor):n0}");      
        }
    }
}