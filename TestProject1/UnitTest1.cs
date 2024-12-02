using Practice_3;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void IsEven_ReturnsTrue_ForEvenNumber1()
        {
            var even = new Parity_Check();
            Assert.True(even.IsEven(2)); // четное число
        }

        public void IsEven_ReturnsTrue_ForEvenNumber2()
        {
            var even = new Parity_Check();
            Assert.True(even.IsEven(4)); // четное число
        }

        public void IsEven_ReturnsTrue_ForEvenNumber3()
        {
            var even = new Parity_Check();
            Assert.True(even.IsEven(6)); // четное число
        }

        [Fact]
        public void IsEven_ReturnsFalse_ForNegativeNumber1()
        {
            var odd = new Parity_Check();
            Assert.False(odd.IsEven(-3)); // отрицательное число
        }
        [Fact]
        public void IsEven_ReturnsFalse_ForNegativeNumber2()
        {
            var odd = new Parity_Check();
            Assert.False(odd.IsEven(-5)); // отрицательное число
        }
        public void IsEven_ReturnsFalse_ForNullNumber()
        {
            var odd = new Parity_Check();
            Assert.False(odd.IsEven(0)); // 0
        }
    }
}