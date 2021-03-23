using System;

namespace SpacePark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Rest starwars = new Rest();

            //Söker med swapi, sparar svaret i dynamisk typ
            Console.WriteLine("sök personer:");
            string input = Console.ReadLine();
            var results = starwars.Search(input);
            var ships = starwars.GetShips();

            //Databasen lagras i \bin\debug.. för tillfället
            Database.StoreInDatabase(results);
            Console.ReadLine();
            // NOTE: The Swreponse is a custom class which represents the data returned by the API, RestClient have buildin ORM which maps the data arom the reponse into a given type of object
        }
    }
}