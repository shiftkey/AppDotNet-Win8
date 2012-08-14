using System.Threading.Tasks;

namespace AppDotNet.Tests
{
    public class MockClient : IHttpClient
    {
        private string currentContent;

        public void SetResult(string contents)
        {
            currentContent = contents;
        }

        public Task<string> Get(string uri, string token)
        {
            return Task.FromResult(currentContent);
        }
    }
}
