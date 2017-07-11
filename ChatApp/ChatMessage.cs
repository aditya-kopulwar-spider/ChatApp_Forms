using System;
namespace ChatApp
{
    public class ChatMessage
    {
        public string Username
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public ChatMessage()
        {
        }

        public ChatMessage(string Username, string Date, string Message)
        {
            this.Username = Username;
            this.Date = Date;
            this.Message = Message;
        }
    }
}
