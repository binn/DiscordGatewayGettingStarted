using System;
using System.Net.Http;
using Newtonsoft.Json;
using WebSocket4Net;
using Discord.Rest;

namespace Discord
{
    public class CordClient
    {
        public CordClient()
        {

        }

        public WebSocket Socket { get; private set; }
        public CordRestClient Client { get; private set; }

        public async void Login(string token)
        {

        }

        public async void Login(string username, string password)
        {
            
        }
    }
}