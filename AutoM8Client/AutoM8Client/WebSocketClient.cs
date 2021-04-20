using System;
using System.IO;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading;
using System.Threading.Tasks;

namespace AutoM8Client
{
    class WebSocketClient
    {
        private MessageHandler mh;
        private Websocket.Client.WebsocketClient client;

        public WebSocketClient(MessageHandler messageHandler)
        {
            this.mh = messageHandler;
        }

        public void start()
        {
            var exitEvent = new ManualResetEvent(false);
            var url = new Uri("ws://192.168.1.32:8080");

            using (client = new Websocket.Client.WebsocketClient(url))
            {
                client.ReconnectTimeout = TimeSpan.FromSeconds(30);

                client.ReconnectionHappened.Subscribe(info => Console.Write($"Reconnection happened, type: {info.Type}"));

                client.MessageReceived.Subscribe(msg => mh.handle(msg));
                client.Start();

                exitEvent.WaitOne();
            }
        }

        public void send(String s)
        {
            client.Send(s);
        }
    }
}
