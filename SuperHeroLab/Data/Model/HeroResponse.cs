using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroLab.Data.Model
{
    public class HeroResponse
    {
        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("powerstats")]
        public HeroPowerstats Powerstats { get; set; }

        [JsonProperty("biography")]
        public HeroBiography Biography { get; set; }

        [JsonProperty("appearance")]
        public HeroAppearance Appearance { get; set; }

        [JsonProperty("work")]
        public HeroWork Work{ get; set; }

        [JsonProperty("connections")]
        public HeroConnections Connections { get; set; }

        [JsonProperty("image")]
        public HeroImage Image { get; set; }
    }
}
