using GeocodingApplication.Models;

namespace GeocodingApplication.Services.GeocodeService
{
    public interface IGeocodingService
    {
        Task<Coordinates> GetCoordinatesAsync(string place);
    }
}
