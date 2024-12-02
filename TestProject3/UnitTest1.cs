using _3_Calculat0r;

namespace TestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectSum_ForPositiveNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Add(5, 3);
            Assert.Equal(8, result); // 5 + 3 = 8
        }

        [Fact]
        public void Add_ReturnsCorrectSum_ForNegativeNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Add(-5, -3);
            Assert.Equal(-8, result); // -5 + (-3) = -8
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference_ForPositiveNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(5, 3);
            Assert.Equal(2, result); // 5 - 3 = 2
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference_ForNegativeNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(-5, -3);
            Assert.Equal(-2, result); // -5 - (-3) = -2
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct_ForPositiveNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(5, 3);
            Assert.Equal(15, result); // 5 * 3 = 15
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct_ForNegativeNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(-5, -3);
            Assert.Equal(15, result); // -5 * (-3) = 15
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct_WhenOneNumberIsZero()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(5, 0);
            Assert.Equal(0, result); // 5 * 0 = 0
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient_ForPositiveNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(6, 2);
            Assert.Equal(3.0, result); // 6 / 2 = 3.0
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient_ForNegativeNumbers()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(-6, -2);
            Assert.Equal(3.0, result); // -6 / -2 = 3.0
        }

        [Fact]
        public void Divide_ThrowsDivideByZeroException_WhenDividingByZero()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0)); // деление на 0 выбрасывает исключение
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient_WhenDividendIsZero()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(0, 5);
            Assert.Equal(0.0, result); // 0 / 5 = 0.0
        }
    }
}