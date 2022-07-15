using System;
using static System.Console;

namespace csharpbook{

    public static class ExtensionMethods{

        static void Main(string[] args){
            DateTime date = new DateTime(2002, 7, 11);
            WriteLine(DateFormat(date, "dd/MMM/yyyy"));
            decimal number = 5.25452m;
            WriteLine(Format(number, ".000")); 
            WriteLine(DateFormat(DateTime.Today, "dddd dd/MMM/yyyy"));
            WriteLine(Format(number, "R$##.00"));
        }

        public static string DateFormat(this DateTime date, string format) => 
            date.ToString(format);
        
        public static string Format(decimal number, string format) =>
            number.ToString(format);
    }

}