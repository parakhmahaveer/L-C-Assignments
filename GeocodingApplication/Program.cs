using GeocodingApplication.Services.GeocodeService;

namespace GeocodingApplication
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string baseUrl = "https://maps.googleapis.com/maps/api/geocode/json";

            IGeocodingService geocodingService = new GeocodingService(baseUrl);

            Console.Write("Enter place name: "); 
            string place = Console.ReadLine();

            try
            {
                var coordinates = await geocodingService.GetCoordinatesAsync(place);
                Console.WriteLine($"\n{coordinates}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }
    }
}