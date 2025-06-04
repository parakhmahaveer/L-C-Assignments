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

        [Fact]
        public void CountMatchingPairs_Returns2_For4()
        {
            var service = new DivisorService();
            var analyzer = new DivisorAnalyzer(service); 
            var result = analyzer.CountMatchingDivisorPairs(4);
            Assert.Equal(2, result);
        }

        [Fact]
        public void CountMatchingPairs_ReturnsZero_ForLargeNegative()
        {
            var processor = new DivisorAnalyzer(new DivisorService());
            int result = processor.CountMatchingDivisorPairs(-1000000);
            Assert.Equal(0, result);
        }
    }
}