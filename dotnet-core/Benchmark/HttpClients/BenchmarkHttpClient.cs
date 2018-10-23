using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Benchmark.HttpClients
{
    public class BenchmarkHttpClient
    {
        private HttpClient _httpClient;
        public BenchmarkHttpClient(HttpClient httpClient, IConfiguration configuration)
        {
            httpClient.BaseAddress = new Uri(configuration["GoLangApiURI"]);
            //httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            //httpClient.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
            _httpClient = httpClient;
        }

        public Task<string> GetFromGoApi(int id)
        {
            return _httpClient.GetStringAsync("/api/benchmark/" + id);
        }

    }
}