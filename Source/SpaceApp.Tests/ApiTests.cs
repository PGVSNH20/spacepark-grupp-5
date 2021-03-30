using SpacePark;
using System;
using Xunit;

namespace SpaceApp.Tests
{
    public class ApiTests
    {
        Rest starwars = new Rest();

        [Fact]
        public async void ApiReturnsResponse()
        {
            var response = await starwars.StarWarsApiRequestAsync("people/?search=r2");

            Assert.True(response.IsSuccessful);
        }

        [Fact]
        public async void ApiReturnsCorrectResponse()
        {
            var response = await starwars.StarWarsApiRequestAsync("people/?search=r2");
            var person = starwars.Deserialize<dynamic>(response);
            var results = person["results"][0];

            Assert.Equal("R2-D2", results["name"]);
        }
    }

    public class DbTests
    {
        
    }

    public class SearchTests
    {

    }

    public class SelectionTests
    {

    }
}

/*
 
    The user entering his name
    Making a simple request against the Starwars Web API to all persons
    Check the name the user entered against the persons from the API request
    Creating a simple table in the database using Entity Framework
    Store in the database that the user have registered himself
    List in the UI all registrations which have been done so far

 */