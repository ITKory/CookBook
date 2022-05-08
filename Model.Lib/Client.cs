using Microsoft.Extensions.Configuration;
using Model.Lib.DataModels;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Lib
{
    public class Client
    {
        private RestClient _client;
        private RestRequest _request;
        private string _token;
        public Client()
        {
            _client = new();
            _client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator("token", "Bearer");
            var builder = new ConfigurationBuilder().AddUserSecrets<ApiKey>().Build().Providers.First().TryGet("ApiKey:Token", out var token);
            _token = token;

        }

        public void SendRequest(string uri)
        {
            var test = $"{uri}&apiKey={_token}";
            _request = new RestRequest($"{uri}&apiKey={_token}", Method.Get);
            _request.AddHeader("Content-Type", "aplication/json");
        }

        public async Task<List<T>> GetResponseList<T>()
        {
            var response = await _client.GetAsync(_request);

            var data = JsonConvert.DeserializeObject<List<T>>(response.Content);

            return data;
        }

        public async Task<T> GetResponseSingle<T>()
        {
            var response = await _client.GetAsync(_request);
            T data = JsonConvert.DeserializeObject<T>(response.Content);
            return data;
        }
    }
}
