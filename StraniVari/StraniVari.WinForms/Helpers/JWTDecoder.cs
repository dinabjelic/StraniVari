using StraniVari.WinUI.Service;
using System.IdentityModel.Tokens.Jwt;

namespace StraniVari.WinUI.Helpers
{
    public static class JWTDecoder
    {
        public static void ShowUsername(Label lblName)
        {
            if (ApiService.Token != null)
            {
                var stream = ApiService.Token;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(stream);

                string username = jsonToken.Claims.First(claim => claim.Type == "unique_name").Value;
                if (!string.IsNullOrEmpty(username))
                {
                    username = username.Substring(0, 1).ToLower() + username.Substring(1);
                    lblName.Text = username;
                }
            }
        }
    }
}
