using System;
using System.Net;
using System.Threading.Tasks;
using AppDotNet.Tests.Mocks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AppDotNet.Tests.Tests
{
    [TestClass]
    public class AuthenticatorTests
    {
        Authenticator authenticator = new Authenticator();

        [TestMethod]
        public void CreateUrl_WhenTokenSpecified_GeneratesUrl()
        {
            // arrange
            var clientId = "foo";
            var redirectUri = "uri";
            var expected = string.Format("https://alpha.app.net/oauth/authenticate?client_id={0}&response_type=token&redirect_uri={1}&scope={2}",
                clientId, redirectUri, "s");

            // act
            var url = authenticator.CreateUrl(clientId, redirectUri, new[] { "s" });

            Assert.AreEqual(expected, url);
        }

        [TestMethod]
        public void CreateUrl_WhenClientIdNotSpecified_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => authenticator.CreateUrl("", "uri"));
        }

        [TestMethod]
        public void CreateUrl_WhenRedirectUriNotSpecified_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => authenticator.CreateUrl("foo", ""));
        }

        [TestMethod]
        public void CreateUrl_WhenNoScopeSpecified_ProvidesAllScopes()
        {
            // arrange
            var scopes = WebUtility.UrlEncode(string.Join(" ", Authenticator.AllScopes));
            var clientId = "foo";
            var redirectUri = "uri";
            var expected = string.Format("https://alpha.app.net/oauth/authenticate?client_id={0}&response_type=token&redirect_uri={1}&scope={2}",
                clientId, redirectUri, scopes);

            var url = authenticator.CreateUrl("foo", "uri");
            
            Assert.AreEqual(expected, url);
        }

        [TestMethod]
        public async Task Authenticate_WhereDownstreamResultOccurs_ReturnsSuccess()
        {
            // arrange
            var proxy = new AuthenticatorProxyWithResult("foo");
            authenticator = new Authenticator(proxy);

            // act
            var result = await authenticator.Authenticate("url");

            Assert.IsTrue(result.IsSuccess);
        }

        [TestMethod]
        public async Task Authenticate_WhereDownstreamResultEmpty_ReturnsFalse()
        {
            // arrange
            var proxy = new AuthenticatorProxyWithResult("");
            authenticator = new Authenticator(proxy);

            // act
            var result = await authenticator.Authenticate("url");

            Assert.IsFalse(result.IsSuccess);
        }

        [TestMethod]
        public async Task Authenticate_WhereDownstreamResultOccurs_ReturnsToken()
        {
            // arrange
            var proxy = new AuthenticatorProxyWithResult("foo");
            authenticator = new Authenticator(proxy);

            // act
            var result = await authenticator.Authenticate("url");

            Assert.AreEqual("foo", result.AccessToken);
        }
    }
}
