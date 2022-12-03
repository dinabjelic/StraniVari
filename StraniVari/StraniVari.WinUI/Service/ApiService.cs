using Flurl.Http;

namespace StraniVari.WinUI.Service
{
    public class ApiService
    {
        private string _route= null;
        public ApiService(string route)
        {
            _route = route;
        }

        public T GetRoute<T>()
        {
            var result = $"{ Properties.Settings.Default.APIUrl }/{ _route}".GetJsonAsync<T>();

            return result.Result;
        }
    }
}
