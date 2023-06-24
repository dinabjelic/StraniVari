using StraniVari.WinUI.Service;
using System.IdentityModel.Tokens.Jwt;

namespace StraniVari.WinUI.Helpers
{
    public static class JWTDecoder
    {
        public static void ShowEmail(Label lblName)
        {
            if (ApiService.Token != null)
            {
                var stream = ApiService.Token;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(stream);

                string email = jsonToken.Claims.First(claim => claim.Type == "email").Value;
                if (!string.IsNullOrEmpty(email))
                {
                    email = email.Substring(0, 1).ToLower() + email.Substring(1);
                    lblName.Text = email;
                }
            }
        }
    }
}
