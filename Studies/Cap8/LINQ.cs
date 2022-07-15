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

            var minNum = numbers.Min();
            var minNumPlusThree = numbers.Min(x => x + 3);
            Console.WriteLine(minNum);
            Console.WriteLine(minNumPlusThree);

            decimal[] decimalNumbers = new decimal[] {1, 2, 3, 4, 5};
            var avgNum = numbers.Average();
            var avgDecimal = decimalNumbers.Average();
            Console.WriteLine(avgNum);
            Console.WriteLine(avgNum.GetType());
            Console.WriteLine(avgDecimal.GetType());

            var reversed = numbers.Reverse();
            foreach(int number in reversed){
                Console.WriteLine(number);
            }

            var unorderedNums = new[] {3, 2, 1};
            var orderedNums = unorderedNums.OrderBy(x => x);
            foreach(int number in orderedNums){
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------- Desc ---------------");
            var descOrder = numbers.OrderByDescending(x => x);
            foreach(int number in descOrder){
                Console.WriteLine(number);
            }

            var partitioned = numbers.Take(2);
            foreach(int number in partitioned){
                Console.WriteLine(number);
            }

            var partitionWhile = numbers.TakeWhile(x => x < 4);
            foreach(int number in partitionWhile){
                Console.WriteLine(number);
            }

            var randomNums = new[] {5, 3, 341, 6, 321, 778, 12};
            var first = randomNums.First(x => x > 300 && x < 340);
            Console.WriteLine(first);

            int[] empty = new int[2];
            var emptyDefault = empty.FirstOrDefault();
            var noMatchDefault = numbers.FirstOrDefault(x => x>5);
            Console.WriteLine(emptyDefault);
            Console.WriteLine(noMatchDefault);

            var last = numbers.Last();
            var lastFiltered = randomNums.LastOrDefault(x => x > 300 && x < 400);
            Console.WriteLine(last);
            Console.WriteLine(lastFiltered);

            var skipped = numbers.Skip(2);
            foreach(int number in skipped){
                Console.WriteLine(number);
            }

            var concat = numbers.Concat(randomNums);
            foreach(int number in concat){
                Console.WriteLine(number);
            }

            List<Car> cars = new List<Car> 
            {
                new Car { 
                    ID = 1, 
                    Model = "Honda Civic", 
                    Year = 2010, 
                    KilometersDriven = 30000, 
                    Color = Colors.Green.ToString(),
                    GasTank = 24
                    },
                new Car { 
                    ID = 2, 
                    Model = "Ford Ka", 
                    Year = 2020, 
                    KilometersDriven = 12000, 
                    Color = Colors.Gray.ToString(),
                    GasTank = 31
                    },
                new Car { 
                    ID = 3, 
                    Model = "Ford GT", 
                    Year = 2007, 
                    KilometersDriven = 80000, 
                    Color = Colors.Red.ToString(),
                    GasTank = 40
                    }    
            };

            var element = cars.ElementAt(2);
            Console.WriteLine(element.Model);
            
            try{
                var verifyError = randomNums.SingleOrDefault(x => x>300);
            } catch (InvalidOperationException e){
                Console.WriteLine($"2 elements bigger than 300");
            }
            var verify = randomNums.SingleOrDefault(x => x>500);
            Console.WriteLine(verify);

            var categories = numbers.Select(x => 
                new
                {
                    id = x,
                    description = $"Category {x}"
                }
            );

            foreach(var category in categories){
                Console.WriteLine($"Category: {category.id} - {category.description}");
            }
            
        }
        enum Colors
        {
            Red = 1,
            Green = 2,
            Blue = 3,
            Gray = 4
        }
    }
}