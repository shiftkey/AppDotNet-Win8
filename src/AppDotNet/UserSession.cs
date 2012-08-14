using System;
using System.Reactive.Threading.Tasks;
using AppDotNet.Entities;
using Newtonsoft.Json;

namespace AppDotNet
{
    public class UserSession : IUserSession
    {
        private readonly string token;
        private readonly IHttpClient client;

        public UserSession(string token) 
            : this(token, new SimpleHttpClient())
        {
            
        }

        public UserSession(string token, IHttpClient client)
        {
            this.token = token;
            this.client = client;
        }

        public IObservable<User> GetUser(string name)
        {
            var uri = string.Format("https://alpha-api.app.net/stream/0/users/{0}", name);
            return client.Get(uri, token)
                         .ContinueWith(t => JsonConvert.DeserializeObject<User>(t.Result))
                         .ToObservable();
        }
    }
}
