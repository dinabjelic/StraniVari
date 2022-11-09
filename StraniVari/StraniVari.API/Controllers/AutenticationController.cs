using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;
using System.Threading.Tasks;

namespace StraniVari.API.Controllers
{
    public class AutenticationController : BaseApiController
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenService _token;
        IPasswordHasher<User> _passwordHasher;

        public AutenticationController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            ITokenService token,
            IPasswordHasher<User> passwordHasher)
        {
            _token = token;
            _signInManager = signInManager;
            _userManager = userManager;
            _passwordHasher = passwordHasher;
        }


        [HttpPost("login")]
        public async Task<ActionResult<GetUserRequest>> Login(RequestLoginDto loginModel)
        {

            var _user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == loginModel.Username);
            if (_user == null)
            {
                return Unauthorized("Something went wrong, try again!");
            }

            var result = await _signInManager
            .CheckPasswordSignInAsync(_user, loginModel.Password, false);


            if (!result.Succeeded) return Unauthorized();

            User user = new User
            {
                Id = _user.Id
            };

            return new GetUserRequest
            {
                Username = _user.UserName,
                Token = _token.CreateToken(user)
            };
        }

        [HttpGet]
        public async Task<string> GetPassword()
        {
            var _user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == "Dina");
            return _passwordHasher.HashPassword(_user, "test");
        }
    }
}

