using DivisorCounter.Services;

namespace DivisorCounter.Tests
{
    public class DivisorCounterTest
    {
        [Fact]
        public void CountDivisors_Return1_For1()
        {
            var service = new DivisorService();
            var result = service.CountDivisors(1);
            Assert.Equal(1, result);
        }
    }
}