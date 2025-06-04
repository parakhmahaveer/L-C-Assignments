namespace DivisorCounter.Tests
{
    public class DivisorCounterTest
    {
        [Fact]
        public void No_Service_Exists_Test()
        {
            // Compilation Error
            var service = new DivisorService();
            var result = service.CountDivisors(1);
            Assert.Equal(1, result);
        }
    }
}