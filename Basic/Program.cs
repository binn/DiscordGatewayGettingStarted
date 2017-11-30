using System;
using System.Net.Http;
using Newtonsoft.Json;
using SuperSocket.ClientEngine;
using WebSocket4Net;
using MyApp.Models;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        string token = ""; // put ur token here
        bool bot_account = true; //set this to false if you are using a **user** token (a token for a user account, and not from a **bot** account).

        WebSocket socket = new WebSocket("wss://gateway.discord.gg/?v=6&encoding=json");

        string intial_status = "dnd"; //status, examples: online | dnd | offline | invisible | idle 
        string intital_status_game = "Hello from .NET!"; // the game you want.

        int seq = 0; //ignore this as it's for heartbeat

        static void Main(string[] args)
        {
            new Program().Start().GetAwaiter().GetResult();
        }

        async Task Start()
        {
            if (bot_account) token = "Bot " + token;

            socket.Opened += new EventHandler(socket_Opened);
            socket.Error += new EventHandler<ErrorEventArgs>(socket_Error);
            socket.Closed += new EventHandler(socket_Closed);
            socket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(socket_MessageReceived);
            socket.Open();

            await Task.Delay(-1);
        }

        private void socket_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("[SOCKET] Connected to gateway!");
            socket.Send(JsonConvert.SerializeObject(
                new GatewayIdentifyModel()
                {
                    Token = token,
                    Threshold = 50,
                    Compress = false,
                    Properties = new GatewayProperties()
                    {
                        Os = "Windows", // change if needed
                        Browser = "DiscordGatewayGettingStarted",
                        Device = "DiscordGatewayGettingStarted" // change these if you'd like
                    },
                    Status = new GatewayStatus()
                    {
                        Status = intial_status,
                        Afk = false,
                        Since = 0,
                        Game = new GatewayGame()
                        {
                            Name = intital_status_game,
                            Type = 0,
                        }
                    }
                }
            ));
            Console.WriteLine("[SOCKET] Sent initial heartbeat data!");
            //send the intital heartbeat data
        }

        private void socket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void socket_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Socket closed! Exiting the program!");
            Environment.Exit(0);
        }

        private void socket_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Error! Exiting the program!");
            Environment.Exit(0);
        }


        async Task heartbeat(int wait_time)
        {
            while (true)
            {
                await Task.Delay(wait_time);

                int? send_data = 0;
                if (seq == 0) send_data = null;
                else send_data = seq;

                socket.Send(JsonConvert.SerializeObject(new { op = 1, d = send_data }));
            }

        }
    }
}
