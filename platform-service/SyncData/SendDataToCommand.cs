using platform_service.Dtos;
using System.Text;
using System.Text.Json;

namespace platform_service.SyncData
{
    public class SendDataToCommand : ISendDataToCommand
    {
        private HttpClient _httpClient;
        private IConfiguration _configuration;

        public SendDataToCommand(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task SendHttpToCommand(PlatformReadDto plat)
        {
            string baseUrl = _configuration.GetSection("CommandServiceUrl").Value;
            string relativeUrl = "/api/c/commands";
            string url = baseUrl + relativeUrl;

            var content = new StringContent(JsonSerializer.Serialize(plat),Encoding.UTF8);

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("--> Sync data successfully");
            }
            else
            {
                Console.WriteLine("--> Sync data failure");
            }

        }
    }
}
