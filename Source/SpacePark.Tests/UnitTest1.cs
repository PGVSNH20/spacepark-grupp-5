using System.Linq;
using Xunit;



namespace SpacePark.Tests
{
    public class API_Tests
    {

        /* Rest rest = new();

         [Fact]
         public void API_Returns_Response()
         {
             var response = rest.StarWarsApiRequest("people/?search=r2");
             Assert.True(response.IsSuccessful);
         }

         [Fact]
         public void API_Returns_Correct_Response()
         {
             var response = rest.StarWarsApiRequest("people/?search=r2");
             var person = rest.Deserialize<dynamic>(response);
             var results = person["results"][0];

             Assert.Equal("R2-D2", results["name"]);
         }
     }

     public class Database_Tests
     {
         SpaceParkContext db = new();

         [Fact]
         public void Can_Save_To_Database_With_API_Input()
         {
             Database.InputCreationTestWithApi();

             //query
             var parkEvents = db.ParkEvent.Where(person => person.LastName == "Skywalker");

             //test
             foreach (var person in parkEvents)
             {
                 Assert.Equal("Skywalker", person.LastName);
                 db.Remove(person);
                 db.SaveChanges();
             }
         }*/
    }
}