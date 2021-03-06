﻿using KnowYourRoute.Directions.Contracts.Common.Entities;
using Newtonsoft.Json;

namespace KnowYourRoute.Directions.Contracts.Routes.Entities
{
    public class Stop
    {
        [JsonProperty( "name" )]
        public string Name { get; set; }

        [JsonProperty( "location" )]
        public LatLong Location { get; set; }
    }
}
