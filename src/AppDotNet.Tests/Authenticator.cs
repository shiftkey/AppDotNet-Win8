using System;
using System.Net;

namespace AppDotNet.Tests
{
    public class Authenticator
    {
        readonly IAuthenticatorProxy authenticatorProxy;
        public static readonly string[] AllScopes = new[] { "stream", "email", "write_post", "follow", "messages", "export" };

        public Authenticator() : this(new AuthenticatorProxyWithResult("foo"))
        {

        }

        public Authenticator(IAuthenticatorProxy authenticatorProxy)
        {
            this.authenticatorProxy = authenticatorProxy;
        }

        public string CreateUrl(string clientId, string redirectUri, string[] scope = null)
        {
            if (string.IsNullOrWhiteSpace(clientId))
                throw new ArgumentException("ClientId must be specified", "clientId");
            if (string.IsNullOrWhiteSpace(redirectUri))
                throw new ArgumentException("Redirect Uri must be specified", "redirectUri");

            if (scope == null)
                scope = AllScopes;
            
            var scopes = WebUtility.UrlEncode(string.Join(" ", scope));
            
            return string.Format("https://alpha.app.net/oauth/authenticate?client_id={0}&response_type=token&redirect_uri={1}&scope={2}",
                                 clientId, redirectUri, scopes);
        }

        public AuthenticationResult Authenticate(string url)
        {
            return authenticatorProxy.Authenticate(url);
        }
    }

    public class AuthenticationResult
    {
        public AuthenticationResult(string accessToken)
        {
            AccessToken = accessToken;
        }

        public bool IsSuccess { get { return !string.IsNullOrWhiteSpace(AccessToken); }}
        public string AccessToken { get; set; }
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorUri { get; set; }
    }
}