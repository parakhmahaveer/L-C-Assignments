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

        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}\nLongitude: {Longitude}";
        }
    }
}
