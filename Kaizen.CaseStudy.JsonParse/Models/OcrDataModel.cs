using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kaizen.CaseStudy.JsonParse.Models
{
    public class OcrDataModel
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("boundingPoly")]
        public VerticesModel BoundingPoly { get; set; }
    }
}
