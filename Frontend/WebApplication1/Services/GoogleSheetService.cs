using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class GoogleSheetService
    {
        private readonly HttpClient _httpClient;

        public GoogleSheetService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> FetchCsvAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
