using GeocodingApplication.Models;
using Newtonsoft.Json;
using System.Net;
using Xunit;

namespace GeocodingApplication.Tests
{
    public class MapsCoApiTests
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://geocode.maps.co/search";
        private const string ApiKey = "6823271eba8e6870654244jtvfbfd9b"; // Replace with a valid key or use Environment Variable

        public MapsCoApiTests()
        {
            _httpClient = new HttpClient();
        }

        [Theory]
        [InlineData("Berlin")]
        [InlineData("New Delhi")]
        [InlineData("invalidplacenamethatdoesnotexist")]
        public async Task CanUnderstandGeocodeApiResponse(string place)
        {
            // Arrange
            string url = $"{BaseUrl}?q={Uri.EscapeDataString(place)}&api_key={ApiKey}";

            // Act
            var response = await _httpClient.GetAsync(url);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var content = await response.Content.ReadAsStringAsync();

            var apiResponse = JsonConvert.DeserializeObject<GeocodingResponse>(content);

            if (place == "invalidplacenamethatdoesnotexist")
            {
                Assert.Empty(apiResponse.Results);
            }
            else
            {
                Assert.NotEmpty(apiResponse.Results);
                var first = apiResponse.Results[0];
                Assert.True(first.Location.Latitude != 0 && first.Location.Longitude != 0, "Coordinates should be valid");
            }
        }
    }
}
