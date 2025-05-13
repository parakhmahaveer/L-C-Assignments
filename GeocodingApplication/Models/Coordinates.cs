using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeocodingApplication.Models
{
    public class Coordinates
    {
        public double Latitude { get; }
        public double Longitude { get; }
        public string DisplayName { get; }

        public Coordinates(double latitude, double longitude, string displayName)
        {
            Latitude = latitude;
            Longitude = longitude;
            DisplayName = displayName;
        }

        public override string ToString()
        {
            return $"Name: {DisplayName}\nLatitude: {Latitude}\nLongitude: {Longitude}";
        }
    }
}
