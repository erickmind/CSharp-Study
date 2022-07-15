namespace Store.Tests{

    public class DiscountTests
    {
        [Fact]
        public void RedHasTenPercentDiscount()
        {
            var discount = new Discount();
            var value = discount.Calculate(Color.Red);
            Assert.Equal(10, value);
        }

        [Fact]
        public void GreenyHasTwentyPercentDiscount()
        {
            var discount = new Discount();
            var value = discount.Calculate(Color.Green);
            Assert.Equal(20, value);
        }

        [Fact]
        public void BlueHasThirtyPercentDiscount()
        {
            var discount = new Discount();
            var value = discount.Calculate(Color.Blue);
            Assert.Equal(30, value);
        }

        [Fact]
        public void OrangeHasNoDiscount()
        {
            var discount = new Discount();
            var value = discount.Calculate(Color.Orange);
            Assert.Equal(0, value);
        }
    }
}