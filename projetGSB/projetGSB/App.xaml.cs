using projetGSB.classeMetier;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace projetGSB
{
    public partial class App : Application
    {
        public static string LocalHost { get; set; }
        public static string RegionInsertInitial { get; set; }
        public static string RegionInsertSecteur { get; set; }
        public static string RegionAInserer { get; set; }
        public static GstWebServices GstWS  { get; set; }
 

        public App()
        {
            InitializeComponent();
            GstWS = new GstWebServices();
            MainPage = new MainPage();
            LocalHost = "http://localhost/SIO2/CSGBOCK/";
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
