using GeocodingApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeocodingApplication.Services.GeocodeService
{
    public class GeocodingService : IGeocodingService
    {
        private readonly string _baseUrl;
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public GeocodingService(string baseUrl, string apiKey)
        {
            _baseUrl = baseUrl;
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<Coordinates> FetchCoordinatesAsync(string place)
        {
            string url = $"{_baseUrl}?q={Uri.EscapeDataString(place)}&api_key={_apiKey}";

            var response = await _httpClient.GetStringAsync(url);
            var locationResults = JsonConvert.DeserializeObject<GeocodingResponse>(response);

            if (locationResults != null && locationResults.Results.Count > 0)
            {
                var loc = locationResults.Results[0];
                return new Coordinates(loc.Location.Latitude, loc.Location.Longitude, loc.DisplayName);
            }

            throw new InvalidOperationException("Failed to retrieve location for the given place.");
        }
    }
}
