using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI.Models
{
    class SearchResult<T>//using a generic
    {
        [JsonProperty ("count")]
        public int Count { get; set; }
        [JsonProperty ("results")]
        public List<T> Results { get; set; }
    }
}
