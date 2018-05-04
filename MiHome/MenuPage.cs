using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace MiHome
{
    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }


        /*protected async override void OnAppearing()
        {
            base.OnAppearing();
        }*/
        Label nameLabel;
        Label distanceLabel;
        public MenuPage()
        {
            Icon = "settings.png";


            Title = "Menu"; // The Title property must be set.
                            //BackgroundColor = Color.FromHex ("333333");
            BackgroundColor = Color.FromHex("333");


            Menu = new MenuListView("coach");

            Menu.BackgroundColor = Color.FromHex("333");

            /*var menuLabel = new ContentView {
                Padding = new Thickness (20, 0, 0, 5),
                Content = new Label {
                    TextColor = Color.FromHex ("AAAAAA"),
                    Text = ""
                }
            };*/

            //var s = DependencyService.Get<ISaveAndLoad>();
            //string path = s.GetPath("");



            /* var slpitter = new ContentView
             {
                 Padding = new Thickness(20, 25, 0, 5),
                 Content = new Label
                 {
                     TextColor = Color.FromHex("AAAAAA"),
                     Text = "",
                 }
             };*/


            nameLabel = new Label()
            {
                FontFamily = "HelveticaNeue-Medium",
                FontSize = 20,
                TextColor = Color.Black
            };
            nameLabel.Text = "";
            nameLabel.TextColor = Color.White;

            distanceLabel = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 12,
                TextColor = Color.White
            };
            distanceLabel.Text = "John O'Sullivan";

            // Online image and label
            var onlineImage = new Image()
            {
                Source = "online.png",
                HeightRequest = 8,
                WidthRequest = 8
            };
            var onLineLabel = new Label()
            {
                Text = "",
                TextColor = Color.Blue,
                FontSize = 12,
            };

            // Offline image and label
            var offlineImage = new Image()
            {
                Source = "offline.png",
                HeightRequest = 8,
                WidthRequest = 8
            };
            var offLineLabel = new Label()
            {
                Text = "",
                TextColor = Color.FromHex("#ddd"),
                FontSize = 12,
            };

            // Vet rating label and star image
            var starLabel = new Label()
            {
                FontSize = 12,
                TextColor = Color.Gray
            };
            starLabel.Text = "jnosullivan@icloud.com";
            var ratingStack = new StackLayout()
            {
                Spacing = 5,
                Orientation = StackOrientation.Horizontal,
                Children = { starLabel }
            };

            var statusLayout = new StackLayout
            {
                Spacing = 5,
                Orientation = StackOrientation.Horizontal,
                Children = {
                                distanceLabel,
                                onlineImage,
                                onLineLabel,
                                offlineImage,
                                offLineLabel
                        }
            };

            var vetDetailsLayout = new StackLayout
            {
                Padding = new Thickness(15, 0, 0, 0),
                Spacing = 5,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { nameLabel, statusLayout, ratingStack }
            };

            var tapImage = new Image()
            {
                HorizontalOptions = LayoutOptions.End,
                HeightRequest = 12,
            };

            var cellLayout = new StackLayout
            {
                Spacing = 0,
                Padding = new Thickness(10, 38, 0, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { vetDetailsLayout, tapImage }
            };


            var layout = new StackLayout
            {
                Spacing = 5,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            layout.Children.Add(cellLayout);





            layout.Children.Add(Menu);


            Content = layout;



        }



        public void UpDate(string str)
        {

            List<MenuItem> data = new MenuListData(str);
            Menu.ItemsSource = data;

        }

    }
}