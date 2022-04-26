using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Syra.Tests
{
		public class HomeControllerTests
    : IClassFixture<WebApplicationFactory<Syra.Startup>>
    {
				private readonly WebApplicationFactory<Syra.Startup> _factory;

				public HomeControllerTests(WebApplicationFactory<Syra.Startup> factory)
        {
            _factory = factory;
        }
				[Theory]
		    	[InlineData("/")]
				[InlineData("/Users/Index")]
				[InlineData("/Users/Create")]
				[InlineData("/Users/Delete/4")]
				[InlineData("/Users/Edit/1")]
				[InlineData("/Users/Details/5")]
				[InlineData("/Resources/Index")]
				[InlineData("/Resources/Create")]
				[InlineData("/Resources/Delete/1050")]
				[InlineData("/Resources/Edit/2042")]
				[InlineData("/Resources/Details/4041")]
		    public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
		    {
		        // Arrange
		        var client = _factory.CreateClient();
		        // Act
		        var response = await client.GetAsync(url);
		        // Assert
		        response.EnsureSuccessStatusCode(); // Status Code 200-299
		        Assert.Equal("text/html; charset=utf-8",
		            response.Content.Headers.ContentType.ToString());
		    }
		}
}