using StraniVari.WinUI.Service;
using System.IdentityModel.Tokens.Jwt;

namespace StraniVari.WinUI.Helpers
{
    public static class JWTNameDecoder
    {
        public static string ShowName()
        {
            var stream = ApiService.Token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(stream);

            string firstName = jsonToken.Claims.First(claim => claim.Type == "given_name").Value;
            if (!string.IsNullOrEmpty(firstName))
            {
                firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1);
            }

            return firstName;
        }
    }
}
