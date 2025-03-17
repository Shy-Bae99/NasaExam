using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NasaExam.Services
{
    public interface INasaService
    {
        Task<NasaImageResponse> GetImageOfTheDay(string date = "");
    }

    public class NasaService : INasaService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "odevGI9hzzQlKBF4VcNy66qwgGPIL6yb7glzaMPN";

        public NasaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NasaImageResponse> GetImageOfTheDay(string date = "")
        {
            string url = $"https://api.nasa.gov/planetary/apod?api_key={ApiKey}";
            if (!string.IsNullOrEmpty(date))
            {
                url += $"&date={date}";
            }

            return await _httpClient.GetFromJsonAsync<NasaImageResponse>(url);
        }
    }

    public class NasaImageResponse
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
    }
}