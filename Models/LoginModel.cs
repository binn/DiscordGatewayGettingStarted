using System;
using Newtonsoft.Json;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Discord.Models
{
    // response from /auth/login
    public class LoginModel
    {
        [J("token")] 
        public string Token { get; set; }
    }
}