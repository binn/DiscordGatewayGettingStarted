using System;
using Newtonsoft.Json;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Discord.Models
{
    // response from /auth/login
    public class GatewayUrlModel
    {
        [J("url")] 
        public string Url { get; set; }
    }
}