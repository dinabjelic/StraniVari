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

        private bool HandleError(FlurlHttpException ex)
        {
            if (ex.Call.Response.StatusCode == 401)
            {
                MessageBox.Show("Authentication failed.");
                return true;
            }
            else if (ex.Call.Response.StatusCode == 403)
            {
                MessageBox.Show("You do not have permission to access this resource.");
                return true;
            }
            else if (ex.Call.Response.StatusCode == 500)
            {
                MessageBox.Show("Something went wrong");
                return true;
            }
            return false;
        }

        public async Task<T> Get<T>() where T : class
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
                HandleError(ex);
                return default(T);
            }
        }

        public async Task<T> Get<T>(string url) where T : class
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}/{url}"
                .WithOAuthBearerToken(Token)
                .GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                HandleError(ex);
                return default(T);
            }
        }

        public async Task<T> Login<T>(object request) where T : class
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

        public async Task<T> Insert<T>(object request) where T: class
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
                HandleError(ex);
                return default(T);
            }
        }

        public async Task<T> Update<T>(object request, object id = null) where T : class
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
                HandleError(ex);
                return default(T);
            }
        }

        public async Task<T> GetById<T>(object id) where T : class
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}?id={id}"
                         .WithOAuthBearerToken(Token).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                HandleError(ex);
                return default(T);
            }
        }

        public async Task<T> Delete<T>(int id) where T : class
        {
            try
            {
                var result = await $"{Properties.Settings.Default.APIUrl}/{_route}?id={id}"
                         .WithOAuthBearerToken(Token).DeleteAsync().ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                HandleError(ex);
                return default(T);
            }
        }
    }
}
