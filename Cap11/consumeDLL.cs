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

        }

    }
}