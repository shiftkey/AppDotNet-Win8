using System.Threading.Tasks;

namespace AppDotNet.Tests
{
    public class AuthenticatorProxyWithResult : IAuthenticatorProxy
    {
        private readonly string result;

        public AuthenticatorProxyWithResult(string result)
        {
            this.result = result;
        }

        public Task<AuthenticationResult> Authenticate(string url)
        {
            return Task.FromResult(new AuthenticationResult(result));
        }
    }
}