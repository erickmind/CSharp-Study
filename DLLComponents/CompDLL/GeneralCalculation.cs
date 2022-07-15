using System;

namespace CompDLL{
    public class GeneralCalculation
    {
        public int value { get; set; }
        public int days { get; set; }
        
        public int? AverageIncome() => value/days;
    }

    public class GeneralDiscount {
        public enum Colors{
            red = 1,
            yellow = 2,
            green = 3 
        } 
        
        public static double DiscountByColor (double value, Colors color) =>
            color switch {
                Colors.red => value*0.9,
                Colors.yellow => value*0.8,
                Colors.green => value*0.7,
                _ => value,
            };
    }
}
