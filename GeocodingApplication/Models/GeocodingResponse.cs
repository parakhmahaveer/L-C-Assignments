using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeocodingApplication.Models
{
    public class GeocodingResponse
    {
        public List<Result> Results { get; set; }
        public string Status { get; set; }
    }

    public class Result
    {
        public Location Location { get; set; }
    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
