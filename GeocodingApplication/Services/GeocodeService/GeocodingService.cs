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

        public GeocodingService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<Coordinates> GetCoordinatesAsync(string place)
        {
            using var httpClient = new HttpClient();
            string url = $"{_baseUrl}?address={Uri.EscapeDataString(place)}";

            var response = await httpClient.GetStringAsync(url);
            var geocodingResponse = JsonConvert.DeserializeObject<GeocodingResponse>(response);

            if (geocodingResponse?.Status == "OK")
            {
                var location = geocodingResponse.Results[0].Geometry.Location;
                return new Coordinates(location.Lat, location.Lng);
            }

            throw new InvalidOperationException($"Failed to get coordinates: {geocodingResponse?.Status}");

        }
    }
}
