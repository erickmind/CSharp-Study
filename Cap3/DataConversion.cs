using System;
using static System.Console;
using System.Globalization;

namespace csharpbook{
    
    class dataConversion{

        static void Main(string[] args){
            WriteLine("---------- Boxing -----------");
            int value = 10;
            object objValue = value;
            WriteLine($"Int type: {value.GetType()}");
            WriteLine($"Object type: {objValue.GetType()}");

            decimal salary = 123012032.54M;
            object objSalary = salary;
            WriteLine($"Decimal type: {salary.GetType()}");
            WriteLine($"Object type: {objSalary.GetType()}");

            WriteLine("---------- Unboxing -----------");
            object objExample = 10;
            int example = (int)objExample;
            WriteLine($"Object type: {objExample.GetType()}");
            WriteLine($"Converted Int type: {example.GetType()}");

            WriteLine("---------- Parse -----------");
            WriteLine($"{Int16.Parse("100")}");
            WriteLine($"{Int16.Parse("(100)", NumberStyles.AllowParentheses)}");
            WriteLine($"{Int32.Parse("50.000", NumberStyles.AllowThousands)}");
            WriteLine($"Current System Culture: {CultureInfo.CurrentCulture.NativeName}");
            WriteLine($"Current System Currency: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");
            WriteLine($"{int.Parse("R$532000", NumberStyles.AllowCurrencySymbol)}");
            WriteLine($"{int.Parse("-200", NumberStyles.AllowLeadingSign)}");
            WriteLine($"{int.Parse(" 500 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite)}");

            WriteLine("---------- Convert.To -----------");
            decimal stringToDecimal = Convert.ToDecimal("12450,08");
            WriteLine($"{stringToDecimal.GetType()} - {stringToDecimal}");
            string decimalToString = Convert.ToString(2607.20m);
            WriteLine($"{decimalToString.GetType()} - {decimalToString ?? "Text is null"}");
            object? errorTest = null;
            WriteLine($"{errorTest ?? "Text is null"}");
        }
    }
}