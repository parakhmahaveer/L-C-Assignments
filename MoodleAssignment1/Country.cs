using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment1
{
    public class Country
    {
        public string CountryCode { get; set; }
        public List<string> AdjacentCountries { get; set; }

        public Country(string countryCode)
        {
            CountryCode = countryCode;
            AdjacentCountries = new List<string>();
        }

        public void AddAdjacentCountry(string country)
        {
            if (!AdjacentCountries.Contains(country))
            {
                AdjacentCountries.Add(country);
            }
        }
    }
}
