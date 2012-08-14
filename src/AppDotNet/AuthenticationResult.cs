namespace AppDotNet
{
    public class AuthenticationResult
    {
        public AuthenticationResult(string accessToken)
        {
            AccessToken = accessToken;
        }

        public bool IsSuccess
        {
            get { return !string.IsNullOrWhiteSpace(AccessToken); }
        }

        public string AccessToken { get; set; }
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorUri { get; set; }
    }
}