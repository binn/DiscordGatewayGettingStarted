using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace MyApp.Models
{
    public class GatewayModel
    {
        [J("op")]
        public int Opcode { get; set; }
        [J("s")]
        public int? Sequence { get; set; }
        [J("t")]
        public string EventName { get; set; }
        [J("d")]
        public object Data { get; set; }
    }
}