using System.Net.Http;
using System.Threading.Tasks;

namespace AppDotNet
{
    public class SimpleHttpClient : IHttpClient
    {
        private HttpClient client = new HttpClient();

        public async Task<string> Get(string uri, string token)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, uri);
            message.Headers.Add("Authorization", "Bearer " + token);

            var result = await client.SendAsync(message);
            return await result.Content.ReadAsStringAsync();
        }
    }
}