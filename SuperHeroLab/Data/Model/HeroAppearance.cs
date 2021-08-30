using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroLab.Data.Model
{
    public class HeroAppearance
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }
    }
}
