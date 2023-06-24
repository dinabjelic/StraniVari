using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

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
            IPasswordHasher<User> passwordHasher
            )
        {
            _token = token;
            _signInManager = signInManager;
            _userManager = userManager;
            _passwordHasher = passwordHasher;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<GetUserResponse>> Login(RequestLoginDto loginModel)
        {
            var _user = await _userManager.Users.
                SingleOrDefaultAsync(x => x.UserName == loginModel.Username);
            if (_user == null)
            {
                return Unauthorized("Something went wrong, try again!");
            }
            var userRoles = await _userManager.GetRolesAsync(_user);

            var result = await _signInManager
            .CheckPasswordSignInAsync(_user, loginModel.Password, false);


            if (!result.Succeeded) return Unauthorized();

            User user = new User
            {
                Id = _user.Id, 
                FirstName = _user.FirstName, 
                LastName = _user.LastName, 
                Email = _user.Email
            };

            return new GetUserResponse
            {
                Username = _user.UserName,
                Roles = userRoles,
                Token = _token.CreateToken(user, userRoles)
            };
        }
        
        [AllowAnonymous]
        [HttpGet]
        public async Task<string> GetPassword()
        {
            var _user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == "Dina");
            return _passwordHasher.HashPassword(_user, "admin");
        }
    }
}

