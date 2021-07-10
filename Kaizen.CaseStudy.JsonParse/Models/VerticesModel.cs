using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kaizen.CaseStudy.JsonParse.Models
{
    public class VerticesModel
    {
        [JsonProperty("vertices")]
        public List<EdgeModel> Edges { get; set; }
    }
}
