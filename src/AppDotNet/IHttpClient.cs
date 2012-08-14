using System.Threading.Tasks;

namespace AppDotNet
{
    public interface IHttpClient
    {
        Task<string> Get(string uri, string token);
    }
}