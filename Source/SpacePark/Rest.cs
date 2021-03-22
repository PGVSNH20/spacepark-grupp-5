using RestSharp;
using RestSharp.Serialization.Json;
using System;

namespace SpacePark
{
    public class Rest
    {
        public T Deserialize<T>(IRestResponse response)
        {
            //restsharps serialisering
            var deser = new JsonSerializer();
            var person = deser.Deserialize<T>(response);
            return person;
        }

        public dynamic Search(string input)
        {
            //Söker för innehåll
            var request = $"people/?search={input}";
            var response = StarWarsApiRequest(request);

            //Gör en dynamisk person av json-svaret
            var person = Deserialize<dynamic>(response);
            try
            {
                //json-svaret är i key value pairs
                var results = person["results"][0];
                //Skriv ut från key value
                Console.WriteLine($"Namn: {results["name"]}, Födelseår: {results["birth_year"]}, Hårfärg: {results["hair_color"]}");
                return results;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("sökningen gav inget svar");
            }
        }

        public IRestResponse StarWarsApiRequest(string req)
        {
            var client = new RestClient("https://swapi.dev/api/");
            var request = new RestRequest(req, DataFormat.Json);
            var response = client.Get(request);
            return response;
            //var request = new RestRequest("people/", DataFormat.Json);
        }
    }
}