using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChatApp
{
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();

            var ChatMessages = new List<ChatMessage>
            {
                new ChatMessage {Username = "Aditya", Date = "17-04-2017", Message = "test message"},
                new ChatMessage {Username = "Aditya", Date = "17-04-2017", Message = "test message"},
                new ChatMessage {Username = "Aditya", Date = "17-04-2017", Message = "test message"},
                new ChatMessage {Username = "Aditya", Date = "17-04-2017", Message = "test message"},
            };

            MessageListView.ItemsSource = ChatMessages;
        }
    }
}
