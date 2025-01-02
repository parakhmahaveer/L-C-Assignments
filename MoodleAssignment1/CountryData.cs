using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment1
{
    public class CountryData
    {
        public Dictionary<string, Country> Countries { get; private set; }

        public CountryData()
        {
            Countries = new Dictionary<string, Country>();

            InitializeCountryData();
        }

        // Initialize with some data
        private void InitializeCountryData()
        {
            var india = new Country("IN");
            india.AddAdjacentCountry("Pakistan");
            india.AddAdjacentCountry("China");
            india.AddAdjacentCountry("Nepal");
            india.AddAdjacentCountry("Bangladesh");
            india.AddAdjacentCountry("Sri Lanka");
            india.AddAdjacentCountry("Bhutan");

            var us = new Country("US");
            us.AddAdjacentCountry("Canada");
            us.AddAdjacentCountry("Mexico");

            var newZealand = new Country("NZ");
            newZealand.AddAdjacentCountry("Australia");

            var canada = new Country("CA");
            canada.AddAdjacentCountry("US");

            var mexico = new Country("MX");
            mexico.AddAdjacentCountry("US");
            mexico.AddAdjacentCountry("Guatemala");
            mexico.AddAdjacentCountry("Belize");

            var australia = new Country("AU");
            australia.AddAdjacentCountry("New Zealand");

            // Adding all countries to dictionary for mapping data
            _countries.Add("IN", india);
            _countries.Add("US", us);
            _countries.Add("NZ", newZealand);
            _countries.Add("CA", canada);
            _countries.Add("MX", mexico);
            _countries.Add("AU", australia);
        }
    }
}
