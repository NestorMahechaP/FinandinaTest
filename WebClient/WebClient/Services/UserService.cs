using Microsoft.Extensions.Options;
using System.Text.Json;
using WebClient.Models;

namespace WebClient.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllAsync();
    }
    public class UserService : IUserService
    {
        private readonly ApiUrls _apiUrls;
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient, IOptions<ApiUrls> apiUrls)
        {
            _httpClient = httpClient;
            _apiUrls = apiUrls.Value;
        }
        public async Task<List<UserDto>> GetAllAsync()
        {
            var request = await _httpClient.GetAsync($"{_apiUrls.WebApi}users");
            request.EnsureSuccessStatusCode();
            return JsonSerializer.Deserialize<List<UserDto>>(await request.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
        }
    }
}
