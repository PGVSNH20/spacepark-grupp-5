using RestSharp;
using RestSharp.Serialization.Json;
using System.Threading.Tasks;
using DataFormat = RestSharp.DataFormat;

namespace SpaceAppWPF
{
    public class StarWarsApi
    {
        public static T Deserialize<T>(IRestResponse response)
        {
            //restsharps serialisering
            var deser = new JsonSerializer();
            var person = deser.Deserialize<T>(response);
            return person;
        }

        public static async Task<dynamic> SearchAsync(string input)
        {
            //Söker för innehåll
            var request = $"people/?search={input}";
            var response = await StarWarsApiRequestAsync(request);

            //Gör en dynamisk person av json-svaret
            var person = Deserialize<dynamic>(response);
            return person;
        }

        public static async Task<IRestResponse> StarWarsApiRequestAsync(string req)
        {
            var client = new RestClient("https://swapi.dev/api/");
            var request = new RestRequest(req, DataFormat.Json);
            var response = await client.ExecuteAsync<dynamic>(request);
            return response;
            //var request = new RestRequest("people/", DataFormat.Json);
        }
    }
}