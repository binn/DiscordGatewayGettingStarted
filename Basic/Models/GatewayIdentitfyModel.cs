using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace MyApp.Models
{
    public class GatewayIdentifyModel
    {
        [J("properties")]
        public GatewayProperties Properties { get; set; }
        [J("compress")]
        public bool Compress { get; set; }
        [J("large_threshold")]
        public int Threshold { get; set; }
        [J("presence")]
        public GatewayStatus Status { get; set; }
        [J("token")]
        public string Token { get; set; }
    }

    public class GatewayStatus 
    {
        [J("status")]
        public string Status { get; set; }
        [J("afk")]
        public bool Afk { get; set; }
        [J("since")]
        public int Since { get; set; }
        [J("game")]
        public GatewayGame Game { get; set; }
    }

    public class GatewayGame 
    {
        [J("name")]
        public string Name { get; set; }
        [J("type")]
        public int Type { get; set; }
    }

    public class GatewayProperties
    {
        [J("$os")]
        public string Os { get; set; }
        [J("$browser")]
        public string Browser { get; set; }
        [J("$device")]
        public string Device { get; set; }
    }
}



/*

using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace MyApp.Models
{
    public class modelName
    {
        
    }
}


 */