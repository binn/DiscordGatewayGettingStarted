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
        public string Token { get; set; }

        public void Login(string token, bool bot)
        {
            Token = bot ? "" : "Bot " + token;
            Client = new CordRestClient(token, false);

            string gateway_url = await Client.GetGatewayUrl();

            return;
        }

        public async void Login(string email, string password)
        {
            string token = await CordRestClient.GetToken(email, password);
            
            Login(token, false);

            return;
        }
    }
}