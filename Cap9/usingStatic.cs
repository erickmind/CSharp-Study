using System;
using static System.Math;
using static System.Console;
using static System.String;

namespace csharpbook{
    public class StaticUsings{
        static void Main(string[] args){
            WriteLine(Sqrt(4));
            WriteLine(Abs(-10));
            WriteLine(Max(10, 54054));
            WriteLine(Round(321904.329389, 2));

            string text = "Test string";
            string concat = Concat(text, " 1");
            WriteLine(text.Length);
            WriteLine(text.Insert(4 ," advanced"));
            WriteLine(concat);
            WriteLine(text.ToUpper());
        }
    }
}