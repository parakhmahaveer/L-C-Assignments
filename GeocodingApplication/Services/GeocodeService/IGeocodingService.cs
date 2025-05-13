using GeocodingApplication.Models;

namespace GeocodingApplication.Services.GeocodeService
{
    public interface IGeocodingService
    {
        Task<Coordinates> FetchCoordinatesAsync(string place);
    }
}
