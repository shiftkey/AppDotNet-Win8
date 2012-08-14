using System.Reactive.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AppDotNet.Tests
{
    [TestClass]
    public class UserSessionTests
    {
        readonly MockClient client;
        readonly UserSession session;

        public UserSessionTests()
        {
            client = new MockClient();
            session = new UserSession("token", client);
        }
        
        [TestMethod]
        public async Task GetUser_WithMockResponse_MapsToUser()
        {
            // arrange
            client.SetResult(await Json.FromFile("data\\test_user.txt"));
        
            // act 
            var user = await session.GetUser("something");

            Assert.AreEqual("Mark Thurman", user.Name);
        }
    }
}

