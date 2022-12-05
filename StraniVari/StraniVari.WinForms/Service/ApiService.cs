using Flurl.Http;
using System.Threading.Tasks;

namespace StraniVari.WinUI.Service
{
    public class ApiService
    {
        private string _route = null;
        public static string Token { get; set; }
        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>()
        {
            var result = await $"{Properties.Settings.Default.APIUrl}/{_route}"
                .WithOAuthBearerToken(Token)
                .GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Login<T>(object request)
        {
            var result = await $"{Properties.Settings.Default.APIUrl}/{_route}"
                .PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
