using System;
using RestSharp;
using RestSharp.Serialization.Json;

namespace SpacePark
{
    class Program
    {
        static void Main(string[] args)
        {
            Rest rest = new Rest();

            //Söker för innehåll r2
            var R2D2request = "people/?search=r2";
            var searchresponse = rest.StarWarsApiRequest(R2D2request);

            //Skapa en dictionairy av json-svaret
            var person = rest.Deserialize<dynamic>(searchresponse);
            var results = person["results"][0];

            //Skriv ut namn från dictionary, borde vara R2D2
            Console.WriteLine(results["name"]);
            Console.ReadLine();
            
            // Live Share Test
            // NOTE: The Swreponse is a custom class which represents the data returned by the API, RestClient have buildin ORM which maps the data arom the reponse into a given type of object
        }
    }
    public class Rest
    {
        public T Deserialize<T>(IRestResponse response)
        {

            var deser = new JsonSerializer();
            var person = deser.Deserialize<T>(response);
            return person;
        }

        public IRestResponse StarWarsApiRequest(string req)
        {

            var client = new RestClient("https://swapi.dev/api/");
            var request = new RestRequest(req, DataFormat.Json);
            var response = client.Get(request);
            return response;

            //var request = new RestRequest("people/", DataFormat.Json);
            //var response = client.Get(request);
        }
    }
}