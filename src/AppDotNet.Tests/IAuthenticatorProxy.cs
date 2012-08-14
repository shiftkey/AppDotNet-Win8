namespace AppDotNet.Tests
{
    public interface IAuthenticatorProxy
    {
        AuthenticationResult Authenticate(string url);
    }
}