namespace AppDotNet.Tests
{
    public class AuthenticatorProxyWithResult : IAuthenticatorProxy
    {
        private readonly string result;

        public AuthenticatorProxyWithResult(string result)
        {
            this.result = result;
        }

        public AuthenticationResult Authenticate(string url)
        {
            return new AuthenticationResult(result);
        }
    }
}