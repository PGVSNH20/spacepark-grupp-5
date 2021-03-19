using Xunit;

namespace SpacePark.Tests
{
    public class API_Tests
    {
        Rest rest = new Rest();
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
}
