using Flurl.Http;
using System.Threading.Tasks;

namespace StraniVari.WinUI.Service
{
    public class ApiService
    {
        private string _route= null;
        public static string Token { get; set; }
        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<T> GetRoute<T>()
        {
            var result = await $"{ Properties.Settings.Default.APIUrl }/{ _route}"
                .WithOAuthBearerToken(Token)
                .GetJsonAsync<T>();

            return result;
        }

        //public async Task PostRoute<T>()
        //{
        //    var result = await $"{ Properties.Settings.Default.APIUrl }/{ _route}".PostAsync();

        //    return result;
        //}
    }
}
