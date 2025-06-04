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


        [Fact]
        public void CountDivisors_Return3_For4()
        {
            var service = new DivisorService();
            var result = service.CountDivisors(4);
            Assert.Equal(3, result);
        }
    }
}