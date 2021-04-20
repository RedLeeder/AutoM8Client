using System;
using System.Collections.Generic;
using System.Text;

namespace AutoM8Client
{
    class Message
    {
        public string username;
        public int type;
        public string payload;

        public Message(String username, int type, String payload)
        {
            this.username = username;
            this.type = type;
            this.payload = payload;
        }

        public Message(String payload)
        {
            this.payload = payload;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public void setType(int type)
        {
            this.type = type;
        }
        public void setMessage(String payload)
        {
            this.payload = payload;
        }

    }
}
