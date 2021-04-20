using System;
using System.Collections.Generic;
using System.Text;

namespace AutoM8Client
{
    class MessageHandler
    {
        public WebSocketClient wsc;
        public MessageHandler()
        {
            wsc = new WebSocketClient(this);
            wsc.start();
        }
        public void handle(Websocket.Client.ResponseMessage msg)
        {
            Console.WriteLine(msg);
        }
    }
}
