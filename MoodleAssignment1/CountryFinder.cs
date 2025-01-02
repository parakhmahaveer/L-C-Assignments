using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment1
{
    public class CountryFinder
    {
        private readonly Dictionary<string, Country> _countries;

        public CountryFinder(Dictionary<string, Country> countries)
        {
            _countries = countries;
        }


        public string GetUserInput()
        {
            Console.WriteLine("Enter a Country Code (e.g., IN, US, NZ):");
            return Console.ReadLine()?.ToUpper();  // Read input and ensure it's uppercase
        }

        public List<string> GetAdjacentCountries(string countryCode)
        {
            if (_countries.TryGetValue(countryCode.ToUpper(), out Country country))
            {
                return country.AdjacentCountries;
            }
            return null;
        }

        public void FindAndDisplayAdjacentCountries(string countryCode)
        {
            var adjacentCountries = GetAdjacentCountries(countryCode);

            if (adjacentCountries != null && adjacentCountries.Count > 0)
            {
                Console.WriteLine($"Adjacent countries to {countryCode}:");
                foreach (var country in adjacentCountries)
                {
                    Console.WriteLine(country);
                }
            }
            else
            {
                Console.WriteLine($"No data available for country code: {countryCode}");
            }
        }
    }
}
