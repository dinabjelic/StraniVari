using Flurl.Http;

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
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}"
                .WithOAuthBearerToken(Token)
                .GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Authentication failed.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("You do not have permission to access this resource.");
                }
                throw;
            }

        }
        public async Task<T> Login<T>(object request)
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}"
                .PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Authentication failed.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("You do not have permission to access this resource.");
                }
                throw;
            }

        }
        public async Task<T> Insert<T>(object request)
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}"
                 .WithOAuthBearerToken(Token)
                .PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Authentication failed.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("You do not have permission to access this resource.");
                }
                throw;
            }
        }
        public async Task<T> Update<T>(object request, object id = null)
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}?id={id}"
                    .WithOAuthBearerToken(Token)
                    .PutJsonAsync(request).ReceiveJson<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Authentication failed.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("You do not have permission to access this resource.");
                }
                throw;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}?id={id}"
                         .WithOAuthBearerToken(Token).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Authentication failed.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("You do not have permission to access this resource.");
                }
                throw;
            }
        }
        public async Task<T> Delete<T>(int id)
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}?id={id}"
                         .WithOAuthBearerToken(Token).DeleteAsync().ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Authentication failed.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("You do not have permission to access this resource.");
                }
                throw;
            }

        }
    }
}
