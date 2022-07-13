using System;
using System.Linq;


namespace csharpbook{
    public class LinqTests{
        static void Main(string[] args){
            var people = new[]
            {
                "Erick",
                "Maria",
                "Joao",
                "Ana",
                "Claudio",
                "Erick K",
                "Erick N"

            };
            var filteredPeople = people.Where(x => x.Contains("Erick"));
            foreach(string person in filteredPeople){
                Console.WriteLine(person);
            }

            var numbers = new[] {1, 2, 3, 4, 5};
            var countTotal = numbers.Count();
            var countPartial = numbers.Count(x => x>3);
            Console.WriteLine(countTotal);
            Console.WriteLine(countPartial);

            var sumTotal = numbers.Sum();
            // Override Method
            var tripleSum = numbers.Sum(x => x * 3);
            Console.WriteLine(sumTotal);
            Console.WriteLine(tripleSum);

            var maxNum = numbers.Max();
            // Override Method
            var maxNumDoubled = numbers.Max(x => x * 2);
            Console.WriteLine(maxNum);
            Console.WriteLine(maxNumDoubled);


        }
    }
}