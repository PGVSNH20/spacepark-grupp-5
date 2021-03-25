using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;

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
                //Console.WriteLine($"Namn: {results["name"]}, Födelseår: {results["birth_year"]}, Hårfärg: {results["hair_color"]}");
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

        public List<dynamic> GetShips()
        {
            List<dynamic> pageships = new List<dynamic>();
            List<dynamic> ships = new List<dynamic>();

            try
            {
                for (var i = 1; i < 5; i++)
                {
                    var pageresponse = GetPageNumber(i);
                    var pageship = Deserialize<dynamic>(pageresponse);
                    pageships.Add(pageship);
                }

                foreach (var ship in pageships)
                {
                    for (var i = 0; i < ship["results"].Count; i++ )
                    {
                        var results = ship["results"][i];
                        ships.Add(results);
                        if (results != null) Console.WriteLine($"Shipname: {results["name"]} kostar {results["cost_in_credits"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, något fel hände", ex);
            }
            return ships;
        }
        public IRestResponse GetPageNumber(int pagenumber)
        {
            //"next": "http://swapi.dev/api/starships/?page=2"
            IRestResponse response = StarWarsApiRequest($"starships/?page={pagenumber}");
            return response;
        }
    }
}