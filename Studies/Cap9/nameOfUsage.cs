using System;
using static System.Console;

namespace csharpbook{
    public class NameOfUsage{
        static void Main(string[] args){
            var date = new DateTime(2010, 7, 1);
            Func<int, int> idade = (yearVar) => 
                { 
                    if(yearVar > DateTime.Today.Year) throw new Exception($"Invalid year: {nameof(yearVar)}"); 
                    return DateTime.Today.Year - yearVar; 
                };
            // try{
            //     Console.WriteLine(year.Year);
            //     Console.WriteLine(idade(2030));
            // } catch (Exception e){
            //     Console.WriteLine(e.Message);
            // }
            try{
                WriteLine(fishingAuthorization(date.Month, date.Day));
            } catch (Exception e){
                WriteLine(e.Message);
            }
        }

        public static string fishingAuthorization(int fishingMonth, int fishingDay){
            if(fishingDay < 15){
                throw new Exception($"First half of the month: {nameof(fishingDay)}");
            }else if(fishingMonth >= 5 && fishingMonth <= 8){
                throw new Exception($"Winter Season: {nameof(fishingMonth)}");
            }
            return "Fishing approved";

        }
    }
}