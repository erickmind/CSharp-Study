using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace csharpbook{

    public class Dictionary{
        static void Main(string[] args){
            var gender = new Dictionary<string, string>();
            gender.Add("M", "Male");
            gender.Add("F", "Female");
            WriteLine(gender["F"]);

            var cities = new Dictionary<string, string>
            { 
                ["MG"] = "Minas Gerais",
                ["SP"] = "São Paulo",
                ["RJ"] = "Rio de Janeiro",
                ["SC"] = "Santa Catarina"
            };
            WriteLine(cities["MG"]);
            foreach(var city in cities){
                WriteLine($"State: {city.Key} - City: {city.Value} ");
            }

            var countries = new Dictionary<int, string>
            {
                [1] = "Brazil",
                [200] = "United States",
                [2] = "Canada",
                [30] = "New Zealand"
            };

            foreach (var country in countries){
                WriteLine($"{country.Key} Country: {country.Value}");
            }
            
            //Indexing
            string[] text = new string[]
            {
                "My",
                "code",
                "has",
                "worked",
                "sucessfully."
            };

            WriteLine(string.Join(" ", text));
            WriteLine($"Last word: {text[^1]}");
            WriteLine($"First word: {text[^5]}");

            // Slicing
            var textSlice = text[0..3];
            WriteLine(string.Join(" ", textSlice));

            Range interval = 0..3;
            foreach(var p in text[interval]){
                WriteLine($"{p} ");
            }

            var textSlice2 = text[..5];
            WriteLine(string.Join(" ", textSlice2));
            var textSlice3 = text[1..];
            WriteLine(string.Join(" ", textSlice3));
        }
    }
}