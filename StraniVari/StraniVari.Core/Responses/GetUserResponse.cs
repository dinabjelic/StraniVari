﻿
namespace StraniVari.Core.Responses
{
    public class GetUserResponse
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
