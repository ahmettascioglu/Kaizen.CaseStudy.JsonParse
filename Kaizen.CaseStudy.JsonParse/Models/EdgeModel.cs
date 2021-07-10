using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kaizen.CaseStudy.JsonParse.Models
{
    public class EdgeModel
    {
        [JsonProperty("x")]
        public int CoordinateX { get; set; }
        [JsonProperty("y")]
        public int CoordinateY { get; set; }
    }
}
