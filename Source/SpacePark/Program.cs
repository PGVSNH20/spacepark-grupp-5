using System;
using RestSharp;
using System.Threading.Tasks;
using RestSharp.Authenticators;

namespace SpacePark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new RestClient("https://swapi.dev/api/");
            var request = new RestRequest("people/", DataFormat.Json);
            var response = client.Get(request);

            JsonSerializer json = new JsonSerializer(typeof(Person));
            json.Deserialize(response);

            

            Console.WriteLine();
            
            // Live Share Test
            // NOTE: The Swreponse is a custom class which represents the data returned by the API, RestClient have buildin ORM which maps the data arom the reponse into a given type of object
        }
    }
}