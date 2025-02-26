
namespace MoodleAssignment2_Functions
{
    public class MeanCalculator
    {
        public static int[] CalculatePrefixSum(int[] numbers, int length)
        {
            try
            {
                int[] prefixSumArray = new int[length + 1];
                prefixSumArray[0] = 0;
                for (int i = 1; i <= length; i++)
                {
                    prefixSumArray[i] = prefixSumArray[i - 1] + numbers[i - 1];
                }
                return prefixSumArray;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int CalculateRangeAverage(int[] prefixSumArray, int left, int right)
        {
            try
            {
                return (prefixSumArray[right] - prefixSumArray[left - 1]) / (right - left + 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
