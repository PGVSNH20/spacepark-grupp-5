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

        public dynamic GetShips()
        {
            IRestResponse request = StarWarsApiRequest("starships/");
            var ship = Deserialize<dynamic>(request);
            List<dynamic> ships = new List<dynamic>();
            try
            {
                int y = new int();
                //json-svaret är i key value pairs
                for (int i = 0; i < 30; i++)
                {
                y++;
                var results = ship["results"][i];
                

                    //Skriv ut från key value
                    Console.WriteLine($"Shipname: {results["name"]}");
                    if (y == 10)
                    {
                        results = results["next"][i];
                        y = 0;
                    }

                ships.Add(results);    
                }

                return ships;
            }
            catch(Exception)
            {
                throw new Exception("Ops, något fel hände");
            }
        }
    }
}