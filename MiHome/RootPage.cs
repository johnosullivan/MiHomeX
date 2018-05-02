using System;
using Xamarin.Forms;
using System.Linq;

namespace MiHome
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;

        public RootPage()
        {
            // Creates a new MenuPage from the master page of the application
            menuPage = new MenuPage();
            menuPage.Menu.ItemSelected += (sender, e) => NavigateToItem(e.SelectedItem as MenuItem);
            menuPage.SetValue(NavigationPage.BarTextColorProperty, Color.Maroon);

            // Sets the master to the option view
            Master = menuPage;
            Detail = new NavigationPage(new Dashboard()) { BarBackgroundColor = Color.FromHex("008080"), BarTextColor = Color.White };

            // Present the login screen
            //ShowLoginDialog();
        }
        // To navigate to the correct navigate menu item 
        void NavigateToItem(MenuItem menu)
        {
            // If the menu item is null will return, prevention of crash
            if (menu == null) return;
            // Creates a page for the Xamarin masterdetail model
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
            // Sets the detail of the page to the new page
            Detail = new NavigationPage(displayPage) { BarBackgroundColor = Color.FromHex("008080"), BarTextColor = Color.White };
            // Animates and deselects the menu items slected from the side menu
            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }

        // Trigggers onces the page view is presented
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}