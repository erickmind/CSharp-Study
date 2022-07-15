using System;
using static System.Console;

namespace csharpbook{

    public class OptionalParameters{
        static void Main(string[] args){
            WriteLine(Invoicing(2));
            WriteLine(Invoicing(2, 20));
            WriteLine(Invoicing(2, 20, 10));
            WriteLine(Invoicing(2, bonus:15));
        }

        public static decimal Invoicing(int qnt, decimal price = 10, decimal bonus = 5){
            return qnt*(price + bonus);
        }
    }
}