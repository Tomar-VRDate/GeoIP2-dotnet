﻿using System.Collections.Generic;
using System;
using MaxMind.GeoIP2.Model;

namespace MaxMind.GeoIP2.Responses
{
    /// <summary>
    /// This class provides a model for the data returned by the GeoIP2 Precision: 
    /// Insights web service end point.
    /// 
    /// The only difference between the City and Insights response classes is
    /// which fields in each record may be populated.
    /// 
    /// <a href="http://dev.maxmind.com/geoip/geoip2/web-services">GeoIP2 Web
    ///      Services</a>
    /// </summary>
    [Obsolete("OmniResponse is deprecated. Please use InsightsResponse instead.")]
    public class OmniResponse : AbstractCityResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OmniResponse() { }

        /// <summary>
        /// Constructor
        /// </summary>
        public OmniResponse(
            City city = null,
            Continent continent = null,
            Country country = null,
            Location location = null,
            Model.MaxMind maxMind = null,
            Postal postal = null,
            Country registeredCountry = null,
            RepresentedCountry representedCountry = null,
            List<Subdivision> subdivisions = null,
            Traits traits = null)
            : base(
                city, continent, country, location, maxMind, postal, registeredCountry, representedCountry, subdivisions, traits)
        {
        }
    }
}