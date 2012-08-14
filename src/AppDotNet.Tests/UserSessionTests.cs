using System.Reactive.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AppDotNet.Tests
{
    [TestClass]
    public class UserSessionTests
    {
        [TestMethod]
        public async Task GetUser_WithMockResponse_MapsToUser()
        {
            // arrange
            var client = new MockClient();
            client.SetResult(await Json.FromFile("data\\test_user.txt"));
            var session = new UserSession("token", client);

            // act 
            var user = await session.GetUser("something");

            Assert.AreEqual("Mark Thurman", user.name);
        }
    }
}

