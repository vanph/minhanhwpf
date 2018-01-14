using System.Collections.Generic;
using Newtonsoft.Json;

namespace CallApi.ExternalModels
{
    public class StateResult
    {
        [JsonProperty("RestResponse")]
        public RestResponse RestResponse { get; set; }
    }

    public class RestResponse
    {

        [JsonProperty("messages")]
        public IList<string> Messages { get; set; }

        [JsonProperty("result")]
        public IList<ResultItem> ResultItems { get; set; }
    }
    
    public class ResultItem
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("area")]
        public string Area { get; set; }

        [JsonProperty("largest_city")]
        public string LargestCity { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }
    }


}
