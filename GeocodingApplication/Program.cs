using GeocodingApplication.Services.GeocodeService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeocodingApplication
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var baseUrl = configuration["BaseUrl"];
            var apiKey = configuration["ApiKey"];

            var geocodingService = new GeocodingService(baseUrl, apiKey);

            Console.Write("Enter place name: ");
            var place = Console.ReadLine();

            try
            {
                var coordinates = await geocodingService.FetchCoordinatesAsync(place);
                Console.WriteLine($"\n{coordinates}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }
    }
}