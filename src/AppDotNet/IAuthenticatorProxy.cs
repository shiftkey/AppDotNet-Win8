using System;
using System.Threading.Tasks;
using Windows.Security.Authentication.Web;

namespace AppDotNet
{
    public interface IAuthenticatorProxy
    {
        Task<AuthenticationResult> Authenticate(string url);
    }

    public class WebAuthenticationBrokerProxy : IAuthenticatorProxy
    {
        public async Task<AuthenticationResult> Authenticate(string url)
        {
            var result = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, new Uri(url));

            if (result.ResponseStatus == WebAuthenticationStatus.Success)
            {
                return new AuthenticationResult(result.ResponseData);
            }
            
            return null;
        }
    }
}