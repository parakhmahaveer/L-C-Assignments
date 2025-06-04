using DivisorComparer.Logic.Services;

namespace DivisorComparer.Tests
{
    public class DivisorServiceTests

    {
        private readonly DivisorService _service = new();

        [Theory]
        [InlineData(10, 2)] 
        [InlineData(1, 0)]  
        [InlineData(2, 1)]  
        [InlineData(5, 2)]  
        public void CountMatchingDivisorPairs_ValidInput_ReturnsExpected(int input, int expected)
        {
            var result = _service.CountMatchingDivisorPairs(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 1)]   
        [InlineData(6, 4)]   
        [InlineData(10, 4)]  
        [InlineData(16, 5)]  
        public void CountDivisors_ValidInput_ReturnsCorrectCount(int number, int expected)
        {
            var result = _service.CountDivisors(number);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountMatchingDivisorPairs_ZeroInput_ReturnsZero()
        {
            var result = _service.CountMatchingDivisorPairs(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountDivisors_NegativeInput_ReturnsZero()
        {
            var result = _service.CountDivisors(-5);
            Assert.Equal(0, result); 
        }
    }

}