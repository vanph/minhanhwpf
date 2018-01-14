using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallApi.ExternalModels;
using Newtonsoft.Json;
using RestSharp;

namespace CallApi.Services
{
    public class LocationService
    {
        private readonly string _stateServiceUrl = "http://services.groupkt.com/state/get/USA/all";

        public StateResult SearchState()
        {
            var client = new RestClient(_stateServiceUrl);
            var request = new RestRequest(Method.GET);

            // execute the request
            var response = client.Execute(request);
            var content = response.Content; // raw content as string

            //Deserialize json result to object
            var result = JsonConvert.DeserializeObject<StateResult>(content);

            return result;
        }
    }
}
