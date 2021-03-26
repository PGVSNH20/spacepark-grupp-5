using RestSharp;
using RestSharp.Serialization.Json;
using SpaceApp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        public async Task<dynamic> SearchAsync(string input)
        {
            //Söker för innehåll
            var request = $"people/?search={input}";
            var response = await StarWarsApiRequestAsync(request);

            //Gör en dynamisk person av json-svaret
            var person = Deserialize<dynamic>(response);
            return person;

        }
        public async Task<IRestResponse> StarWarsApiRequestAsync(string req)
        {
          
            var client = new RestClient("https://swapi.dev/api/");
            var request = new RestRequest(req, DataFormat.Json);
            var response = await client.ExecuteAsync<dynamic>(request);
            return response;
            //var request = new RestRequest("people/", DataFormat.Json);
        }

        //public async Task<List<dynamic>> GetShipsAsync(Form2 form)
        //{            
        //    List<dynamic> ships = new List<dynamic>();

        //    Random rand = new Random();

        //    try
        //    {
        //        var page = rand.Next(1, 5);
        //        var response = await StarWarsApiRequestAsync($"starships/?page={page}");
        //        var ship = Deserialize<dynamic>(response);

        //        //Få ut 3 st random ship åt gången när man klickar på sök-knappen
        //        for (var i = 0; i < 3; i++ )
        //        {
        //            var randomship = rand.Next(1, 10);
        //            var results = ship["results"][randomship];
        //            ships.Add(results);
        //            if (results != null) form.listBox1.Items.Add($"Shipname: {results["name"]} kostar {results["cost_in_credits"]}");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        form.listBox1.Items.Add("Ops, något fel hände");
        //    }
        //    return ships;
        //}
    }
}