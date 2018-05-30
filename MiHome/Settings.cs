using System;

using Xamarin.Forms;

namespace MiHome
{
    public class Settings : ContentPage
    {
        public Settings()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

