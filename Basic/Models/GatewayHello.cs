using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace MyApp.Models
{
    public class GatewayHello
    {
        [J("heartbeat_interval")]
        public int HeartbeatInterval { get; set; }
        [J("_trace")]
        public List<string> Trace { get; set; }

        public string GetTraceString()
        {
            string trace = "";
            foreach(string t in Trace)
            {
                trace += t + ", ";
            }

            return trace;
        }
    }
}