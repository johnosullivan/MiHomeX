using System;

using Xamarin.Forms;

namespace MiHome
{
    public class App : Application
    {
        // mockRunning trigger to toggle between live and mock
        public static bool mockRunning = true;
        // Application entry point
        public App()
        {
           
            // UI sets the main page to the RootPage ContectView
            MainPage = new RootPage();
            //MainPage = profilePage;
        }
        // Lifecycle of the application, triggers when the application is opened 
        protected override void OnStart()
        {

        }
        // Lifecycle of the application, triggers when the application is closed
        protected override void OnSleep()
        {

        }
        // Lifecycle of the application, triggers when the application is reopened from multitasking
        protected override void OnResume()
        {

        }
    }
}
