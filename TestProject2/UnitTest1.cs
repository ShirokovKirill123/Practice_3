using _2_CountWords;

namespace TestProject2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Hello world", 2)]
        [InlineData("  This   is a    test  ", 4)]
        [InlineData("", 0)]
        [InlineData("One-word", 1)]

        public void CountWords_ShouldReturnCorrectWordCount(string input, int expectedCount)
        {
            var a = new CountOfWords();
            int result = a.CountWords(input);
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CountWords_ShouldThrowArgumentNullException_ForNullInput()
        {
            var a = new CountOfWords();
            Assert.Throws<ArgumentNullException>(() => a.CountWords(null));
        }
    }
}