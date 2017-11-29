using System;
using Newtonsoft.Json;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Discord.Models
{
    // response from /auth/login
    public class RateLimitModel
    {
        [J("message")] 
        public string Message { get; set; }
        [J("retry_after")]
        public int RetryAfter { get; set; }
        [J("global")]
        public bool Global { get; set; }
    }
}