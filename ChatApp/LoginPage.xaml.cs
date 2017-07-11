using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChatApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Login_Button_Clicked(object sender, System.EventArgs e)
        {
            //if(((usernameEntry.Text).Trim()).Equals("")){
            //    messageLabel.Text = "Please insert Username";
            //    return;
            //}

            Navigation.PushAsync(new ChatPage());
        }
    }
}
