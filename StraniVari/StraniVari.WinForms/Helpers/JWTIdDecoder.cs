using StraniVari.WinUI.Service;
using System.IdentityModel.Tokens.Jwt;

namespace StraniVari.WinUI.Helpers
{
    public class JWTIdDecoder
    {
        public static string ShowId()
        {
            var stream = ApiService.Token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(stream);
            var userId = jsonToken.Claims.First(claim => claim.Type == "nameid").Value;
            return userId;
        }
    }
}
