using System;
using System.Collections.Generic;

namespace csharpbook{

    public class Car{
        public int ID { get; set; }
        public string Model { get; set; }
        public int GasTank { get; set; }
        public double KilometersDriven { get; set; }
        public int Year { get; set; }
        public string Color { get; set; } 
        
        public double Consume() => KilometersDriven/GasTank;

        public string ConsumeString() => GasTank > 0 ? $"{Consume():n2}" : "-----";

        public static List<Car> Get(){
            return new List<Car>
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