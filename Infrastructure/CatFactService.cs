using Application.Interfaces;
using System.Text.Json;

namespace Infrastructure.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly HttpClient _httpClient;

        public CatFactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetRandomFactAsync()
        {
            var response = await _httpClient.GetAsync("https://catfact.ninja/fact");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var fact = JsonDocument.Parse(json).RootElement.GetProperty("fact").GetString();

            return fact ?? "No fact found.";
        }
    }
}
