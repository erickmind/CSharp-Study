using System;
using static System.Console;

namespace csharpbook{

    public class FuncExample{

        static void Main(string[] args){
            int value = 0;
            Func<int> increment = () => ++value;
            WriteLine(increment());
            WriteLine(increment());
            WriteLine(value);

            string text = "Example string to count words using Delegates";
            Func<string, int> countLetters = (testString) => 
            { 
                return testString.Length; 
            };
            Func<string, int> countWords = (testString) => 
            { 
                return testString.Split(" ").Count(); 
            };
            WriteLine($"Number of Letters: {countLetters(text)}");
            WriteLine($"Number of words: {countWords(text)}");

            Func<decimal, decimal, decimal, decimal> calculateTax = (salary, percentage, aliquot) => 
            {
                return salary <= 1000 ? 0 : salary*(percentage/100)-aliquot;
            };

            WriteLine(calculateTax(1000, 10, 10));
            WriteLine(calculateTax(5000, 27.5m, 80));       
            WriteLine(calculateTax(23500, 32.5M, 180));

            int currentYear = DateTime.Today.Year;
            Func<int, double, double> KmPerYearCalculation = (year, km) =>
                year >= currentYear ? km : km/(currentYear - year);

            var data = Car.Get();

            data.ForEach(x => 
            {
                var kmPerYear = KmPerYearCalculation(x.Year, x.KilometersDriven);
                WriteLine($"{x.Model} | {x.Year} | {x.KilometersDriven:n0} | GasTank:{x.GasTank} | km/year: {kmPerYear:n0}");
            });
        }
    }
}