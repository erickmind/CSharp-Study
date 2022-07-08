using System;
using static System.Console;

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
            

        }
    }
}