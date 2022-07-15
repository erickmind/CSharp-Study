using System;

namespace Store{

    public class Discount
    {
        public object Calculate(Color color) => color switch{
            Color.Red => 10,
            Color.Green => 20,
            Color.Blue => 30,
            _ => 0
        };
    }
}