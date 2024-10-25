using System;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace TwitchInteractive
{
    public class TwitchService
    {
        private ConnectionCredentials _credentials;
        private TwitchClient _client;

        public TwitchService(string username, string accessToken)
        {
            //ClientOptions options = new() { MessagesAllowedInPeriod = 1000, ThrottlingPeriod = TimeSpan.FromSeconds(30) };
            
            _client = new TwitchClient();
            _credentials = new(username, accessToken);
        }

        public void Start(string channel)
        {
            //_client?.Initialize(_credentials, channel);
            _client?.Connect();
        }

        public void Stop()
        {
            _client?.Disconnect();
        }
    }
}