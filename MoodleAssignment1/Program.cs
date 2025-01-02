namespace MoodleAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countryData = new CountryData();
            var countryFinder = new CountryFinder(countryData.Countries);

            // Get user input
            string countryCode = countryFinder.GetUserInput();

            // Validate the input
            if (string.IsNullOrEmpty(countryCode))
            {
                Console.WriteLine("Invalid input. Please enter a valid country code.");
                return;
            }

            // Find and display the adjacent countries
            countryFinder.FindAndDisplayAdjacentCountries(countryCode);
        }
    }
}